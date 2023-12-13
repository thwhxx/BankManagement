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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\thuhu\source\repos\BankManagement\BankDb.mdf;Integrated Security=True;Connect Timeout=30";
        int Balance;
        private void CheckBalance()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM AccountTbl WHERE ACNum = '" + txtCheckBalance.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    lblBalance.Text = dr["ACBal"].ToString();
                    Balance = Convert.ToInt32(dr["ACBal"].ToString());
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCheckBalance.Text == "")
                {
                    MessageBox.Show("Please enter an account number!");
                }
                else
                {
                    CheckBalance();
                    if (lblBalance.Text == "YourBalance")
                    {
                        MessageBox.Show("Account can not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCheckBalance.Text = "";
            lblBalance.Text = "YourBalance";
        }
        private void Deposit()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransactionsTbl(TName, TDate, TAmount, TACNum) VALUES(@TN, @TD, @TA, @TACNum)", con);
                    cmd.Parameters.AddWithValue("@TN", "Deposit");
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@TA", Convert.ToInt32(txtDepositAmount.Text));
                    cmd.Parameters.AddWithValue("@TACNum", txtDepositAN.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deposit successfully!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void Withdraw()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransactionsTbl(TName, TDate, TAmount, TACNum) VALUES(@TN, @TD, @TA, @TACNum)", con);
                    cmd.Parameters.AddWithValue("@TN", "Withdraw");
                    cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@TA", Convert.ToInt32(txtWithdrawAmount.Text));
                    cmd.Parameters.AddWithValue("@TACNum", txtWithdrawAN.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Withdraw successfully!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void SubtractBal()
        {
            GetNewBalance(txtFrom.Text);
            int NewBalance = Balance - Convert.ToInt32(txtTransferAmount.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNUm=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AB", NewBalance);
                    cmd.Parameters.AddWithValue("@AcKey", txtFrom.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void AddBal()
        {
            GetNewBalance(txtTo.Text);
            int NewBalance = Balance + Convert.ToInt32(txtTransferAmount.Text);
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBal=@AB where ACNum=@AcKey", con);
                    cmd.Parameters.AddWithValue("@AB", NewBalance);
                    cmd.Parameters.AddWithValue("@AcKey", txtTo.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "" || txtFrom.Text == "" || txtTransferAmount.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else
            {
                GetNewBalance(txtFrom.Text); // Assuming GetNewBalance now takes an argument
                if (Convert.ToInt32(txtTransferAmount.Text) > Balance)
                {
                    MessageBox.Show("Insufficient Balance!");
                }
                else
                {
                    Transfer();
                    SubtractBal();
                    AddBal();
                    txtFrom.Text = "";
                    txtTo.Text = "";
                    txtTransferAmount.Text = "";
                }
            }
        }
        private void GetNewBalance(string accountNumber)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM AccountTbl WHERE ACNum = '" + txtCheckBalance.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    // lblBalance.Text = dr["ACBal"].ToString();
                    Balance = Convert.ToInt32(dr["ACBal"].ToString());
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtWithdrawAN.Text) || string.IsNullOrEmpty(txtWithdrawAmount.Text))
                {
                    MessageBox.Show("Missing Information!");
                }
                else
                {
                    Withdraw();
                    GetNewBalance(txtTo.Text);
                    if (Balance < Convert.ToInt32(txtWithdrawAmount.Text))
                    {
                        MessageBox.Show("Insufisiant Balance!");
                    }
                    else
                    {
                        int newBalance = Balance - Convert.ToInt32(txtWithdrawAmount.Text);
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();
                            string query = "UPDATE AccountTbl SET ACBal = @ACBal WHERE ACNum = @AcKey";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@AcKey", txtWithdrawAN.Text);
                            cmd.Parameters.AddWithValue("@ACBal", newBalance);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Withdraw successfully!");
                            CheckBalance();
                            txtWithdrawAmount.Text = "";
                            con.Close();
                            txtWithdrawAmount.Text = "";
                            txtWithdrawAN.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void picAN_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "")
            {
                MessageBox.Show("Please enter source account!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM AccountTbl WHERE ACNum = '" + txtFrom.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        CheckAvailableBal();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account not found!");
                        txtFrom.Text = "";
                    }
                    con.Close();
                }
            }
        }
        private void CheckAvailableBal()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // con.Open();
                string query = "SELECT * FROM AccountTbl WHERE ACNum = '" + txtCheckBalance.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    sda.Fill(dt);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    lblTransfer.Text = dr["ACBal"].ToString();
                    Balance = Convert.ToInt32(dr["ACBal"].ToString());
                }
            }
        }

        private void picTransferAmount_Click(object sender, EventArgs e)
        {
            if (txtTo.Text == "")
            {
                MessageBox.Show("Please enter source account!");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM AccountTbl WHERE ACNum = '" + txtTo.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        con.Close();
                        if (txtFrom.Text == txtTo.Text)
                        {
                            MessageBox.Show("Please enter another account!");
                            txtTo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Account not found!");
                        txtTo.Text = "";
                    }
                    con.Close();
                }
            }
        }

        private void btnTransferCheck_Click(object sender, EventArgs e)
        {
            if(txtTo.Text == "" || txtFrom.Text == "" || txtTransferAmount.Text == "")
            {
                MessageBox.Show("Missing Information!");
            }
            else if(Convert.ToInt16(txtTransferAmount.Text) > Balance)
            {
                MessageBox.Show("Insufisiant Balance!");
            }
            else 
            {
                Transfer();
                SubtractBal();
                AddBal();
                txtFrom.Text = "";
                txtTo.Text = "";
                txtTransferAmount.Text = "";
            }
        }
        private void Transfer()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TransferTbl(TrSrc, TrDest, Tramount, TrDate) VALUES(@TS, @TD, @TA, @TDa)", con);
                    cmd.Parameters.AddWithValue("@TS", txtFrom.Text);
                    cmd.Parameters.AddWithValue("@TD", txtTo.Text);
                    cmd.Parameters.AddWithValue("@TA", txtTransferAmount.Text);
                    cmd.Parameters.AddWithValue("@TDa", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer successfully!");
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        
    }
}

