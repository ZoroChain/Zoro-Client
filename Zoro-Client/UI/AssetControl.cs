using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Neo.VM;
using Zoro.Network.RPC;
using Newtonsoft.Json.Linq;
using System.Numerics;
using Zoro.Wallets;

namespace Zoro_Client.UI
{
    public partial class AssetControl : UserControl
    {
        private RpcHandler Handler = new RpcHandler();
        public bool IsShow = false;
        private WalletAccount Account;
        private UInt160 AssetHash;
        private string AssetSymbol;
        private int Decimals;

        public AssetControl()
        {
            InitializeComponent();
        }

        public AssetControl(UInt160 assetHash, WalletAccount account)
        {
            InitializeComponent();

            GetBalance(assetHash, account);
        }

        public void RefreshBalance()
        {
            GetBalance(AssetHash, Account);
        }

        private void GetBalance(UInt160 assetHash, WalletAccount account)
        {
            using (ScriptBuilder sb = new ScriptBuilder())
            {
                sb.EmitAppCall(assetHash, "balanceOf", account.ScriptHash);
                sb.EmitAppCall(assetHash, "decimals");
                sb.EmitAppCall(assetHash, "symbol");

                var script = sb.ToArray().ToHexString();
                Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                _params.Add("");
                _params.Add(script);

                var info = Handler.Process("invokescript", _params);

                JObject json = JObject.Parse(info.ToString());
                if (json.ContainsKey("stack"))
                {                    
                    JArray stack = json["stack"] as JArray;

                    if (stack[0]["value"].ToString() == "" || stack[1]["value"].ToString() == "" || stack[2]["value"].ToString() == "") return;

                    string value = ZoroHelper.GetJsonValue((JObject)stack[0]);
                    string decimals = BigInteger.Parse(stack[1]["value"].ToString()).ToString();
                    string symbol = Encoding.UTF8.GetString(ZoroHelper.HexString2Bytes(stack[2]["value"].ToString()));

                    decimal balance = Math.Round(decimal.Parse(value) / (decimal)Math.Pow(10, double.Parse(decimals)), int.Parse(decimals));

                    if (balance > 0)
                    {
                        IsShow = true;
                        this.lblAddress.Text = account.Address;
                        this.lblAsset.Text = assetHash.ToString() + "(" + symbol + ")";
                        this.lblBalance.Text = balance.ToString();

                        Account = account;
                        AssetHash = assetHash;
                        AssetSymbol = symbol;
                        Decimals = int.Parse(decimals);
                    }
                }
            }
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            TransferFrm transferFrm = new TransferFrm(Account, AssetHash.ToString(), AssetSymbol, Decimals);
            transferFrm.Show();
            transferFrm.TopMost = true;
        }
    }
}
