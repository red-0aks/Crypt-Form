using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuprumFramework.Security.Cryptography;

namespace Crypt_Form
{
    public partial class CrypForm : Form
    {
        public CrypForm()
        {
            InitializeComponent();
        }

        private void CrypForm_Load(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            raBtnEncrypt.Checked = true;
            raBtnDecrypt.Checked = false;
            txtInput.Focus();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            var input = txtInput.Text;
            var output = "";
            if (raBtnEncrypt.Checked)
            {
                output = Crypt.Encrypt(input);
            }
            else if (raBtnDecrypt.Checked)
            {
                output = Crypt.Decrypt(input);
            }
            txtOutput.Text = output;
        }

        private void raBtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }
    }
}
