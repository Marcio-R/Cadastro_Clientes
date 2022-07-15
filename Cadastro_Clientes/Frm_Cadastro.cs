using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    public partial class Frm_Cadastro : Form
    {

        public Frm_Cadastro()
        {
            InitializeComponent();
            txt_Id.Hide();
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" && txt_Telefone.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txt_Nome.Text;
                cliente.Telefone = txt_Telefone.Text;
                cliente.Endereco = txt_Endereco.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Email = txt_Email.Text;
                cliente.Uf = txt_Uf.Text;
                Banco.NovoCliente(cliente);
                txt_Nome.Clear();
                txt_Telefone.Clear();
                txt_Endereco.Clear();
                txt_Bairro.Clear();
                txt_Cidade.Clear();
                txt_Email.Clear();
                txt_Uf.Clear();

            }
            else
            {
                MessageBox.Show("Preencha os campos");
                txt_Nome.Focus();

            }
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (txt_Nome.Text != "" && txt_Telefone.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.Id = int.Parse(txt_Id.Text);
                cliente.Nome = txt_Nome.Text;
                cliente.Telefone = txt_Telefone.Text;
                cliente.Endereco = txt_Endereco.Text;
                cliente.Bairro = txt_Bairro.Text;
                cliente.Cidade = txt_Cidade.Text;
                cliente.Email = txt_Email.Text;
                cliente.Uf = txt_Uf.Text;
                Banco.Atualizar(cliente);
                txt_Nome.Clear();
                txt_Telefone.Clear();
                txt_Endereco.Clear();
                txt_Bairro.Clear();
                txt_Cidade.Clear();
                txt_Email.Clear();
                txt_Uf.Clear();
            }
            else
            {
                MessageBox.Show("Não foi possivel alterar");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Deletar_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                cliente.Id = int.Parse(txt_Id.Text);
                Banco.Delete(cliente);
                txt_Nome.Clear();
                txt_Telefone.Clear();
                txt_Endereco.Clear();
                txt_Bairro.Clear();
                txt_Cidade.Clear();
                txt_Email.Clear();
                txt_Uf.Clear();
            }
            else
            {
                MessageBox.Show("Exclusão não efetuada ");
            }
        }
    }
}
