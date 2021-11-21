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
                command.CommandText = "insert into Pacientes (Identificacion,Nombre,Apellidos,Edad,Telefono,Estado) values (@Identificacion,@Nombre,@Apellidos,@Edad,@Telefono,@Estado)";
                command.Parameters.Add(new SqlParameter("@Identicacion", paciente.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre",paciente.Nombre));
                command.Parameters.Add(new SqlParameter("@apellidos",paciente.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", paciente.Edad));
                command.Parameters.Add(new SqlParameter("@Telefono", paciente.Telefono));
                command.Parameters.Add(new SqlParameter("@Estado",paciente.Apellido));
                int fila = command.ExecuteNonQuery();
            }
        }
        
    }
}