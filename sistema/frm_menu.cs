using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frm_produtos frm = new frm_produtos();
            frm.ShowDialog();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_categorias_Click(object sender, EventArgs e)
        {
            frm_Categorias frm = new frm_Categorias();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Categorias frm = new frm_Categorias();
            frm.ShowDialog();
        }
    }
}
