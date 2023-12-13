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
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

namespace BankManagement
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
            DisplayAccount();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DisplayAccount()
        {
            con.Open();
            string query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Reset()
        {
            txtAccName.Text = "";
            txtAccPhone.Text = "";
            txtAddress.Text = "";
            cboGender.SelectedIndex = -1;
            txtOccupation.Text = "";
            cboEducation.SelectedIndex = -1;
            txtIncome.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccName.Text) || string.IsNullOrEmpty(txtAccPhone.Text) || string.IsNullOrEmpty(txtAddress.Text) || cboGender.SelectedIndex == -1 || string.IsNullOrEmpty(txtOccupation.Text) || cboEducation.SelectedIndex == -1 || string.IsNullOrEmpty(txtIncome.Text))
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(ACName, ACPhone, ACAddress, ACGen, ACOccup, ACEduc, ACInc, ACBal) values(@ACName, @ACPhone, @ACAddress, @ACGen, @ACOccup, @ACEduc, @ACInc, @ACBal)", con);
                    cmd.Parameters.AddWithValue("@ACName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@ACPhone", txtAccPhone.Text);
                    cmd.Parameters.AddWithValue("@ACAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@ACGen", cboGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACOccup", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@ACEduc", cboEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACInc", txtIncome.Text);
                    cmd.Parameters.AddWithValue("@ACBal", 0); // Assuming you want to set the account balance to 0 by default
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Added!");
                    con.Close();
                    Reset();
                    DisplayAccount();
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
                    MessageBox.Show("Select The Account");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where ACNum=@ACNum", con);
                    cmd.Parameters.AddWithValue("@ACNum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted!");
                    con.Close();
                    Reset();
                    DisplayAccount();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }
        int Key = 0;
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccName.Text) || string.IsNullOrEmpty(txtAccPhone.Text) || string.IsNullOrEmpty(txtAddress.Text) || cboGender.SelectedIndex == -1 || string.IsNullOrEmpty(txtOccupation.Text) || cboEducation.SelectedIndex == -1 || string.IsNullOrEmpty(txtIncome.Text))
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set (ACName=@ACName, ACPhone=@ACPhone, ACAddress=@ACAddress, ACGen=@ACGen, ACOccup=@ACOccup, ACEduc=@ACEduc, ACInc=@ACInc, ACBal=@ACBal  where ACNUm=@AcKey", con);
                    cmd.Parameters.AddWithValue("@ACName", txtAccName.Text);
                    cmd.Parameters.AddWithValue("@ACPhone", txtAccPhone.Text);
                    cmd.Parameters.AddWithValue("@ACAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@ACGen", cboGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACOccup", txtOccupation.Text);
                    cmd.Parameters.AddWithValue("@ACEduc", cboEducation.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ACInc", txtIncome.Text);
                    cmd.Parameters.AddWithValue("AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Update!");
                    
                    Reset();
                    DisplayAccount();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("An error occurred: " + Ex.Message);
            }
        }

        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AccountDGV.SelectedRows.Count > 0) // Ensure there is a selected row
            {
                txtAccName.Text = AccountDGV.SelectedRows[0].Cells[1].Value.ToString(); // Assigns the second cell value (name) to the txtAccName text box
                txtAccPhone.Text = AccountDGV.SelectedRows[0].Cells[2].Value.ToString(); // Assigns the third cell value (phone number) to the txtAccPhone text box
                txtAddress.Text = AccountDGV.SelectedRows[0].Cells[3].Value.ToString(); // Assigns the fourth cell value (address) to the txtAddress text box
                cboGender.SelectedItem = AccountDGV.SelectedRows[0].Cells[4].Value.ToString(); // Assigns the fifth cell value (gender) to the cboGender combo box
                txtOccupation.Text = AccountDGV.SelectedRows[0].Cells[5].Value.ToString(); // Assigns the sixth cell value (occupation) to the txtOccupation text box
                cboEducation.SelectedItem = AccountDGV.SelectedRows[0].Cells[6].Value.ToString(); // Assigns the seventh cell value (education) to the cboEducation combo box
                txtIncome.Text = AccountDGV.SelectedRows[0].Cells[7].Value.ToString(); // Assigns the eighth cell value (income) to the txtIncome text box
                Key = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells[0].Value.ToString()); // Assigns the first cell value (account number) to the Key variable
            }
        }
    }
}
