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
    public partial class ManageAgents : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30";

        public ManageAgents()
        {
            InitializeComponent();
        }


        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void displayAgent()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM AgentTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                AgentsDGV.DataSource = ds.Tables[0];
            }
        }
        private void Reset()
        {
            txtAgentName.Text = "";
            txtAgentPhone.Text = "";
            txtAgentAddress.Text = "";
            txtAgentPassword.Text = "";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAgentName.Text == "" || txtAgentPassword.Text == "" || txtAgentPhone.Text == "" || txtAgentAddress.Text == "")
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO AgentTbl(AName, APass, APhone, AAddress) VALUES (@AName, @APassword, @APhone, @Aaddress)", con);
                        cmd.Parameters.AddWithValue("@AName", txtAgentName.Text);
                        cmd.Parameters.AddWithValue("@APassword", txtAgentPassword.Text);
                        cmd.Parameters.AddWithValue("@APhone", txtAgentPhone.Text);
                        cmd.Parameters.AddWithValue("@Aaddress", txtAgentAddress.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agent Added!");
                        Reset();
                        displayAgent();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select The Agent");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId=@AcKey", con);
                        cmd.Parameters.AddWithValue("@AcKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agent Deleted!");
                        con.Close();
                        Reset();
                        displayAgent();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }
        int Key = 0;
        private void AgentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AgentsDGV.SelectedRows.Count > 0)
            {
                Key = Convert.ToInt32(AgentsDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtAgentName.Text = AgentsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAgentPassword.Text = AgentsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAgentPhone.Text = AgentsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtAgentAddress.Text = AgentsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAgentName.Text) || string.IsNullOrEmpty(txtAgentPassword.Text) || string.IsNullOrEmpty(txtAgentPhone.Text) || string.IsNullOrEmpty(txtAgentAddress.Text))
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update AgentTbl set AName=@AName, APass=@APass, APhone=@APhone, AAddress=@AAddress where AId=@AcKey", con);
                        cmd.Parameters.AddWithValue("@AName", txtAgentName.Text);
                        cmd.Parameters.AddWithValue("@APass", txtAgentPassword.Text);
                        cmd.Parameters.AddWithValue("@APhone", txtAgentPhone.Text);
                        cmd.Parameters.AddWithValue("@AAddress", txtAgentAddress.Text);
                        cmd.Parameters.AddWithValue("@AcKey", Key);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Agent Update!");
                        Reset();
                        displayAgent();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }
    }
}
