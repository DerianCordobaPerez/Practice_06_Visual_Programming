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
using Practice_06.Views;

namespace Practice_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowForm(new SignInView(), false);
            this.InitialConfiguration();
        }

        private void ToolStripMenuItemReports_Click(object sender, EventArgs e)
        {
            this.ShowForm(new ReportsView());
        }

        private void ToolStripMenuItemCatalogs_Click(object sender, EventArgs e)
        {
            this.ShowForm(new CatalogsView());
        }
    }
}
