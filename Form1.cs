using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMS
{
    public partial class frm_front : Form
    {
      

        public frm_front()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameInput = textBox_fullName.Text;
            string contactInput = textBox_contact.Text;

            if (string.IsNullOrWhiteSpace(nameInput))
            {
                MessageBox.Show("Invalid input: Please enter characters.");
                frm_front form1 = new frm_front();
                form1.Show();
                this.Hide();

            } else
            {
                services frm_services = new services();
                frm_services.name = textBox_fullName.Text;
                frm_services.contact = textBox_contact.Text;
                frm_services.Show();
                this.Hide();
            }
 
            
        }

        

        private void textBox_fullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                string message = "Invalid input: Please enter characters.";
                MessageBox.Show(message);
                e.Handled = true;
            }
        }

        private void textBox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                string message = "Invalid input: Not a valid numeric value.";
                MessageBox.Show(message);
                e.Handled = true;
            }
        }

        private void textBox_fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
