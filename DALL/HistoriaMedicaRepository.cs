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
                
                command.CommandText = "insert into HistoriasMedicas (Titulo, FechaCreacion, UltimaEdicion, FechaFinalizada,Estado) values (@Titulo, @FechaCreacion, @UltimaEdicion, @FechaFinalizada, @Estado)";
                command.Parameters.Add(new SqlParameter("@Titulo", historiaMedica.Titutlo));
                command.Parameters.Add(new SqlParameter("@FechaCreacion", historiaMedica.FechaDeCreacion));
                command.Parameters.Add(new SqlParameter("@UltimaEdicion", historiaMedica.UltimaFechaDeEdicion));
                command.Parameters.Add(new SqlParameter("@FechaFinalizada", historiaMedica.FechaDeFinalizacion));
                command.Parameters.Add(new SqlParameter("@Estado", historiaMedica.Estado));

            }
        }
    }
}
