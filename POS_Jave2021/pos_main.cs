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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string passsword = txt_newpassword.Text.Trim();
                label15.Text = passwordValidator.CheckStrength(passsword).ToString();
            }
            catch (Exception)
            {
                label15.Text = "Invalid Password..";
            }
        }

        private void txt_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_newpassword.Text.Trim() == txt_confirmpassword.Text.Trim())
                {
                    label16.Text = "Password match!";
                }
                else
                {
                    label16.Text = "Password not match!";
                }
            }
            catch (Exception)
            {
                label16.Text = "Password not match!";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "Hide")
            {
                txt_newpassword.UseSystemPasswordChar = true;
                button15.Text = "Show";
            }
            else
            {
                txt_newpassword.UseSystemPasswordChar = false;
                button15.Text = "Hide";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "Hide")
            {
                txt_confirmpassword.UseSystemPasswordChar = true;
                button16.Text = "Show";
            }
            else
            {
                txt_confirmpassword.UseSystemPasswordChar = false;
                button16.Text = "Hide";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string retpass = passwordHash.encryptor(txt_confirmpassword.Text.Trim());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    pictureBox5.Image = new Bitmap(open.FileName);
                    // image file path  
                    label17.Text = open.FileName;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (validator.email(textBox9.Text.Trim()))
            {
                label18.Text = "Email is valid!";
            }
            else
            {
                label18.Text = "Invalid Email!";
            }
        }

        //private void textBox8_Enter(object sender, EventArgs e)
        //{

        //}

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            label23.Text = validator.phonenumber(textBox8.Text.Trim());
        }
    }
}
