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
    public partial class login : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;
        public login()
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=;database=onlineshopdb";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        private void Logindata()
        {
            if (_email.Text != string.Empty || _password.Text != string.Empty)
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM registration WHERE Email='"+_email.Text+"'AND _Password='"+_password.Text+"'",con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Category category = new Category();
                    category.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logindata();
        }

        private void _signup_Click(object sender, EventArgs e)
        {
            
            Registrationform reg = new Registrationform();
            this.Hide();
            reg.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _showpss_CheckedChanged(object sender, EventArgs e)
        {
            _password.PasswordChar = _showpss.Checked ? '\0' : '*';
        }
    }
}
