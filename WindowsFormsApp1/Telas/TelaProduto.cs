using System;
using System.Windows.Forms;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.Telas
{
    public partial class TelaProduto : Form
    {
        public TelaProduto(string id, string nome, string descricao, string valor)
        {
            InitializeComponent();
            labelID.Text = (id);
            textBoxValorProduto.Text = valor;
            textBoxNomeProduto.Text = nome;
            textBoxDescricaoProduto.Text = descricao;
        }

        public TelaProduto()
        {
            InitializeComponent();
            labelID.Visible = false;
            labelProdutoId.Visible = false;
            botaoExcluir.Visible = false;
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            var produtoBusiness = new ProdutoBusiness();

            if (string.IsNullOrWhiteSpace(labelID.Text))
            {
                produtoBusiness.SalvarProduto(textBoxValorProduto.Text, textBoxNomeProduto.Text, textBoxDescricaoProduto.Text, this);
            }
            else
            {
                produtoBusiness.SalvarEditProduto(labelID.Text, textBoxValorProduto.Text, textBoxNomeProduto.Text, textBoxDescricaoProduto.Text, this);
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            var produtoBusiness = new ProdutoBusiness();
            produtoBusiness.ExcluirProduto(labelID.Text);
            Dispose();
        }

        private void textBoxValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Valida se foi digitado letras ou espaço
            if ((Char.IsLetter(e.KeyChar) || e.KeyChar != ',' && !(char.IsNumber(e.KeyChar))) || Char.IsWhiteSpace(e.KeyChar))
            {
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }
    }
}