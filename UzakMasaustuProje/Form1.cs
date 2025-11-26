using MetroFramework.Forms;
using MSTSCLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzakMasaustuProje
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Lokal Makinemizin IP sini alıyoruz
                btnKes.Enabled = false;
                GetMyIp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "some Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void GetMyIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPAdresiniYaz.Text = ip.ToString();
                    //IPv4 Address. . . . . . . . . . . : 192.168.1.105
                }
            }
        }
        private void btnBaglantı_Click(object sender, EventArgs e)
        {
            try
            {
                btnBaglantı.Enabled = false;
                btnKes.Enabled = true;
                rdp.Server = txtKarsıIp.Text;
                rdp.UserName = txtKullanıcı.Text;

                IMsTscNonScriptable Secured = (IMsTscNonScriptable) rdp.GetOcx();
                Secured.ClearTextPassword = txtSıfre.Text;
                rdp.Connect();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKes_Click(object sender, EventArgs e)
        {
            if (rdp.Connected.ToString() == "1")
                rdp.Disconnect();
        }
    }
}
