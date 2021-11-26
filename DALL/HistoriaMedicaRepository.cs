using Entity;
using System.Data.Common;
using System.Data.SqlClient;


namespace DALL
{
    public class HistoriaMedicaRepository
    {
        DbConnection _connection;

        public HistoriaMedicaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarHistoriaMedica(HistoriaMedica historiaMedica)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "insert into HistoriasMedicas (Titulo, FechaCreacion, UltimaEdicion, FechaFinalizada,Estado,CodigoPacientes) values (@Titulo, @FechaCreacion, @UltimaEdicion, @FechaFinalizada, @Estado,@CodigoPacientes)";
                command.Parameters.Add(new SqlParameter("@Titulo", historiaMedica.Titutlo));
                command.Parameters.Add(new SqlParameter("@FechaCreacion", historiaMedica.FechaDeCreacion));
                command.Parameters.Add(new SqlParameter("@UltimaEdicion", historiaMedica.UltimaFechaDeEdicion));
                command.Parameters.Add(new SqlParameter("@FechaFinalizada", historiaMedica.FechaDeFinalizacion));
                command.Parameters.Add(new SqlParameter("@Estado", historiaMedica.Estado));
                command.Parameters.Add(new SqlParameter("@CodigoPacientes",historiaMedica.Paciente.Identificacion));
                command.ExecuteNonQuery();
            }
        }

        public void Activar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update HistoriasMedicas set Estado=@Estado where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Activado"));
                command.ExecuteNonQuery();
            }
        }

        public HistoriaMedica BuscarHistoriaMedica(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from HistoriasMedicas where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo",codigo));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HistoriaMedica historiaMedica = new HistoriaMedica();
                        historiaMedica.Titutlo = reader.GetString(1);
                        historiaMedica.FechaDeCreacion = reader.GetDateTime(2);
                        historiaMedica.UltimaFechaDeEdicion = reader.GetDateTime(3);
                        historiaMedica.FechaDeFinalizacion = reader.GetDateTime(4);
                        historiaMedica.Estado = reader.GetString(5);

                        return historiaMedica;
                    }
                    reader.Close();
                }

                return null;
            }

        }

        public void Desactivar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update HistoriasMedicas set Estado=@Estado where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Desactivado"));
                
                command.ExecuteNonQuery();
            }
        }

        public string BuscarEstado(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from HistoriasMedicas where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo",codigo));
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

        public int BuscarIdentificacionPaciente(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from HistoriasMedicas where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo",codigo));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
;                       return reader.GetInt32(6);
                    }
                }
                reader.Close();
            }
            return 0;
        }
        
        
        
    }
}