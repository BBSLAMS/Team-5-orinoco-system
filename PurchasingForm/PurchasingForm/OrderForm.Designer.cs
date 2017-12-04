namespace PurchasingForm
{
    partial class PurchasingForm
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
            this.lblItemSelect = new System.Windows.Forms.Label();
            this.cboItemSelect = new System.Windows.Forms.ComboBox();
            this.updItemAmount = new System.Windows.Forms.NumericUpDown();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.lstSelectedItems = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updItemAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemSelect
            // 
            this.lblItemSelect.AutoSize = true;
            this.lblItemSelect.Location = new System.Drawing.Point(13, 15);
            this.lblItemSelect.Name = "lblItemSelect";
            this.lblItemSelect.Size = new System.Drawing.Size(60, 13);
            this.lblItemSelect.TabIndex = 0;
            this.lblItemSelect.Text = "Select Item";
            // 
            // cboItemSelect
            // 
            this.cboItemSelect.FormattingEnabled = true;
            this.cboItemSelect.Location = new System.Drawing.Point(79, 12);
            this.cboItemSelect.Name = "cboItemSelect";
            this.cboItemSelect.Size = new System.Drawing.Size(121, 21);
            this.cboItemSelect.TabIndex = 1;
            // 
            // updItemAmount
            // 
            this.updItemAmount.Location = new System.Drawing.Point(206, 12);
            this.updItemAmount.Name = "updItemAmount";
            this.updItemAmount.Size = new System.Drawing.Size(65, 20);
            this.updItemAmount.TabIndex = 2;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(277, 12);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(13, 41);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(77, 13);
            this.lblSelectedItems.TabIndex = 4;
            this.lblSelectedItems.Text = "Selected Items";
            // 
            // lstSelectedItems
            // 
            this.lstSelectedItems.FormattingEnabled = true;
            this.lstSelectedItems.Location = new System.Drawing.Point(16, 58);
            this.lstSelectedItems.Name = "lstSelectedItems";
            this.lstSelectedItems.Size = new System.Drawing.Size(255, 108);
            this.lstSelectedItems.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(277, 58);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(277, 87);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnReq
            // 
            this.btnReq.Location = new System.Drawing.Point(277, 116);
            this.btnReq.Name = "btnReq";
            this.btnReq.Size = new System.Drawing.Size(75, 50);
            this.btnReq.TabIndex = 8;
            this.btnReq.Text = "Request Item";
            this.btnReq.UseVisualStyleBackColor = true;
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 181);
            this.Controls.Add(this.btnReq);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstSelectedItems);
            this.Controls.Add(this.lblSelectedItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.updItemAmount);
            this.Controls.Add(this.cboItemSelect);
            this.Controls.Add(this.lblItemSelect);
            this.Name = "PurchasingForm";
            this.Text = "Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.updItemAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemSelect;
        private System.Windows.Forms.ComboBox cboItemSelect;
        private System.Windows.Forms.NumericUpDown updItemAmount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.ListBox lstSelectedItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReq;
    }
}

