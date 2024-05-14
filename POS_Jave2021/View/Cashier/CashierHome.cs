using MySqlX.XDevAPI.Relational;
using POS_Jave2021.Class;
using POS_Jave2021.Model;
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

        private void CashierHome_Load(object sender, EventArgs e)
        {

            InventoryClass ic = new InventoryClass(_conn);
            _dtInv = ic.getListofInventory();
            dt_productlist.DataSource = _dtInv;
            _dtOrders = ic.customOrderLayout();
            dt_orderlist.DataSource = _dtOrders;
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
                scanProductID(txtPosScreenSearch.Text);
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
                }
                else
                {
                    MessageBox.Show("No Item Found!", "No Matching Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                if(ex.Message.ToLower().Trim()  == "the source contains no datarows.")
                {
                    MessageBox.Show("No Item Found!", "No Matching Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                MessageBox.Show("C");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
