using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Zoro.Network.P2P;
using Zoro.Wallets;
using Zoro.Wallets.NEP6;
using Zoro_Client.Properties;

namespace Zoro_Client.UI
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void 创建钱包数据库NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateWalletDialog dialog = new CreateWalletDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;

                LoadingFrm loadingFrm = new LoadingFrm("Creating...");
                SplashScreen.Show(loadingFrm);

                NEP6Wallet wallet = new NEP6Wallet(dialog.WalletPath, null);
                wallet.Unlock(dialog.Password);
                WalletAccount account = wallet.CreateAccount();
                wallet.Save();
                Settings.Default.LastWalletPath = dialog.WalletPath;
                Settings.Default.Save();

                Program.Wallet = wallet;
                //ZoroChainSystem.Singleton.SetWallet(Program.Wallet);

                SplashScreen.Close();
            }
        }

        private void 打开钱包数据库OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenWalletDialog dialog = new OpenWalletDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                string path = dialog.WalletPath;

                LoadingFrm loadingFrm = new LoadingFrm("Opening...");
                SplashScreen.Show(loadingFrm);

                NEP6Wallet nep6wallet = new NEP6Wallet(dialog.WalletPath, null);
                try
                {
                    nep6wallet.Unlock(dialog.Password);
                }
                catch (CryptographicException)
                {
                    SplashScreen.Close();
                    MessageBox.Show(Strings.PasswordIncorrect);
                    return;
                }

                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();

                ChangeWallet(nep6wallet);

                Program.Wallet = nep6wallet;               

                SplashScreen.Close();
            }
        }

        private void ChangeWallet(Wallet wallet)
        {
            if (Program.Wallet != null)
                panel1.Controls.Clear();

            if (wallet != null)
            {
                foreach (WalletAccount account in wallet.GetAccounts().ToArray())
                {
                    AddAccount(account);
                }

                if (wallet is IDisposable disposable)
                    disposable.Dispose();
            }
        }

        private void AddAccount(WalletAccount account)
        {
            AddressControl addressControl = new AddressControl(account);
            addressControl.Parent = this.panel1;
            addressControl.Dock = DockStyle.Top;
            addressControl.Show();

        }

        private void AddAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddAssetFrm addAssetFrm = new AddAssetFrm())
            {
                addAssetFrm.ShowDialog();               
            }
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainService.OnStop();
            ChangeWallet(null);
        }

        private void 创建新地址NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadingFrm loadingFrm = new LoadingFrm("Creating...");
            SplashScreen.Show(loadingFrm);
            WalletAccount account = Program.Wallet.CreateAccount();
            AddAccount(account);
            if (Program.Wallet is NEP6Wallet wallet)
                wallet.Save();
            SplashScreen.Close();
        }

        private void ImportWIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ImportPrivateKeyDialog dialog = new ImportPrivateKeyDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                foreach (string wif in dialog.WifStrings)
                {
                    WalletAccount account;
                    try
                    {
                        account = Program.Wallet.Import(wif);
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                    AddAccount(account);
                }
                if (Program.Wallet is NEP6Wallet wallet)
                    wallet.Save();
            }
        }

        private void ImportCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (SelectCertificateDialog dialog = new SelectCertificateDialog())
            //{
            //    if (dialog.ShowDialog() != DialogResult.OK) return;
            //    listView1.SelectedIndices.Clear();
            //    WalletAccount account = Program.CurrentWallet.Import(dialog.SelectedCertificate);
            //    AddAccount(account, true);
            //    if (Program.CurrentWallet is NEP6Wallet wallet)
            //        wallet.Save();
            //}
        }

        private void ImportWatchOnlyAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string text = InputBox.Show(Strings.Address, Strings.ImportWatchOnlyAddress);
            //if (string.IsNullOrEmpty(text)) return;
            //using (StringReader reader = new StringReader(text))
            //{
            //    while (true)
            //    {
            //        string address = reader.ReadLine();
            //        if (address == null) break;
            //        address = address.Trim();
            //        if (string.IsNullOrEmpty(address)) continue;
            //        UInt160 scriptHash;
            //        try
            //        {
            //            scriptHash = Wallet.ToScriptHash(address);
            //        }
            //        catch (FormatException)
            //        {
            //            continue;
            //        }
            //        WalletAccount account = Program.CurrentWallet.CreateAccount(scriptHash);
            //        AddAccount(account, true);
            //    }
            //}
            //if (Program.CurrentWallet is NEP6Wallet wallet)
            //    wallet.Save();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            Program.MainService.Run();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Blockchain blockchain = LocalNode.Root.Blockchain;
            DateTime persistence_time = blockchain.GetBlock(blockchain.GetBlockHash(blockchain.Height)).Timestamp.ToDateTime();

            lbl_height.Text = $"{blockchain.Height}/{blockchain.HeaderHeight}";

            lbl_count_node.Text = LocalNode.Root.ConnectedCount.ToString();

            TimeSpan persistence_span = DateTime.UtcNow - persistence_time;
            if (persistence_span < TimeSpan.Zero) persistence_span = TimeSpan.Zero;

            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            创建新地址NToolStripMenuItem.Enabled = Program.Wallet != null;
            导入私钥IToolStripMenuItem.Enabled = Program.Wallet != null;
        }
    }
}
