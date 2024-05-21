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
        logsClass _logClass;
        OleDbConnection _conn;
        OrderTransactionClass _otClass;
        public static DataTable _userDetails;
        public static string _userDetailsName;
        public static DataTable _dtInv;
        public static DataTable _dtOrders;
        customOrderLayoutModel orderModels;
        public decimal _totalOrderAmount;
        public static decimal _cashorder;
        public static decimal _cashChange;
        public static string _remarks;
        cashierBtnEnabilityModel btnEM = new cashierBtnEnabilityModel();
        InventoryClass _invClass;
        /// Shift Out
        DataTable _dtMySalesInv = new DataTable();
        DataTable _dtMySalesPOS = new DataTable();
        DataTable _dtMyShiftIn = new DataTable();
        shiftstart _ssClass;

        public CashierHome(DataTable userDetails, OleDbConnection conn)
        {
            InitializeComponent();
            _userDetails = userDetails;
            _conn = conn;
            _logClass = new logsClass();
            _otClass = new OrderTransactionClass(_conn);
            _invClass = new InventoryClass(_conn);
            _ssClass = new shiftstart(_conn);
            _userDetailsName = _userDetails.Rows[0]["user_id"].ToString() + " - " + _userDetails.Rows[0]["username"].ToString();
        }

        private void CashierTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CashierTab.SelectedIndex == 0)
            {
                CashierHome_Load(null, null);
            }
            else if (CashierTab.SelectedIndex == 1)
            {
                CashierTab_window2();
            }
        }

        #region Cashier POS
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void logs(string log)
        {
            rtb_logs.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss -- ")+log+ "\n");
            _logClass.writelineLogs(_userDetailsName + " - "+log);
        }

        private void CashierHome_Load(object sender, EventArgs e)
        {
            _totalOrderAmount = 0;
            _cashorder = 0;
            _cashChange = 0;
            processOnOff(true);
            txtPosScreenSearch.Focus();
            _dtInv = _invClass.getListofInventory();
            dt_productlist.DataSource = _dtInv;
            _dtOrders = _invClass.customOrderLayout();
            dt_orderlist.DataSource = _dtOrders;
            rtb_logs.HideSelection = false;
            // Btn accessability
            btnSetEnability( new cashierBtnEnabilityModel
            {
                _isProceed = false,
                _IsReset = false,
                _isReady = true,
                _IsEnterCash = false,
                _IsVoid = false,
            });
            processOnOff(false);
        }

        public void btnSetEnability(cashierBtnEnabilityModel model)
        {
            btnEM = model;
            btn_ready.Enabled = model._isReady;
            btn_Proceed.Enabled = model._isProceed;
            btn_reset.Enabled = model._IsReset;
            btn_EnterCash.Enabled = model._IsEnterCash;
            btn_void.Enabled = model._IsVoid;
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
                            InvID = r["ProductID"].ToString(),
                            Name = r["Name"].ToString(),
                            QTY = 1,
                            Price = decimal.Parse(r["Price"].ToString()),
                            TotalPrice = decimal.Parse(r["Price"].ToString()),
                            IsCancel = false,
                            Remarks = string.Empty,
                            
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
            _dtOrders.Rows.Add(model.ID, model.InvID, model.Name, model.QTY, model.Price, model.TotalPrice, model.IsCancel, model.Remarks);
            _totalOrderAmount = _totalOrderAmount + model.TotalPrice;
            lblTotalPriceOrder.Text = Convert.ToDecimal(_totalOrderAmount).ToString("C");
            dt_orderlist.DataSource = _dtOrders;

        }

        private void CashierHome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && btnEM._IsReset)
            {
                btn_reset_Click(null, null); //btn_reset_Click
            }
            else if (e.KeyCode == Keys.F2 && btnEM._IsEnterCash)
            {
                button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.R && btnEM._isReady)
            {
                btn_ready_Click(null, null );
            }
            else if (e.KeyCode == Keys.F12 && btnEM._isProceed)
            {
                button2_Click(null, null);
            }
            else if (e.KeyCode == Keys.Escape && btnEM._IsVoid)
            {
                btn_void_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logs("POS Enter Cash Order: Started");
            try
            {
                CashPayment cpf = new CashPayment();
                cpf.ShowDialog();
                _cashChange = _cashorder - _totalOrderAmount;
                lblCashLabel.Text = _cashorder.ToString("C");
                lblCashChange.Text = _cashChange.ToString("C");
                logs("Enter Custumer Cash: " + _cashorder.ToString("C"));
                logs("Custumer total order: " + _totalOrderAmount.ToString("C"));
                logs("Custumer Change: " + _cashChange.ToString("C"));

                btnSetEnability(new cashierBtnEnabilityModel
                {
                    _isProceed = true,
                    _IsReset = false,
                    _isReady = false,
                    _IsEnterCash = true,
                    _IsVoid = true,
                });
            }
            catch (Exception ex)
            {
                logs("POS Enter Cash Order Catch Error: " + ex.Message);
                throw ex;
            }
            logs("POS Enter Cash Order: Started");
        }

        private void btn_ready_Click(object sender, EventArgs e)
        {

            _totalOrderAmount = 0;
            _cashorder = 0;
            _cashChange = 0;
            lblTotalPriceOrder.Text = _totalOrderAmount.ToString("C");
            lblCashLabel.Text = _cashorder.ToString("C");
            lblCashChange.Text = _cashChange.ToString("C");
            btnSetEnability(new cashierBtnEnabilityModel
            {
                _isProceed = false,
                _IsReset = true,
                _isReady = false,
                _IsEnterCash = true,
                _IsVoid = false
            });
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
                if((_cashorder >= _totalOrderAmount))
                {
                    logs("POS Orders Transaction: Started");
                    processOnOff(true);
                    await transaction(false);
                    CashierHome_Load(null, null);
                    processOnOff(false);
                    logs("POS Orders Transaction: End");
                }
                else
                {
                    MessageBox.Show("Payment is not input Or lessthan compare to ordered amount! \nPlease ask the customer to pay first to proceed!!.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public async Task transaction(bool isVoid)
        {
            var model = new PosModel
            {
                total_inv = dt_orderlist.Rows.Count.ToString(),
                total_price = _totalOrderAmount,
                cash = _cashorder,
                change = _cashChange,
                user_id = _userDetails.Rows[0]["user_id"].ToString()
            };
            logs("Orders POS: " + JsonConvert.SerializeObject(model));
            var response = _otClass.InsertPosTransaction(model, isVoid, string.Empty);
            logs("Orders POS response: " + JsonConvert.SerializeObject(response));
            if (response.is_Success)
            {
                logs("Orders [tbl_inv_sold] : waiting");
                response = _otClass.InsertInvSold(_dtOrders, _dtInv, response.message, isVoid);
                logs("Orders [tbl_inv_sold]: " + JsonConvert.SerializeObject(response));
                if (response.is_Success)
                {
                    MessageBox.Show("Transaction Complete!", "Successfully Insert!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Incomplete!", "Unsuccessfully Insert to [tbl_inv_sold]!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Transaction Complete!", "Unsuccessfully Insert to [tbl_pos]!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void processOnOff(bool is_on)
        {
            if(is_on)
            {
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
                txtPosScreenSearch.Enabled = false;
                tlp_Controls.Enabled = false;
            }
            else
            {
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                txtPosScreenSearch.Enabled = true;
                tlp_Controls.Enabled = true;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            _totalOrderAmount = 0;
            _cashorder = 0;
            _cashChange = 0;
            logs("POS Clear Order: Started");
            DialogResult d = MessageBox.Show("Are your sure...", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (d == DialogResult.OK)
            {
                logs("Clear Orders......");
                _remarks = string.Empty;
                Remarks fr = new Remarks();
                fr.ShowDialog();
                if(!string.IsNullOrEmpty(_remarks))
                {
                    _dtOrders.Clear();
                    _totalOrderAmount = 0;
                    _cashorder = 0;
                    _cashChange = 0;
                    lblTotalPriceOrder.Text = _totalOrderAmount.ToString("C");
                    lblCashLabel.Text = _cashorder.ToString("C");
                    _cashChange = _cashorder - _totalOrderAmount;
                    lblCashChange.Text = _cashChange.ToString("C");
                    lbl_ordersCount.Text = _dtOrders.Rows.Count.ToString();
                    logs("Remarks : " + _remarks);
                }
            }
            logs("POS Clear Order: End");
        }

        private void rtb_logs_TextChanged(object sender, EventArgs e)
        {

        }

        private void dt_orderlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_void_Click(object sender, EventArgs e)
        {
            if (dt_orderlist.Rows.Count == 0)
            {
                MessageBox.Show("No available item in order list.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {    _remarks = null;
                Remarks fr = new Remarks();
                fr.ShowDialog();
                if(!string.IsNullOrEmpty(_remarks))
                {
                    if ((_cashorder >= _totalOrderAmount))
                    {
                        logs("POS VOid Orders Transaction: Started");
                        processOnOff(true);
                        await transaction(true);
                        CashierHome_Load(null, null);
                        processOnOff(false);
                        logs("POS VOid Orders Transaction: End");
                    }
                    else
                    {
                        MessageBox.Show("Payment is not input Or lessthan compare to ordered amount! \nPlease ask the customer to pay first to proceed!!.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Remark is null or empty!.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        public async Task CashierTab_window2()
        {
            processOnOff(true);
            logs("Cashier window 2 is open...");
            try
            {
                lbl_userid.Text = _userDetails.Rows[0]["user_id"].ToString();
                lbl_username.Text = _userDetails.Rows[0]["username"].ToString();
                lbl_userfullname.Text = _userDetails.Rows[0]["lastname"].ToString() + ", " + _userDetails.Rows[0]["firstname"].ToString();
                lbl_usertype.Text = Int32.Parse(_userDetails.Rows[0]["usertype"].ToString()) == 0 ? "Cashier" : "Administrator";
                await getSaleINV();
                await getSalePOS();
                await getShiftIN();
                lbl_shiftInAmount.Text = _dtMyShiftIn.Rows[0]["shift_In_amount"].ToString();
                lbl_shiftTotalSales.Text = gettotalSales(false).ToString("C");
                lbl_shiftVoidSales.Text = gettotalSales(true).ToString("C");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Catch Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            processOnOff(false);
        }

        public decimal gettotalSales(bool isVoid)
        {
            decimal totalSales = 0;
            DataTable ret = _dtMySalesPOS.AsEnumerable().Where(
                    w => w.Field<bool>("is_void") == isVoid).CopyToDataTable();
            if (ret.Rows.Count > 0)
            {
                foreach (DataRow row in ret.Rows)
                {
                    totalSales = totalSales + Decimal.Parse(row["total_price"].ToString());
                }
            }            
            return totalSales;
        }

        public async Task getSaleINV()
        {

            logs("getSaleINV....wait");
            try
            {
                _dtMySalesInv = await _invClass.getInvSold();
            }
            catch (Exception ex)
            {
                logs("getSaleINV Error Catch :" + ex.Message);
                throw ex;
            }
            logs("getSaleINV....end");
        }
        public async Task getSalePOS()
        {
            logs("getSalePOS....wait");
            try
            {
                _dtMySalesPOS = _otClass.getPOSlist();
            }
            catch (Exception ex)
            {
                logs("getSalePOS Error Catch :" + ex.Message);
                throw ex;
            }
            logs("getSaleINV....end");
        }
        public async Task getShiftIN()
        {
            logs("getShiftIN....wait");
            try
            {
                _dtMyShiftIn = _ssClass.getShiftIn(_userDetails.Rows[0]["user_id"].ToString());
            }
            catch (Exception ex)
            {
                logs("getShiftIN Error Catch :" + ex.Message);
                throw ex;
            }
            logs("getShiftIN....end");
        }

        private void tabControlCashierReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_shiftOut_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            CashierTab_window2();
        }
    }
    
}
