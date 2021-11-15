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

namespace CreateQRCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int mov, movX, movY;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createdQRText.Visible = false;
            saveQR.Visible = false;
        }

        private void createQR_Click(object sender, EventArgs e)
        {
            string str = urlQr.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            createdQR.Image = qrCodeImage;
            createdQRText.Visible = true;
            saveQR.Visible = true;
            urlQr.Clear();
        }

        private void saveQR_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Jpeg file(*.jpg)|*.jpg|Png file(*.png)|*.png";
            sfd.Title = "Save QR Code";
            sfd.FileName = "QRCode";
            DialogResult sonuç = sfd.ShowDialog();
            if (sonuç == DialogResult.OK)
            {
                createdQR.Image.Save(sfd.FileName);
                createdQR.Image = null;
                createdQRText.Visible = false;
                saveQR.Visible = false;
                urlQr.Text = "ENTER THE TEXT (URL ETC.) YOU WANT!";
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
