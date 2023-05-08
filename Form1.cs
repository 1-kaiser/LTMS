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
            services frm_services = new services();
            frm_services.name = textBox_fullName.Text;
            frm_services.contact = textBox_contact.Text;
            frm_services.Show();
            this.Hide();
            
        }

        private void textBox_fullName_TextChanged(object sender, EventArgs e)
        {
            string nameInput = textBox_fullName.Text;

            if (string.IsNullOrWhiteSpace(nameInput))
            {
                MessageBox.Show("Invalid input: Please enter characters.");
            }

            if (int.TryParse(nameInput, out int result))
            {

                MessageBox.Show("Invalid input: Please enter characters.");
            }

        }

        private void textBox_contact_TextChanged(object sender, EventArgs e)
        {
            string contactInput = textBox_contact.Text;

            if (!int.TryParse(contactInput, out int result))
            {
                
                MessageBox.Show("Invalid input: Not a valid numeric value.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }

        
    }
}
