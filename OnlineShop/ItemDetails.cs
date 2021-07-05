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
    public partial class ItemDetails : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;
        public ItemDetails(string name, string price, string id, Image picture )
        {
            InitializeComponent();
            _id.Text = id;
            _name.Text = name;
            _price.Text = price;
            _prodimage.Image = picture;
            con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=;database=onlineshopdb";



        }

        private void _close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _quantity_TextChanged(object sender, EventArgs e)
        {
            double pricevalue, totalvalue;
            int quantityvalue;
            totalvalue = 0;
            
                double.TryParse(_price.Text, out pricevalue);
                int.TryParse(_quantity.Text, out quantityvalue);


                totalvalue = pricevalue * quantityvalue;

                _totalprice.Text = totalvalue.ToString() + " Php";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ItemDetails_Load(object sender, EventArgs e)
        {

        }
        String Color;
        String _Size;
        private void saveorderdate()
        {

            con.Open();
            cmd = new MySqlCommand(@"Insert into oderdetails(productID,picture,productname,
                    productPrice, productquantity,totalprice,size,color) values(@productID,@picture,@productname,
                    @productPrice, @productquantity,@totalprice,@size,@color)", con);
            cmd.Parameters.AddWithValue("@productID", _id.Text);
            cmd.Parameters.AddWithValue("@picture", _prodimage.Image);
            cmd.Parameters.AddWithValue("productname", _name.Text);
            cmd.Parameters.AddWithValue("@productPrice", double.Parse(_price.Text).ToString());
            cmd.Parameters.AddWithValue("@productquantity",_quantity.Text);
            cmd.Parameters.AddWithValue("@totalprice", _totalprice.Text);
            cmd.Parameters.AddWithValue("@size", _Size);
            cmd.Parameters.AddWithValue("@color", Color);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added to cart", "ADDED", MessageBoxButtons.OK);
            con.Close();

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           Color = "Maroon";
        }

        private void _black_CheckedChanged(object sender, EventArgs e)
        {
            Color = "Black";
        }

        private void _brown_CheckedChanged(object sender, EventArgs e)
        {
           Color = "brown";
        }

        private void _blue_CheckedChanged(object sender, EventArgs e)
        {
           Color = "Blue";
        }

        private void _voilet_CheckedChanged(object sender, EventArgs e)
        {
            Color = "Voilet";
        }

        private void _extralarge_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "Extra Large";
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "Medium";
        }

        private void _large_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "Large";
        }

        private void _extrasmall_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "Extra small";
        }

        private void _small_CheckedChanged(object sender, EventArgs e)
        {
            _Size = "small";
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if(_quantity.Text == string.Empty)
            {
                MessageBox.Show("Enter Quantity", "Ops!", MessageBoxButtons.OK);
            }
            else
            {
                saveorderdate();
            }
        }
    }
}
