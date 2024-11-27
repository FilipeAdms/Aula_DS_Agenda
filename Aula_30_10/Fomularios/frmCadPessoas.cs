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
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda_Corrigido);

        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda_Corrigido1.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter1.Fill(this.dataSet_Agenda_Corrigido1.Pessoa);
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda_Corrigido.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda_Corrigido.Pessoa);

        }
    }
}
