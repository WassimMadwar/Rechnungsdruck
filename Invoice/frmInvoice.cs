using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;


/* 
   Es muss geändert werden, wenn das Element wiederholt wird, muss es mit dem alten kombiniert werden
   eine ID-Nummer hinzufügen (InVoiceNuber)
   Bei einer Mengenanpassung auf Null muss der gesamte Artikel gelöscht werden

   */
namespace Invoice
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://cellbox-solutions.com/");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            txt_Datum.Text = DateTime.Now.ToLongDateString();

            Dictionary<int,string> itemData = new Dictionary<int,string>();
            //(Price,Item Name)
            itemData.Add(0, "Select Item");
            itemData.Add(70, "Item1");
            itemData.Add(100, "Item2");
            itemData.Add(150, "Item3");
            itemData.Add(4000, "Item4");
            itemData.Add(80, "Item5");
            cb_Product.DataSource = new BindingSource(itemData,null);
            cb_Product.ValueMember = "key";//1
            cb_Product.DisplayMember = "value";//2
            //txt_Price.Text = cb_Product.SelectedValue.ToString();//

            dataGV.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;


            //txt_Customer.Focus();
            txt_Customer.Select();
        }

        private void txt_Datum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) 
            {
                cb_Product.Focus();

            }
        }

        private void cb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Quantity.Focus();
            txt_Quantity.SelectAll();
            txt_Price.Text = cb_Product.SelectedValue.ToString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string item = cb_Product.Text;

            int qua = Convert.ToInt32(txt_Quantity.Text);
            int price = Convert.ToInt32(txt_Price.Text);

            if (cb_Product.SelectedIndex <= 0 || qua == 0)  
            {
                return;
            }
            int subTotal = qua * price;
            object[] row = {item, price, qua,subTotal};
            dataGV.Rows.Add(row);
            txt_Total.Text = (Convert.ToInt32(txt_Total.Text) + subTotal) + "";//  or i can use .ToString();
            
            cb_Product.Focus();

            txt_Price.Text = cb_Product.SelectedValue.ToString();

        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) 
            {
                btn_Add.PerformClick();
                txt_Quantity.Text = "0";
                cb_Product.Focus();

            }
        }
        string old_qua = "1";
        private void dataGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGV.CurrentRow != null)
            {
                old_qua = dataGV.CurrentRow.Cells["Quantity"].Value.ToString();
            }
        }

        private void dataGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newqua = dataGV.CurrentRow.Cells["Quantity"].Value.ToString();
            if (newqua == old_qua) return; 
            
            if (dataGV.CurrentRow != null) 
            {
            
                if (!Regex.IsMatch(newqua,"^\\d+$")) // Es ist sehr wichtig, den alten Wert beizubehalten und die Art der Eingabe als Zahlen anzugeben !!!!!!!
                {
                    dataGV.CurrentRow.Cells["Quantity"].Value = old_qua;
                }
                else 
                {
                    int p = (int)dataGV.CurrentRow.Cells["itemPrice"].Value;

                    dataGV.CurrentRow.Cells["Subtotal"].Value = Convert.ToInt32(newqua) * p;


               
                }

                int nTotal = 0;
                foreach (DataGridViewRow r in dataGV.Rows)
                {
                    nTotal += Convert.ToInt32(r.Cells["Subtotal"].Value);
                }
                txt_Total.Text = nTotal.ToString();
            }
        }

        private void btn_PrintPdf_Click(object sender, EventArgs e)
        {
            //((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;//!!!!!To delete!!!!!!!!

            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDoc1.Print();
            }
        }

        private void printDoc1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //جدا مهم 
            float mar = 8;
            Font f = new Font("Cairo", 18);

            string NO_str = "#NO" + txt_InvoiceNr.Text;
            string strData = "Datum  : " + txt_Datum.Text;
            string strNam = "Heir / Frau : " + txt_Customer.Text;

            SizeF fontsizeNO = e.Graphics.MeasureString(NO_str, f);
            SizeF fontsizeDa = e.Graphics.MeasureString(strData, f);
            SizeF fontsizeNa = e.Graphics.MeasureString(strNam, f);

            e.Graphics.DrawImage(Properties.Resources.Cellbox_logo, mar, mar, 175, 50);
            e.Graphics.DrawString(NO_str, f, Brushes.Red,(e.PageBounds.Width-fontsizeNO.Width)/2, mar);
            e.Graphics.DrawString(strData, f, Brushes.Black, mar,mar + Properties.Resources.Cellbox_logo.Height);
            e.Graphics.DrawString(strNam, f, Brushes.Black, mar,mar + Properties.Resources.Cellbox_logo.Height+ fontsizeDa.Height);


            //Draw Table
            float preHei = mar + fontsizeNO.Height + fontsizeDa.Height + fontsizeNa.Height + Properties.Resources.Cellbox_logo.Height;
            //dr Continar
            e.Graphics.DrawRectangle(Pens.Black, mar, preHei, e.PageBounds.Width - mar * 2,e.PageBounds.Height-mar-preHei);

            float headerHei = 50;
            float footer = 88;
            float colWid = 400;
            float colWid2 = colWid+120;
            float colWid3 = colWid2+95;
            float colWid4 = colWid3+140;
            //dr Header line
            e.Graphics.DrawLine(Pens.Black, mar, preHei + headerHei, e.PageBounds.Width - mar, preHei + headerHei);


            //dr fist column
            e.Graphics.DrawLine(Pens.Black, mar + colWid, preHei, mar + colWid, e.PageBounds.Height - footer + mar);
            e.Graphics.DrawString("Product ", f, Brushes.Black, (mar), preHei);


            //dr Second column
            e.Graphics.DrawLine(Pens.Black, mar + colWid2, preHei, mar + colWid2, e.PageBounds.Height - footer + mar);
            e.Graphics.DrawString("Price ", f, Brushes.Black, (mar+colWid), preHei);

            
            // dr third column
            e.Graphics.DrawLine(Pens.Black, mar+colWid3, preHei, mar + colWid3, e.PageBounds.Height - mar);
            e.Graphics.DrawString("Amount", f, Brushes.Black, (mar+colWid2), preHei); 
            
            
            //dr Forth column
            e.Graphics.DrawLine(Pens.Black, mar+colWid4, preHei, mar + colWid4, e.PageBounds.Height - mar);
            e.Graphics.DrawString("Sub total", f, Brushes.Black, (mar+colWid3), preHei);


            // dr Footer line invoice total
            e.Graphics.DrawLine(Pens.Black,mar, (mar + e.PageBounds.Height - footer),  e.PageBounds.Width - mar, (mar + e.PageBounds.Height - footer));
            e.Graphics.DrawString(" Invoice Total", f, Brushes.Black, mar, (mar + e.PageBounds.Height - footer));


            // ////////////////////// Invoice Content//////////////////////////
            
            float rowsHei = 40;
            for (int i = 0; i < dataGV.Rows.Count; i++)
            {
                
                e.Graphics.DrawString(dataGV.Rows[i].Cells[0].Value.ToString(), f, Brushes.Black, mar, (mar + headerHei + preHei));
                e.Graphics.DrawString(dataGV.Rows[i].Cells[1].Value.ToString(), f, Brushes.Black, mar + colWid, (mar + headerHei + preHei));
                e.Graphics.DrawString(dataGV.Rows[i].Cells[2].Value.ToString(), f, Brushes.Black, mar + colWid2, (mar + headerHei + preHei));
                e.Graphics.DrawString(dataGV.Rows[i].Cells[3].Value.ToString(), f, Brushes.Black, mar + colWid3, (mar + headerHei + preHei));
                e.Graphics.DrawString("$", f, Brushes.Black, mar + colWid4, (mar + headerHei + preHei));
                
                e.Graphics.DrawLine(Pens.Black, mar, preHei + headerHei+rowsHei, e.PageBounds.Width - mar, preHei + headerHei + rowsHei);
             
                preHei += rowsHei;  

            }
            // dr Total invoice
            e.Graphics.DrawLine(Pens.Black, mar + colWid4, preHei, mar + colWid4, e.PageBounds.Height - mar);
            e.Graphics.DrawString(txt_Total.Text, f, Brushes.Black, (mar + colWid3), (mar + e.PageBounds.Height - footer));
            e.Graphics.DrawString("$", f, Brushes.Black, mar + colWid4, (mar + e.PageBounds.Height - footer));


        }

        private void txt_InvoiceNr_TextChanged(object sender, EventArgs e)
        {
            if (txt_InvoiceNr.Text.Trim()=="")
            {
                MessageBox.Show("Enter Number");
            }
        }

  


    }
}
