using POS_Jave2021.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public CashierHome(DataTable userDetails)
        {
            InitializeComponent();
            _userDetails = userDetails;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CashierHome_Load(object sender, EventArgs e)
        {
            InventoryClass ic = new InventoryClass(pos_main.conn);
            DataTable resDt = ic.getListofInventory();
            dt_productlist.DataSource = resDt;
           
        }
    }
}
