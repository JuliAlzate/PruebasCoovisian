using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos
{
    public class CarroDto
    {

        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Costo { get; set; }
        public bool Disponible { get; set; }
    }
}
