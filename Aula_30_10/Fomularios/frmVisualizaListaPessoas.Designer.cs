namespace Aula_30_10.Fomularios
{
    partial class frmVisualizaListaPessoas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet_Agenda_Corrigido = new Aula_30_10.DataSet_Agenda_Corrigido();
            this.dataSetAgendaCorrigidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Aula_30_10.DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaCorrigidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_Pessoas";
            reportDataSource1.Value = this.pessoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Aula_30_10.Relatórios.RelatorioPessoas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet_Agenda_Corrigido
            // 
            this.dataSet_Agenda_Corrigido.DataSetName = "DataSet_Agenda_Corrigido";
            this.dataSet_Agenda_Corrigido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAgendaCorrigidoBindingSource
            // 
            this.dataSetAgendaCorrigidoBindingSource.DataSource = this.dataSet_Agenda_Corrigido;
            this.dataSetAgendaCorrigidoBindingSource.Position = 0;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSetAgendaCorrigidoBindingSource;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisualizaListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisualizaListaPessoas";
            this.Text = "frmVisualizaListaPessoas";
            this.Load += new System.EventHandler(this.frmVisualizaListaPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAgendaCorrigidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet_Agenda_Corrigido dataSet_Agenda_Corrigido;
        private System.Windows.Forms.BindingSource dataSetAgendaCorrigidoBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter pessoaTableAdapter;
    }
}