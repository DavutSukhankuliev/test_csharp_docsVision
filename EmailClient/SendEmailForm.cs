using System;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class SendEmailForm : Form
    {
        public SendEmailForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "" || receiverTextBox.Text == "" || textTextBox.Text == "" || senderTextBox.Text == "")
            {
                return;
            }
            
            //send logic

            titleTextBox.Text = "";
            receiverTextBox.Text = "";
            textTextBox.Text = "";
            senderTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
    }
}