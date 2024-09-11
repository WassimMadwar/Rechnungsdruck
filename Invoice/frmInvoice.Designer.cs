namespace Invoice
{
    partial class frmInvoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_Datum = new System.Windows.Forms.TextBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Customer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_InvoiceNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_Product = new System.Windows.Forms.ComboBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_PrintPdf = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Invoice.Properties.Resources.Cellbox_logo;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Exit.Location = new System.Drawing.Point(0, 427);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(800, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_Datum
            // 
            this.txt_Datum.ForeColor = System.Drawing.Color.Red;
            this.txt_Datum.Location = new System.Drawing.Point(489, 38);
            this.txt_Datum.Name = "txt_Datum";
            this.txt_Datum.Size = new System.Drawing.Size(151, 20);
            this.txt_Datum.TabIndex = 13;
            this.txt_Datum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_Datum, "Tow Event to be Read and Copy only");
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.itemPrice,
            this.Quantity,
            this.Subtotal});
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV.Location = new System.Drawing.Point(0, 262);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(800, 165);
            this.dataGV.TabIndex = 22;
            this.toolTip1.SetToolTip(this.dataGV, "جدا مهم للحفاظ على القيمة القديمة و تحديد نوع المدخلات كارقام");
            this.dataGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGV_CellBeginEdit);
            this.dataGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellEndEdit);
            // 
            // Product
            // 
            this.Product.FillWeight = 200F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 300;
            // 
            // itemPrice
            // 
            this.itemPrice.FillWeight = 10.08369F;
            this.itemPrice.HeaderText = "Item Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 10.28947F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 50;
            // 
            // Subtotal
            // 
            this.Subtotal.FillWeight = 10.08369F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 150;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(789, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // txt_Customer
            // 
            this.txt_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Customer.Location = new System.Drawing.Point(386, 118);
            this.txt_Customer.Name = "txt_Customer";
            this.txt_Customer.Size = new System.Drawing.Size(254, 22);
            this.txt_Customer.TabIndex = 15;
            this.txt_Customer.Text = "Name";
            this.txt_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Customer_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(669, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(669, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Invoice Datum";
            // 
            // txt_InvoiceNr
            // 
            this.txt_InvoiceNr.Location = new System.Drawing.Point(489, 78);
            this.txt_InvoiceNr.Name = "txt_InvoiceNr";
            this.txt_InvoiceNr.Size = new System.Drawing.Size(151, 20);
            this.txt_InvoiceNr.TabIndex = 11;
            this.txt_InvoiceNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_InvoiceNr.TextChanged += new System.EventHandler(this.txt_InvoiceNr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(669, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Invoice Number";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(519, 203);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.ReadOnly = true;
            this.txt_Price.Size = new System.Drawing.Size(121, 22);
            this.txt_Price.TabIndex = 17;
            this.txt_Price.Text = "0";
            this.txt_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(669, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(669, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Product";
            // 
            // cb_Product
            // 
            this.cb_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Product.FormattingEnabled = true;
            this.cb_Product.Items.AddRange(new object[] {
            "Select Please",
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5"});
            this.cb_Product.Location = new System.Drawing.Point(519, 171);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(121, 21);
            this.cb_Product.TabIndex = 19;
            this.cb_Product.SelectedIndexChanged += new System.EventHandler(this.cb_Product_SelectedIndexChanged);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(257, 203);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(121, 22);
            this.txt_Quantity.TabIndex = 21;
            this.txt_Quantity.Text = "0";
            this.txt_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quantity_KeyDown);
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(407, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Quantity";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subtotal.Location = new System.Drawing.Point(6, 109);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(121, 22);
            this.txt_Subtotal.TabIndex = 24;
            this.txt_Subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(156, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Subtotal";
            // 
            // btn_Add
            // 
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_Add.Location = new System.Drawing.Point(377, 232);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_PrintPdf
            // 
            this.btn_PrintPdf.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btn_PrintPdf.Location = new System.Drawing.Point(271, 232);
            this.btn_PrintPdf.Name = "btn_PrintPdf";
            this.btn_PrintPdf.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintPdf.TabIndex = 26;
            this.btn_PrintPdf.Text = "PrintPdf";
            this.btn_PrintPdf.UseVisualStyleBackColor = true;
            this.btn_PrintPdf.Click += new System.EventHandler(this.btn_PrintPdf_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(6, 233);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(121, 22);
            this.txt_Total.TabIndex = 28;
            this.txt_Total.Text = "0";
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(156, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Total";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDoc1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDoc1
            // 
            this.printDoc1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc1_PrintPage);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_PrintPdf);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Datum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_InvoiceNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Datum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_InvoiceNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_Product;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_PrintPdf;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDoc1;
    }
}

