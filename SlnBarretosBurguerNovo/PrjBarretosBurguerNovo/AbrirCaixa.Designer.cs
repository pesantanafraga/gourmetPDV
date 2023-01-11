namespace PrjBarretosBurguerNovo
{
    partial class AbrirCaixa
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
            this.txtFundoDeCaixa = new System.Windows.Forms.TextBox();
            this.lblFundoDeCaixa = new System.Windows.Forms.Label();
            this.dtpFundoDeCaixa = new System.Windows.Forms.DateTimePicker();
            this.btnAbrirCaixa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFundoDeCaixa
            // 
            this.txtFundoDeCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFundoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFundoDeCaixa.Location = new System.Drawing.Point(81, 117);
            this.txtFundoDeCaixa.Name = "txtFundoDeCaixa";
            this.txtFundoDeCaixa.Size = new System.Drawing.Size(350, 19);
            this.txtFundoDeCaixa.TabIndex = 3;
            // 
            // lblFundoDeCaixa
            // 
            this.lblFundoDeCaixa.AutoSize = true;
            this.lblFundoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundoDeCaixa.Location = new System.Drawing.Point(168, 50);
            this.lblFundoDeCaixa.Name = "lblFundoDeCaixa";
            this.lblFundoDeCaixa.Size = new System.Drawing.Size(160, 20);
            this.lblFundoDeCaixa.TabIndex = 2;
            this.lblFundoDeCaixa.Text = "FUNDO DE CAIXA";
            // 
            // dtpFundoDeCaixa
            // 
            this.dtpFundoDeCaixa.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFundoDeCaixa.CustomFormat = "d/MM/yyyy HH:mm";
            this.dtpFundoDeCaixa.Enabled = false;
            this.dtpFundoDeCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFundoDeCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFundoDeCaixa.Location = new System.Drawing.Point(81, 204);
            this.dtpFundoDeCaixa.Name = "dtpFundoDeCaixa";
            this.dtpFundoDeCaixa.Size = new System.Drawing.Size(350, 26);
            this.dtpFundoDeCaixa.TabIndex = 4;
            // 
            // btnAbrirCaixa
            // 
            this.btnAbrirCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaixa.Location = new System.Drawing.Point(172, 300);
            this.btnAbrirCaixa.Name = "btnAbrirCaixa";
            this.btnAbrirCaixa.Size = new System.Drawing.Size(156, 33);
            this.btnAbrirCaixa.TabIndex = 5;
            this.btnAbrirCaixa.Text = "ABRIR CAIXA";
            this.btnAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // AbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(520, 400);
            this.Controls.Add(this.btnAbrirCaixa);
            this.Controls.Add(this.dtpFundoDeCaixa);
            this.Controls.Add(this.txtFundoDeCaixa);
            this.Controls.Add(this.lblFundoDeCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AbrirCaixa";
            this.Text = "AbrirCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFundoDeCaixa;
        private System.Windows.Forms.Label lblFundoDeCaixa;
        private System.Windows.Forms.DateTimePicker dtpFundoDeCaixa;
        private System.Windows.Forms.Button btnAbrirCaixa;
    }
}