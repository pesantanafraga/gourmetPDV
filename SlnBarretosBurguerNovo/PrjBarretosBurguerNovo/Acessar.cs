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
    public partial class Acessar : Form
    {
        
        public Principal p;

        public Acessar(Principal _principal)
        {
            this.p = _principal;
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Properties.Resources.strC);
                SqlConnection conexao = sqlConnection;

                SqlCommand command = new SqlCommand();
                command.CommandText = "ps_Login";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = conexao;
                command.Parameters.AddWithValue("@login", txtLogin.Text);
                command.Parameters.AddWithValue("@senha", txtSenha.Text);

                SqlDataReader reader;

                conexao.Open();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    if (reader.GetString(2) == "Atendente")
                    {
                        p.sairMenu.Visible = true;
                        p.funcionariosMenu.Visible = false;
                        p.financeiroMenu.Visible = true;
                        p.abrirCaixaFinanceiroMenu.Visible = true;
                        p.fecharCaixaFinanceiroMenu.Visible = true;
                        p.estoqueMenu.Visible = true;
                        p.vendasMenu.Visible = true;
                        p.acessarMenu.Visible = false;
                        MessageBox.Show("SEJA BEM VINDO " + reader.GetString(0) + "!" );
                    }

                    else if (reader.GetString(2) == "Gerente")
                    {
                        p.sairMenu.Visible = true;
                        p.funcionariosMenu.Visible = true;
                        p.financeiroMenu.Visible = true;
                        p.abrirCaixaFinanceiroMenu.Visible = true;
                        p.fecharCaixaFinanceiroMenu.Visible = true;
                        p.estoqueMenu.Visible = true;
                        p.vendasMenu.Visible = true;
                        p.acessarMenu.Visible = false;
                        MessageBox.Show("SEJA BEM VINDO " + reader.GetString(0) + "!");
                    }
                    else
                    {
                        MessageBox.Show("USUÁRIO E/OU SENHA INCORRETOS!!");
                    }

                    
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO! " + ex.Message);
            }


                this.Close();
            
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else if (chkMostrarSenha.CheckState.ToString() == "Unchecked")
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }


       
        
    }
}
