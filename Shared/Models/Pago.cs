using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Valor { get; set; }

        public int IdAlquiler { get; set; }
        public Alquiler Alquiler { get; set; }
    }
}
