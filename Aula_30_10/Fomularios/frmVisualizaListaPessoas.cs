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
    public partial class frmVisualizaListaPessoas : Form
    {
        public frmVisualizaListaPessoas()
        {
            InitializeComponent();
        }

        private void frmVisualizaListaPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda_Corrigido.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda_Corrigido.Pessoa);

            this.reportViewer1.RefreshReport();
        }
    }
}
