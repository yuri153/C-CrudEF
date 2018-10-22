namespace WindowsFormsApp1.Telas
{
    partial class TelaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaProduto));
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.textBoxValorProduto = new System.Windows.Forms.TextBox();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.valorProduto = new System.Windows.Forms.Label();
            this.descricaoProduto = new System.Windows.Forms.Label();
            this.nomeProduto = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelProdutoId = new System.Windows.Forms.Label();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCancelar.Location = new System.Drawing.Point(594, 374);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(130, 60);
            this.botaoCancelar.TabIndex = 15;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.Location = new System.Drawing.Point(201, 374);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(130, 60);
            this.botaoSalvar.TabIndex = 14;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(201, 163);
            this.textBoxDescricaoProduto.MaxLength = 60;
            this.textBoxDescricaoProduto.Multiline = true;
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(523, 188);
            this.textBoxDescricaoProduto.TabIndex = 13;
            // 
            // textBoxValorProduto
            // 
            this.textBoxValorProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorProduto.Location = new System.Drawing.Point(201, 113);
            this.textBoxValorProduto.MaxLength = 10;
            this.textBoxValorProduto.Name = "textBoxValorProduto";
            this.textBoxValorProduto.Size = new System.Drawing.Size(100, 26);
            this.textBoxValorProduto.TabIndex = 12;
            this.textBoxValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValorProduto_KeyPress);
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(201, 61);
            this.textBoxNomeProduto.MaxLength = 60;
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(523, 26);
            this.textBoxNomeProduto.TabIndex = 11;
            // 
            // valorProduto
            // 
            this.valorProduto.AutoSize = true;
            this.valorProduto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProduto.Location = new System.Drawing.Point(31, 111);
            this.valorProduto.Name = "valorProduto";
            this.valorProduto.Size = new System.Drawing.Size(55, 23);
            this.valorProduto.TabIndex = 10;
            this.valorProduto.Text = "Valor";
            // 
            // descricaoProduto
            // 
            this.descricaoProduto.AutoSize = true;
            this.descricaoProduto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProduto.Location = new System.Drawing.Point(31, 161);
            this.descricaoProduto.Name = "descricaoProduto";
            this.descricaoProduto.Size = new System.Drawing.Size(99, 23);
            this.descricaoProduto.TabIndex = 9;
            this.descricaoProduto.Text = "Descrição";
            // 
            // nomeProduto
            // 
            this.nomeProduto.AutoSize = true;
            this.nomeProduto.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProduto.Location = new System.Drawing.Point(31, 59);
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.Size = new System.Drawing.Size(163, 23);
            this.nomeProduto.TabIndex = 8;
            this.nomeProduto.Text = "Nome do Produto";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(145, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 23);
            this.labelID.TabIndex = 16;
            // 
            // labelProdutoId
            // 
            this.labelProdutoId.AutoSize = true;
            this.labelProdutoId.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProdutoId.Location = new System.Drawing.Point(31, 23);
            this.labelProdutoId.Name = "labelProdutoId";
            this.labelProdutoId.Size = new System.Drawing.Size(108, 23);
            this.labelProdutoId.TabIndex = 17;
            this.labelProdutoId.Text = "Produto ID:";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluir.Location = new System.Drawing.Point(401, 374);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(130, 60);
            this.botaoExcluir.TabIndex = 18;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Máximo de 60 Caractéres";
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.labelProdutoId);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.textBoxValorProduto);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.valorProduto);
            this.Controls.Add(this.descricaoProduto);
            this.Controls.Add(this.nomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "TelaProduto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        public System.Windows.Forms.TextBox textBoxValorProduto;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label valorProduto;
        private System.Windows.Forms.Label descricaoProduto;
        private System.Windows.Forms.Label nomeProduto;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelProdutoId;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Label label1;
    }
}