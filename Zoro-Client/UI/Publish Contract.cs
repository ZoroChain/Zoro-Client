using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro.SmartContract;

namespace Zoro_Client.UI
{
    public partial class PublishContractFrm : Form
    {
        public PublishContractFrm()
        {
            InitializeComponent();
        }

        private void BtnLoadContract_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbxContractPath.Text = openFileDialog1.FileName;
                    tbxContractName.Text = openFileDialog1.FileName.Replace(".avm", "");
                    var contractScript = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    var contractHash = contractScript.ToScriptHash();
                    tbxContractHash.Text = contractHash.ToString();
                }
                catch
                {
                    if (!System.IO.File.Exists(openFileDialog1.FileName))
                    {
                        MessageBox.Show("Contract file error！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxContractPath.Text = string.Empty;
                        tbxContractHash.Text = string.Empty;
                        tbxContractName.Text = string.Empty;
                        return;
                    }
                }
            }
        }
    }
}
