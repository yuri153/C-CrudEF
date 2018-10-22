using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Telas
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void botaoCadastroProduto_Click(object sender, EventArgs e)
        {
            TelaProduto tela = new TelaProduto();
            tela.Show();
        }

        private void botaoPesquisaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                TelaPesquisa tela = new TelaPesquisa();
                tela.Show();
            }
            catch (System.ObjectDisposedException)
            {

            }
        }
    }
}