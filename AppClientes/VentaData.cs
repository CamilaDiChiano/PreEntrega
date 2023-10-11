using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class VentaData
    {
        private readonly DbContext _dbContext;

        public VentaData(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public static void ObtenerVenta(int id, DbContext _dbContext)
        {
            return _dbContext.Set<Venta>().FirstOrDefault(v => v.Id == id);
        }

        public static List<Venta> ListarVentas(DbContext _dbContext)  
        {
            return _dbContext.Set<Venta>().ToList();
        }

        public static void CrearVenta(Venta nuevaVenta, DbContext _dbContext)
        {
            if (nuevaVenta == null)
                throw new ArgumentNullException(nameof(nuevaVenta));

            _dbContext.Set<Venta>().Add(nuevaVenta);
            _dbContext.SaveChanges();
        }

        public static void ModificarVenta(Venta ventaModificada, DbContext _dbContext)
        {
            if (ventaModificada == null)
                throw new ArgumentNullException(nameof(ventaModificada));

            _dbContext.Entry(ventaModificada).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public static void EliminarVenta(int id, DbContext _dbContext)
        {
            var venta = _dbContext.Set<Venta>().FirstOrDefault(v => v.Id == id);
            if (venta != null)
            {
                _dbContext.Set<Venta>().Remove(venta);
                _dbContext.SaveChanges();
            }
        }
    }
}
