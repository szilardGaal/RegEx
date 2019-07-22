using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regular_expressions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string MessageText = "";

            string NameString = NameBox.Text;
            string PhoneNumber = PhoneBox.Text;
            string Email = MailBox.Text;

            if (!Validator.ValidName(NameString) || NameString == "Full Name") MessageText += "Not a valid name format!\n";
            if (!Validator.ValidCellPhoneNumberHUN(PhoneNumber)) MessageText += "Not a valid hungarian cell phone number!\n";
            if (!Validator.ValidateEmail(Email) || Email == "example@something.com") MessageText += "Not a valid e-mail address!";

            if (MessageText == "") MessageText += "All good!";
            MessageBox.Show(MessageText);
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (NameBox.Text == "Full Name")
            {
                NameBox.Text = "";
                NameBox.ForeColor = Color.Black;
            }
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || NameBox.Text == "Full Name")
            {
                NameBox.ForeColor = Color.Silver;
                NameBox.Text = "Full Name";
            }
        }

        private void PhoneBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.Text == @"+36 ## ### ####")
            {
                PhoneBox.Text = "";
                PhoneBox.ForeColor = Color.Black;
            }
        }

        private void PhoneBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "" || PhoneBox.Text == @"+36 ## ### ####")
            {
                PhoneBox.ForeColor = Color.Silver;
                PhoneBox.Text = "+36 ## ### ####";
            }
        }

        private void MailBox_Enter(object sender, EventArgs e)
        {
            if (MailBox.Text == @"example@something.com")
            {
                MailBox.Text = "";
                MailBox.ForeColor = Color.Black;
            }
        }

        private void MailBox_Leave(object sender, EventArgs e)
        {
            if (MailBox.Text == "" || MailBox.Text == @"example@something.com")
            {
                MailBox.ForeColor = Color.Silver;
                MailBox.Text = "example@something.com";
            }
        }
    }
}
