using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using AppClientesData;

namespace AppClienteBussiness
{
    public static class ProductoVendidoBussiness
    {
        public static void ObtenerProductoVendido(int id, DbContext dbContext)
        {
            ProductoVendidoData.ObtenerProductoVendido(id, dbContext);
        }

        public static void ListarProductosVendidos()
        {
            ProductoVendidoData.ListProductosVendidos();
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            ProductoVendidoData.crearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoNuevo)
        {
            ProductoVendidoData.ModificarProductoVendido(id, productoVendidoNuevo);
        }

        public static void EliminarProductoVendido(int id)
        {
            ProductoVendidoData.eliminarProductoVendido(id);
        }
    }
}
