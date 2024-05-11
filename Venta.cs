using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Venta
    {
        //Clase: Venta;
        //Propiedades: Id, Comentarios, IdUsuario
        private int Id { get; set; }
        private string Comentarios { get; set; }
        public int IdUsuario { get; set; }

        public Venta()
        {
        }

        public Venta(int id, string comentarios, int idUsuario)
        {
            Id = id;
            Comentarios = comentarios;
            IdUsuario = idUsuario;
        }
    }
}
