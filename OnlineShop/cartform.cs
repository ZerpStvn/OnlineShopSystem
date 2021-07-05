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
    public partial class cartform : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;
        public cartform()
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=;database=onlineshopdb";
        }

        private void cartform_Load(object sender, EventArgs e)
        {
            pulldata();
        }
        private void pulldata()
        {
            con.Open();
            cmd = new MySqlCommand(@"Select productID,productname,
                    productPrice, productquantity,color,size,totalprice from  oderdetails", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                _addcartgrid.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),
                    dr.GetString(4), dr.GetString(5), dr.GetString(6) + " Php");
            }
            con.Close();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
