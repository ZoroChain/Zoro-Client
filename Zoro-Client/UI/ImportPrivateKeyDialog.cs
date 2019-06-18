using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoro_Client.UI
{
    public partial class ImportPrivateKeyDialog : Form
    {
        public ImportPrivateKeyDialog()
        {
            InitializeComponent();
        }

        public string[] WifStrings
        {
            get
            {
                return textBox1.Lines;
            }
            set
            {
                textBox1.Lines = value;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.TextLength > 0;
        }
    }
}
