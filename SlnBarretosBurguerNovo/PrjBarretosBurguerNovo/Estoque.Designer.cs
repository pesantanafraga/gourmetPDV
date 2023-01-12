namespace PrjBarretosBurguerNovo
{
    partial class Estoque
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
            this.lblNomeProdutoEstoque = new System.Windows.Forms.Label();
            this.lblTipoProdutoEstoque = new System.Windows.Forms.Label();
            this.lblQuantidadeProdutoEstoque = new System.Windows.Forms.Label();
            this.lblValorUnitarioProdutoEstoque = new System.Windows.Forms.Label();
            this.txtNomeProdutoEstoque = new System.Windows.Forms.TextBox();
            this.cmbTipoProdutoEstoque = new System.Windows.Forms.ComboBox();
            this.txtValorUnitarioProdutoEstoque = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProdutoEstoque = new System.Windows.Forms.TextBox();
            this.btnAdicionarProdutoEstoque = new System.Windows.Forms.Button();
            this.btnDeletarProdutoEstoque = new System.Windows.Forms.Button();
            this.btnAtualizarProdutoEstoque = new System.Windows.Forms.Button();
            this.txtBuscarProdutoBuscarEstoque = new System.Windows.Forms.TextBox();
            this.lblBuscarProdutoEstoque = new System.Windows.Forms.Label();
            this.dgvBuscarProdutoEstoque = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeProdutoEstoque
            // 
            this.lblNomeProdutoEstoque.AutoSize = true;
            this.lblNomeProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProdutoEstoque.Location = new System.Drawing.Point(12, 46);
            this.lblNomeProdutoEstoque.Name = "lblNomeProdutoEstoque";
            this.lblNomeProdutoEstoque.Size = new System.Drawing.Size(151, 20);
            this.lblNomeProdutoEstoque.TabIndex = 0;
            this.lblNomeProdutoEstoque.Text = "NOME PRODUTO";
            // 
            // lblTipoProdutoEstoque
            // 
            this.lblTipoProdutoEstoque.AutoSize = true;
            this.lblTipoProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProdutoEstoque.Location = new System.Drawing.Point(12, 131);
            this.lblTipoProdutoEstoque.Name = "lblTipoProdutoEstoque";
            this.lblTipoProdutoEstoque.Size = new System.Drawing.Size(49, 20);
            this.lblTipoProdutoEstoque.TabIndex = 0;
            this.lblTipoProdutoEstoque.Text = "TIPO";
            // 
            // lblQuantidadeProdutoEstoque
            // 
            this.lblQuantidadeProdutoEstoque.AutoSize = true;
            this.lblQuantidadeProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeProdutoEstoque.Location = new System.Drawing.Point(12, 225);
            this.lblQuantidadeProdutoEstoque.Name = "lblQuantidadeProdutoEstoque";
            this.lblQuantidadeProdutoEstoque.Size = new System.Drawing.Size(125, 20);
            this.lblQuantidadeProdutoEstoque.TabIndex = 0;
            this.lblQuantidadeProdutoEstoque.Text = "QUANTIDADE";
            // 
            // lblValorUnitarioProdutoEstoque
            // 
            this.lblValorUnitarioProdutoEstoque.AutoSize = true;
            this.lblValorUnitarioProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnitarioProdutoEstoque.Location = new System.Drawing.Point(12, 310);
            this.lblValorUnitarioProdutoEstoque.Name = "lblValorUnitarioProdutoEstoque";
            this.lblValorUnitarioProdutoEstoque.Size = new System.Drawing.Size(187, 20);
            this.lblValorUnitarioProdutoEstoque.TabIndex = 0;
            this.lblValorUnitarioProdutoEstoque.Text = "VALOR UNITÁRIO R$";
            // 
            // txtNomeProdutoEstoque
            // 
            this.txtNomeProdutoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProdutoEstoque.Location = new System.Drawing.Point(16, 89);
            this.txtNomeProdutoEstoque.Name = "txtNomeProdutoEstoque";
            this.txtNomeProdutoEstoque.Size = new System.Drawing.Size(350, 19);
            this.txtNomeProdutoEstoque.TabIndex = 1;
            // 
            // cmbTipoProdutoEstoque
            // 
            this.cmbTipoProdutoEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoProdutoEstoque.FormattingEnabled = true;
            this.cmbTipoProdutoEstoque.Items.AddRange(new object[] {
            "Lanches",
            "Salgados",
            "Porções",
            "Molhos",
            "Bebidas"});
            this.cmbTipoProdutoEstoque.Location = new System.Drawing.Point(16, 174);
            this.cmbTipoProdutoEstoque.Name = "cmbTipoProdutoEstoque";
            this.cmbTipoProdutoEstoque.Size = new System.Drawing.Size(350, 28);
            this.cmbTipoProdutoEstoque.TabIndex = 2;
            // 
            // txtValorUnitarioProdutoEstoque
            // 
            this.txtValorUnitarioProdutoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorUnitarioProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorUnitarioProdutoEstoque.Location = new System.Drawing.Point(16, 353);
            this.txtValorUnitarioProdutoEstoque.Name = "txtValorUnitarioProdutoEstoque";
            this.txtValorUnitarioProdutoEstoque.Size = new System.Drawing.Size(350, 19);
            this.txtValorUnitarioProdutoEstoque.TabIndex = 4;
            // 
            // txtQuantidadeProdutoEstoque
            // 
            this.txtQuantidadeProdutoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidadeProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidadeProdutoEstoque.Location = new System.Drawing.Point(16, 268);
            this.txtQuantidadeProdutoEstoque.Name = "txtQuantidadeProdutoEstoque";
            this.txtQuantidadeProdutoEstoque.Size = new System.Drawing.Size(350, 19);
            this.txtQuantidadeProdutoEstoque.TabIndex = 3;
            // 
            // btnAdicionarProdutoEstoque
            // 
            this.btnAdicionarProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdutoEstoque.Location = new System.Drawing.Point(940, 649);
            this.btnAdicionarProdutoEstoque.Name = "btnAdicionarProdutoEstoque";
            this.btnAdicionarProdutoEstoque.Size = new System.Drawing.Size(124, 30);
            this.btnAdicionarProdutoEstoque.TabIndex = 5;
            this.btnAdicionarProdutoEstoque.Text = "ADICIONAR";
            this.btnAdicionarProdutoEstoque.UseVisualStyleBackColor = true;
            this.btnAdicionarProdutoEstoque.Click += new System.EventHandler(this.btnAdicionarProdutoEstoque_Click);
            // 
            // btnDeletarProdutoEstoque
            // 
            this.btnDeletarProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarProdutoEstoque.Location = new System.Drawing.Point(1070, 649);
            this.btnDeletarProdutoEstoque.Name = "btnDeletarProdutoEstoque";
            this.btnDeletarProdutoEstoque.Size = new System.Drawing.Size(124, 30);
            this.btnDeletarProdutoEstoque.TabIndex = 9;
            this.btnDeletarProdutoEstoque.Text = "DELETAR";
            this.btnDeletarProdutoEstoque.UseVisualStyleBackColor = true;
            this.btnDeletarProdutoEstoque.Click += new System.EventHandler(this.btnDeletarProdutoEstoque_Click);
            // 
            // btnAtualizarProdutoEstoque
            // 
            this.btnAtualizarProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProdutoEstoque.Location = new System.Drawing.Point(1200, 649);
            this.btnAtualizarProdutoEstoque.Name = "btnAtualizarProdutoEstoque";
            this.btnAtualizarProdutoEstoque.Size = new System.Drawing.Size(124, 30);
            this.btnAtualizarProdutoEstoque.TabIndex = 6;
            this.btnAtualizarProdutoEstoque.Text = "ATUALIZAR";
            this.btnAtualizarProdutoEstoque.UseVisualStyleBackColor = true;
            this.btnAtualizarProdutoEstoque.Click += new System.EventHandler(this.btnAtualizarProdutoEstoque_Click);
            // 
            // txtBuscarProdutoBuscarEstoque
            // 
            this.txtBuscarProdutoBuscarEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProdutoBuscarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProdutoBuscarEstoque.Location = new System.Drawing.Point(571, 89);
            this.txtBuscarProdutoBuscarEstoque.Name = "txtBuscarProdutoBuscarEstoque";
            this.txtBuscarProdutoBuscarEstoque.Size = new System.Drawing.Size(753, 19);
            this.txtBuscarProdutoBuscarEstoque.TabIndex = 7;
            // 
            // lblBuscarProdutoEstoque
            // 
            this.lblBuscarProdutoEstoque.AutoSize = true;
            this.lblBuscarProdutoEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarProdutoEstoque.Location = new System.Drawing.Point(567, 46);
            this.lblBuscarProdutoEstoque.Name = "lblBuscarProdutoEstoque";
            this.lblBuscarProdutoEstoque.Size = new System.Drawing.Size(301, 20);
            this.lblBuscarProdutoEstoque.TabIndex = 0;
            this.lblBuscarProdutoEstoque.Text = "NOME DO PRODUTO PARA BUSCA";
            // 
            // dgvBuscarProdutoEstoque
            // 
            this.dgvBuscarProdutoEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBuscarProdutoEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProdutoEstoque.Location = new System.Drawing.Point(571, 113);
            this.dgvBuscarProdutoEstoque.Name = "dgvBuscarProdutoEstoque";
            this.dgvBuscarProdutoEstoque.Size = new System.Drawing.Size(753, 519);
            this.dgvBuscarProdutoEstoque.TabIndex = 0;
            this.dgvBuscarProdutoEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProdutoEstoque_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::PrjBarretosBurguerNovo.Properties.Resources.logogenerico;
            this.pictureBox1.Location = new System.Drawing.Point(16, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarEstoque
            // 
            this.btnBuscarEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstoque.Location = new System.Drawing.Point(1200, 36);
            this.btnBuscarEstoque.Name = "btnBuscarEstoque";
            this.btnBuscarEstoque.Size = new System.Drawing.Size(124, 30);
            this.btnBuscarEstoque.TabIndex = 8;
            this.btnBuscarEstoque.Text = "BUSCAR";
            this.btnBuscarEstoque.UseVisualStyleBackColor = true;
            this.btnBuscarEstoque.Click += new System.EventHandler(this.btnBuscarEstoque_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.btnBuscarEstoque);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvBuscarProdutoEstoque);
            this.Controls.Add(this.txtBuscarProdutoBuscarEstoque);
            this.Controls.Add(this.lblBuscarProdutoEstoque);
            this.Controls.Add(this.btnAtualizarProdutoEstoque);
            this.Controls.Add(this.btnDeletarProdutoEstoque);
            this.Controls.Add(this.btnAdicionarProdutoEstoque);
            this.Controls.Add(this.txtQuantidadeProdutoEstoque);
            this.Controls.Add(this.txtValorUnitarioProdutoEstoque);
            this.Controls.Add(this.cmbTipoProdutoEstoque);
            this.Controls.Add(this.txtNomeProdutoEstoque);
            this.Controls.Add(this.lblValorUnitarioProdutoEstoque);
            this.Controls.Add(this.lblQuantidadeProdutoEstoque);
            this.Controls.Add(this.lblTipoProdutoEstoque);
            this.Controls.Add(this.lblNomeProdutoEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProdutoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeProdutoEstoque;
        private System.Windows.Forms.Label lblTipoProdutoEstoque;
        private System.Windows.Forms.Label lblQuantidadeProdutoEstoque;
        private System.Windows.Forms.Label lblValorUnitarioProdutoEstoque;
        private System.Windows.Forms.TextBox txtNomeProdutoEstoque;
        private System.Windows.Forms.ComboBox cmbTipoProdutoEstoque;
        private System.Windows.Forms.TextBox txtValorUnitarioProdutoEstoque;
        private System.Windows.Forms.TextBox txtQuantidadeProdutoEstoque;
        private System.Windows.Forms.Button btnAdicionarProdutoEstoque;
        private System.Windows.Forms.Button btnDeletarProdutoEstoque;
        private System.Windows.Forms.Button btnAtualizarProdutoEstoque;
        private System.Windows.Forms.TextBox txtBuscarProdutoBuscarEstoque;
        private System.Windows.Forms.Label lblBuscarProdutoEstoque;
        private System.Windows.Forms.DataGridView dgvBuscarProdutoEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarEstoque;
    }
}