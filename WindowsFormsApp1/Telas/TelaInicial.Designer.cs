namespace WindowsFormsApp1.Telas
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.botaoCadastroProduto = new System.Windows.Forms.Button();
            this.botaoPesquisaProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCadastroProduto
            // 
            this.botaoCadastroProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroProduto.Location = new System.Drawing.Point(20, 78);
            this.botaoCadastroProduto.Name = "botaoCadastroProduto";
            this.botaoCadastroProduto.Size = new System.Drawing.Size(176, 148);
            this.botaoCadastroProduto.TabIndex = 0;
            this.botaoCadastroProduto.Text = "Cadastrar Produtos";
            this.botaoCadastroProduto.UseVisualStyleBackColor = true;
            this.botaoCadastroProduto.Click += new System.EventHandler(this.botaoCadastroProduto_Click);
            // 
            // botaoPesquisaProduto
            // 
            this.botaoPesquisaProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisaProduto.Location = new System.Drawing.Point(275, 78);
            this.botaoPesquisaProduto.Name = "botaoPesquisaProduto";
            this.botaoPesquisaProduto.Size = new System.Drawing.Size(176, 148);
            this.botaoPesquisaProduto.TabIndex = 1;
            this.botaoPesquisaProduto.Text = "Pesquisar Produtos";
            this.botaoPesquisaProduto.UseVisualStyleBackColor = true;
            this.botaoPesquisaProduto.Click += new System.EventHandler(this.botaoPesquisaProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Olá, seja bem vindo!";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoPesquisaProduto);
            this.Controls.Add(this.botaoCadastroProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(487, 290);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroProduto;
        private System.Windows.Forms.Button botaoPesquisaProduto;
        private System.Windows.Forms.Label label1;
    }
}