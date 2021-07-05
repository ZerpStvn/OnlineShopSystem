using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace OnlineShop
{
    public partial class Category : Form
    {
        MySqlCommand cmd;
        MySqlDataReader dr;
        MySqlConnection con;

        private PictureBox pic;

        //private Label name;
        //private Label price;
        public Category()
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=;database=onlineshopdb";

        }

        private void Category_Load(object sender, EventArgs e)
        {
            categorybase();
        }
        public void categorybase()
        {
            con.Open();
            cmd = new MySqlCommand("SELECT Product_image, Name, brand,id, Price FROM productdetails", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] arr = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, arr, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 154;
                pic.Height = 167;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Tag = dr["id"].ToString();

                //name = new Label();
                //name.Text = dr["Name"].ToString();
                //name.BackColor = Color.Transparent;
                //name.ForeColor = Color.Transparent;
                //name.Dock = DockStyle.Bottom;
                //name.TextAlign = ContentAlignment.BottomLeft;

                //price = new Label();
                //price.Text = dr["Price"].ToString();
                //price.BackColor = Color.Transparent;
                //price.ForeColor = Color.Transparent;
                //price.Dock = DockStyle.Bottom;
                //price.TextAlign = ContentAlignment.BottomLeft;


                MemoryStream ms = new MemoryStream(arr);
                Bitmap bm = new Bitmap(ms);
                pic.BackgroundImage = bm;


                
                _centerpanel1.Controls.Add(pic);

                this.pic.Click += new EventHandler(onclickpic);

            }
            dr.Close();
            con.Close();

        }
        private void onclickpic(object sender, EventArgs e)
        {

            String tag = ((PictureBox)sender).Tag.ToString();
            con.Open();
            cmd = new MySqlCommand("Select * from productdetails where id like '" + tag + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "productdetails");
            int c = ds.Tables["productdetails"].Rows.Count;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (c > 0)
                {
                    Byte[] bytedta = new Byte[0];
                    bytedta = (Byte[])(ds.Tables["productdetails"].Rows[c - 1]["Product_image"]);
                    MemoryStream stmdata = new MemoryStream(bytedta);
                    pic.Width = 154;
                    pic.Height = 167;
                    pictureBox5.Image = Image.FromStream(stmdata);

                }
                ItemDetails itemDetails = new ItemDetails
                (dr["Name"].ToString(),
              double.Parse(dr["Price"].ToString()).ToString(), dr["id"].ToString(), pictureBox5.Image);
                itemDetails.ShowDialog();


            }
            con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activform = null;
        private void centerpanel(Form childform)
        {
            if (activform != null)
                activform.Close();
            activform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel6.Controls.Add(childform);
            panel6.Tag = childform;
            childform.BringToFront();
            childform.Show();         
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            centerpanel(new cartform());
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
