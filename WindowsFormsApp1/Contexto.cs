using System.Data.Entity;
using WindowsFormsApp1.Dominios;

namespace WindowsFormsApp1
{
    public class Contexto : DbContext
    {
        public Contexto() : base("conexao")
        {

        }

        public DbSet<Produto> Produto { get; set; }

    }
}
