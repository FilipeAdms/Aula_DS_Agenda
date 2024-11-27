using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_30_10.Fomularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void relatórioDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizaListaPessoas objVisualizaListaPessoas = new frmVisualizaListaPessoas();
            objVisualizaListaPessoas.MdiParent = this;
            objVisualizaListaPessoas.Show();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }
    }
}
