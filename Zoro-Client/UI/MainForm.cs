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
        public WalletAccount WalletAccount;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(WalletAccount walletAccount)
        {
            InitializeComponent();
            WalletAccount = walletAccount;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RefreshBalance();
        }

        private void RefreshBalance()
        {
            foreach(Control control in panel4.Controls)
            {
                if (control is AccountControl)
                {
                    ((AccountControl)control).RefreshBalance();
                }
            }

            foreach (Control control in panel4.Controls)
            {
                if (control is AssetControl)
                {
                    ((AssetControl)control).RefreshBalance();
                }
            }
        }

        public void RefreshAsset(string asset)
        {
            foreach (WalletAccount account in Program.Wallet.GetAccounts())
            {
                AssetControl assetControl = new AssetControl(UInt160.Parse(asset), account);
                if (assetControl.IsShow)
                {
                    assetControl.Parent = panel4;
                    assetControl.Dock = DockStyle.Top;
                }
                else
                {
                    assetControl.Dispose();
                }
            }
        }               

        private void PublishContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PublishContractFrm publishContractFrm = new PublishContractFrm())
            {
                publishContractFrm.ShowDialog();
            }
        }
    }
}
