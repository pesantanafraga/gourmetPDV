using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjBarretosBurguerNovo
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
              sairMenu.Visible = false;
              funcionariosMenu.Visible = false;
              financeiroMenu.Visible = false;
              abrirCaixaFinanceiroMenu.Visible = false;
              fecharCaixaFinanceiroMenu.Visible = false;
              estoqueMenu.Visible = false;
              vendasMenu.Visible = false;
              acessarMenu.Visible = true;

            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                {
                    c.BackColor = this.BackColor;
                    c.BackgroundImage = this.BackgroundImage;
                }
            }
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            sairMenu.Visible = false;
            funcionariosMenu.Visible = false;
            financeiroMenu.Visible = false;
            abrirCaixaFinanceiroMenu.Visible = false;
            fecharCaixaFinanceiroMenu.Visible = false;
            estoqueMenu.Visible = false;
            vendasMenu.Visible = false;
            acessarMenu.Visible = true;
        }

        private void vendasMenu_Click(object sender, EventArgs e)
        {
            Vendas venda = new Vendas();
            venda.MdiParent = this;
            venda.Show();
        }

        private void estoqueMenu_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();
            estoque.MdiParent = this;
            estoque.Show();
        }

        private void funcionariosMenu_Click(object sender, EventArgs e)
        {
            Funcionarios func = new Funcionarios();
            func.MdiParent = this;
            func.Show();
        }

        private void abrirCaixaFinanceiroMenu_Click(object sender, EventArgs e)
        {
            AbrirCaixa ab = new AbrirCaixa();
            ab.MdiParent = this;
            ab.Show();
        }

        private void fecharCaixaFinanceiroMenu_Click(object sender, EventArgs e)
        {
            FechamentoCaixa fc = new FechamentoCaixa();
            fc.MdiParent = this;
            fc.Show();
        }

        private void acessarMenu_Click(object sender, EventArgs e)
        {
            Acessar acessar = new Acessar(this);
            acessar.MdiParent = this;
            acessar.Show();
        }
    }
}
