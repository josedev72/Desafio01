using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class Producto
    {
        //Clase: Producto;
        //Propiedades: Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario

        private int Id { get; set; }
        public string Descripcion { get; set; }
        private decimal Costo { get; set; }
        private decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        private int IdUsuario { get; set; }

        private Producto()
        {
            
        }

        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
    }

}
