using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro_Client.Properties;

namespace Zoro_Client.UI
{
    public partial class OpenWalletDialog : Form
    {
        public OpenWalletDialog()
        {
            InitializeComponent();

            if (File.Exists(Settings.Default.LastWalletPath))
            {
                textBox1.Text = Settings.Default.LastWalletPath;
                
                // focus in password input if wallet has been set
                this.ActiveControl = textBox2;
            }
        }

        public string Password
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        public string WalletPath
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

    }
}
