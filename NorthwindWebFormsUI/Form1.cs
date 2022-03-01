using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete;
using NorthwindDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindWebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        IProductService _productService;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgwProduct.DataSource = _productService.GetAll();
        }

        
    }
}
