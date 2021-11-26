using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DALL
{
    public class ConsultaRepository
    {
        DbConnection _connection;

        public ConsultaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public void GuardarConsulta(ConsultaMedica consulta, int codigoHistoriaMedica)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "insert into ConsultasMedicas (Estado,FaseTratamiento,FechaCreada,CodigoHistoriaMedica) values (@Estado,@FaseTratamiento,@FechaCreada,@CodigoHistoriaMedica)";
                command.Parameters.Add(new SqlParameter("@Estado", consulta.Estado));
                command.Parameters.Add(new SqlParameter("@FaseTratamiento", consulta.FaseTratamiento));
                command.Parameters.Add(new SqlParameter("@FechaCreada", consulta.FechaCreada));
                command.Parameters.Add(new SqlParameter("@CodigoHistoriaMedica", codigoHistoriaMedica));
                command.ExecuteNonQuery();
            }
        }

        public int BuscarCodigoCansulta(int codigo, DateTime fechaCreada)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "select * from ConsultasMedicas where CodigoHistoriaMedica=@CodigoHistoriaMedica and  FechaCreada=@FechaCreada";
                command.Parameters.Add(new SqlParameter("@CodigoHistoriaMedica", codigo));
                command.Parameters.Add(new SqlParameter("@FechaCreada", fechaCreada));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int codigoConsulta = 0;
                    while (reader.Read())
                    {
                        codigoConsulta = reader.GetInt32(0);
                    }

                    reader.Close();
                    return codigoConsulta;
                }

                return 0;
            }
        }

        public ConsultaMedica BuscarConsultaMedica(int codigoHistoriaMedica, int codigoConsulta)
        {
            var consulta = ArmarConsulta(codigoHistoriaMedica, codigoConsulta);
            if (consulta != null)
            {
                foreach (CIE cie in ArmarCIEDiagnosticos(codigoConsulta))
                {
                    consulta.Diagnostico.AgregarCIE(cie);
                }
            }

            return consulta;
        }

        public ConsultaMedica ArmarConsulta(int codigoHistoriaMedica, int codigoConsulta)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "select DISTINCT ConsultasMedicas.Estado,ConsultasMedicas.FaseTratamiento,ConsultasMedicas.FechaCreada,ValoracionesMultidiciplinar.InformeIndividual,ValoracionesMultidiciplinar.InformeGrupal,CategoriaEvaluaciones.EscalaDolor,CategoriaEvaluaciones.Localizacion,CategoriaEvaluaciones.FrecuenciaAumento,CategoriaEvaluaciones.FrecuenciaDisminucion,Medicaciones.Prescripcion,Medicaciones.Rehabilitacion,Diagnosticos.ObservacionesExtra,ValoracionesIngreso.Deportiva,ValoracionesIngreso.DiagnosticoRemision,ValoracionesIngreso.ImagenDiagnostica,Lesiones.Caracteristica,Lesiones.Antecedentes from ConsultasMedicas join ValoracionesMultidiciplinar on ConsultasMedicas.Codigo = ValoracionesMultidiciplinar.CodigoConsultaMedica join Medicaciones on ConsultasMedicas.Codigo = Medicaciones.CodigoConsultaMedica join Diagnosticos on ConsultasMedicas.Codigo = Diagnosticos.CodigoConsultaMedica join ValoracionesIngreso on ConsultasMedicas.Codigo = ValoracionesIngreso.CodigoConsultaMedica join CategoriaEvaluaciones on ValoracionesMultidiciplinar.Codigo = CategoriaEvaluaciones.CodigoValoracionMultiDiciplinar join CIE on Diagnosticos.Codigo = CIE.CodigoDiagnostico join Lesiones on ValoracionesIngreso.Codigo = Lesiones.CodigoValoracionIngreso where ConsultasMedicas.CodigoHistoriaMedica = @CodigoConsultaMedica and ConsultasMedicas.Codigo = @Codigo";
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica", codigoHistoriaMedica));
                command.Parameters.Add(new SqlParameter("@Codigo", codigoConsulta));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ConsultaMedica consulta = new ConsultaMedica();
                    while (reader.Read())
                    {
                        consulta.Estado = reader.GetString(0);
                        consulta.FaseTratamiento = reader.GetInt32(1);
                        consulta.FechaCreada = reader.GetDateTime(2);
                        consulta.ValoracionMultiDiciplinar = new ValoracionMultiDiciplinar(reader.GetString(3),
                            reader.GetString(4), reader.GetInt32(5), reader.GetString(6), reader.GetInt32(7),
                            reader.GetInt32(8));
                        consulta.Medicacion = new Medicacion(reader.GetString(9), reader.GetString(10));
                        consulta.Diagnostico = new Diagnostico(reader.GetString(11));
                        consulta.ValoracionIngreso = new ValoracionIngreso(reader.GetString(12), reader.GetString(13),
                            reader.GetString(14), reader.GetString(15), reader.GetString(16));
                    }

                    reader.Close();
                    return consulta;
                }
                return null;
            }
        }

        public IList<CIE> ArmarCIEDiagnosticos(int codigoConsulta)
        {
            IList<CIE> listaCIE = new List<CIE>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "select CIE.Codigo,CIE.Descripcion from Diagnosticos join CIE on Diagnosticos.Codigo = CIE.CodigoDiagnostico  where Diagnosticos.CodigoConsultaMedica = @CodigoConsultaMedica ";
                command.Parameters.Add(new SqlParameter("@CodigoConsultaMedica", codigoConsulta));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        CIE cie = new CIE();
                        cie.Codigo = reader.GetString(0);
                        cie.Descripcion = reader.GetString(1);
                        listaCIE.Add(cie);
                    }

                    reader.Close();
                    return listaCIE;
                }

                return null;
            }
        }

        public string BuscarEstado(int codigo, int codigoHistoriaMedica)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText =
                    "select * from ConsultasMedicas where Codigo=@Codigo and CodigoHistoriaMedica=@CodigoHistoriaMedica";
                command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                command.Parameters.Add(new SqlParameter("@CodigoHistoriaMedica", codigoHistoriaMedica));
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

        public void Desactivar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update ConsultasMedicas set Estado=@Estado where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Desactivado"));

                command.ExecuteNonQuery();
            }
        }

        public void Activar(int codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update ConsultasMedicas set Estado=@Estado where Codigo=@Codigo";
                command.Parameters.Add(new SqlParameter("@Codigo", codigo));
                command.Parameters.Add(new SqlParameter("@Estado", "Activado"));
                command.ExecuteNonQuery();
            }
        }
    }
}