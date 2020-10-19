using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xpredio_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ListProduct();
            ListCategory();
            

        }
        public void ListProduct()
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                dgwListele.DataSource = context.Products.ToList();
            }
        }
        public void ListProductByString(string key)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                dgwListele.DataSource = context.Products.Where(p=>p.ProductName.Contains(key)).ToList();
            }
        }
        public void ListProductByCategory(int categoryId)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                dgwListele.DataSource = context.Products.Where(p=>p.CategoryId==categoryId).ToList();
            }
        }
        public void ListCategory()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cmb_Kategori.DataSource = context.Categories.ToList();
                cmb_Kategori.DisplayMember = "CategoryName";
                cmb_Kategori.ValueMember = "CategoryId";

            }
        }
        

        private void cmb_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductByCategory(Convert.ToInt32(cmb_Kategori.SelectedValue));
            }
            catch (Exception exception)
            {

              
            }
        

        }

        private void txt_isim_TextChanged(object sender, EventArgs e)
        {
            if (txt_isim.Text=="")
            {
                ListProduct();
            }
            else if (txt_isim.Text!="")
            {
               ListProductByString(txt_isim.Text);
            }
       
            
        }
    }
}
