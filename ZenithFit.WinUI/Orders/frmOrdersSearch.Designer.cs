
namespace ZenithFit.WinUI.Orders
{
    partial class frmOrdersSearch
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderCancelled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OrderPriceNoTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPriceTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarehouseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderNumber,
            this.OrderDate,
            this.OrderStatus,
            this.OrderCancelled,
            this.OrderPriceNoTax,
            this.OrderPriceTax,
            this.WarehouseId,
            this.ClientId});
            this.dgvOrders.Location = new System.Drawing.Point(12, 82);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(880, 256);
            this.dgvOrders.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.DataPropertyName = "OrderId";
            this.OrderId.HeaderText = "OrderId";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "OrderNumber";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "OrderStatus";
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            // 
            // OrderCancelled
            // 
            this.OrderCancelled.DataPropertyName = "OrderCancelled";
            this.OrderCancelled.HeaderText = "OrderCancelled";
            this.OrderCancelled.Name = "OrderCancelled";
            this.OrderCancelled.ReadOnly = true;
            // 
            // OrderPriceNoTax
            // 
            this.OrderPriceNoTax.DataPropertyName = "OrderPriceNoTax";
            this.OrderPriceNoTax.HeaderText = "OrderPriceNoTax";
            this.OrderPriceNoTax.Name = "OrderPriceNoTax";
            this.OrderPriceNoTax.ReadOnly = true;
            // 
            // OrderPriceTax
            // 
            this.OrderPriceTax.DataPropertyName = "OrderPriceTax";
            this.OrderPriceTax.HeaderText = "OrderPriceTax";
            this.OrderPriceTax.Name = "OrderPriceTax";
            this.OrderPriceTax.ReadOnly = true;
            // 
            // WarehouseId
            // 
            this.WarehouseId.DataPropertyName = "WarehouseId";
            this.WarehouseId.HeaderText = "WarehouseId";
            this.WarehouseId.Name = "WarehouseId";
            this.WarehouseId.ReadOnly = true;
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            this.ClientId.ReadOnly = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(243, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(12, 39);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(214, 20);
            this.txtOrderNumber.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order number";
            // 
            // frmOrdersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvOrders);
            this.Name = "frmOrdersSearch";
            this.Text = "frmOrdersSearch";
            this.Load += new System.EventHandler(this.frmOrdersSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderCancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPriceNoTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPriceTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarehouseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
    }
}