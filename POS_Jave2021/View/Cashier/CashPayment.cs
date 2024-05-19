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
    public partial class CashPayment : Form
    {
        string _cashOnHand;
        public CashPayment()
        {
            InitializeComponent();
            txtCashOnhand.Focus();
            btn_enter.Focus();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CashPayment_Load(object sender, EventArgs e)
        {
            
        }

        public void setCashOnHand(string cashOnHand)
        {
            _cashOnHand = cashOnHand;
        }
        private void btn_ONE_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "1";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_TWO_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "2";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_THREE_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "3";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_FOUR_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "4";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_FIVE_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "5";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_SIX_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "6";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_SEVEN_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "7";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_EIGHT_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "8";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_NINE_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "9";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_ZERO_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + "0";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_POINT_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = txtCashOnhand.Text + ".";
            setCashOnHand(txtCashOnhand.Text);
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if(txtCashOnhand.Text.Length > 0)
            {
                txtCashOnhand.Text = txtCashOnhand.Text.Substring(0, txtCashOnhand.Text.Length - 1);
                setCashOnHand(txtCashOnhand.Text);
            }           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCashOnhand.Text = string.Empty;
            setCashOnHand(txtCashOnhand.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCashOnhand.Text))
            {
                CashierHome._cashorder = decimal.Parse(txtCashOnhand.Text);
            }            
            this.Close();
        }

        private void txtCashOnhand_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtCashOnhand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void CashPayment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad1)
            {
                btn_ONE_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                btn_TWO_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                btn_THREE_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                btn_FOUR_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                btn_FIVE_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                btn_SIX_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                btn_SEVEN_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                btn_EIGHT_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                btn_NINE_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                btn_ZERO_Click(null, null);
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                btn_POINT_Click(null, null);
            }
            else if(e.KeyCode == Keys.Delete)
            {
                btn_DELETE_Click(null, null);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
    }
}
