using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMarket
{
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void grn_Click(object sender, EventArgs e)
        {
            Grains gr = new Grains();
            gr.ShowDialog();
        }

        private void cds_Click(object sender, EventArgs e)
        {
            CoolDrinks cd = new CoolDrinks();
            cd.ShowDialog();
        }

        private void cw_Click(object sender, EventArgs e)
        {
            kitchenware kw = new kitchenware();
            kw.ShowDialog();
        }

        private void brd_Click(object sender, EventArgs e)
        {
            Bread br = new Bread();
            br.ShowDialog();
        }

        private void grc_Click(object sender, EventArgs e)
        {
            Grocery gc = new Grocery();
            gc.ShowDialog();
        }

        private void snks_Click(object sender, EventArgs e)
        {
            Snacks sn = new Snacks();
            sn.ShowDialog();
        }
    }
}
