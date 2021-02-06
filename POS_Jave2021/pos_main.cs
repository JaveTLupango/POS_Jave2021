using MySql.Data.MySqlClient;
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

namespace POS_Jave2021
{
    public partial class pos_main : Form
    {
        public pos_main()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pos_main_Load(object sender, EventArgs e)
        {
            connectionClass.connect();
            conn = connectionClass.conn;


        }
    }
}
