namespace Aula_30_10.Fomularios
{
    partial class frmCadPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPessoas));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nascimentoLabel;
            this.dataSet_Agenda_Corrigido = new Aula_30_10.DataSet_Agenda_Corrigido();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaTableAdapter = new Aula_30_10.DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter();
            this.tableAdapterManager = new Aula_30_10.DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager();
            this.pessoaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pessoaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Agenda_Corrigido1 = new Aula_30_10.Dados.DataSet_Agenda_Corrigido();
            this.pessoaTableAdapter1 = new Aula_30_10.Dados.DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter();
            this.tableAdapterManager1 = new Aula_30_10.Dados.DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.logradouroTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).BeginInit();
            this.pessoaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet_Agenda_Corrigido
            // 
            this.dataSet_Agenda_Corrigido.DataSetName = "DataSet_Agenda_Corrigido";
            this.dataSet_Agenda_Corrigido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSet_Agenda_Corrigido;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PessoaTableAdapter = this.pessoaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Aula_30_10.DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoaBindingNavigator
            // 
            this.pessoaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoaBindingNavigator.BindingSource = this.pessoaBindingSource;
            this.pessoaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pessoaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoaBindingNavigatorSaveItem});
            this.pessoaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoaBindingNavigator.Name = "pessoaBindingNavigator";
            this.pessoaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.pessoaBindingNavigator.TabIndex = 0;
            this.pessoaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pessoaBindingNavigatorSaveItem
            // 
            this.pessoaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoaBindingNavigatorSaveItem.Image")));
            this.pessoaBindingNavigatorSaveItem.Name = "pessoaBindingNavigatorSaveItem";
            this.pessoaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pessoaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoaBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoaBindingNavigatorSaveItem_Click);
            // 
            // pessoaDataGridView
            // 
            this.pessoaDataGridView.AutoGenerateColumns = false;
            this.pessoaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.pessoaDataGridView.DataSource = this.pessoaBindingSource;
            this.pessoaDataGridView.Location = new System.Drawing.Point(24, 145);
            this.pessoaDataGridView.Name = "pessoaDataGridView";
            this.pessoaDataGridView.Size = new System.Drawing.Size(743, 220);
            this.pessoaDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Logradouro";
            this.dataGridViewTextBoxColumn3.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nascimento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nascimento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataMember = "Pessoa";
            this.pessoaBindingSource1.DataSource = this.dataSet_Agenda_Corrigido1;
            // 
            // dataSet_Agenda_Corrigido1
            // 
            this.dataSet_Agenda_Corrigido1.DataSetName = "DataSet_Agenda_Corrigido";
            this.dataSet_Agenda_Corrigido1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaTableAdapter1
            // 
            this.pessoaTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PessoaTableAdapter = this.pessoaTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Aula_30_10.Dados.DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(70, 66);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(142, 63);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(36, 20);
            this.iDTextBox.TabIndex = 16;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(70, 92);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 17;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(142, 89);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 18;
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Location = new System.Drawing.Point(70, 118);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(64, 13);
            logradouroLabel.TabIndex = 19;
            logradouroLabel.Text = "Logradouro:";
            // 
            // logradouroTextBox
            // 
            this.logradouroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Logradouro", true));
            this.logradouroTextBox.Location = new System.Drawing.Point(142, 115);
            this.logradouroTextBox.Name = "logradouroTextBox";
            this.logradouroTextBox.Size = new System.Drawing.Size(200, 20);
            this.logradouroTextBox.TabIndex = 20;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(386, 92);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 21;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(458, 89);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidadeTextBox.TabIndex = 22;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(386, 122);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 23;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(458, 119);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(96, 20);
            this.telefoneTextBox.TabIndex = 24;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(386, 66);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(458, 63);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 26;
            // 
            // nascimentoLabel
            // 
            nascimentoLabel.AutoSize = true;
            nascimentoLabel.Location = new System.Drawing.Point(184, 66);
            nascimentoLabel.Name = "nascimentoLabel";
            nascimentoLabel.Size = new System.Drawing.Size(66, 13);
            nascimentoLabel.TabIndex = 27;
            nascimentoLabel.Text = "Nascimento:";
            // 
            // nascimentoDateTimePicker
            // 
            this.nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoaBindingSource, "Nascimento", true));
            this.nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nascimentoDateTimePicker.Location = new System.Drawing.Point(256, 62);
            this.nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            this.nascimentoDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.nascimentoDateTimePicker.TabIndex = 28;
            // 
            // frmCadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(logradouroLabel);
            this.Controls.Add(this.logradouroTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nascimentoLabel);
            this.Controls.Add(this.nascimentoDateTimePicker);
            this.Controls.Add(this.pessoaDataGridView);
            this.Controls.Add(this.pessoaBindingNavigator);
            this.Name = "frmCadPessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.frmCadPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingNavigator)).EndInit();
            this.pessoaBindingNavigator.ResumeLayout(false);
            this.pessoaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda_Corrigido1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_Agenda_Corrigido dataSet_Agenda_Corrigido;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pessoaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Dados.DataSet_Agenda_Corrigido dataSet_Agenda_Corrigido1;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private Dados.DataSet_Agenda_CorrigidoTableAdapters.PessoaTableAdapter pessoaTableAdapter1;
        private Dados.DataSet_Agenda_CorrigidoTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox logradouroTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker nascimentoDateTimePicker;
    }
}