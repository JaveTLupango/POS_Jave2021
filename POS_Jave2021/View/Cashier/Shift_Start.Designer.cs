namespace POS_Jave2021.View.Cashier
{
    partial class Shift_Start
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
            this.txtShiftName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShiftDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShiftAmount = new System.Windows.Forms.TextBox();
            this.btn_ShiftProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShiftName
            // 
            this.txtShiftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftName.HideSelection = false;
            this.txtShiftName.Location = new System.Drawing.Point(240, 44);
            this.txtShiftName.Name = "txtShiftName";
            this.txtShiftName.Size = new System.Drawing.Size(155, 26);
            this.txtShiftName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(7, 44);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(155, 26);
            this.txtUserID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shift Date";
            // 
            // txtShiftDate
            // 
            this.txtShiftDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftDate.HideSelection = false;
            this.txtShiftDate.Location = new System.Drawing.Point(7, 109);
            this.txtShiftDate.Name = "txtShiftDate";
            this.txtShiftDate.Size = new System.Drawing.Size(155, 26);
            this.txtShiftDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shift Start Amount";
            // 
            // txtShiftAmount
            // 
            this.txtShiftAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShiftAmount.Location = new System.Drawing.Point(240, 109);
            this.txtShiftAmount.Name = "txtShiftAmount";
            this.txtShiftAmount.Size = new System.Drawing.Size(155, 26);
            this.txtShiftAmount.TabIndex = 6;
            // 
            // btn_ShiftProceed
            // 
            this.btn_ShiftProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShiftProceed.Location = new System.Drawing.Point(7, 147);
            this.btn_ShiftProceed.Name = "btn_ShiftProceed";
            this.btn_ShiftProceed.Size = new System.Drawing.Size(383, 52);
            this.btn_ShiftProceed.TabIndex = 8;
            this.btn_ShiftProceed.Text = "Proceed";
            this.btn_ShiftProceed.UseVisualStyleBackColor = true;
            this.btn_ShiftProceed.Click += new System.EventHandler(this.btn_ShiftProceed_Click);
            // 
            // Shift_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(402, 207);
            this.Controls.Add(this.btn_ShiftProceed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtShiftAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShiftDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShiftName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Shift_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift_Start";
            this.Load += new System.EventHandler(this.Shift_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtShiftName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShiftDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShiftAmount;
        private System.Windows.Forms.Button btn_ShiftProceed;
    }
}