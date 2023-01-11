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
    public partial class Vendas : Form
    {
        public Acessar acesso;
        public Vendas()
        {
            InitializeComponent();
        }

        private void btnTodosVendas_Click(object sender, EventArgs e)
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

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void btnLanchesVendas_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_ProdutoLanches";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();



                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void btnSalgadosVendas_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_ProdutoSalgados";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();



                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void btnPorcoesVendas_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_ProdutoPorcoes";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();



                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void btnBebidasVendas_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_ProdutoBebidas";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();



                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        private void btnMolhosVendas_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao = new SqlConnection(Properties.Resources.strC);

                SqlCommand command = new SqlCommand();

                command.CommandText = "ps_ProdutoMolhos";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;

                command.Parameters.Clear();



                conexao.Open();
                command.ExecuteNonQuery();
                conexao.Close();

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ds = new DataTable();

                adapter.Fill(ds);

                dgvPedidosVendas.DataSource = ds;
            }

            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }
    }
}
