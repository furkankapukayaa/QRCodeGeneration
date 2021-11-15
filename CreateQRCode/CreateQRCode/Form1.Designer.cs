
namespace CreateQRCode
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlQr = new System.Windows.Forms.TextBox();
            this.createQR = new System.Windows.Forms.Button();
            this.qrLogo = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.createdQR = new System.Windows.Forms.PictureBox();
            this.createdQRText = new System.Windows.Forms.Label();
            this.saveQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdQR)).BeginInit();
            this.SuspendLayout();
            // 
            // urlQr
            // 
            this.urlQr.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlQr.Location = new System.Drawing.Point(12, 250);
            this.urlQr.Name = "urlQr";
            this.urlQr.Size = new System.Drawing.Size(374, 26);
            this.urlQr.TabIndex = 0;
            this.urlQr.Text = "ENTER THE TEXT (URL ETC.) YOU WANT!";
            // 
            // createQR
            // 
            this.createQR.BackColor = System.Drawing.Color.Transparent;
            this.createQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createQR.FlatAppearance.BorderSize = 0;
            this.createQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createQR.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createQR.ImageKey = "create.png";
            this.createQR.ImageList = this.ımageList1;
            this.createQR.Location = new System.Drawing.Point(188, 282);
            this.createQR.Name = "createQR";
            this.createQR.Size = new System.Drawing.Size(198, 58);
            this.createQR.TabIndex = 1;
            this.createQR.Text = "Generate QR Code";
            this.createQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createQR.UseVisualStyleBackColor = false;
            this.createQR.Click += new System.EventHandler(this.createQR_Click);
            // 
            // qrLogo
            // 
            this.qrLogo.Image = global::CreateQRCode.Properties.Resources.QR1;
            this.qrLogo.Location = new System.Drawing.Point(117, 58);
            this.qrLogo.Name = "qrLogo";
            this.qrLogo.Size = new System.Drawing.Size(170, 170);
            this.qrLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrLogo.TabIndex = 2;
            this.qrLogo.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(346, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(40, 40);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "create.png");
            this.ımageList1.Images.SetKeyName(1, "save.png");
            // 
            // createdQR
            // 
            this.createdQR.Location = new System.Drawing.Point(103, 346);
            this.createdQR.Name = "createdQR";
            this.createdQR.Size = new System.Drawing.Size(216, 184);
            this.createdQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.createdQR.TabIndex = 4;
            this.createdQR.TabStop = false;
            // 
            // createdQRText
            // 
            this.createdQRText.AutoSize = true;
            this.createdQRText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdQRText.ForeColor = System.Drawing.Color.Green;
            this.createdQRText.Location = new System.Drawing.Point(93, 543);
            this.createdQRText.Name = "createdQRText";
            this.createdQRText.Size = new System.Drawing.Size(237, 21);
            this.createdQRText.TabIndex = 5;
            this.createdQRText.Text = "QR Code successfully generated!";
            // 
            // saveQR
            // 
            this.saveQR.BackColor = System.Drawing.Color.Transparent;
            this.saveQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveQR.FlatAppearance.BorderSize = 0;
            this.saveQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveQR.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveQR.ImageKey = "save.png";
            this.saveQR.ImageList = this.ımageList1;
            this.saveQR.Location = new System.Drawing.Point(129, 567);
            this.saveQR.Name = "saveQR";
            this.saveQR.Size = new System.Drawing.Size(170, 58);
            this.saveQR.TabIndex = 6;
            this.saveQR.Text = "Save QR Code";
            this.saveQR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveQR.UseVisualStyleBackColor = false;
            this.saveQR.Click += new System.EventHandler(this.saveQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 637);
            this.Controls.Add(this.saveQR);
            this.Controls.Add(this.createdQRText);
            this.Controls.Add(this.createdQR);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.qrLogo);
            this.Controls.Add(this.createQR);
            this.Controls.Add(this.urlQr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR CODE GENERATING";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.qrLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlQr;
        private System.Windows.Forms.Button createQR;
        private System.Windows.Forms.PictureBox qrLogo;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox createdQR;
        private System.Windows.Forms.Label createdQRText;
        private System.Windows.Forms.Button saveQR;
    }
}

