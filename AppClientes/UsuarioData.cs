using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionEntities
{
    public class UsuarioData
    {
        private readonly DbContext _dbContext;

        public UsuarioData(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public static Usuario ObtenerUsuario(int id, DbContext _dbContext)
        {
            return _dbContext.Set<Usuario>().FirstOrDefault(u => u.Id == id);
        }

        public static List<Usuario> ListarUsuarios(DbContext _dbContext)
        {
            return _dbContext.Set<Usuario>().ToList();
        }

        public static void CrearUsuario(Usuario nuevoUsuario, DbContext _dbContext)
        {
            _dbContext.Set<Usuario>().Add(nuevoUsuario);
            _dbContext.SaveChanges();
        }

        public static void ModificarUsuario(Usuario usuarioModificado, DbContext _dbContext)
        {
            _dbContext.Entry(usuarioModificado).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public static void EliminarUsuario(int id, DbContext _dbContext)
        {
            var usuario = _dbContext.Set<Usuario>().FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _dbContext.Set<Usuario>().Remove(usuario);
                _dbContext.SaveChanges();
            }
        }
    }
}
