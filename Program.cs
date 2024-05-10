using System;

namespace Desafio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instanciar clases
            // En la declaracion de las clases se codificó constructor vacio y completo para poder instancias con y sin parametros
            Producto producto = new Producto();
            Usuario usuario = new Usuario();
            Venta venta = new Venta();
            ProductoVendido productoVendido = new ProductoVendido();

            Console.WriteLine("Desafio 01!");
        }
    }
}