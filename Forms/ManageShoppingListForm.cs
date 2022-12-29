﻿using MySqlConnector;
using E = MySqlConnector.MySqlErrorCode;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WarsztatSamochodowy.Services;

namespace WarsztatSamochodowy.Forms
{
    public partial class ManageShoppingListForm : Form
    {
        protected string? listName;
        protected bool isFulfilled = false;

        protected const string NOT_FULFILLED_TEXT = "Możesz oznaczyć tę listę jako zrealizowaną. Spowoduje to dodanie wszystkich zawartych na niej części do stanu magazynu. Operacji tej nie da się wycofać.";
        protected const string FULFILLED_TEXT = "Ta lista została oznaczona jako zrealizowana. Wszystkie znajdujące się na niej części zostały dodane do stanu magazynu. Operacji tej nie da się wycofać.";

        public ManageShoppingListForm(string? listName)
        {
            InitializeComponent();

            this.listName = listName;

            if(listName != null)
            {
                var rows = DatabaseService.Get().Select(DatabaseService.TABLE_SHOPPING_LISTS,
                    new() { ["name"] = listName }, new() { "isFulfilled" });
                var isFulfilled = rows[0][0];
                this.isFulfilled = (isFulfilled != "0");
            }
            
            FillView();
            RefreshButtonsState();
        }

        protected void FillView()
        {
            tbListName.Text = listName ?? "";
            tbListName.ReadOnly = (listName != null);
            lblFulfillText.Text = isFulfilled ? FULFILLED_TEXT : NOT_FULFILLED_TEXT;

            if (listName == null) return;

            var entries = DatabaseService.Get().Select(DatabaseService.TABLE_SHOPPING_LISTS_PARTS_WITH_NAMES,
                new() { ["listName"] = listName }, new() { "partCode", "partName", "quantity" });

            lvListParts.Items.Clear();
            foreach(var entry in entries)
            {
                string[] fields = {
                    $"{entry[1]} (#{entry[0]})",
                    $"{entry[2]}"
                };
                var lvItem = new ListViewItem(fields);
                lvItem.Tag = entry[0];
                lvListParts.Items.Add(lvItem);
            }
        }

        protected void RefreshButtonsState()
        {
            btnEditEntry.Enabled =
                btnRemoveEntry.Enabled = (lvListParts.SelectedItems.Count == 1) && !isFulfilled && (listName != null);
            btnMoveEntry.Enabled = (lvListParts.SelectedItems.Count == 1) && (listName != null);
            btnMarkFulfilled.Enabled = !isFulfilled && (listName != null);
        }

        #region List renaming

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (tbListName.ReadOnly)
            {
                tbListName.ReadOnly = false;
                return;
            }

            InitiateSaveListName();
        }

        private void tbListName_DoubleClick(object sender, EventArgs e)
        {
            if (!tbListName.ReadOnly) return;
            tbListName.ReadOnly = false;
            tbListName.Select(tbListName.Text.Length, 0);
        }

        private void tbListName_ReadOnlyChanged(object sender, EventArgs e)
        {
            btnRename.Text = tbListName.ReadOnly ? "Zmień" : "Zapisz";
        }

        private void tbListName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbListName.ReadOnly) return;

            if (e.KeyChar == (char)Keys.Enter)
            {
                InitiateSaveListName();
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Escape && listName != null)
            {
                tbListName.Text = listName;
                tbListName.ReadOnly = true;
                e.Handled = true;
            }
        }

        private void InitiateSaveListName()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbListName.Text))
                {
                    throw new ArgumentException("Nazwa listy nie może być pusta");
                }

                SaveListName(tbListName.Text);
                tbListName.ReadOnly = true;
                RefreshButtonsState();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Niepoprawne dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                string message = ex.ErrorCode switch
                {
                    E.DuplicateKeyEntry => "Lista o podanej nazwie już istnieje.",
                    _ => $"{ex.Message} (kod błędu: {ex.ErrorCode})"
                };
                MessageBox.Show(message, "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveListName(string newListName)
        {
            var db = DatabaseService.Get();
            
            if(listName != null)
            {
                db.update(DatabaseService.TABLE_SHOPPING_LISTS,
                    new() { ["name"] = listName }, new() { ["name"] = newListName });
            } else
            {
                db.insert(DatabaseService.TABLE_SHOPPING_LISTS,
                    new() { ["name"] = newListName, ["isFulfilled"] = "0" });
            }
            listName = newListName;
        }

        #endregion

        #region Part management

        private void lvListParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshButtonsState();
        }

        private void btnRemoveEntry_Click(object sender, EventArgs e)
        {
            if (listName == null) return;

            if (isFulfilled)
            {
                MessageBox.Show("Nie można skasować pozycji ze zrealizowanej listy zakupów.", "Lista została zrealizowana",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(lvListParts.SelectedItems.Count != 1)
            {
                MessageBox.Show("Zaznacz pozycję do usunięcia.", "Nic nie wybrano");
                return;
            }

            ListViewItem selectedItem = lvListParts.SelectedItems[0];
            string partCode = (string)selectedItem.Tag;

            DatabaseService.Get().delete(DatabaseService.TABLE_SHOPPING_LISTS_PARTS,
                new() { ["listName"] = listName, ["partCode"] = partCode });
            selectedItem.Remove();
        }

        #endregion

        private void btnMarkFulfilled_Click(object sender, EventArgs e)
        {
            if (listName == null) return;

            var result = MessageBox.Show($"Oznaczenie listy jako zrealizowana jest nieodwracalne. Czy oznaczyć listę „{listName}” jako zrealizowaną?",
                "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                DatabaseService.Get().update(DatabaseService.TABLE_SHOPPING_LISTS,
                    new() { ["name"] = listName }, new() { ["isFulfilled"] = "1" });
                isFulfilled = true;
                RefreshButtonsState();
                lblFulfillText.Text = FULFILLED_TEXT;
            }
            catch(MySqlException ex)
            {
                string message = ex.ErrorCode switch
                {
                    _ => $"{ex.Message} (kod błędu: {ex.ErrorCode})"
                };
                MessageBox.Show(message, "Błąd bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
