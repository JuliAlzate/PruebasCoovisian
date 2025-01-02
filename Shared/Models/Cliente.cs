using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }

        public ICollection<Alquiler> Alquileres { get; set; }
    }
}
