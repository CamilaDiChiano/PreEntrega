using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace AppClienteBussiness
{
    public static class ProductoBussiness
    {
        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ListarProductos(int id, Producto producto)
        {            
            ProductoData.ModificarProducto(id, producto);
        }

        public static void ModificarProducto(int id, Producto productoNuevo)
        {
            ProductoData.ModificarProducto(id, productoNuevo);
        }

        public static void EliminarProducto(int id)
        {
            ProductoData.DeleteProducto(id);
        }
    }
}
