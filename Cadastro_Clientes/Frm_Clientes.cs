using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    public partial class Frm_Clientes : Form
    {
        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clientesDataSet.Cad_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.cad_ClienteTableAdapter.Fill(this.clientesDataSet.Cad_Cliente);
          

        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            Frm_Cadastro frm = new Frm_Cadastro();
            frm.ShowDialog();
            
           
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro frm = new Frm_Cadastro();
            frm.txt_Id.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            frm.txt_Nome.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            frm.txt_Endereco.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            frm.txt_Bairro.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            frm.txt_Cidade.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            frm.txt_Uf.Text = this.dataGrid.CurrentRow.Cells[5].Value.ToString();
            frm.txt_Telefone.Text = this.dataGrid.CurrentRow.Cells[6].Value.ToString();
            frm.txt_Email.Text = this.dataGrid.CurrentRow.Cells[7].Value.ToString();
            frm.ShowDialog();
            
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            
            Frm_Cadastro frm = new Frm_Cadastro();
            frm.txt_Id.Text = this.dataGrid.CurrentRow.Cells[0].Value.ToString();
            frm.txt_Nome.Text = this.dataGrid.CurrentRow.Cells[1].Value.ToString();
            frm.txt_Endereco.Text = this.dataGrid.CurrentRow.Cells[2].Value.ToString();
            frm.txt_Bairro.Text = this.dataGrid.CurrentRow.Cells[3].Value.ToString();
            frm.txt_Cidade.Text = this.dataGrid.CurrentRow.Cells[4].Value.ToString();
            frm.txt_Uf.Text = this.dataGrid.CurrentRow.Cells[5].Value.ToString();
            frm.txt_Telefone.Text = this.dataGrid.CurrentRow.Cells[6].Value.ToString();
            frm.txt_Email.Text = this.dataGrid.CurrentRow.Cells[7].Value.ToString();
            frm.ShowDialog();
           
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
