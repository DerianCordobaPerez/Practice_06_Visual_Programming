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
    public partial class ReportsView : Form
    {
        public ReportsView()
        {
            InitializeComponent();
        }

        private void ReportsView_Load(object sender, EventArgs e)
        {
            this.ConfigurationComboBoxCodes()
                .ConfigurationDataGridView()
                .ChangeTotalPrice()
                .ChangeCliente();
            
        }

        private void ComboBoxReportsCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ConfigurationDataGridView()
                .ChangeTotalPrice()
                .ChangeCliente();
        }
    }
}
