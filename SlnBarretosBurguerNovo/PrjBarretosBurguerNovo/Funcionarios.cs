using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjBarretosBurguerNovo
{
    public partial class Funcionarios : Form
    {
        public string nomeFunc;
        public string cpfDeletar;

        
        public Funcionarios()
        {
            
            InitializeComponent();
        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();
                command.CommandText = "pi_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();

                command.Parameters.AddWithValue("nomeFunc", txtNomeFuncionario.Text);
                command.Parameters.AddWithValue("cpf", txtCpfFuncionario.Text);
                command.Parameters.AddWithValue("celular", txtCelularFuncionario.Text);
                command.Parameters.AddWithValue("login", txtLoginFuncionario.Text);
                command.Parameters.AddWithValue("senha", txtSenhaFuncionario.Text);
                command.Parameters.AddWithValue("perfil", cmbPerfilFuncionario.Text);

                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("FUNCIONÁRIO CADASTRADO COM SUCESSO!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO! " + ex.Message);
            }

        }

        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("DESEJA REALMENTE ATUALIZAR O(A) " + nomeFunc + "?", "AVISO", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "pu_Funcionario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conexao;

                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("nomeFunc", txtNomeFuncionario.Text);
                    command.Parameters.AddWithValue("celular", txtCelularFuncionario.Text);
                    command.Parameters.AddWithValue("senha", txtSenhaFuncionario.Text);
                    command.Parameters.AddWithValue("perfil", cmbPerfilFuncionario.Text);

                    conexao.Open();
                    command.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("FUNCIONÁRIO ATUALIZADO COM SUCESSO!!");

                    ListarFuncionario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO! " + ex.Message);
                }
            }
            
        }
        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("DESEJA REALMENTE DELETAR O(A) " + nomeFunc + "?", "AVISO", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "pd_Funcionario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conexao;

                    command.Parameters.Clear();

                    command.Parameters.AddWithValue("cpf", cpfDeletar);

                    conexao.Open();
                    command.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("FUNCIONÁRIO DELETADO COM SUCESSO!!");

                    ListarFuncionario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO! " + ex.Message);
                }
            }
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nomeFunc", txtBuscarFuncionario.Text);


                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvBuscarFuncionario.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }


        private void dgvBuscarFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFunc = dgvBuscarFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
            cpfDeletar = dgvBuscarFuncionario.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        public void ListarFuncionario()
        {
            SqlConnection conexao = new SqlConnection(Properties.Resources.strC);


            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_FuncionarioListar";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;


            SqlDataReader leitor;
            conexao.Open();

            leitor = command.ExecuteReader();


            if (leitor.HasRows)
            {
                leitor.Read();

                txtNomeFuncionario.Text = leitor.GetString(1);
                txtCpfFuncionario.Text = leitor.GetString(2);
                txtCelularFuncionario.Text = leitor.GetString(3);
                txtLoginFuncionario.Text = leitor.GetString(4);
                txtSenhaFuncionario.Text = leitor.GetString(5);
                cmbPerfilFuncionario.Text = leitor.GetString(6);
            }



            conexao.Close();
        }
    }
}
