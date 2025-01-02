using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class Alquiler
    {
        [Key]
        public int IdAlquiler { get; set; }
        public DateTime Fecha { get; set; }
        public int TiempoDias { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal Saldo { get; set; }
        public decimal AbonoInicial { get; set; }
        public bool Devuelto { get; set; }

       
        public int IdCliente { get; set; }
        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        public int IdCarro { get; set; }
        [ForeignKey("IdCarro")]
        public Carro Carro { get; set; }

       
        public ICollection<Pago> Pagos { get; set; }
    }
}
