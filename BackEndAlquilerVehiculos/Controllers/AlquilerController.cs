using BackEndAlquilerVehiculos.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos;

namespace BackEndAlquilerVehiculos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlquilerController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("detalleAlquiler")]
        public List<DetalleAlquilerDto> Get()
        {
           var detallesAlquiler= _context.Alquiler.Include(c=>c.Cliente).Include(ca=> ca.Carro)
                .Select(da=> new DetalleAlquilerDto
                {
                    Cedula= da.Cliente.Cedula,
                    Nombre= da.Cliente.Nombre,
                    FechaAlquiler= da.Fecha,
                    Marca= da.Carro.Marca,
                    Placa= da.Carro.Placa,
                    TiempoAlquiler=  da.TiempoDias,
                    Saldo =da.Saldo,


                }).ToList();
            return detallesAlquiler;
        }

        [HttpGet]
        [Route("vehiculos")]
        public List<CarroDto> GetVehiculos()
        {
            var vehiculos = _context.Carro
                 .Select(da => new CarroDto
                 {
                     
                     Marca = da.Marca,
                     Placa = da.Placa,
                     Modelo= da.Modelo,
                     Costo= da.Costo,
                     Disponible = da.Disponible,
               


                 }).ToList();
            return vehiculos;
        }

        [HttpGet]
        [Route("alquilerPorDia")]
        public List<AlquileresPorDiaDto> GetAlquilerPorDia()
        {
            var alquileresPorDia = _context.Alquiler
        .GroupBy(a => a.Fecha.Date)
        .Select(g => new AlquileresPorDiaDto
        {
            Dia = g.Key,
            Cantidad = g.Count()
        })
        .OrderBy(g => g.Dia)
        .ToList();
            return alquileresPorDia;
        }

        [HttpGet]
        [Route("alquilerPorMes")]
        public List<AlquileresPorMesDto> GetAlquilerPorMes()
        {
            var alquileresPorMes = _context.Alquiler
                .GroupBy(a => new { a.Fecha.Month })
                .Select(g => new AlquileresPorMesDto
                {
                    Mes = g.Key.Month,
                    Cantidad = g.Count()
                })
                .OrderBy(g => g.Mes)
                .ToList();

            return alquileresPorMes;
        }
    }
}