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
        public MainForm()
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

        private static bool NoWallet()
        {
            if (Program.Wallet != null) return false;
            Console.WriteLine("You have to open the wallet first.");
            return true;
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
                    MessageBox.Show(Strings.PasswordIncorrect);
                    return;
                }               

                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();

                ChangeWallet(nep6wallet);

                Program.Wallet = nep6wallet;

                //修改密码CToolStripMenuItem.Enabled = Program.Wallet is Wallet;

                SplashScreen.Close();
            }
        }

        private void ChangeWallet(Wallet wallet)
        {
            if (Program.Wallet != null)
                panel2.Controls.Clear();

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
            AccountControl accountFrm = new AccountControl(account);
            accountFrm.Parent = panel2;
            accountFrm.Dock = DockStyle.Top;
            accountFrm.Show();

            foreach (string asset in Settings.Default.NEP5Watched)
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

        private void 修改密码CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (ChangePasswordFrm dialog = new ChangePasswordFrm())
            //{
            //    if (dialog.ShowDialog() != DialogResult.OK) return;
            //    if (((NEP6Wallet)Program.Wallet)(dialog.OldPassword, dialog.NewPassword))
            //        MessageBox.Show(Strings.ChangePasswordSuccessful);
            //    else
            //        MessageBox.Show(Strings.PasswordIncorrect);
            //}
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

        private void MainForm_Load(object sender, EventArgs e)
        {            
            Program.MainService.Run();            
        }

        private void ShowState()
        {
            Blockchain blockchain = LocalNode.Root.Blockchain;

            lbl_height.Text = $"{blockchain.Height}/{blockchain.HeaderHeight}";

            Console.WriteLine($"block:{blockchain.Name} {blockchain.ChainHash.ToString()} {blockchain.Height}/{blockchain.HeaderHeight}  connected: {LocalNode.Root.ConnectedCount}  unconnected: {LocalNode.Root.UnconnectedCount}  mempool:{blockchain.GetMemoryPoolCount()}");

            foreach (RemoteNode node in LocalNode.Root.GetRemoteNodes())
            {
                Console.WriteLine($"  ip: {node.Remote.Address}\tport: {node.Remote.Port}\tlisten: {node.ListenerPort}\theight: {node.Height}\tlatency: {node.Latency}");
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Blockchain blockchain = LocalNode.Root.Blockchain;
            DateTime persistence_time = blockchain.GetBlock(blockchain.GetBlockHash(blockchain.Height)).Timestamp.ToDateTime();

            lbl_height.Text = $"{blockchain.Height}/{blockchain.HeaderHeight}";

            lbl_count_node.Text = LocalNode.Root.ConnectedCount.ToString();

            TimeSpan persistence_span = DateTime.UtcNow - persistence_time;
            if (persistence_span < TimeSpan.Zero) persistence_span = TimeSpan.Zero;
           
            //if (persistence_span > Blockchain.TimePerBlock)
            //{
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            //}
            //else
            //{
            //    toolStripProgressBar1.Value = persistence_span.Seconds;
            //    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            //}

            RefreshBalance();
        }

        private void RefreshBalance()
        {
            foreach(Control control in panel2.Controls)
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

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.MainService.OnStop();
            ChangeWallet(null);
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            创建新地址NToolStripMenuItem.Enabled = Program.Wallet != null;
            导入私钥IToolStripMenuItem.Enabled = Program.Wallet != null;
        }

        private void AddAssetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddAssetFrm addAssetFrm = new AddAssetFrm())
            {
                if (addAssetFrm.ShowDialog() != DialogResult.OK) return;
                panel4.Controls.Clear();
                foreach (string asset in Settings.Default.NEP5Watched.OfType<string>().ToArray())
                {
                    RefreshAsset(asset);
                }
            }
        }
    }
}
