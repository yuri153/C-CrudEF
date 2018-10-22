using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Dominios
{

    [Table("dbo.Produto")]
    public class Produto
    {

        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }


    }
}