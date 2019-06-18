using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro.Wallets;

namespace Zoro_Client.UI
{
    public partial class ViewPrivateKeyDialog : Form
    {
        public ViewPrivateKeyDialog(WalletAccount account)
        {
            InitializeComponent();

            KeyPair keyPair = account.GetKey();

            tbxAddress.Text = account.Address.ToString();
            tbxPublicKey.Text = keyPair.PublicKey.ToString();
            tbxHex.Text = account.ScriptHash.ToString();
            tbxWif.Text = keyPair.Export();
        }
    }
}
