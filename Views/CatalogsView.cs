using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_06.Views
{
    public partial class CatalogsView : Form
    {
        public CatalogsView()
        {
            InitializeComponent();
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.invoiceManagmentDataSet.Product);
            
        }
    }
}
