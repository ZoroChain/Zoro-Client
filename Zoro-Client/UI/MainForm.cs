using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Zoro.Network.P2P;
using Zoro.Persistence.LevelDB;
using Zoro.Wallets;
using Zoro.Wallets.NEP6;
using Zoro_Client.Properties;

namespace Zoro_Client.UI
{
    public partial class MainForm : Form
    {
        private WalletAccount WalletAccount;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(WalletAccount walletAccount)
        {
            InitializeComponent();
            WalletAccount = walletAccount;
            lblAddress.Text = walletAccount.Address;
            RefreshAsset();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RefreshBalance();
        }

        private void RefreshBalance()
        {
            try
            {
                foreach (Control control in panel4.Controls)
                {
                    if (control is AssetControl)
                    {
                        ((AssetControl)control).RefreshBalance();
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public void RefreshAsset()
        {
            try
            {
                foreach (string asset in Settings.Default.NEP5Watched.OfType<string>().ToArray())
                {
                    AssetControl assetControl = new AssetControl(UInt160.Parse(asset), WalletAccount);

                    assetControl.Parent = panel4;
                    assetControl.Dock = DockStyle.Top;

                }
            }
            catch
            {
                return;
            }
        }    

        private void PublishContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PublishContractFrm publishContractFrm = new PublishContractFrm(WalletAccount))
            {
                publishContractFrm.ShowDialog();
            }
        }

        private void LblAddress_Click(object sender, EventArgs e)
        {
            using (ViewPrivateKeyDialog dialog = new ViewPrivateKeyDialog(WalletAccount))
            {
                dialog.ShowDialog();
            }
        }

        private void BackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
