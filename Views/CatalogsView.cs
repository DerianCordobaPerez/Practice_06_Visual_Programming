using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_06.Utils;

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
            this.FillDataSet();
        }

        private void CatalogsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.HasChangesDataSet();
        }
    }
}
