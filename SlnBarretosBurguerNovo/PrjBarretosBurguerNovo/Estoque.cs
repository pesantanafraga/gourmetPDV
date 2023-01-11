using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjBarretosBurguerNovo
{
    public partial class Estoque : Form
    {
        public string nomeProduto;
        public int IdProduto;

        
        public Estoque()
        {
            
            InitializeComponent();
        }

        private void btnAdicionarProdutoEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "pi_Produto";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nomeProduto", txtNomeProdutoEstoque.Text);
                command.Parameters.AddWithValue("tipoProduto", cmbTipoProdutoEstoque.Text);
                command.Parameters.AddWithValue("quantidade", txtQuantidadeProdutoEstoque.Text);
                command.Parameters.AddWithValue("valor", Convert.ToDouble(txtValorUnitarioProdutoEstoque.Text));

                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();


                MessageBox.Show("PRODUTO CADASTRADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO! " + ex.Message);
            }
        }

        private void btnAtualizarProdutoEstoque_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("DESEJA REALMENTE ATUALIZAR O(A) " + nomeProduto + "?", "AVISO", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                    SqlCommand command = new SqlCommand();

                    command.CommandText = "pu_Produto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conexao;

                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("nomeProduto", txtNomeProdutoEstoque.Text);
                    command.Parameters.AddWithValue("tipoProduto", cmbTipoProdutoEstoque.Text);
                    command.Parameters.AddWithValue("quantidade", txtQuantidadeProdutoEstoque.Text);
                    command.Parameters.AddWithValue("valor", Convert.ToDouble(txtValorUnitarioProdutoEstoque.Text));

                    conexao.Open();
                    command.ExecuteNonQuery();
                    conexao.Close();


                    MessageBox.Show("PRODUTO ATUALIZADO COM SUCESSO!");

                    ListarEstoque();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO! " + ex.Message);
                }
            }
            
        }

        private void btnDeletarProdutoEstoque_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("DESEJA REALMENTE DELETAR O(A) " + nomeProduto + "?", "AVISO", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                    SqlCommand command = new SqlCommand();

                    command.CommandText = "pd_Produto";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conexao;
                    command.Parameters.AddWithValue("IdProduto", IdProduto);
                    conexao.Open();
                    command.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("PRODUTO EXCLUÍDO COM SUCESSO!!");

                    ListarEstoque();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO! " + ex.Message);
                }

            }
        }

        private void btnBuscarEstoque_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_Produto";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();
                


                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvBuscarProdutoEstoque.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void dgvBuscarProdutoEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProduto = Convert.ToInt32(dgvBuscarProdutoEstoque.Rows[e.RowIndex].Cells[0].Value.ToString());
            nomeProduto = dgvBuscarProdutoEstoque.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        public void ListarEstoque()
        {
            SqlConnection conexao = new SqlConnection(Properties.Resources.strC);




            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Produto";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = conexao;


            SqlDataReader leitor;
            conexao.Open();



            leitor = command.ExecuteReader();




            if (leitor.HasRows)
            {
                leitor.Read();



                txtNomeProdutoEstoque.Text = leitor.GetString(1);
                cmbTipoProdutoEstoque.Text = leitor.GetString(2);
                txtQuantidadeProdutoEstoque.Text = leitor.GetInt32(3).ToString();
                txtValorUnitarioProdutoEstoque.Text = leitor.GetDecimal(4).ToString();
            }





            conexao.Close();
        }

       
    }
}
