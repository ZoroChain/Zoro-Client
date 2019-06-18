using System;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Neo.VM;
using Zoro.Network.RPC;
using Newtonsoft.Json.Linq;
using Zoro.Wallets;
using System.Runtime.InteropServices;
using Zoro_Client.Properties;
using System.Linq;
using Zoro.Wallets.NEP6;
using Zoro.Network.P2P;
using Zoro.SmartContract;
using System.Drawing;

namespace Zoro_Client.UI
{
    public partial class AccountControl : UserControl
    {
        public string Address;
        public WalletAccount Account;
        private RpcHandler handler = new RpcHandler();

        public AccountControl()
        {
            InitializeComponent();
        }
        public AccountControl(WalletAccount account)
        {
            InitializeComponent();
            Account = account;
            lblAddress.Text = account.Address;
            Address = account.Address;
            GetBalance();
        }

        public void RefreshBalance()
        {
            GetBalance();
        }

        private void GetBalance()
        {
            Blockchain blockchain = LocalNode.Root.Blockchain;
            try
            {
                UInt160 bcpAssetId = Genesis.BcpContractAddress;
                UInt160 bctAssetId = Genesis.BctContractAddress;

                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "BalanceOf", bcpAssetId, Account.ScriptHash);
                    //sb.EmitSysCall("Zoro.NativeNEP5.Call", "Decimals", bcpAssetId);

                    //var script = sb.ToArray().ToHexString();
                    //Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    //_params.Add("");
                    //_params.Add(script);

                    var script = sb.ToArray();
                    ApplicationEngine engine = ApplicationEngine.Run(script, blockchain, testMode: true);
                    Zoro.IO.Json.JObject json = new Zoro.IO.Json.JObject();
                    json["script"] = script.ToHexString();
                    json["state"] = engine.State;
                    json["gas_consumed"] = engine.GasConsumed.ToString();
                    try
                    {
                        json["stack"] = new Zoro.IO.Json.JArray(engine.ResultStack.Select(p => p.ToParameter().ToJson()));
                    }
                    catch (InvalidOperationException)
                    {
                        json["stack"] = "error: recursive reference";
                    }

                    //var info = handler.Process("invokescript", _params);
                    var value = GetBalanceFromJson(json.ToString());

                    lblZoro.Text = value;

                }

                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "BalanceOf", bctAssetId, Account.ScriptHash);
                    //sb.EmitSysCall("Zoro.NativeNEP5.Call", "Decimals", bctAssetId);

                    //var script = sb.ToArray().ToHexString();
                    //Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    //_params.Add("");
                    //_params.Add(script);

                    var script = sb.ToArray();
                    ApplicationEngine engine = ApplicationEngine.Run(script, blockchain, testMode: true);
                    Zoro.IO.Json.JObject json = new Zoro.IO.Json.JObject();
                    json["script"] = script.ToHexString();
                    json["state"] = engine.State;
                    json["gas_consumed"] = engine.GasConsumed.ToString();
                    try
                    {
                        json["stack"] = new Zoro.IO.Json.JArray(engine.ResultStack.Select(p => p.ToParameter().ToJson()));
                    }
                    catch (InvalidOperationException)
                    {
                        json["stack"] = "error: recursive reference";
                    }

                    //var info = handler.Process("invokescript", _params);
                    var value = GetBalanceFromJson(json.ToString());

                    lblBct.Text = value;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("获取余额出错！" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private string GetBalanceFromJson(string info)
        {
            string result = "";
            JObject json = JObject.Parse(info);

            JArray stack = json["stack"] as JArray;

            if (stack != null && stack.Count > 0)
            {
                string balance = ZoroHelper.GetJsonValue(stack[0] as JObject);

                Decimal value = Decimal.Parse(balance) / new Decimal(Math.Pow(10, 8));
                string fmt = "{0:N" + 8 + "}";
                result = string.Format(fmt, value);
            }

            return result;
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

        private void AccountFrm_DoubleClick(object sender, EventArgs e)
        {
            using (ViewPrivateKeyDialog dialog = new ViewPrivateKeyDialog(Account))
            {
                dialog.ShowDialog();
            }
        }

        private void AccountFrm_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void AccountFrm_MouseEnter(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void AccountFrm_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void BtnTransferZoro_Click(object sender, EventArgs e)
        {
            TransferFrm transferFrm = new TransferFrm(Account, "0x0000000000000000000000000000000000000001", "ZORO", 8);
            transferFrm.Show();
            transferFrm.TopMost = true;
        }

        private void BtnTransferBct_Click(object sender, EventArgs e)
        {
            TransferFrm transferFrm = new TransferFrm(Account, "0x0000000000000000000000000000000000000002", "BCT", 8);
            transferFrm.Show();
            transferFrm.TopMost = true;
        }
    }
}
