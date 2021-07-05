using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace OnlineShop
{
    public partial class Registrationform : Form
    {
        MySqlCommand cmd;
        MySqlConnection con;
        public Registrationform()
        {
            
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=;database=onlineshopdb";
        }

        private void signupdata()
        {
            if(_name.Text != string.Empty || _age.Text != string.Empty || _add.Text != string.Empty || _zipcode.Text != string.Empty || _email.Text != string.Empty || _pass.Text != string.Empty || _confpass.Text != string.Empty)
            {
                if(_pass.Text == _confpass.Text)
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO registration (Name,Age,Address,Street_add,City,Zipcode,Email,_Password) VALUES (@Name, @Age, @Address, @Street_add, @City, @Zipcode, @Email, @_Password)", con);
                    cmd.Parameters.AddWithValue("@Name", _name.Text);
                    cmd.Parameters.AddWithValue("@Age", _age.Text);
                    cmd.Parameters.AddWithValue("@Address", _add.Text);
                    cmd.Parameters.AddWithValue("@Street_add", _streetadd.Text);
                    cmd.Parameters.AddWithValue("@City", _city.Text);
                    cmd.Parameters.AddWithValue("@Zipcode", _zipcode.Text);
                    cmd.Parameters.AddWithValue("@Email", _email.Text);
                    cmd.Parameters.AddWithValue("@_Password", _pass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signing up successful!", "Successful",MessageBoxButtons.OK);
                    login lg = new login();
                    this.Hide();
                    lg.ShowDialog();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.RetryCancel);
                }
            }
            else
            {
                MessageBox.Show("Fill all the information needed", "Error", MessageBoxButtons.OKCancel);
            }                
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            signupdata();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _showpss_CheckedChanged(object sender, EventArgs e)
        {
            _pass.PasswordChar = _showpss.Checked ? '\0' : '*';
            _confpass.PasswordChar = _showpss.Checked ? '\0' : '*';
        }
    }
   
}


