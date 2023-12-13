using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30";
        private void btnSubmitANP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAdminNewPassword.Text == "")
                {
                    MessageBox.Show("Please Entert New Password!");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPass=@AP where AdId=@AKey", con);
                        cmd.Parameters.AddWithValue("@AP", txtAdminNewPassword.Text);
                        cmd.Parameters.AddWithValue("@AKey", 1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Update!");
                        con.Close();
                        txtAdminNewPassword.Text = "";

                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAdminNewPassword.Text = "";
            cboTheme.SelectedIndex = -1;
        }

        private void btnSubmitTheme_Click(object sender, EventArgs e)
        {
            if(cboTheme.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a theme!");
            }else if (cboTheme.SelectedIndex == 0)
            {
                flowLayoutPanel1.BackColor = Color.Gold;
            }else if (cboTheme.SelectedIndex == 1)
            {
                flowLayoutPanel1.BackColor = Color.LightGreen;
            }else
            {
                flowLayoutPanel1.BackColor = Color.LightBlue;
            }
        }
    }
}
