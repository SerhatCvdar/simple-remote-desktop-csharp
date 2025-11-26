
using MetroFramework.Forms;

namespace UzakMasaustuProje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.IPAdresiniYaz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSıfre = new System.Windows.Forms.TextBox();
            this.txtKullanıcı = new System.Windows.Forms.TextBox();
            this.txtKarsıIp = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdp = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            this.btnBaglantı = new MetroFramework.Controls.MetroButton();
            this.btnKes = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.IPAdresiniYaz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // IPAdresiniYaz
            // 
            this.IPAdresiniYaz.Location = new System.Drawing.Point(16, 58);
            this.IPAdresiniYaz.Multiline = true;
            this.IPAdresiniYaz.Name = "IPAdresiniYaz";
            this.IPAdresiniYaz.Size = new System.Drawing.Size(346, 26);
            this.IPAdresiniYaz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Ip";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 98);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtSıfre);
            this.panel3.Controls.Add(this.txtKullanıcı);
            this.panel3.Controls.Add(this.txtKarsıIp);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(394, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 100);
            this.panel3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(397, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(203, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karşı IP";
            // 
            // txtSıfre
            // 
            this.txtSıfre.Location = new System.Drawing.Point(412, 58);
            this.txtSıfre.Multiline = true;
            this.txtSıfre.Name = "txtSıfre";
            this.txtSıfre.PasswordChar = '*';
            this.txtSıfre.Size = new System.Drawing.Size(188, 26);
            this.txtSıfre.TabIndex = 5;
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(218, 58);
            this.txtKullanıcı.Multiline = true;
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Size = new System.Drawing.Size(188, 26);
            this.txtKullanıcı.TabIndex = 4;
            // 
            // txtKarsıIp
            // 
            this.txtKarsıIp.Location = new System.Drawing.Point(24, 58);
            this.txtKarsıIp.Multiline = true;
            this.txtKarsıIp.Name = "txtKarsıIp";
            this.txtKarsıIp.Size = new System.Drawing.Size(188, 26);
            this.txtKarsıIp.TabIndex = 3;
            this.txtKarsıIp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 98);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UzakMasaustuProje.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(23, 169);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(1466, 508);
            this.rdp.TabIndex = 3;
            // 
            // btnBaglantı
            // 
            this.btnBaglantı.Location = new System.Drawing.Point(1003, 63);
            this.btnBaglantı.Name = "btnBaglantı";
            this.btnBaglantı.Size = new System.Drawing.Size(104, 98);
            this.btnBaglantı.TabIndex = 4;
            this.btnBaglantı.Text = "Şimdi Bağlan";
            this.btnBaglantı.UseSelectable = true;
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(1113, 63);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(104, 98);
            this.btnKes.TabIndex = 5;
            this.btnKes.Text = "Bağlantıyı Kes";
            this.btnKes.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 700);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnBaglantı);
            this.Controls.Add(this.rdp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "            Uzak Masaustu Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtKarsıIp;
        private System.Windows.Forms.TextBox IPAdresiniYaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSıfre;
        private System.Windows.Forms.TextBox txtKullanıcı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting rdp;
        private MetroFramework.Controls.MetroButton btnBaglantı;
        private MetroFramework.Controls.MetroButton btnKes;
    }
}

