using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro_Client.Properties;

namespace Zoro_Client.UI
{
    public partial class AddAssetFrm : Form
    {
        public AddAssetFrm()
        {
            InitializeComponent();
            textBox1.Lines = Settings.Default.NEP5Watched.OfType<string>().ToArray();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) return;
            Settings.Default.NEP5Watched.Clear();
            foreach (var p in textBox1.Lines)
            {
                if (!Settings.Default.NEP5Watched.OfType<string>().ToArray().Contains(p))
                {
                    Settings.Default.NEP5Watched.Add(p);
                    Settings.Default.Save();
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            textBox1.Lines = Settings.Default.NEP5Watched.OfType<string>().ToArray();
            this.Close();
        }
    }
}
