
namespace ZenithFit.WinUI.Procurements
{
    partial class frmProcurementsSearch
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
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.txtProcurementNumber = new System.Windows.Forms.TextBox();
            this.dgvProcurementDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProcurements = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcurementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementAccountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcurementNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurementDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurements)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate1
            // 
            this.dtpDate1.Location = new System.Drawing.Point(15, 30);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(200, 20);
            this.dtpDate1.TabIndex = 0;
            // 
            // txtProcurementNumber
            // 
            this.txtProcurementNumber.Location = new System.Drawing.Point(445, 30);
            this.txtProcurementNumber.Name = "txtProcurementNumber";
            this.txtProcurementNumber.Size = new System.Drawing.Size(100, 20);
            this.txtProcurementNumber.TabIndex = 1;
            // 
            // dgvProcurementDetails
            // 
            this.dgvProcurementDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurementDetails.Location = new System.Drawing.Point(12, 277);
            this.dgvProcurementDetails.Name = "dgvProcurementDetails";
            this.dgvProcurementDetails.Size = new System.Drawing.Size(923, 161);
            this.dgvProcurementDetails.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procurement number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(569, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 31);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate2
            // 
            this.dtpDate2.Location = new System.Drawing.Point(221, 30);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(200, 20);
            this.dtpDate2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "To";
            // 
            // dgvProcurements
            // 
            this.dgvProcurements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcurements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcurementID,
            this.ProcurementNumber,
            this.ProcurementDate,
            this.ProcurementAccountAmount,
            this.ProcurementTax,
            this.ProcurementNote,
            this.WarehouseName,
            this.SupplierName,
            this.ContactPerson,
            this.ContactPhone});
            this.dgvProcurements.Location = new System.Drawing.Point(12, 71);
            this.dgvProcurements.Name = "dgvProcurements";
            this.dgvProcurements.Size = new System.Drawing.Size(923, 174);
            this.dgvProcurements.TabIndex = 8;
            this.dgvProcurements.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProcurements_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Details";
            // 
            // ProcurementID
            // 
            this.ProcurementID.DataPropertyName = "ProcurementID";
            this.ProcurementID.HeaderText = "ProcurementID";
            this.ProcurementID.Name = "ProcurementID";
            this.ProcurementID.Visible = false;
            // 
            // ProcurementNumber
            // 
            this.ProcurementNumber.DataPropertyName = "ProcurementNumber";
            this.ProcurementNumber.HeaderText = "Procurement No.";
            this.ProcurementNumber.Name = "ProcurementNumber";
            // 
            // ProcurementDate
            // 
            this.ProcurementDate.DataPropertyName = "ProcurementDate";
            this.ProcurementDate.HeaderText = "Procurement date";
            this.ProcurementDate.Name = "ProcurementDate";
            // 
            // ProcurementAccountAmount
            // 
            this.ProcurementAccountAmount.DataPropertyName = "ProcurementAccountAmount";
            this.ProcurementAccountAmount.HeaderText = "Total value";
            this.ProcurementAccountAmount.Name = "ProcurementAccountAmount";
            // 
            // ProcurementTax
            // 
            this.ProcurementTax.DataPropertyName = "ProcurementTax";
            this.ProcurementTax.HeaderText = "Tax amount";
            this.ProcurementTax.Name = "ProcurementTax";
            // 
            // ProcurementNote
            // 
            this.ProcurementNote.DataPropertyName = "ProcurementNote";
            this.ProcurementNote.HeaderText = "Note";
            this.ProcurementNote.Name = "ProcurementNote";
            // 
            // WarehouseName
            // 
            this.WarehouseName.DataPropertyName = "WarehouseName";
            this.WarehouseName.HeaderText = "Warehouse";
            this.WarehouseName.Name = "WarehouseName";
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            // 
            // ContactPerson
            // 
            this.ContactPerson.DataPropertyName = "ContactPerson";
            this.ContactPerson.HeaderText = "Contact";
            this.ContactPerson.Name = "ContactPerson";
            // 
            // ContactPhone
            // 
            this.ContactPhone.DataPropertyName = "ContactPhone";
            this.ContactPhone.HeaderText = "Contact Phone";
            this.ContactPhone.Name = "ContactPhone";
            // 
            // frmProcurementsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvProcurements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDate2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProcurementDetails);
            this.Controls.Add(this.txtProcurementNumber);
            this.Controls.Add(this.dtpDate1);
            this.Name = "frmProcurementsSearch";
            this.Text = "frmProcurementsSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurementDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcurements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.TextBox txtProcurementNumber;
        private System.Windows.Forms.DataGridView dgvProcurementDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProcurements;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementAccountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcurementNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhone;
    }
}