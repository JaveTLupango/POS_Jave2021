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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_orderlist = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dt_productlist = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CashierTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_orderlist)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productlist)).BeginInit();
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
            this.CashierTab.Size = new System.Drawing.Size(1308, 623);
            this.CashierTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1300, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "POS Screen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_orderlist);
            this.groupBox2.Location = new System.Drawing.Point(852, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order List";
            // 
            // dt_orderlist
            // 
            this.dt_orderlist.AllowUserToOrderColumns = true;
            this.dt_orderlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_orderlist.Location = new System.Drawing.Point(0, 25);
            this.dt_orderlist.Name = "dt_orderlist";
            this.dt_orderlist.Size = new System.Drawing.Size(425, 522);
            this.dt_orderlist.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dt_productlist);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Inventory List";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(606, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 2;
            // 
            // dt_productlist
            // 
            this.dt_productlist.AllowUserToOrderColumns = true;
            this.dt_productlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_productlist.Location = new System.Drawing.Point(6, 25);
            this.dt_productlist.Name = "dt_productlist";
            this.dt_productlist.Size = new System.Drawing.Size(807, 314);
            this.dt_productlist.TabIndex = 0;
            this.dt_productlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1300, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POS Seach";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 625);
            this.Controls.Add(this.CashierTab);
            this.Name = "CashierHome";
            this.Text = "Cashier DashBoard";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            this.CashierTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_orderlist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_productlist)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}