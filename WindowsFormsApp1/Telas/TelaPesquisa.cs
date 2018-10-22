using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Telas
{
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();

            using (var ctx = new Contexto())
            {
                try
                {
                    var dadosTabela = ctx.Produto.ToList();
                    gridPesquisa.DataSource = dadosTabela;
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Dispose();
                }
            }
        }

        private void gridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var grid = ((System.Windows.Forms.DataGridView)sender);
                var id = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                var nome = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                var descricao = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                var valor = grid.Rows[e.RowIndex].Cells[3].Value.ToString();

                var tela = new TelaProduto(id, nome, descricao, valor);

                tela.Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Erro de conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dispose();
            }
        }

        private void botaoPesquisar_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (var ctx = new Contexto())
                {
                    //Busca por nome
                    var listProdutosEncontrados = ctx.Produto.Where(a => a.Nome.StartsWith(textBoxNomePesquisa.Text)).ToList();
                    gridPesquisa.DataSource = listProdutosEncontrados;
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Erro de conexão com o banco de dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Dispose();
            }
        }
    }
}