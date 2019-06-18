using Neo.VM;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro.IO;
using Zoro.Network.RPC;
using Zoro.Wallets;

namespace Zoro_Client.UI
{
    public partial class TransferFrm : Form
    {
        private RpcHandler Handler = new RpcHandler();
        private WalletAccount Account;
        private UInt160 AssetId;
        private string Symbol;
        private int Decimals;

        public TransferFrm()
        {
            InitializeComponent();
        }

        public TransferFrm(WalletAccount account, string assetHash, string symbol, int decimals)
        {
            InitializeComponent();
            Account = account;
            this.tbxFrom.Text = account.Address;
            this.lblAsset.Text = assetHash + "(" + symbol + ")";
            AssetId = UInt160.Parse(assetHash);
            Symbol = symbol;
            Decimals = decimals;
        }

        private void BtnEstimateGas_Click(object sender, EventArgs e)
        {
            UInt160 to;
            Decimal value;
            try
            {
                to = ZoroHelper.GetPublicKeyHashFromAddress(tbxTo.Text);
            }
            catch
            {
                MessageBox.Show("To address error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                value = Decimal.Parse(tbxValue.Text, NumberStyles.Float) * new Decimal(Math.Pow(10, Decimals));
            }
            catch
            {
                MessageBox.Show("Value error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ScriptBuilder sb = new ScriptBuilder())
            {
                if (Symbol == "ZORO" || Symbol == "BCT")
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "Transfer", AssetId, Account.ScriptHash, to, new BigInteger(value));
                else
                    sb.EmitAppCall(AssetId, "transfer", Account.ScriptHash, to, new BigInteger(value));

                var tx = ZoroHelper.MakeTransaction(sb.ToArray(), Account.GetKey(), Fixed8.Zero, Fixed8.FromDecimal(0.0001m));

                var script = sb.ToArray().ToHexString();
                Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                _params.Add("");
                _params.Add(tx.ToArray().ToHexString());

                var info = Handler.Process("estimategas", _params);

                JObject json_response = JObject.Parse(info.ToString());
                string json_gas_consumed = json_response["gas_consumed"].ToString();

                tbxGasLimit.Text = json_gas_consumed;

            }
        }

        private void tbxOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsPunctuation(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;//消除不合适字符
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                if (e.KeyChar != '.')//小数点
                {
                    e.Handled = true;
                }
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxGasLimit.Text))
                MessageBox.Show("Please estimategas first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            UInt160 to;
            Decimal value;
            try
            {
                to = ZoroHelper.GetPublicKeyHashFromAddress(tbxTo.Text);
            }
            catch
            {
                MessageBox.Show("To address error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                value = Decimal.Parse(tbxValue.Text, NumberStyles.Float) * new Decimal(Math.Pow(10, 8));
            }
            catch
            {
                MessageBox.Show("Value error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ScriptBuilder sb = new ScriptBuilder())
            {
                if (Symbol == "ZORO" || Symbol == "BCT")
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "Transfer", AssetId, Account.ScriptHash, to, new BigInteger(value));
                else
                    sb.EmitAppCall(AssetId, "transfer", Account.ScriptHash, to, new BigInteger(value));

                decimal gasLimit = decimal.Parse(tbxGasLimit.Text);
                decimal gasPrice = decimal.Parse(tbxGasPrice.Text);

                var tx = ZoroHelper.MakeTransaction(sb.ToArray(), Account.GetKey(), Fixed8.FromDecimal(gasLimit), Fixed8.FromDecimal(gasPrice));

                string txid = tx.Hash.ToString();

                var script = sb.ToArray().ToHexString();
                Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                _params.Add("");
                _params.Add(tx.ToArray().ToHexString());

                var result = Handler.Process("sendrawtransaction", _params);

                string[] text = new string[] { "Result : " + result.ToString(), "Txid : " + txid };

                tbxResult.Lines = text;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
