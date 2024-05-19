using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Jave2021.View.Cashier
{
    public partial class Remarks : Form
    {
        public Remarks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please input remark!", "Remark is null or empty!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CashierHome._remarks = richTextBox1.Text;
                richTextBox1.Text = string.Empty;
                this.Close();
            }
        }
    }
}
