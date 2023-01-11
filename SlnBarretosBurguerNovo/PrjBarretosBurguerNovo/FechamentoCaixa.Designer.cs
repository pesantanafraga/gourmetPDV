namespace PrjBarretosBurguerNovo
{
    partial class FechamentoCaixa
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
            this.btnFecharCaixa = new System.Windows.Forms.Button();
            this.dtpFechamentoDeCaixa = new System.Windows.Forms.DateTimePicker();
            this.txtNomeOperadorFechamentoDeCaixa = new System.Windows.Forms.TextBox();
            this.lblFechamentoDeCaixa = new System.Windows.Forms.Label();
            this.lblNomeOperadorFechamentoDeCaixa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFecharCaixa
            // 
            this.btnFecharCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharCaixa.Location = new System.Drawing.Point(176, 309);
            this.btnFecharCaixa.Name = "btnFecharCaixa";
            this.btnFecharCaixa.Size = new System.Drawing.Size(156, 33);
            this.btnFecharCaixa.TabIndex = 9;
            this.btnFecharCaixa.Text = "FECHAR CAIXA";
            this.btnFecharCaixa.UseVisualStyleBackColor = true;
            // 
            // dtpFechamentoDeCaixa
            // 
            this.dtpFechamentoDeCaixa.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechamentoDeCaixa.CustomFormat = "d/MM/yyyy HH:mm";
            this.dtpFechamentoDeCaixa.Enabled = false;
            this.dtpFechamentoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechamentoDeCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechamentoDeCaixa.Location = new System.Drawing.Point(85, 213);
            this.dtpFechamentoDeCaixa.Name = "dtpFechamentoDeCaixa";
            this.dtpFechamentoDeCaixa.Size = new System.Drawing.Size(350, 26);
            this.dtpFechamentoDeCaixa.TabIndex = 8;
            // 
            // txtNomeOperadorFechamentoDeCaixa
            // 
            this.txtNomeOperadorFechamentoDeCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeOperadorFechamentoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOperadorFechamentoDeCaixa.Location = new System.Drawing.Point(85, 153);
            this.txtNomeOperadorFechamentoDeCaixa.Name = "txtNomeOperadorFechamentoDeCaixa";
            this.txtNomeOperadorFechamentoDeCaixa.Size = new System.Drawing.Size(350, 19);
            this.txtNomeOperadorFechamentoDeCaixa.TabIndex = 7;
            // 
            // lblFechamentoDeCaixa
            // 
            this.lblFechamentoDeCaixa.AutoSize = true;
            this.lblFechamentoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechamentoDeCaixa.Location = new System.Drawing.Point(149, 54);
            this.lblFechamentoDeCaixa.Name = "lblFechamentoDeCaixa";
            this.lblFechamentoDeCaixa.Size = new System.Drawing.Size(219, 20);
            this.lblFechamentoDeCaixa.TabIndex = 6;
            this.lblFechamentoDeCaixa.Text = "FECHAMENTO DE CAIXA";
            // 
            // lblNomeOperadorFechamentoDeCaixa
            // 
            this.lblNomeOperadorFechamentoDeCaixa.AutoSize = true;
            this.lblNomeOperadorFechamentoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeOperadorFechamentoDeCaixa.Location = new System.Drawing.Point(158, 120);
            this.lblNomeOperadorFechamentoDeCaixa.Name = "lblNomeOperadorFechamentoDeCaixa";
            this.lblNomeOperadorFechamentoDeCaixa.Size = new System.Drawing.Size(196, 20);
            this.lblNomeOperadorFechamentoDeCaixa.TabIndex = 10;
            this.lblNomeOperadorFechamentoDeCaixa.Text = "NOME DO OPERADOR";
            // 
            // FechamentoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.lblNomeOperadorFechamentoDeCaixa);
            this.Controls.Add(this.btnFecharCaixa);
            this.Controls.Add(this.dtpFechamentoDeCaixa);
            this.Controls.Add(this.txtNomeOperadorFechamentoDeCaixa);
            this.Controls.Add(this.lblFechamentoDeCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FechamentoCaixa";
            this.Text = "FechamentoCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharCaixa;
        private System.Windows.Forms.DateTimePicker dtpFechamentoDeCaixa;
        private System.Windows.Forms.TextBox txtNomeOperadorFechamentoDeCaixa;
        private System.Windows.Forms.Label lblFechamentoDeCaixa;
        private System.Windows.Forms.Label lblNomeOperadorFechamentoDeCaixa;
    }
}