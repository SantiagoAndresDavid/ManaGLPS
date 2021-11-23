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
                command.CommandText = "insert into Usuarios (Correo, NombreUsuario, Rol, Contraseña) values (@Correo, @NombreUsuario, @Rol, @Contraseña)";
                command.Parameters.Add(new SqlParameter("@Correo", usuario.Email));
                command.Parameters.Add(new SqlParameter("@NombreUsuario", usuario.NombreDeUsuario));
                command.Parameters.Add(new SqlParameter("@Rol", usuario.Rol));
                command.Parameters.Add(new SqlParameter("@Contraseña", usuario.Contraseña));

                int fila = command.ExecuteNonQuery();

            }
        }

        public Usuario buscarPorNombre(string nombreUsuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Usuarios where NombreUsuario=@NombreUsuario";
                command.Parameters.Add(new SqlParameter("@NombreUsuario",nombreUsuario));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Email = reader.GetString(1);
                        usuario.NombreDeUsuario = reader.GetString(2);
                        usuario.Rol = reader.GetString(3);
                        usuario.Contraseña = reader.GetString(4);
                        return usuario;
                    }
                }
                reader.Close();
            }
            return null;
        }
    }
}
