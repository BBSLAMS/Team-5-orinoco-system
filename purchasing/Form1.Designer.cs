namespace purchasing
{
    partial class Form1
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
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxNewItemRequest = new System.Windows.Forms.TextBox();
            this.textBoxReasonforRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRequestNewItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Items.AddRange(new object[] {
            "item 1",
            "item 2",
            "item 3"});
            this.comboBoxItems.Location = new System.Drawing.Point(161, 69);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(121, 24);
            this.comboBoxItems.TabIndex = 0;
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 16;
            this.listBoxItems.Location = new System.Drawing.Point(162, 99);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(120, 84);
            this.listBoxItems.TabIndex = 1;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(288, 70);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(75, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "add";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(288, 99);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxNewItemRequest
            // 
            this.textBoxNewItemRequest.Location = new System.Drawing.Point(162, 249);
            this.textBoxNewItemRequest.Name = "textBoxNewItemRequest";
            this.textBoxNewItemRequest.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewItemRequest.TabIndex = 4;
            this.textBoxNewItemRequest.Visible = false;
            // 
            // textBoxReasonforRequest
            // 
            this.textBoxReasonforRequest.Location = new System.Drawing.Point(161, 277);
            this.textBoxReasonforRequest.Multiline = true;
            this.textBoxReasonforRequest.Name = "textBoxReasonforRequest";
            this.textBoxReasonforRequest.Size = new System.Drawing.Size(389, 104);
            this.textBoxReasonforRequest.TabIndex = 5;
            this.textBoxReasonforRequest.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "select item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "selected items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "name of new item";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "reason for new item";
            this.label4.Visible = false;
            // 
            // buttonRequestNewItem
            // 
            this.buttonRequestNewItem.Location = new System.Drawing.Point(330, 195);
            this.buttonRequestNewItem.Name = "buttonRequestNewItem";
            this.buttonRequestNewItem.Size = new System.Drawing.Size(137, 23);
            this.buttonRequestNewItem.TabIndex = 10;
            this.buttonRequestNewItem.Text = "request new item";
            this.buttonRequestNewItem.UseVisualStyleBackColor = true;
            this.buttonRequestNewItem.Click += new System.EventHandler(this.buttonRequestNewItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "don\'t see the item you need? try";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(288, 128);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 12;
            this.buttonConfirm.Text = "confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 397);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRequestNewItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReasonforRequest);
            this.Controls.Add(this.textBoxNewItemRequest);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.comboBoxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxNewItemRequest;
        private System.Windows.Forms.TextBox textBoxReasonforRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRequestNewItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonConfirm;
        public System.Windows.Forms.ListBox listBoxItems;
    }
}

