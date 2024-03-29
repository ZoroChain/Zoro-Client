﻿using System;
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
using Zoro.Ledger;

namespace Zoro_Client.UI
{
    public partial class AssetControl : UserControl
    {
        //public bool IsShow = false;
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
            Account = account;
            AssetHash = assetHash;
            GetBalance(assetHash, account);
        }

        public void RefreshBalance()
        {
            GetBalance(AssetHash, Account);
        }

        private void GetBalance(UInt160 assetHash, WalletAccount account)
        {
            try
            {
                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    if (assetHash == Genesis.BcpContractAddress || assetHash == Genesis.BctContractAddress)
                    {
                        sb.EmitSysCall("Zoro.NativeNEP5.Call", "BalanceOf", assetHash, Account.ScriptHash);
                        sb.EmitSysCall("Zoro.NativeNEP5.Call", "Decimals", assetHash);
                        sb.EmitSysCall("Zoro.NativeNEP5.Call", "Symbol", assetHash);
                    }
                    else
                    {
                        sb.EmitAppCall(assetHash, "balanceOf", account.ScriptHash);
                        sb.EmitAppCall(assetHash, "decimals");
                        sb.EmitAppCall(assetHash, "symbol");
                    }

                    var script = sb.ToArray().ToHexString();
                    Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    _params.Add("");
                    _params.Add(script);


                    Zoro.IO.Json.JObject info;
                    info = Program.Handler.Process("invokescript", _params);


                    JObject json = JObject.Parse(info.ToString());
                    string decimals;
                    string symbol = "";
                    decimal balance = 0.00m;

                    if (json.ContainsKey("stack"))
                    {
                        JArray stack = json["stack"] as JArray;
                        
                        symbol = Encoding.UTF8.GetString(ZoroHelper.HexString2Bytes(stack[2]["value"].ToString()));
                        decimals = BigInteger.Parse(stack[1]["value"].ToString()).ToString();

                        if (stack[0]["value"].ToString() == "" || stack[1]["value"].ToString() == "" || stack[2]["value"].ToString() == "")
                        {
                            this.lblBalance.Text = "0.00";
                            this.btnTransfer.Enabled = false;
                        }
                        else
                        {
                            string value = ZoroHelper.GetJsonValue((JObject)stack[0]);

                            balance = Math.Round(decimal.Parse(value) / (decimal)Math.Pow(10, double.Parse(decimals)), int.Parse(decimals));

                            if (balance != 0)
                                this.btnTransfer.Enabled = true;
                        }

                        Account = account;
                        AssetHash = assetHash;
                        AssetSymbol = symbol;
                        Decimals = int.Parse(decimals);

                    }

                    this.lblAsset.Text = assetHash.ToString() + "(" + symbol + ")";
                    this.lblBalance.Text = balance.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            using (TransferFrm transferFrm = new TransferFrm(Account, AssetHash.ToString(), AssetSymbol, Decimals))
            {
                transferFrm.ShowDialog();
            }                   
        }
    }
}
