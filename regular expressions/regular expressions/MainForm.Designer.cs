namespace regular_expressions
{
    partial class MainForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 55);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneLabel.TabIndex = 1;
            this.PhoneLabel.Text = "Phone";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 81);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 13);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "E-Mail";
            // 
            // NameBox
            // 
            this.NameBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Location = new System.Drawing.Point(66, 26);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(198, 20);
            this.NameBox.TabIndex = 3;
            this.NameBox.Text = "Full Name";
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.Leave += new System.EventHandler(this.NameBox_Leave);
            // 
            // PhoneBox
            // 
            this.PhoneBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneBox.Location = new System.Drawing.Point(66, 52);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(198, 20);
            this.PhoneBox.TabIndex = 4;
            this.PhoneBox.Text = "+36 #########";
            this.PhoneBox.Enter += new System.EventHandler(this.PhoneBox_Enter);
            this.PhoneBox.Leave += new System.EventHandler(this.PhoneBox_Leave);
            // 
            // MailBox
            // 
            this.MailBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MailBox.Location = new System.Drawing.Point(66, 78);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(198, 20);
            this.MailBox.TabIndex = 5;
            this.MailBox.Text = "example@something.com";
            this.MailBox.Enter += new System.EventHandler(this.MailBox_Enter);
            this.MailBox.Leave += new System.EventHandler(this.MailBox_Leave);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(189, 118);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Input validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

