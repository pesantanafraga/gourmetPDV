namespace PrjBarretosBurguerNovo
{
    partial class Principal
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
            this.menuPrincipalVendas = new System.Windows.Forms.MenuStrip();
            this.vendasMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionariosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirCaixaFinanceiroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharCaixaFinanceiroMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.acessarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipalVendas
            // 
            this.menuPrincipalVendas.BackColor = System.Drawing.Color.LightGray;
            this.menuPrincipalVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuPrincipalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipalVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessarMenu,
            this.vendasMenu,
            this.estoqueMenu,
            this.funcionariosMenu,
            this.financeiroMenu,
            this.sairMenu});
            this.menuPrincipalVendas.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalVendas.Name = "menuPrincipalVendas";
            this.menuPrincipalVendas.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipalVendas.Size = new System.Drawing.Size(1346, 32);
            this.menuPrincipalVendas.TabIndex = 1;
            this.menuPrincipalVendas.Text = "menuStrip1";
            // 
            // vendasMenu
            // 
            this.vendasMenu.Name = "vendasMenu";
            this.vendasMenu.Size = new System.Drawing.Size(106, 28);
            this.vendasMenu.Text = "VENDAS";
            this.vendasMenu.Click += new System.EventHandler(this.vendasMenu_Click);
            // 
            // estoqueMenu
            // 
            this.estoqueMenu.Name = "estoqueMenu";
            this.estoqueMenu.Size = new System.Drawing.Size(122, 28);
            this.estoqueMenu.Text = "ESTOQUE";
            this.estoqueMenu.Click += new System.EventHandler(this.estoqueMenu_Click);
            // 
            // funcionariosMenu
            // 
            this.funcionariosMenu.Name = "funcionariosMenu";
            this.funcionariosMenu.Size = new System.Drawing.Size(176, 28);
            this.funcionariosMenu.Text = "FUNCIONÁRIOS";
            this.funcionariosMenu.Click += new System.EventHandler(this.funcionariosMenu_Click);
            // 
            // financeiroMenu
            // 
            this.financeiroMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirCaixaFinanceiroMenu,
            this.fecharCaixaFinanceiroMenu});
            this.financeiroMenu.Name = "financeiroMenu";
            this.financeiroMenu.Size = new System.Drawing.Size(147, 28);
            this.financeiroMenu.Text = "FINANCEIRO";
            // 
            // abrirCaixaFinanceiroMenu
            // 
            this.abrirCaixaFinanceiroMenu.Name = "abrirCaixaFinanceiroMenu";
            this.abrirCaixaFinanceiroMenu.Size = new System.Drawing.Size(232, 28);
            this.abrirCaixaFinanceiroMenu.Text = "ABRIR CAIXA";
            this.abrirCaixaFinanceiroMenu.Click += new System.EventHandler(this.abrirCaixaFinanceiroMenu_Click);
            // 
            // fecharCaixaFinanceiroMenu
            // 
            this.fecharCaixaFinanceiroMenu.Name = "fecharCaixaFinanceiroMenu";
            this.fecharCaixaFinanceiroMenu.Size = new System.Drawing.Size(232, 28);
            this.fecharCaixaFinanceiroMenu.Text = "FECHAR CAIXA";
            this.fecharCaixaFinanceiroMenu.Click += new System.EventHandler(this.fecharCaixaFinanceiroMenu_Click);
            // 
            // sairMenu
            // 
            this.sairMenu.Name = "sairMenu";
            this.sairMenu.Size = new System.Drawing.Size(68, 28);
            this.sairMenu.Text = "SAIR";
            this.sairMenu.Click += new System.EventHandler(this.sairMenu_Click);
            // 
            // acessarMenu
            // 
            this.acessarMenu.Name = "acessarMenu";
            this.acessarMenu.Size = new System.Drawing.Size(118, 28);
            this.acessarMenu.Text = "ACESSAR";
            this.acessarMenu.Click += new System.EventHandler(this.acessarMenu_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1346, 725);
            this.Controls.Add(this.menuPrincipalVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuPrincipalVendas.ResumeLayout(false);
            this.menuPrincipalVendas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipalVendas;
        public System.Windows.Forms.ToolStripMenuItem vendasMenu;
        public System.Windows.Forms.ToolStripMenuItem estoqueMenu;
        public System.Windows.Forms.ToolStripMenuItem funcionariosMenu;
        public System.Windows.Forms.ToolStripMenuItem financeiroMenu;
        public System.Windows.Forms.ToolStripMenuItem abrirCaixaFinanceiroMenu;
        public System.Windows.Forms.ToolStripMenuItem fecharCaixaFinanceiroMenu;
        public System.Windows.Forms.ToolStripMenuItem sairMenu;
        public System.Windows.Forms.ToolStripMenuItem acessarMenu;
    }
}