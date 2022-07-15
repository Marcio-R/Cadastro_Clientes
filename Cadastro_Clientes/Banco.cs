using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Clientes
{
    class Banco
    {
        private static SqlConnection conecta;

        public static SqlConnection Conexao()
        {
            conecta = new SqlConnection("Data Source=DESKTOP-KB48KMI\\SQLEXPRESS;Initial Catalog=Clientes;Integrated Security=True");
            conecta.Open();
            return conecta;
        }

        public static DataTable MostraTodos()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Pessoas", Conexao());
            DataTable dados = new DataTable();
            adapter.Fill(dados);
            Conexao().Close();
            return dados;
        }

        public static void NovoCliente(Cliente cli)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = "Insert Into Cad_Cliente (Nome,Telefone,Endereço,Bairro,Cidade,UF,Email) Values (@Nome,@Telefone,@Endereco,@Bairro,@Cidade,@UF,@Email)";
                cmd.Parameters.AddWithValue("@Nome", cli.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cli.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", cli.Endereco);
                cmd.Parameters.AddWithValue("@Bairro", cli.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", cli.Cidade);
                cmd.Parameters.AddWithValue("@UF", cli.Uf);
                cmd.Parameters.AddWithValue("@Email", cli.Email);
                cmd.ExecuteNonQuery();
                Conexao().Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar nova pessoa", ex.Message);
                Conexao().Close();
            }
        }
        public static void Atualizar(Cliente cli)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = $"Update Cad_Cliente Set Nome = @Nome, Telefone = @Telefone, Endereço = @Endereco, Bairro = @Bairro ,Cidade = @Cidade, UF = @UF,Email = @Email Where Id = {cli.Id}";
                cmd.Parameters.AddWithValue("@Nome", cli.Nome);
                cmd.Parameters.AddWithValue("@Telefone", cli.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", cli.Endereco);
                cmd.Parameters.AddWithValue("@Bairro", cli.Bairro);
                cmd.Parameters.AddWithValue("@Cidade", cli.Cidade);
                cmd.Parameters.AddWithValue("@UF", cli.Uf);
                cmd.Parameters.AddWithValue("@Email", cli.Email);
                cmd.ExecuteNonQuery();
                Conexao().Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void Delete(Cliente cli)
        {
            try
            {
                var cmd = Conexao().CreateCommand();
                cmd.CommandText = $"delete from Cad_Cliente Where Id = {cli.Id}";
                cmd.ExecuteNonQuery();
                Conexao().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
