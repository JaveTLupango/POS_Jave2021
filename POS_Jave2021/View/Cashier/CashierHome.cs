using MySqlX.XDevAPI.Relational;
using Newtonsoft.Json;
using POS_Jave2021.Class;
using POS_Jave2021.Model;
using POS_Jave2021.View.Cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Jave2021.View
{
    public partial class CashierHome : Form
    {
        public static DataTable _userDetails;
        public static DataTable _dtInv;
        public static DataTable _dtOrders;
        customOrderLayoutModel orderModels;
        public decimal _totalOrder;
        public static decimal _cashorder;
        public static decimal _cashChange;
        public static string _remarks;
        OleDbConnection _conn;
        public CashierHome(DataTable userDetails, OleDbConnection conn)
        {
            InitializeComponent();
            _userDetails = userDetails;
            _conn = conn;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void logs(string log)
        {
            rtb_logs.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss -- ")+log+ "\n");
        }

        private void CashierHome_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            txtPosScreenSearch.Focus();
            InventoryClass ic = new InventoryClass(_conn);
            _dtInv = ic.getListofInventory();
            dt_productlist.DataSource = _dtInv;
            _dtOrders = ic.customOrderLayout();
            dt_orderlist.DataSource = _dtOrders;
            rtb_logs.HideSelection = false;
        }

        private void CashierTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CashierTab.SelectedIndex == 0)
            {
                txtPosScreenSearch.Focus();
            }
            else
            {
                txtPosSearch.Focus();
            }
        }


        private void txtPosScreenSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logs("SCAN PRODUCTID : " + txtPosScreenSearch.Text);
                scanProductID(txtPosScreenSearch.Text);                
                txtPosScreenSearch.Text = "";
            }
        }

        public void scanProductID(string id)
        {
            try
            {
                DataTable ret = _dtInv.AsEnumerable().Where(
                    w => w.Field<string>("ProductID").Trim()  == id.Trim()).CopyToDataTable();

                if (ret.Rows.Count > 0)
                {
                    foreach (DataRow r in ret.Rows)
                    {
                        int orderID = _dtOrders.Rows.Count;
                        orderModels = new customOrderLayoutModel
                        {
                            ID = orderID + 1,
                            Name = r["Name"].ToString(),
                            QTY = 1,
                            Price = decimal.Parse(r["Price"].ToString()),
                            TotalPrice = decimal.Parse(r["Price"].ToString())
                        };
                        addRowsOrder(orderModels);
                        break;
                    }
                    logs("Product JSON: " + JsonConvert.SerializeObject(ret));
                    lbl_ordersCount.Text = _dtOrders.Rows.Count.ToString();
                }
                else
                {
                    logs("Product JSON: No Result!");
                    MessageBox.Show("No Item Found!", "No Matching Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if(ex.Message.ToLower().Trim()  == "the source contains no datarows.")
                {
                    MessageBox.Show("No Item Found!", "No Matching Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    logs("Catch : No Item Found!");
                }
                else
                {
                    logs("Catch : " + ex.Message);
                }
            }
        }

        public void addRowsOrder(customOrderLayoutModel model)
        {
            _dtOrders.Rows.Add(model.ID, model.Name, model.QTY, model.Price, model.TotalPrice);
            _totalOrder = _totalOrder + model.TotalPrice;
            lblTotalPriceOrder.Text = Convert.ToDecimal(_totalOrder).ToString("C");
            dt_orderlist.DataSource = _dtOrders;

        }

        private void CashierHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btn_reset_Click(null, null); //btn_reset_Click
            }
            else if (e.KeyCode == Keys.F2)
            {
                button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.R)
            {
                btn_ready_Click(null, null);
            }
            else if (e.KeyCode == Keys.F12)
            {
                button2_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CashPayment cpf = new CashPayment();
                cpf.ShowDialog();
                lblCashLabel.Text = _cashorder.ToString("C");
                _cashChange = _cashorder - _totalOrder;
                lblCashChange.Text = _cashChange.ToString("C");
                logs("Enter Custumer Cash: " + _cashorder.ToString("C"));
                logs("Custumer total order: " + _totalOrder.ToString("C"));
                logs("Custumer Change: " + _cashChange.ToString("C"));
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {
            txtPosScreenSearch.Focus();
            logs("POS Ready!!");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if(dt_orderlist.Rows.Count == 0)
            {
                MessageBox.Show("No available item in order list.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if((_cashorder >= _totalOrder))
                {
                    processOnOff(true);
                }
                else
                {
                    MessageBox.Show("Payment is not input Or lessthan compare to ordered amount! \nPlease ask the customer to pay first to proceed!!.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void processOnOff(bool is_on)
        {
            if(is_on)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                txtPosScreenSearch.Enabled = false;
                tlp_Controls.Enabled = false;
            }
            else
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                txtPosScreenSearch.Enabled = true;
                tlp_Controls.Enabled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are your sure...", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                logs("Clear Orders......");
                Remarks fr = new Remarks();
                fr.ShowDialog();
                if(!string.IsNullOrEmpty(_remarks))
                {
                    _dtOrders.Clear();
                    _totalOrder = 0;
                    _cashorder = 0;
                    _cashChange = 0;
                    lblTotalPriceOrder.Text = _totalOrder.ToString("C");
                    lblCashLabel.Text = _cashorder.ToString("C");
                    _cashChange = _cashorder - _totalOrder;
                    lblCashChange.Text = _cashChange.ToString("C");
                    lbl_ordersCount.Text = _dtOrders.Rows.Count.ToString();
                    logs("Remarks : " + _remarks);
                }
            }          
        }

        private void rtb_logs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
