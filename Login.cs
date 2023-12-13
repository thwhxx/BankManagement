using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace BankManagement
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=BankDb.mdfBankDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsename.Text = "";
            txtPassword.Text = "";
            cboLoginRole.SelectedIndex = -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cboLoginRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role!");
            }
            else if (cboLoginRole.SelectedIndex == 0)
            {
                if (txtUsename.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AdminTbl WHERE AdName = @AdName AND AdPass = @AdPass", con);
                            cmd.Parameters.AddWithValue("@AdName", txtUsename.Text);
                            cmd.Parameters.AddWithValue("@AdPass", txtPassword.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                ManageAgents Obj = new ManageAgents();
                                Obj.Show();
                                this.Hide();
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!");
                                txtUsename.Text = "";
                                txtPassword.Text = "";
                            }
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else if (cboLoginRole.SelectedIndex == 1) // Agent Role
            {
                if (txtUsename.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30"))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AgentTbl WHERE AName = @AName AND APass = @APass", con);
                            cmd.Parameters.AddWithValue("@AName", txtUsename.Text);
                            cmd.Parameters.AddWithValue("@APass", txtPassword.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                MainMenu Obj = new MainMenu();
                                Obj.Show();
                                this.Hide();
                                con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password!");
                                txtUsename.Text = "";
                                txtPassword.Text = "";
                            }
                            con.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
