using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppClientesData;
using AppClientesBussiness;
using SistemaGestionEntities;

namespace AppClienteBussiness
{
    public static class UsuarioBussiness
    {
        public static void ObtenerUsuario(int id, DbContext dbContext)
        {
            UsuarioData.ObtenerUsuario(id, dbContext);
        }

        public static void ListarUsuarios(DbContext dbContext)
        {
            UsuarioData.ListarUsuarios(dbContext);
        }

        public static void CrearUsuario(Usuario user, DbContext dbContext)
        {
           UsuarioData.CrearUsuario(user, dbContext);
        }

        public static void ModificarUsuario(Usuario usuarioNuevo, DbContext _dbContext)
        {
            UsuarioData.ModificarUsuario(usuarioNuevo, _dbContext);
        }

        public static void EliminarUsuario(int id, DbContext dbContext)
        {
            UsuarioData.EliminarUsuario(id, dbContext);
        }
    }
}
