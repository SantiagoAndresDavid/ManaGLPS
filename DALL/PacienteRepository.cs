using System;
using System.Data.Common;
using System.Data.SqlClient;
using Entity;

namespace DALL
{
    public class PacienteRepository
    {
        DbConnection _connection;

        public PacienteRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarPaciente(Paciente paciente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Pacientes (Identificacion,Nombre,Apellido,Edad,Telefono,Estado) values (@Identificacion,@Nombre,@Apellido,@Edad,@Telefono,@Estado)";
                command.Parameters.Add(new SqlParameter("@Identificacion", paciente.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", paciente.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", paciente.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", paciente.Edad));
                command.Parameters.Add(new SqlParameter("@Telefono", paciente.Telefono));
                command.Parameters.Add(new SqlParameter("@Estado", paciente.Afiliacion));
                command.ExecuteNonQuery();
            }
        }



        public Paciente BuscarPorID(int Identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Pacientes where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", Identificacion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Paciente paciente = new Paciente();

                        paciente.Identificacion = reader.GetInt32(0);
                        paciente.Nombre = reader.GetString(1);
                        paciente.Apellido = reader.GetString(2);
                        paciente.Edad = reader.GetInt32(3);
                        paciente.Telefono = reader.GetInt32(4);
                        paciente.Afiliacion = reader.GetString(5);

                        return paciente;
                    }
                    reader.Close();
                }

                return null;
            }

        }
        
        public string BuscarEstado(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Pacientes where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", codigo));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader["Estado"].ToString();
                    }
                }
                reader.Close();
            }

            return null;
        }
        public void Activar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Pacientes set Estado=@Estado where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Activado"));
                command.ExecuteNonQuery();
            }
        }

        public void Desactivar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Pacientes set Estado=@Estado where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Desactivado"));
                command.ExecuteNonQuery();
            }
        }
    }
}