using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01
{
    public class ProductoVendido
    {
        //Clase: ProductoVendido;
        //Propiedades: Id, IdProducto, Stock, IdVenta

        private int Id { get; set; }
        private int IdProducto { get; set; }
        public int Stock { get; set; }
        private decimal IdVenta { get; set; }

        public ProductoVendido()
        {
        }

        public ProductoVendido(int id, int idProducto, int stock, decimal idVenta)
        {
            Id = id;
            IdProducto = idProducto;
            Stock = stock;
            IdVenta = idVenta;
        }
    }
}
