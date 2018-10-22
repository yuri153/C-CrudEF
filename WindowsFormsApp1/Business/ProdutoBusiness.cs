using WindowsFormsApp1.Dominios;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApp1.Telas;

namespace WindowsFormsApp1.Business
{
    public class ProdutoBusiness
    {
        public void SalvarProduto(string valor, string nome, string descricao, TelaProduto tela)
        {
            //Validar campos produto: (valor e nome)
            if (ValidarProduto(valor, nome))
            {

                var produto = new Produto
                {
                    Nome = nome,
                    Valor = double.Parse(valor),
                    Descricao = descricao
                };

                using (var ctx = new Contexto())
                {
                    try
                    {
                        //Verifica se o nome já foi cadastrado no banco de dados
                        var existe = ctx.Produto.Any(a => a.Nome == nome);

                        if (!existe)
                        {
                            //Adiciona o novo produto
                            ctx.Produto.Add(produto);
                            ctx.SaveChanges();


                            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            tela.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Esse produto já foi cadastrado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Erro de conexão com o banco de dados.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void SalvarEditProduto(string id, string valor, string nome, string descricao, TelaProduto tela)
        {
            //Validar campos produto: (valor e nome)
            if (ValidarProduto(valor, nome))
            {
                var produto = new Produto
                {
                    ID = int.Parse(id),
                    Nome = nome,
                    Valor = double.Parse(valor),
                    Descricao = descricao
                };

                using (var ctx = new Contexto())
                {
                    try
                    {
                        //Verifica se o nome já foi cadastrado no banco de dados
                        var existe = ctx.Produto.Any(a => a.Nome == produto.Nome && a.ID != produto.ID);

                        if (!existe)
                        {

                            // Busca pela PK -Retorna apenas um
                            var produtoBanco = ctx.Produto.Find(produto.ID);

                            //Coloca os novos valores
                            produtoBanco.Nome = produto.Nome;
                            produtoBanco.Valor = produto.Valor;
                            produtoBanco.Descricao = produto.Descricao;

                            ctx.SaveChanges();
                            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            tela.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Esse produto já foi cadastrado!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (System.Data.SqlClient.SqlException)
                    {
                        MessageBox.Show("Erro de conexão com o banco de dados.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        public void ExcluirProduto(string id)
        {
            using (var ctx = new Contexto())
            {
                try
                {
                    // Busca pela PK - Retorna apenas um
                    var produtoBanco = ctx.Produto.Find(int.Parse(id));

                    try
                    {
                        //Deleta o produto selecionado
                        ctx.Produto.Remove(produtoBanco);
                        ctx.SaveChanges();
                        MessageBox.Show("Produto excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (System.ArgumentNullException)
                    {
                        MessageBox.Show("Este produto já foi excluído.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public bool ValidarProduto(string valor, string nome)
        {
            if (string.IsNullOrWhiteSpace(valor) || !double.TryParse(valor, out double dbValor))
            {
                MessageBox.Show("Verifique o valor!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Digite um nome!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}