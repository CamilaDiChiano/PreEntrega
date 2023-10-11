using AppClientesData;
using Microsoft.EntityFrameworkCore;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClienteBussiness
{
    public static class VentaBussiness
    {
        public static void ObtenerVenta(int id, DbContext _dbContext)
        {
           VentaData.ObtenerVenta(id, _dbContext);
        }

        public static void ListarVentas(DbContext _dbContext)
        {
           VentaData.ListarVentas(_dbContext);
        }

        public static void CrearVenta(Venta venta, DbContext _dbContext)
        {
            VentaData.CrearVenta(venta, _dbContext);
        }

        public static void ModificarVenta(Venta ventaNueva, DbContext _dbContext)
        {
           VentaData.ModificarVenta(ventaNueva, _dbContext);
        }

        public static void EliminarVenta(int id, DbContext _dbContext)
        {
            VentaData.EliminarVenta(id, _dbContext);
        }
    }
}
