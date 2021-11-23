using System;
using DALL;
using Entity;

namespace BLL
{
    public class ConsultaService
    {
        ConnectionManager _connectionManager;
        ConsultaRepository _consultaRepository;
        TemporalidadRepository _temporalidadRepository;
        DiagnosticoRepository _diagnosticoRepository;
        ValoracionIngresoRepository _validacionIngresoRepository;
        LesionRepository _lesionRepository;
        MedicacionesRepository _medicacionesRepository;
        ValoracionMultidiciplinarRepository _validacionMultidiciplinarRepository;
        CategoriaEvaluacionRepository _categoriaEvaluacionRepository;
        CIERepository _CIERepository;
        
        
        
        public ConsultaService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _consultaRepository = new ConsultaRepository(_connectionManager.Connection);
            _temporalidadRepository = new TemporalidadRepository(_connectionManager.Connection);
            _diagnosticoRepository = new DiagnosticoRepository(_connectionManager.Connection);
            _validacionIngresoRepository = new ValoracionIngresoRepository(_connectionManager.Connection);
            _lesionRepository = new LesionRepository(_connectionManager.Connection);
            _medicacionesRepository = new MedicacionesRepository(_connectionManager.Connection);
            _validacionMultidiciplinarRepository = new ValoracionMultidiciplinarRepository(_connectionManager.Connection);
            _categoriaEvaluacionRepository = new CategoriaEvaluacionRepository(_connectionManager.Connection);
            _CIERepository = new CIERepository(_connectionManager.Connection);
        }
        
        public string Guardar(ConsultaMedica consultaMedica)
        {
            try
            {
                _connectionManager.Open();
                _consultaRepository.GuardarConsulta(consultaMedica);
                _temporalidadRepository.GuardarTemporalidad(consultaMedica.Temporalidad);
                _validacionMultidiciplinarRepository.GuardarValoracionMultidiciplinar(consultaMedica.ValoracionMultiDiciplinar);
                _categoriaEvaluacionRepository.GuardarCategoriaEvaluacion(consultaMedica.ValoracionMultiDiciplinar.CategoriaEvaluacion);
                _medicacionesRepository.GuardarMedicacion(consultaMedica.Medicacion);
                _validacionIngresoRepository.GuardarValoracionIngreso(consultaMedica.ValoracionIngreso);
                _lesionRepository.GuardarLesion(consultaMedica.ValoracionIngreso.Lesion);
                _diagnosticoRepository.GuardarDiagnostico(consultaMedica.Diagnostico);
                //foreach (CIE cie in consulta.Diagnostico.CIE)
                //{
                //    _CIERepository.GuardarCIE(cie);
                //}
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
            }
            finally
            {
                _connectionManager.Close();
            }

            return "";
        }
    }
}