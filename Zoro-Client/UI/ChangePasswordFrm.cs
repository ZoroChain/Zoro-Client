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
    public partial class ChangePasswordFrm : Form
    {
        public ChangePasswordFrm()
        {
            InitializeComponent();
        }

        public string OldPassword
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public string NewPassword
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
                textBox3.Text = value;
            }
        }       

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.Text == textBox2.Text;
        }
    }
}
