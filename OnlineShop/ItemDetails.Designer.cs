
namespace OnlineShop
{
    partial class ItemDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._name = new System.Windows.Forms.TextBox();
            this._price = new System.Windows.Forms.TextBox();
            this._id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._close = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this._quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._totalprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._prodimage = new System.Windows.Forms.PictureBox();
            this._black = new System.Windows.Forms.RadioButton();
            this._voilet = new System.Windows.Forms.RadioButton();
            this._blue = new System.Windows.Forms.RadioButton();
            this._brown = new System.Windows.Forms.RadioButton();
            this._maroon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this._extrasmall = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this._large = new System.Windows.Forms.RadioButton();
            this._extralarge = new System.Windows.Forms.RadioButton();
            this._small = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._prodimage)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _name
            // 
            this._name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._name.Location = new System.Drawing.Point(330, 83);
            this._name.Name = "_name";
            this._name.ReadOnly = true;
            this._name.Size = new System.Drawing.Size(193, 20);
            this._name.TabIndex = 0;
            // 
            // _price
            // 
            this._price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._price.Location = new System.Drawing.Point(330, 140);
            this._price.Name = "_price";
            this._price.ReadOnly = true;
            this._price.Size = new System.Drawing.Size(193, 20);
            this._price.TabIndex = 1;
            // 
            // _id
            // 
            this._id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._id.Location = new System.Drawing.Point(330, 32);
            this._id.Name = "_id";
            this._id.ReadOnly = true;
            this._id.Size = new System.Drawing.Size(193, 20);
            this._id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product price";
            // 
            // _close
            // 
            this._close.AutoSize = true;
            this._close.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._close.Location = new System.Drawing.Point(826, 1);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(18, 19);
            this._close.TabIndex = 6;
            this._close.Text = "X";
            this._close.Click += new System.EventHandler(this._close_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(494, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 29;
            this.button1.Text = "BUY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(364, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 28);
            this.button2.TabIndex = 30;
            this.button2.Text = "ADD TO CART";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(234, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 28);
            this.button3.TabIndex = 31;
            this.button3.Text = "MESSAGE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // _quantity
            // 
            this._quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._quantity.Location = new System.Drawing.Point(330, 193);
            this._quantity.Name = "_quantity";
            this._quantity.Size = new System.Drawing.Size(68, 20);
            this._quantity.TabIndex = 32;
            this._quantity.TextChanged += new System.EventHandler(this._quantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantity";
            // 
            // _totalprice
            // 
            this._totalprice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._totalprice.Location = new System.Drawing.Point(404, 193);
            this._totalprice.Name = "_totalprice";
            this._totalprice.ReadOnly = true;
            this._totalprice.Size = new System.Drawing.Size(119, 20);
            this._totalprice.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total Price";
            // 
            // _prodimage
            // 
            this._prodimage.Location = new System.Drawing.Point(12, 12);
            this._prodimage.Name = "_prodimage";
            this._prodimage.Size = new System.Drawing.Size(288, 270);
            this._prodimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._prodimage.TabIndex = 36;
            this._prodimage.TabStop = false;
            this._prodimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _black
            // 
            this._black.AutoSize = true;
            this._black.Location = new System.Drawing.Point(593, 71);
            this._black.Name = "_black";
            this._black.Size = new System.Drawing.Size(14, 13);
            this._black.TabIndex = 37;
            this._black.TabStop = true;
            this._black.UseVisualStyleBackColor = true;
            this._black.CheckedChanged += new System.EventHandler(this._black_CheckedChanged);
            // 
            // _voilet
            // 
            this._voilet.AutoSize = true;
            this._voilet.Location = new System.Drawing.Point(761, 71);
            this._voilet.Name = "_voilet";
            this._voilet.Size = new System.Drawing.Size(14, 13);
            this._voilet.TabIndex = 38;
            this._voilet.TabStop = true;
            this._voilet.UseVisualStyleBackColor = true;
            this._voilet.CheckedChanged += new System.EventHandler(this._voilet_CheckedChanged);
            // 
            // _blue
            // 
            this._blue.AutoSize = true;
            this._blue.Location = new System.Drawing.Point(720, 71);
            this._blue.Name = "_blue";
            this._blue.Size = new System.Drawing.Size(14, 13);
            this._blue.TabIndex = 39;
            this._blue.TabStop = true;
            this._blue.UseVisualStyleBackColor = true;
            this._blue.CheckedChanged += new System.EventHandler(this._blue_CheckedChanged);
            // 
            // _brown
            // 
            this._brown.AutoSize = true;
            this._brown.Location = new System.Drawing.Point(678, 71);
            this._brown.Name = "_brown";
            this._brown.Size = new System.Drawing.Size(14, 13);
            this._brown.TabIndex = 40;
            this._brown.TabStop = true;
            this._brown.UseVisualStyleBackColor = true;
            this._brown.CheckedChanged += new System.EventHandler(this._brown_CheckedChanged);
            // 
            // _maroon
            // 
            this._maroon.AutoSize = true;
            this._maroon.Location = new System.Drawing.Point(636, 71);
            this._maroon.Name = "_maroon";
            this._maroon.Size = new System.Drawing.Size(14, 13);
            this._maroon.TabIndex = 41;
            this._maroon.TabStop = true;
            this._maroon.UseVisualStyleBackColor = true;
            this._maroon.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(584, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 32);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(626, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 32);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(669, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 32);
            this.panel3.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(709, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 32);
            this.panel4.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Location = new System.Drawing.Point(749, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(34, 32);
            this.panel5.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(586, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 47;
            this.label6.Text = "Color";
            // 
            // _extrasmall
            // 
            this._extrasmall.AutoSize = true;
            this._extrasmall.Location = new System.Drawing.Point(47, 40);
            this._extrasmall.Name = "_extrasmall";
            this._extrasmall.Size = new System.Drawing.Size(14, 13);
            this._extrasmall.TabIndex = 52;
            this._extrasmall.TabStop = true;
            this._extrasmall.UseVisualStyleBackColor = true;
            this._extrasmall.CheckedChanged += new System.EventHandler(this._extrasmall_CheckedChanged);
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(89, 40);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(14, 13);
            this.Medium.TabIndex = 51;
            this.Medium.TabStop = true;
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // _large
            // 
            this._large.AutoSize = true;
            this._large.Location = new System.Drawing.Point(131, 40);
            this._large.Name = "_large";
            this._large.Size = new System.Drawing.Size(14, 13);
            this._large.TabIndex = 50;
            this._large.TabStop = true;
            this._large.UseVisualStyleBackColor = true;
            this._large.CheckedChanged += new System.EventHandler(this._large_CheckedChanged);
            // 
            // _extralarge
            // 
            this._extralarge.AutoSize = true;
            this._extralarge.Location = new System.Drawing.Point(172, 40);
            this._extralarge.Name = "_extralarge";
            this._extralarge.Size = new System.Drawing.Size(14, 13);
            this._extralarge.TabIndex = 49;
            this._extralarge.TabStop = true;
            this._extralarge.UseVisualStyleBackColor = true;
            this._extralarge.CheckedChanged += new System.EventHandler(this._extralarge_CheckedChanged);
            // 
            // _small
            // 
            this._small.AutoSize = true;
            this._small.Location = new System.Drawing.Point(4, 40);
            this._small.Name = "_small";
            this._small.Size = new System.Drawing.Size(14, 13);
            this._small.TabIndex = 48;
            this._small.TabStop = true;
            this._small.UseVisualStyleBackColor = true;
            this._small.CheckedChanged += new System.EventHandler(this._small_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this._small);
            this.panel6.Controls.Add(this._extrasmall);
            this.panel6.Controls.Add(this._extralarge);
            this.panel6.Controls.Add(this.Medium);
            this.panel6.Controls.Add(this._large);
            this.panel6.Location = new System.Drawing.Point(584, 155);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 127);
            this.panel6.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 54;
            this.label7.Text = "Size";
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(847, 520);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._maroon);
            this.Controls.Add(this._brown);
            this.Controls.Add(this._blue);
            this.Controls.Add(this._voilet);
            this.Controls.Add(this._black);
            this.Controls.Add(this._prodimage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._totalprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._quantity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._id);
            this.Controls.Add(this._price);
            this.Controls.Add(this._name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemDetails";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this._prodimage)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _price;
        private System.Windows.Forms.TextBox _id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label _close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _totalprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _quantity;
        private System.Windows.Forms.PictureBox _prodimage;
        private System.Windows.Forms.RadioButton _black;
        private System.Windows.Forms.RadioButton _voilet;
        private System.Windows.Forms.RadioButton _blue;
        private System.Windows.Forms.RadioButton _brown;
        private System.Windows.Forms.RadioButton _maroon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton _extrasmall;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton _large;
        private System.Windows.Forms.RadioButton _extralarge;
        private System.Windows.Forms.RadioButton _small;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
    }
}