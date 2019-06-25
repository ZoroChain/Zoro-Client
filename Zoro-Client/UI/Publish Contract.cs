using Neo.VM;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro.IO;
using Zoro.Network.RPC;
using Zoro.SmartContract;
using Zoro.Wallets;

namespace Zoro_Client.UI
{
    public partial class PublishContractFrm : Form
    {
        private WalletAccount walletAccount;
        private byte[] contractScript;
        private decimal zoroFee = 1.0000m;

        public PublishContractFrm()
        {
            InitializeComponent();
        }

        public PublishContractFrm(WalletAccount walletAccount)
        {
            InitializeComponent();
            this.walletAccount = walletAccount;
            this.lblZoroFee.Text = zoroFee.ToString();
        }

        private void BtnLoadContract_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tbxContractPath.Text = openFileDialog1.FileName;
                    tbxContractName.Text = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    contractScript = System.IO.File.ReadAllBytes(openFileDialog1.FileName);
                    var contractHash = contractScript.ToScriptHash();
                    tbxContractHash.Text = contractHash.ToString();
                }
                catch
                {
                    if (!System.IO.File.Exists(openFileDialog1.FileName))
                    {
                        MessageBox.Show("Contract file error！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxContractPath.Text = string.Empty;
                        tbxContractHash.Text = string.Empty;
                        tbxContractName.Text = string.Empty;
                        return;
                    }
                }
            }
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            if (contractScript.Length == 0)
            {
                MessageBox.Show("Contract file error！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] parameter__list = ZoroHelper.HexString2Bytes(tbxParameterType.Text);
            byte[] return_type = ZoroHelper.HexString2Bytes("05");
            int need_storage = cbxNeedStorge.Checked == true ? 1 : 0;
            int need_nep4 = cbxNeedNep4.Checked == true ? 2 : 0;
            int need_canCharge = cbxNeedCharge.Checked == true ? 4 : 0;

            try
            {
                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    var ss = need_storage | need_nep4 | need_canCharge;
                    sb.EmitPush(tbxDescri.Text);
                    sb.EmitPush(tbxEmail.Text);
                    sb.EmitPush(tbxAuthor.Text);
                    sb.EmitPush(tbxVersion.Text);
                    sb.EmitPush(tbxContractName.Text);
                    sb.EmitPush(ss);
                    sb.EmitPush(return_type);
                    sb.EmitPush(parameter__list);
                    sb.EmitPush(contractScript);
                    sb.EmitSysCall("Zoro.Contract.Create");

                    var tx = ZoroHelper.MakeTransaction(sb.ToArray(), walletAccount.GetKey(), Fixed8.Zero, Fixed8.FromDecimal(0.00001m));

                    Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    _params.Add("");
                    _params.Add(tx.ToArray().ToHexString());

                    //var info = Program.Handler.Process("estimategas", _params);
                    //JObject json_response = JObject.Parse(info.ToString());
                    //string json_gas_consumed = json_response["gas_consumed"].ToString();

                    //lblZoroFee.Text = json_gas_consumed;


                    tx = ZoroHelper.MakeTransaction(sb.ToArray(), walletAccount.GetKey(), Fixed8.FromDecimal(decimal.Parse(lblZoroFee.Text)), Fixed8.FromDecimal(0.0001m));

                    string txid = tx.Hash.ToString();

                    var script = sb.ToArray().ToHexString();
                    Zoro.IO.Json.JArray _paramss = new Zoro.IO.Json.JArray();
                    _paramss.Add("");
                    _paramss.Add(tx.ToArray().ToHexString());

                    var result = Program.Handler.Process("sendrawtransaction", _paramss);

                    string[] text = new string[] { "Result : " + result.ToString(), "Txid : " + txid };

                    tbxResult.Lines = text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Published error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CbxNeedNep4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNeedNep4.CheckState == CheckState.Checked)
                zoroFee += (decimal)5.0000;
            else
                zoroFee -= (decimal)5.0000;
            lblZoroFee.Text = zoroFee.ToString();
        }

        private void CbxNeedStorge_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNeedStorge.CheckState == CheckState.Checked)
                zoroFee += (decimal)4.0000;
            else
                zoroFee -= (decimal)4.0000;
            lblZoroFee.Text = zoroFee.ToString();
        }
    }
}
