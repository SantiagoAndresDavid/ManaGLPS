using System;
using System.Collections.Generic;
using DALL;
using Entity;

namespace BLL
{
    public class PacienteService
    {
        PacienteRepository _pacienteRepository;
        ConnectionManager _connectionManager;


        public PacienteService(string connectionString)
        {
            _connectionManager = new ConnectionManager(connectionString);
            _pacienteRepository = new PacienteRepository(_connectionManager.Connection);
        }
        
        public string Guardar(Paciente paciente)
        {
            try
            {
                _connectionManager.Open();
                _pacienteRepository.GuardarPaciente(paciente);
            }
            
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
            }
            finally
            {
                _connectionManager.Close();
            }

            return "se guardo con exito";
        }
        
        public Paciente buscarPaciente(int Identificacion)
        {
            try
            {
                _connectionManager.Open();
               return _pacienteRepository.BuscarPorID(Identificacion);

            }
            catch
            {
                _connectionManager.Close();
            }
            _connectionManager.Close();
            return null;
        }

        public string Modificar(int codigo)
        {
            try
            {
                _connectionManager.Open();
                string estado = _pacienteRepository.BuscarEstado(codigo);
                if(estado.Equals("Desactivado")){
                    _pacienteRepository.Activar(codigo);
                }
                else
                {
                    _pacienteRepository.Desactivar(codigo);
                }
                
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error" + e.Message;
                _connectionManager.Close();
            }
            _connectionManager.Close();
            return "se modifico con Exito";
        }
        
        public IList<Paciente> BuscarPacientes()
        {
            try
            {
                _connectionManager.Open();
                return _pacienteRepository.BuscarPacientes();

            }
            catch
            {
                _connectionManager.Close();
            }
            _connectionManager.Close();
            return null;
        }
            
    }
}