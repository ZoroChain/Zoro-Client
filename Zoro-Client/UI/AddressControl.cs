using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro.Wallets;
using System.Runtime.InteropServices;
using Zoro_Client.Properties;
using Zoro.Wallets.NEP6;

namespace Zoro_Client.UI
{
    public partial class AddressControl : UserControl
    {
        private string Address;
        private WalletAccount Account;

        public AddressControl()
        {
            InitializeComponent();
        }

        public AddressControl(WalletAccount walletAccount)
        {
            InitializeComponent();
            Account = walletAccount;
            lblAddress.Text = walletAccount.Address;
            Address = walletAccount.Address;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using (MainForm mainForm = new MainForm(Account))
            {
                mainForm.ShowDialog();
            }
        }

        private void 查看私钥VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ViewPrivateKeyDialog dialog = new ViewPrivateKeyDialog(Account))
            {
                dialog.ShowDialog();
            }
        }

        private void 复制到剪贴板CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Address);
            }
            catch (ExternalException) { }
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Strings.DeleteAddressConfirmationMessage, Strings.DeleteAddressConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            Program.Wallet.DeleteAccount(Account.ScriptHash);

            if (Program.Wallet is NEP6Wallet wallet)
                wallet.Save();
            this.Dispose();
        }

        private void AddressControl_DoubleClick(object sender, EventArgs e)
        {
            using (ViewPrivateKeyDialog dialog = new ViewPrivateKeyDialog(Account))
            {
                dialog.ShowDialog();
            }
        }
    }
}
