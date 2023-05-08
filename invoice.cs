using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;

namespace LTMS
{
    public partial class invoice : Form
    {
        public string Contact, serviceType, laundryType, weight, total, labelForweight;

        

        private void btn_services_Click(object sender, EventArgs e)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(label_totalAmount.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);
            complete complete = new complete(qrCodeImage);
            complete.Show();
            this.Hide();
        }

        private void btn_back_toServices_Click(object sender, EventArgs e)
        {
            services frm_services = new services();
            frm_services.Show();
            this.Hide();
        }

        public int totalAmount;

        public invoice()
        {
            InitializeComponent();
        }

        

        private void invoice_Load(object sender, EventArgs e)
        {
            total = Convert.ToString(totalAmount);
            
            label_serviceType.Text = serviceType;
            label_laundryType.Text = laundryType;
            label_weight.Text = weight;
            label_totalAmount.Text = total;
            label_fullName.Text = Name;
            label_contactNumber.Text = Contact;
            labelWeight.Text = labelForweight;

        }

        private void labelWeight_Click(object sender, EventArgs e)
        {

        }


    }
}
