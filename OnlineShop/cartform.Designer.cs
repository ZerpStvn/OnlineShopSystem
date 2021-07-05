
namespace OnlineShop
{
    partial class cartform
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
            this._addcartgrid = new System.Windows.Forms.DataGridView();
            this._prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prodtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._addcartgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // _addcartgrid
            // 
            this._addcartgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this._addcartgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._addcartgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._addcartgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._addcartgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._prodid,
            this._prodname,
            this._prodprice,
            this._prodquantity,
            this._prodcolor,
            this._prodsize,
            this._prodtotal});
            this._addcartgrid.Location = new System.Drawing.Point(0, 30);
            this._addcartgrid.Name = "_addcartgrid";
            this._addcartgrid.Size = new System.Drawing.Size(663, 409);
            this._addcartgrid.TabIndex = 0;
            // 
            // _prodid
            // 
            this._prodid.HeaderText = "Product ID";
            this._prodid.Name = "_prodid";
            // 
            // _prodname
            // 
            this._prodname.HeaderText = "Product Name";
            this._prodname.Name = "_prodname";
            // 
            // _prodprice
            // 
            this._prodprice.HeaderText = "Price";
            this._prodprice.Name = "_prodprice";
            // 
            // _prodquantity
            // 
            this._prodquantity.HeaderText = "Quantity";
            this._prodquantity.Name = "_prodquantity";
            // 
            // _prodcolor
            // 
            this._prodcolor.HeaderText = "Color";
            this._prodcolor.Name = "_prodcolor";
            // 
            // _prodsize
            // 
            this._prodsize.HeaderText = "Size";
            this._prodsize.Name = "_prodsize";
            // 
            // _prodtotal
            // 
            this._prodtotal.HeaderText = "Total Price";
            this._prodtotal.Name = "_prodtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(642, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cartform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._addcartgrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cartform";
            this.Text = "cartform";
            this.Load += new System.EventHandler(this.cartform_Load);
            ((System.ComponentModel.ISupportInitialize)(this._addcartgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _addcartgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodname;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prodtotal;
        private System.Windows.Forms.Label label6;
    }
}