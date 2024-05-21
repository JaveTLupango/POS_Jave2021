namespace POS_Jave2021.View
{
    partial class CashierHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_refresh;
            this.CashierTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlp_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCashChange = new System.Windows.Forms.Label();
            this.lblTotalPriceOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCashLabel = new System.Windows.Forms.Label();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EnterCash = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_ready = new System.Windows.Forms.Button();
            this.btn_void = new System.Windows.Forms.Button();
            this.rtb_logs = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ordersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dt_orderlist = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPosScreenSearch = new System.Windows.Forms.TextBox();
            this.dt_productlist = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlCashierReport = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_shiftOut = new System.Windows.Forms.Button();
            this.lbl_shiftInAmount = new System.Windows.Forms.Label();
            this.lbl_shiftTotalSales = new System.Windows.Forms.Label();
            this.lbl_shiftVoidSales = new System.Windows.Forms.Label();
            this.lbl_isBalance = new System.Windows.Forms.Label();
            this.lbl_disbalance = new System.Windows.Forms.Label();
            this.lbl_cashOnHand = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_userfullname = new System.Windows.Forms.Label();
            this.lbl_usertype = new System.Windows.Forms.Label();
            btn_refresh = new System.Windows.Forms.Button();
            this.CashierTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlp_Controls.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_orderlist)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productlist)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControlCashierReport.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            btn_refresh.BackgroundImage = global::POS_Jave2021.Properties.Resources.png_clipart_computer_icons_synchronization_refresh_miscellaneous_leaf_thumbnail;
            btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_refresh.Location = new System.Drawing.Point(1475, 3);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new System.Drawing.Size(47, 35);
            btn_refresh.TabIndex = 10;
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // CashierTab
            // 
            this.CashierTab.Controls.Add(this.tabPage1);
            this.CashierTab.Controls.Add(this.tabPage2);
            this.CashierTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierTab.Location = new System.Drawing.Point(1, 1);
            this.CashierTab.Name = "CashierTab";
            this.CashierTab.SelectedIndex = 0;
            this.CashierTab.Size = new System.Drawing.Size(1543, 691);
            this.CashierTab.TabIndex = 0;
            this.CashierTab.SelectedIndexChanged += new System.EventHandler(this.CashierTab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.Controls.Add(this.tlp_Controls);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1535, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POS Screen";
            // 
            // tlp_Controls
            // 
            this.tlp_Controls.ColumnCount = 2;
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.88587F));
            this.tlp_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.11413F));
            this.tlp_Controls.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tlp_Controls.Controls.Add(this.btn_Proceed, 1, 1);
            this.tlp_Controls.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tlp_Controls.Controls.Add(this.rtb_logs, 0, 1);
            this.tlp_Controls.Location = new System.Drawing.Point(3, 432);
            this.tlp_Controls.Name = "tlp_Controls";
            this.tlp_Controls.RowCount = 2;
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Controls.Size = new System.Drawing.Size(944, 220);
            this.tlp_Controls.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCashChange, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalPriceOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCashLabel, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(653, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.9697F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.0303F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 133);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL ";
            // 
            // lblCashChange
            // 
            this.lblCashChange.AutoSize = true;
            this.lblCashChange.Location = new System.Drawing.Point(147, 86);
            this.lblCashChange.Name = "lblCashChange";
            this.lblCashChange.Size = new System.Drawing.Size(19, 20);
            this.lblCashChange.TabIndex = 7;
            this.lblCashChange.Text = "0";
            // 
            // lblTotalPriceOrder
            // 
            this.lblTotalPriceOrder.AutoSize = true;
            this.lblTotalPriceOrder.ForeColor = System.Drawing.Color.Red;
            this.lblTotalPriceOrder.Location = new System.Drawing.Point(147, 0);
            this.lblTotalPriceOrder.Name = "lblTotalPriceOrder";
            this.lblTotalPriceOrder.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPriceOrder.TabIndex = 3;
            this.lblTotalPriceOrder.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CHANGE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CASH ";
            // 
            // lblCashLabel
            // 
            this.lblCashLabel.AutoSize = true;
            this.lblCashLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lblCashLabel.Location = new System.Drawing.Point(147, 40);
            this.lblCashLabel.Name = "lblCashLabel";
            this.lblCashLabel.Size = new System.Drawing.Size(19, 20);
            this.lblCashLabel.TabIndex = 5;
            this.lblCashLabel.Text = "0";
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Location = new System.Drawing.Point(653, 142);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(288, 74);
            this.btn_Proceed.TabIndex = 1;
            this.btn_Proceed.Text = "Proceed (F12)";
            this.btn_Proceed.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Proceed.UseVisualStyleBackColor = true;
            this.btn_Proceed.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel3.Controls.Add(this.btn_EnterCash, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btn_reset, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_ready, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_void, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(644, 133);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_EnterCash
            // 
            this.btn_EnterCash.Location = new System.Drawing.Point(427, 91);
            this.btn_EnterCash.Name = "btn_EnterCash";
            this.btn_EnterCash.Size = new System.Drawing.Size(214, 39);
            this.btn_EnterCash.TabIndex = 0;
            this.btn_EnterCash.Text = "Enter Cash (F2)";
            this.btn_EnterCash.UseVisualStyleBackColor = true;
            this.btn_EnterCash.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(427, 47);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(214, 38);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "RESET (F1)";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_ready
            // 
            this.btn_ready.Location = new System.Drawing.Point(427, 3);
            this.btn_ready.Name = "btn_ready";
            this.btn_ready.Size = new System.Drawing.Size(214, 38);
            this.btn_ready.TabIndex = 1;
            this.btn_ready.Text = "Ready (R)";
            this.btn_ready.UseVisualStyleBackColor = true;
            this.btn_ready.Click += new System.EventHandler(this.btn_ready_Click);
            // 
            // btn_void
            // 
            this.btn_void.Location = new System.Drawing.Point(215, 3);
            this.btn_void.Name = "btn_void";
            this.btn_void.Size = new System.Drawing.Size(206, 38);
            this.btn_void.TabIndex = 3;
            this.btn_void.Text = "VOID (ESC)";
            this.btn_void.UseVisualStyleBackColor = true;
            this.btn_void.Click += new System.EventHandler(this.btn_void_Click);
            // 
            // rtb_logs
            // 
            this.rtb_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_logs.Enabled = false;
            this.rtb_logs.Location = new System.Drawing.Point(3, 142);
            this.rtb_logs.Name = "rtb_logs";
            this.rtb_logs.Size = new System.Drawing.Size(644, 75);
            this.rtb_logs.TabIndex = 3;
            this.rtb_logs.Text = "";
            this.rtb_logs.TextChanged += new System.EventHandler(this.rtb_logs_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_ordersCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.dt_orderlist);
            this.groupBox2.Location = new System.Drawing.Point(953, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 639);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order List";
            // 
            // lbl_ordersCount
            // 
            this.lbl_ordersCount.AutoSize = true;
            this.lbl_ordersCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_ordersCount.Location = new System.Drawing.Point(82, 606);
            this.lbl_ordersCount.Name = "lbl_ordersCount";
            this.lbl_ordersCount.Size = new System.Drawing.Size(19, 20);
            this.lbl_ordersCount.TabIndex = 6;
            this.lbl_ordersCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOTAL  : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_Jave2021.Properties.Resources.loading1;
            this.pictureBox2.Location = new System.Drawing.Point(235, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dt_orderlist
            // 
            this.dt_orderlist.AllowUserToAddRows = false;
            this.dt_orderlist.AllowUserToDeleteRows = false;
            this.dt_orderlist.AllowUserToOrderColumns = true;
            this.dt_orderlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_orderlist.Location = new System.Drawing.Point(1, 25);
            this.dt_orderlist.Name = "dt_orderlist";
            this.dt_orderlist.ReadOnly = true;
            this.dt_orderlist.Size = new System.Drawing.Size(575, 578);
            this.dt_orderlist.TabIndex = 1;
            this.dt_orderlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_orderlist_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtPosScreenSearch);
            this.groupBox1.Controls.Add(this.dt_productlist);
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Inventory List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_Jave2021.Properties.Resources.loading2;
            this.pictureBox1.Location = new System.Drawing.Point(247, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPosScreenSearch
            // 
            this.txtPosScreenSearch.Location = new System.Drawing.Point(723, 14);
            this.txtPosScreenSearch.Name = "txtPosScreenSearch";
            this.txtPosScreenSearch.Size = new System.Drawing.Size(207, 26);
            this.txtPosScreenSearch.TabIndex = 2;
            this.txtPosScreenSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosScreenSearch_KeyDown);
            // 
            // dt_productlist
            // 
            this.dt_productlist.AllowUserToAddRows = false;
            this.dt_productlist.AllowUserToDeleteRows = false;
            this.dt_productlist.AllowUserToOrderColumns = true;
            this.dt_productlist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dt_productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_productlist.Location = new System.Drawing.Point(-1, 42);
            this.dt_productlist.Name = "dt_productlist";
            this.dt_productlist.ReadOnly = true;
            this.dt_productlist.Size = new System.Drawing.Size(932, 365);
            this.dt_productlist.TabIndex = 0;
            this.dt_productlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(btn_refresh);
            this.tabPage2.Controls.Add(this.tabControlCashierReport);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1535, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Shift Out";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControlCashierReport
            // 
            this.tabControlCashierReport.Controls.Add(this.tabPage3);
            this.tabControlCashierReport.Controls.Add(this.tabPage4);
            this.tabControlCashierReport.Controls.Add(this.tabPage5);
            this.tabControlCashierReport.Location = new System.Drawing.Point(250, 15);
            this.tabControlCashierReport.Name = "tabControlCashierReport";
            this.tabControlCashierReport.SelectedIndex = 0;
            this.tabControlCashierReport.Size = new System.Drawing.Size(1279, 634);
            this.tabControlCashierReport.TabIndex = 1;
            this.tabControlCashierReport.SelectedIndexChanged += new System.EventHandler(this.tabControlCashierReport_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1271, 601);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.78378F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.21622F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1262, 592);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.52F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.48F));
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox3, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.btn_shiftOut, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.lbl_shiftInAmount, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_shiftTotalSales, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_shiftVoidSales, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lbl_isBalance, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbl_disbalance, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.lbl_cashOnHand, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(625, 341);
            this.tableLayoutPanel5.TabIndex = 0;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Shift In Amount :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_Jave2021.Properties.Resources.loading2;
            this.pictureBox3.Location = new System.Drawing.Point(225, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(3, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Total Sales :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(3, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Sales Void :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(3, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Is Balance:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(3, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Disbalance Amount:";
            // 
            // btn_shiftOut
            // 
            this.btn_shiftOut.Location = new System.Drawing.Point(3, 212);
            this.btn_shiftOut.Name = "btn_shiftOut";
            this.btn_shiftOut.Size = new System.Drawing.Size(214, 39);
            this.btn_shiftOut.TabIndex = 9;
            this.btn_shiftOut.Text = "Shift Out";
            this.btn_shiftOut.UseVisualStyleBackColor = true;
            this.btn_shiftOut.Click += new System.EventHandler(this.btn_shiftOut_Click);
            // 
            // lbl_shiftInAmount
            // 
            this.lbl_shiftInAmount.AutoSize = true;
            this.lbl_shiftInAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiftInAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_shiftInAmount.Location = new System.Drawing.Point(225, 0);
            this.lbl_shiftInAmount.Name = "lbl_shiftInAmount";
            this.lbl_shiftInAmount.Size = new System.Drawing.Size(18, 20);
            this.lbl_shiftInAmount.TabIndex = 11;
            this.lbl_shiftInAmount.Text = "0";
            // 
            // lbl_shiftTotalSales
            // 
            this.lbl_shiftTotalSales.AutoSize = true;
            this.lbl_shiftTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiftTotalSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_shiftTotalSales.Location = new System.Drawing.Point(225, 38);
            this.lbl_shiftTotalSales.Name = "lbl_shiftTotalSales";
            this.lbl_shiftTotalSales.Size = new System.Drawing.Size(18, 20);
            this.lbl_shiftTotalSales.TabIndex = 12;
            this.lbl_shiftTotalSales.Text = "0";
            // 
            // lbl_shiftVoidSales
            // 
            this.lbl_shiftVoidSales.AutoSize = true;
            this.lbl_shiftVoidSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shiftVoidSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_shiftVoidSales.Location = new System.Drawing.Point(225, 74);
            this.lbl_shiftVoidSales.Name = "lbl_shiftVoidSales";
            this.lbl_shiftVoidSales.Size = new System.Drawing.Size(18, 20);
            this.lbl_shiftVoidSales.TabIndex = 13;
            this.lbl_shiftVoidSales.Text = "0";
            // 
            // lbl_isBalance
            // 
            this.lbl_isBalance.AutoSize = true;
            this.lbl_isBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_isBalance.Location = new System.Drawing.Point(225, 106);
            this.lbl_isBalance.Name = "lbl_isBalance";
            this.lbl_isBalance.Size = new System.Drawing.Size(18, 20);
            this.lbl_isBalance.TabIndex = 14;
            this.lbl_isBalance.Text = "0";
            // 
            // lbl_disbalance
            // 
            this.lbl_disbalance.AutoSize = true;
            this.lbl_disbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disbalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_disbalance.Location = new System.Drawing.Point(225, 140);
            this.lbl_disbalance.Name = "lbl_disbalance";
            this.lbl_disbalance.Size = new System.Drawing.Size(18, 20);
            this.lbl_disbalance.TabIndex = 15;
            this.lbl_disbalance.Text = "0";
            // 
            // lbl_cashOnHand
            // 
            this.lbl_cashOnHand.AutoSize = true;
            this.lbl_cashOnHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cashOnHand.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cashOnHand.Location = new System.Drawing.Point(225, 177);
            this.lbl_cashOnHand.Name = "lbl_cashOnHand";
            this.lbl_cashOnHand.Size = new System.Drawing.Size(18, 20);
            this.lbl_cashOnHand.TabIndex = 16;
            this.lbl_cashOnHand.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(3, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Cash On Hand :";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1271, 601);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Sales Report";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1271, 601);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Void Reports";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 634);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_userid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_username, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_userfullname, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_usertype, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.56097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.43903F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "User Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(3, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "User Fullname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "User Type :";
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_userid.Location = new System.Drawing.Point(3, 32);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(28, 20);
            this.lbl_userid.TabIndex = 7;
            this.lbl_userid.Text = "ID";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_username.Location = new System.Drawing.Point(3, 104);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(98, 20);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_userfullname
            // 
            this.lbl_userfullname.AutoSize = true;
            this.lbl_userfullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_userfullname.Location = new System.Drawing.Point(3, 180);
            this.lbl_userfullname.Name = "lbl_userfullname";
            this.lbl_userfullname.Size = new System.Drawing.Size(125, 20);
            this.lbl_userfullname.TabIndex = 9;
            this.lbl_userfullname.Text = "User Fullname";
            // 
            // lbl_usertype
            // 
            this.lbl_usertype.AutoSize = true;
            this.lbl_usertype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_usertype.Location = new System.Drawing.Point(3, 259);
            this.lbl_usertype.Name = "lbl_usertype";
            this.lbl_usertype.Size = new System.Drawing.Size(90, 20);
            this.lbl_usertype.TabIndex = 10;
            this.lbl_usertype.Text = "User Type";
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1556, 704);
            this.Controls.Add(this.CashierTab);
            this.KeyPreview = true;
            this.Name = "CashierHome";
            this.Text = "Cashier DashBoard";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashierHome_KeyDown);
            this.CashierTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlp_Controls.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_orderlist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productlist)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControlCashierReport.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CashierTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dt_productlist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dt_orderlist;
        private System.Windows.Forms.TextBox txtPosScreenSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCashChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCashLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tlp_Controls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotalPriceOrder;
        private System.Windows.Forms.Button btn_EnterCash;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_ready;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.RichTextBox rtb_logs;
        private System.Windows.Forms.Label lbl_ordersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_void;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_userfullname;
        private System.Windows.Forms.Label lbl_usertype;
        private System.Windows.Forms.TabControl tabControlCashierReport;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_shiftOut;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_shiftInAmount;
        private System.Windows.Forms.Label lbl_shiftTotalSales;
        private System.Windows.Forms.Label lbl_shiftVoidSales;
        private System.Windows.Forms.Label lbl_isBalance;
        private System.Windows.Forms.Label lbl_disbalance;
        private System.Windows.Forms.Label lbl_cashOnHand;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}