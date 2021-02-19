
namespace ZenithFit.WinUI.Messages
{
    partial class frmMessagesDetails
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
            this.txtSendMessage = new System.Windows.Forms.TextBox();
            this.dgvMessages = new System.Windows.Forms.DataGridView();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Location = new System.Drawing.Point(12, 224);
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.Size = new System.Drawing.Size(663, 20);
            this.txtSendMessage.TabIndex = 0;
            // 
            // dgvMessages
            // 
            this.dgvMessages.AllowUserToAddRows = false;
            this.dgvMessages.AllowUserToDeleteRows = false;
            this.dgvMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Message,
            this.SentDate});
            this.dgvMessages.Location = new System.Drawing.Point(12, 12);
            this.dgvMessages.Name = "dgvMessages";
            this.dgvMessages.ReadOnly = true;
            this.dgvMessages.Size = new System.Drawing.Size(776, 178);
            this.dgvMessages.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Text";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // SentDate
            // 
            this.SentDate.DataPropertyName = "CreatedDate";
            this.SentDate.HeaderText = "SentDate";
            this.SentDate.Name = "SentDate";
            this.SentDate.ReadOnly = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(702, 221);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 208);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(133, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Type your response here...";
            // 
            // frmMessagesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 256);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgvMessages);
            this.Controls.Add(this.txtSendMessage);
            this.Name = "frmMessagesDetails";
            this.Text = "frmMessagesDetails";
            this.Load += new System.EventHandler(this.frmMessagesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendMessage;
        private System.Windows.Forms.DataGridView dgvMessages;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn SentDate;
    }
}