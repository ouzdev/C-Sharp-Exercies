using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xpredio.BusinessLayer.Abstract;
using Xpredio.BusinessLayer.Concrete;
using Xpredio.DataAccessLayer.Concrete.NHibernate;

namespace Xpredio.DesktopUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService=new ProductManager(new EfProductDal());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetAll();
        }
    }
}
