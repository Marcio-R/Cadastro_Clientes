
namespace Cadastro_Clientes
{
    partial class Frm_Clientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new Cadastro_Clientes.ClientesDataSet();
            this.cad_ClienteTableAdapter = new Cadastro_Clientes.ClientesDataSetTableAdapters.Cad_ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(12, 12);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(120, 43);
            this.btn_Incluir.TabIndex = 0;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Location = new System.Drawing.Point(157, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(120, 43);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(299, 12);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(120, 43);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(443, 12);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(120, 43);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.cadClienteBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(2, 73);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(793, 345);
            this.dataGrid.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            this.endereçoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadClienteBindingSource
            // 
            this.cadClienteBindingSource.DataMember = "Cad_Cliente";
            this.cadClienteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_ClienteTableAdapter
            // 
            this.cad_ClienteTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Incluir);
            this.Name = "Frm_Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Sair;
        private ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource cadClienteBindingSource;
        private ClientesDataSetTableAdapters.Cad_ClienteTableAdapter cad_ClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGrid;
    }
}

