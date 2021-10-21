using System;

namespace Entity
{
    public class Usuario
    {
        public string NombreDeUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }

        public Usuario(string nombreDeUsuario, string contraseña, string rol, string email)
        {
            NombreDeUsuario = nombreDeUsuario;
            Contraseña = contraseña;
            Rol = rol;
            Email = email;
        }
    }

}
