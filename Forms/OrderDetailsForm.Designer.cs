﻿namespace WarsztatSamochodowy.Forms
{
    partial class OrderDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAcceptDate = new System.Windows.Forms.Label();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbCar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewCar = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemovePosition = new System.Windows.Forms.Button();
            this.btnPositionDetails = new System.Windows.Forms.Button();
            this.btnAddPosition = new System.Windows.Forms.Button();
            this.lvOrderPositions = new System.Windows.Forms.ListView();
            this.chServiceName = new System.Windows.Forms.ColumnHeader();
            this.chDate = new System.Windows.Forms.ColumnHeader();
            this.chPrice = new System.Windows.Forms.ColumnHeader();
            this.chEmployee = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditComment = new System.Windows.Forms.Button();
            this.btnSaveComment = new System.Windows.Forms.Button();
            this.tbOrderComment = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPositionsFulfilled = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnFulfillOrder = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data wpłynięcia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data ukończenia:";
            // 
            // lblAcceptDate
            // 
            this.lblAcceptDate.AutoSize = true;
            this.lblAcceptDate.Location = new System.Drawing.Point(141, 23);
            this.lblAcceptDate.Name = "lblAcceptDate";
            this.lblAcceptDate.Size = new System.Drawing.Size(79, 20);
            this.lblAcceptDate.TabIndex = 2;
            this.lblAcceptDate.Text = "00.00.0000";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(141, 57);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(38, 20);
            this.lblFinishDate.TabIndex = 3;
            this.lblFinishDate.Text = "brak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Klient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Samochód:";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(95, 20);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(252, 28);
            this.cbCustomer.TabIndex = 6;
            // 
            // cbCar
            // 
            this.cbCar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCar.FormattingEnabled = true;
            this.cbCar.Location = new System.Drawing.Point(95, 54);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(252, 28);
            this.cbCar.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAcceptDate);
            this.groupBox1.Controls.Add(this.lblFinishDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 123);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveSubject);
            this.groupBox2.Controls.Add(this.btnNewCar);
            this.groupBox2.Controls.Add(this.btnNewCustomer);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbCustomer);
            this.groupBox2.Controls.Add(this.cbCar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(270, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klient";
            // 
            // btnNewCar
            // 
            this.btnNewCar.Location = new System.Drawing.Point(353, 53);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(94, 29);
            this.btnNewCar.TabIndex = 11;
            this.btnNewCar.Text = "Nowy...";
            this.btnNewCar.UseVisualStyleBackColor = true;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(353, 19);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnNewCustomer.TabIndex = 10;
            this.btnNewCustomer.Text = "Nowy...";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemovePosition);
            this.groupBox3.Controls.Add(this.btnPositionDetails);
            this.groupBox3.Controls.Add(this.btnAddPosition);
            this.groupBox3.Controls.Add(this.lvOrderPositions);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(711, 260);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pozycje";
            // 
            // btnRemovePosition
            // 
            this.btnRemovePosition.Location = new System.Drawing.Point(611, 224);
            this.btnRemovePosition.Name = "btnRemovePosition";
            this.btnRemovePosition.Size = new System.Drawing.Size(94, 29);
            this.btnRemovePosition.TabIndex = 12;
            this.btnRemovePosition.Text = "Usuń";
            this.btnRemovePosition.UseVisualStyleBackColor = true;
            // 
            // btnPositionDetails
            // 
            this.btnPositionDetails.Location = new System.Drawing.Point(6, 224);
            this.btnPositionDetails.Name = "btnPositionDetails";
            this.btnPositionDetails.Size = new System.Drawing.Size(167, 29);
            this.btnPositionDetails.TabIndex = 2;
            this.btnPositionDetails.Text = "Szczegóły pozycji...";
            this.btnPositionDetails.UseVisualStyleBackColor = true;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.Location = new System.Drawing.Point(511, 224);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.Size = new System.Drawing.Size(94, 29);
            this.btnAddPosition.TabIndex = 1;
            this.btnAddPosition.Text = "Dodaj...";
            this.btnAddPosition.UseVisualStyleBackColor = true;
            // 
            // lvOrderPositions
            // 
            this.lvOrderPositions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chServiceName,
            this.chDate,
            this.chPrice,
            this.chEmployee});
            this.lvOrderPositions.Location = new System.Drawing.Point(6, 26);
            this.lvOrderPositions.Name = "lvOrderPositions";
            this.lvOrderPositions.Size = new System.Drawing.Size(699, 192);
            this.lvOrderPositions.TabIndex = 0;
            this.lvOrderPositions.UseCompatibleStateImageBehavior = false;
            this.lvOrderPositions.View = System.Windows.Forms.View.Details;
            // 
            // chServiceName
            // 
            this.chServiceName.Text = "Usługa";
            this.chServiceName.Width = 240;
            // 
            // chDate
            // 
            this.chDate.Text = "Data";
            this.chDate.Width = 120;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Cena";
            this.chPrice.Width = 90;
            // 
            // chEmployee
            // 
            this.chEmployee.Text = "Wykonawca";
            this.chEmployee.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditComment);
            this.groupBox4.Controls.Add(this.btnSaveComment);
            this.groupBox4.Controls.Add(this.tbOrderComment);
            this.groupBox4.Location = new System.Drawing.Point(12, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(711, 145);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Komentarz";
            // 
            // btnEditComment
            // 
            this.btnEditComment.Location = new System.Drawing.Point(511, 110);
            this.btnEditComment.Name = "btnEditComment";
            this.btnEditComment.Size = new System.Drawing.Size(94, 29);
            this.btnEditComment.TabIndex = 13;
            this.btnEditComment.Text = "Edytuj";
            this.btnEditComment.UseVisualStyleBackColor = true;
            // 
            // btnSaveComment
            // 
            this.btnSaveComment.Enabled = false;
            this.btnSaveComment.Location = new System.Drawing.Point(611, 110);
            this.btnSaveComment.Name = "btnSaveComment";
            this.btnSaveComment.Size = new System.Drawing.Size(94, 29);
            this.btnSaveComment.TabIndex = 12;
            this.btnSaveComment.Text = "Zapisz";
            this.btnSaveComment.UseVisualStyleBackColor = true;
            // 
            // tbOrderComment
            // 
            this.tbOrderComment.Location = new System.Drawing.Point(6, 26);
            this.tbOrderComment.Multiline = true;
            this.tbOrderComment.Name = "tbOrderComment";
            this.tbOrderComment.ReadOnly = true;
            this.tbOrderComment.Size = new System.Drawing.Size(699, 78);
            this.tbOrderComment.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPositionsFulfilled);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.lblTotalCost);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(12, 558);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(497, 97);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Podsumowanie";
            // 
            // lblPositionsFulfilled
            // 
            this.lblPositionsFulfilled.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPositionsFulfilled.Location = new System.Drawing.Point(310, 43);
            this.lblPositionsFulfilled.Name = "lblPositionsFulfilled";
            this.lblPositionsFulfilled.Size = new System.Drawing.Size(153, 38);
            this.lblPositionsFulfilled.TabIndex = 3;
            this.lblPositionsFulfilled.Text = "0 / 0";
            this.lblPositionsFulfilled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Zrealizowano pozycji:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(6, 43);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(214, 38);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "0,00 zł";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Łączny koszt wszystkich pozycji:";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(6, 26);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(196, 29);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Wycofaj zamówienie";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnFulfillOrder
            // 
            this.btnFulfillOrder.Location = new System.Drawing.Point(6, 61);
            this.btnFulfillOrder.Name = "btnFulfillOrder";
            this.btnFulfillOrder.Size = new System.Drawing.Size(196, 29);
            this.btnFulfillOrder.TabIndex = 3;
            this.btnFulfillOrder.Text = "Oznacz jako zrealizowane";
            this.btnFulfillOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnFulfillOrder);
            this.groupBox6.Controls.Add(this.btnCancelOrder);
            this.groupBox6.Location = new System.Drawing.Point(515, 558);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(208, 97);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Operacje";
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(253, 88);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(94, 29);
            this.btnSaveSubject.TabIndex = 12;
            this.btnSaveSubject.Text = "Zapisz";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(141, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "nie wpłynęło";
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 664);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailsForm";
            this.Text = "Szczegóły zamówienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblAcceptDate;
        private Label lblFinishDate;
        private Label label5;
        private Label label6;
        private ComboBox cbCustomer;
        private ComboBox cbCar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnNewCar;
        private Button btnNewCustomer;
        private GroupBox groupBox3;
        private Button btnRemovePosition;
        private Button btnPositionDetails;
        private Button btnAddPosition;
        private ListView lvOrderPositions;
        private ColumnHeader chServiceName;
        private ColumnHeader chDate;
        private ColumnHeader chPrice;
        private ColumnHeader chEmployee;
        private GroupBox groupBox4;
        private Button btnEditComment;
        private Button btnSaveComment;
        private TextBox tbOrderComment;
        private GroupBox groupBox5;
        private Label lblPositionsFulfilled;
        private Label label7;
        private Label lblTotalCost;
        private Label label3;
        private Button btnCancelOrder;
        private Button btnFulfillOrder;
        private GroupBox groupBox6;
        private Label lblStatus;
        private Label label4;
        private Button btnSaveSubject;
    }
}