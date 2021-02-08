
namespace ZenithFit.WinUI.Categories
{
    partial class frmCategories
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
            this.components = new System.ComponentModel.Container();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategorySubmit = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(12, 36);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(149, 20);
            this.txtCategoryName.TabIndex = 0;
            this.txtCategoryName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCategoryName_Validating);
            // 
            // btnCategorySubmit
            // 
            this.btnCategorySubmit.Location = new System.Drawing.Point(141, 71);
            this.btnCategorySubmit.Name = "btnCategorySubmit";
            this.btnCategorySubmit.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySubmit.TabIndex = 1;
            this.btnCategorySubmit.Text = "Submit";
            this.btnCategorySubmit.UseVisualStyleBackColor = true;
            this.btnCategorySubmit.Click += new System.EventHandler(this.btnCategorySubmit_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(9, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(78, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 115);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.btnCategorySubmit);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "frmCategories";
            this.Text = "frmCategories";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCategorySubmit;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}