namespace SınavCalişma
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.giris = new System.Windows.Forms.Button();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_kapa = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.UserBtn = new System.Windows.Forms.Button();
            this.adminbtn = new System.Windows.Forms.Button();
            this.adminlbl = new System.Windows.Forms.Label();
            this.txt_Admin = new System.Windows.Forms.TextBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.Txt_TC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.giris.FlatAppearance.BorderSize = 2;
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris.Location = new System.Drawing.Point(33, 375);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(218, 35);
            this.giris.TabIndex = 9;
            this.giris.Text = "KAYIT OL VE GİRİŞ YAP";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.Location = new System.Drawing.Point(30, 222);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(65, 13);
            this.lblsoyad.TabIndex = 11;
            this.lblsoyad.Text = "SOYADINIZ";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(30, 183);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(43, 13);
            this.lblad.TabIndex = 9;
            this.lblad.Text = "ADINIZ";
            // 
            // txtsoyad
            // 
            this.txtsoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoyad.Location = new System.Drawing.Point(33, 238);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(218, 20);
            this.txtsoyad.TabIndex = 6;
            // 
            // txtad
            // 
            this.txtad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtad.Location = new System.Drawing.Point(33, 199);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(218, 20);
            this.txtad.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_kapa
            // 
            this.lbl_kapa.AutoSize = true;
            this.lbl_kapa.Location = new System.Drawing.Point(237, 12);
            this.lbl_kapa.Name = "lbl_kapa";
            this.lbl_kapa.Size = new System.Drawing.Size(14, 13);
            this.lbl_kapa.TabIndex = 9;
            this.lbl_kapa.Text = "X";
            this.lbl_kapa.Click += new System.EventHandler(this.lbl_kapa_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsifre.Location = new System.Drawing.Point(32, 319);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(218, 20);
            this.txtsifre.TabIndex = 8;
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(29, 303);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(38, 13);
            this.lblsifre.TabIndex = 11;
            this.lblsifre.Text = "ŞİFRE";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(32, 277);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(30, 261);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(39, 13);
            this.lblemail.TabIndex = 11;
            this.lblemail.Text = "EMAİL";
            // 
            // UserBtn
            // 
            this.UserBtn.Location = new System.Drawing.Point(58, 38);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.Size = new System.Drawing.Size(75, 23);
            this.UserBtn.TabIndex = 13;
            this.UserBtn.Text = "User";
            this.UserBtn.UseVisualStyleBackColor = true;
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // adminbtn
            // 
            this.adminbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminbtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.adminbtn.FlatAppearance.BorderSize = 0;
            this.adminbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adminbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.adminbtn.Location = new System.Drawing.Point(139, 38);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(75, 23);
            this.adminbtn.TabIndex = 14;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.Click += new System.EventHandler(this.adminbtn_Click);
            // 
            // adminlbl
            // 
            this.adminlbl.AutoSize = true;
            this.adminlbl.Location = new System.Drawing.Point(208, 222);
            this.adminlbl.Name = "adminlbl";
            this.adminlbl.Size = new System.Drawing.Size(42, 13);
            this.adminlbl.TabIndex = 15;
            this.adminlbl.Text = "ADMİN";
            // 
            // txt_Admin
            // 
            this.txt_Admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Admin.Location = new System.Drawing.Point(33, 238);
            this.txt_Admin.Name = "txt_Admin";
            this.txt_Admin.Size = new System.Drawing.Size(218, 20);
            this.txt_Admin.TabIndex = 16;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(228, 183);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(21, 13);
            this.lbltc.TabIndex = 17;
            this.lbltc.Text = "TC";
            // 
            // Txt_TC
            // 
            this.Txt_TC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_TC.Location = new System.Drawing.Point(33, 199);
            this.Txt_TC.Name = "Txt_TC";
            this.Txt_TC.Size = new System.Drawing.Size(218, 20);
            this.Txt_TC.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.Txt_TC);
            this.Controls.Add(this.lbltc);
            this.Controls.Add(this.txt_Admin);
            this.Controls.Add(this.adminlbl);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.UserBtn);
            this.Controls.Add(this.lbl_kapa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_kapa;
        public System.Windows.Forms.Button giris;
        public System.Windows.Forms.TextBox txtsoyad;
        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblsifre;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button UserBtn;
        private System.Windows.Forms.Button adminbtn;
        private System.Windows.Forms.Label adminlbl;
        public System.Windows.Forms.TextBox txt_Admin;
        private System.Windows.Forms.Label lbltc;
        public System.Windows.Forms.TextBox Txt_TC;
    }
}