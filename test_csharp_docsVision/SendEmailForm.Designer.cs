namespace test_csharp_docsVision
{
    partial class SendEmailForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.receiverLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.senderLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(95, 64);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 20);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(263, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(146, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.Location = new System.Drawing.Point(263, 90);
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(146, 20);
            this.receiverTextBox.TabIndex = 3;
            // 
            // receiverLabel
            // 
            this.receiverLabel.Location = new System.Drawing.Point(95, 90);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(152, 20);
            this.receiverLabel.TabIndex = 2;
            this.receiverLabel.Text = "Receiver";
            this.receiverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(263, 116);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(146, 142);
            this.textTextBox.TabIndex = 5;
            // 
            // bodyLabel
            // 
            this.bodyLabel.Location = new System.Drawing.Point(95, 116);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(152, 20);
            this.bodyLabel.TabIndex = 4;
            this.bodyLabel.Text = "Text";
            this.bodyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(424, 288);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 38);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(617, 65);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(146, 20);
            this.senderTextBox.TabIndex = 8;
            // 
            // senderLabel
            // 
            this.senderLabel.Location = new System.Drawing.Point(449, 65);
            this.senderLabel.Name = "senderLabel";
            this.senderLabel.Size = new System.Drawing.Size(152, 20);
            this.senderLabel.TabIndex = 7;
            this.senderLabel.Text = "Sender";
            this.senderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(617, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(this.senderLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(this.receiverLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Name = "SendEmailForm";
            this.Text = "Send Email";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DateTimePicker dateTimePicker;

        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.Label senderLabel;

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label bodyLabel;

        private System.Windows.Forms.TextBox receiverTextBox;
        private System.Windows.Forms.Label receiverLabel;

        private System.Windows.Forms.TextBox titleTextBox;

        private System.Windows.Forms.Label titleLabel;

        #endregion
    }
}