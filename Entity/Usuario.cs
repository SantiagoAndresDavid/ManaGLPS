using System;

namespace Entity
{
    public class Usuario
    {
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public string TipoDeUsuario { get; set; }
        public string Email { get; set; }

        public Usuario(string nombreDeUsuario, string tipoDeUsuario, string contraseña, string correo)
        {
           
            this.NombreDeUsuario = nombreDeUsuario;
            this.TipoDeUsuario = tipoDeUsuario;
            this.Contraseña = contraseña;
            this.Email = correo;
        }
    }

}
