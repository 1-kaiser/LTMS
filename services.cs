using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMS
{
    public partial class services : Form
    {

        private string serviceType = "";
        private string laundryType = "";
        public string label_weight = "";
        public string name, contact;

        public int totalamount;
        public int payment;
        const int selfservice = 50;
        const int dropoff = 40;
        const int Wash = 30;
        const int Dry = 20;
        const int WashDry = 50;
        public int weight2;



        public services()
        {
            InitializeComponent();
        }

        private void btn_services_Click(object sender, EventArgs e)
        {


            weight2 = Convert.ToInt32(weight_textbox.Text);

            int[] prices = new int[5];
            prices[0] = Convert.ToInt32(self_service.Checked) * selfservice;
            prices[1] = Convert.ToInt32(drop_off.Checked) * dropoff;
            prices[2] = Convert.ToInt32(wash.Checked) * Wash;
            prices[3] = Convert.ToInt32(dry.Checked) * Dry;
            prices[4] = Convert.ToInt32(wash_dry.Checked) * WashDry;


            if (weight2 <= 4 && weight2 >= 1)
            {
                weight2 = 35;
                label_weight = "P35";

            } else if (weight2 <= 10 && weight2 >= 5)
            {
                weight2 = 65;
                label_weight = "P65";

            } else if (weight2 > 10)
            {
                weight2 = 100;
                label_weight = "P100";
            }

            
            

            if (self_service.Checked && wash.Checked) 
            { 
                payment = prices[0] + prices[2] + weight2;
            } 
            else if (self_service.Checked && dry.Checked) 
            {
                payment = prices[0] + prices[3] + weight2;
            } 
            else if (self_service.Checked && dry.Checked) 
            {
                payment = prices[0] + prices[3] + weight2;
            }
            else if (self_service.Checked && wash_dry.Checked)
            {
                payment = prices[0] + prices[4] + weight2;
            }

            if (drop_off.Checked && wash.Checked)
            {
                payment = prices[1] + prices[2] + weight2;
            }
            else if (drop_off.Checked && dry.Checked)
            {
                payment = prices[1] + prices[3] + weight2;
            }
            else if (drop_off.Checked && dry.Checked)
            {
                payment = prices[1] + prices[3] + weight2;
            }
            else if (drop_off.Checked && wash_dry.Checked)
            {
                payment = prices[1] + prices[4] + weight2;
            }



            if (self_service.Checked)
            {
                serviceType = "Self-Service                         P50";
            }
            if (drop_off.Checked)
            {
                serviceType = "Drop-Off                            P40";
            }

            if (wash.Checked)
            {
                laundryType = "Wash                                P30";
            }
            else if (dry.Checked)
            {
                laundryType = "Dry                                   P20";
            }
            else if (wash_dry.Checked)
            {
                laundryType = "Wash and Dry                    P50";
            }


            if ((self_service.Checked || drop_off.Checked) && (wash.Checked || dry.Checked || wash_dry.Checked))
            {
                invoice frm_invoice = new invoice();
                frm_invoice.serviceType = serviceType;
                frm_invoice.laundryType = laundryType;
                frm_invoice.weight = weight_textbox.Text;
                frm_invoice.Name = name;
                frm_invoice.Contact = contact;
                frm_invoice.totalAmount = payment;
                frm_invoice.labelForweight = label_weight;
                frm_invoice.Show();
                this.Hide();

            } else
            {
                string message_service = "Please select service and laundry type";
                MessageBox.Show(message_service);
                services frm_services = new services();
                frm_services.Show();
                Hide();
            }
        }

        private void weight_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                string message = "Invalid input: Not a valid numeric value.";
                MessageBox.Show(message);
                e.Handled = true;
            }
        }

        private void self_service_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void drop_off_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void wash_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dry_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void wash_dry_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void weight_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void services_Load(object sender, EventArgs e)
        {
            
        }

        


    }
}
