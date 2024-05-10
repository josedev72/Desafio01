﻿using System;
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

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public Producto()
        {
            
        }

        public Producto(int id, string descripcion, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = preciVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }
    }

}
