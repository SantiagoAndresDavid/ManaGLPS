using System;
using DALL;
using Entity;

namespace BLL
{
    public class ConsultaService
    {
        ConnectionManager _connectionManager;
        ConsultaRepository _consultaRepository;

        DiagnosticoRepository _diagnosticoRepository;
        ValoracionIngresoRepository _valoracionIngresoRepository;
        LesionRepository _lesionRepository;
        MedicacionesRepository _medicacionesRepository;
        ValoracionMultidiciplinarRepository _valoracionMultidiciplinarRepository;
        CategoriaEvaluacionRepository _categoriaEvaluacionRepository;
        CIERepository _CIERepository;


        public ConsultaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _consultaRepository = new ConsultaRepository(_connectionManager.Connection);
            _diagnosticoRepository = new DiagnosticoRepository(_connectionManager.Connection);
            _valoracionIngresoRepository= new ValoracionIngresoRepository(_connectionManager.Connection);
            _lesionRepository = new LesionRepository(_connectionManager.Connection);
            _medicacionesRepository = new MedicacionesRepository(_connectionManager.Connection);
            _valoracionMultidiciplinarRepository =
                new ValoracionMultidiciplinarRepository(_connectionManager.Connection);
            _categoriaEvaluacionRepository = new CategoriaEvaluacionRepository(_connectionManager.Connection);
            _CIERepository = new CIERepository(_connectionManager.Connection);
        }

        public string Guardar(ConsultaMedica consultaMedica, int codigoHistoriaMedica)
        {
            try
            {
                _connectionManager.Open();
                _consultaRepository.GuardarConsulta(consultaMedica, codigoHistoriaMedica);
                int codigoConsulta = _consultaRepository.BuscarCodigoCansulta(codigoHistoriaMedica, consultaMedica.FechaCreada);
                _valoracionMultidiciplinarRepository.GuardarValoracionMultidiciplinar(consultaMedica.ValoracionMultiDiciplinar, codigoConsulta);
                _medicacionesRepository.GuardarMedicacion(consultaMedica.Medicacion, codigoConsulta);
                _diagnosticoRepository.GuardarDiagnostico(consultaMedica.Diagnostico, codigoConsulta);
                int codigoValoracionMultiDiciplinar = _valoracionMultidiciplinarRepository.BuscarCodigoValoracionMultiDiciplinar(codigoConsulta);
                _categoriaEvaluacionRepository.GuardarCategoriaEvaluacion(consultaMedica.ValoracionMultiDiciplinar.CategoriaEvaluacion, codigoValoracionMultiDiciplinar);

                _valoracionIngresoRepository.GuardarValoracionIngreso(consultaMedica.ValoracionIngreso,codigoConsulta);

                int codigoDiagostico = _diagnosticoRepository.BuscarCodigoDiagnostico(codigoConsulta);
                foreach (CIE cie in consultaMedica.Diagnostico.CIE)
                {
                    _CIERepository.GuardarCIE(cie, codigoDiagostico);
                }

                int codigoValidacionIngreso =
                    _valoracionIngresoRepository.BuscarCodigoValoracionIngreso(codigoConsulta);
                _lesionRepository.GuardarLesion(consultaMedica.ValoracionIngreso.Lesion, codigoValidacionIngreso);
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
                _connectionManager.Close();
            }
            finally
            {
                _connectionManager.Close();
            }

            return "Se guardo Con Exito";
        }

        public ConsultaMedica BuscarConsultaMedica(int codigoHistoriaMedica,int codigoConsulta)
        {
            _connectionManager.Open();
            ConsultaMedica consulta = _consultaRepository.BuscarConsultaMedica(codigoHistoriaMedica, codigoConsulta);
            return  consulta;
            _connectionManager.Close();
        }


        public string ModificarEstado(int codigoHistoriaMedica ,int codigoConsulta)
        {
            try
            {
                _connectionManager.Open();
                string estado = _consultaRepository.BuscarEstado(codigoConsulta,codigoHistoriaMedica);
                if(estado.Equals("Desactivado")){
                    _consultaRepository.Activar(codigoConsulta);
                }
                else
                {
                    _consultaRepository.Desactivar(codigoConsulta);
                }    
            }
            catch(Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
                _connectionManager.Close();
            }
            return "No se pudo modificar";
            _connectionManager.Close();
        }


        
    }
}