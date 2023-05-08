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
    public partial class complete : Form
    {
        private Bitmap qrCodeImage;
        public object pictureBox11;

        public complete(Bitmap qrCodeImage)
        {
            InitializeComponent();
            this.qrCodeImage = qrCodeImage;
        }

        public void complete_Load(object sender, EventArgs e)
        {
         
            qrImage.Image = qrCodeImage;
        }

        public void qrImage_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
