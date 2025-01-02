using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class Carro
    {
        [Key]
        public int IdCarro { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Costo { get; set; }
        public bool Disponible { get; set; }

        
        public ICollection<Alquiler> Alquileres { get; set; }
    }
}
