using Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class UsuarioRepository
    {
        DbConnection _connection;

        public UsuarioRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarUsuario(Usuario usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Usuario (Correo, NombreUsuario, Rol, Contraseña) values (@Correo, @NombreUsuario, @Rol, @Contraseña)";
                command.Parameters.Add(new SqlParameter("@Correo", usuario.Email));
                command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreDeUsuario));
                command.Parameters.Add(new SqlParameter("@Rol", usuario.Rol));
                command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contraseña));

                int fila = command.ExecuteNonQuery();

            }
        }
        
        
    }
}
