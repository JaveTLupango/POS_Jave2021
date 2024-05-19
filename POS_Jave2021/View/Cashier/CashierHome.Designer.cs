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
            this.txtPosSearch = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 134);
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
            this.lblCashChange.Location = new System.Drawing.Point(147, 87);
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
            this.label4.Location = new System.Drawing.Point(3, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CHANGE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CASH ";
            // 
            // lblCashLabel
            // 
            this.lblCashLabel.AutoSize = true;
            this.lblCashLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lblCashLabel.Location = new System.Drawing.Point(147, 41);
            this.lblCashLabel.Name = "lblCashLabel";
            this.lblCashLabel.Size = new System.Drawing.Size(19, 20);
            this.lblCashLabel.TabIndex = 5;
            this.lblCashLabel.Text = "0";
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.Location = new System.Drawing.Point(653, 143);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(644, 134);
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
            // rtb_logs
            // 
            this.rtb_logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_logs.Enabled = false;
            this.rtb_logs.Location = new System.Drawing.Point(3, 143);
            this.rtb_logs.Name = "rtb_logs";
            this.rtb_logs.Size = new System.Drawing.Size(644, 74);
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
            this.tabPage2.Controls.Add(this.txtPosSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1535, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POS Seach";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPosSearch
            // 
            this.txtPosSearch.Location = new System.Drawing.Point(293, 6);
            this.txtPosSearch.Name = "txtPosSearch";
            this.txtPosSearch.Size = new System.Drawing.Size(207, 26);
            this.txtPosSearch.TabIndex = 3;
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
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPosSearch;
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
    }
}