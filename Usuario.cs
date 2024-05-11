using Desafio01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Usuario
    {
        //Clase: Usuario;
        //Propiedades: Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string NombreUsuario { get; set; }
        private string Contrasenia { get; set; }
        private string Mail { get; set; }

        public Usuario()
        {
            
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Mail = mail;
        }

    }
}
