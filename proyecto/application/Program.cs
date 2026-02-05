using System;
using System.Collections.Generic;
using core; // For Articulo and ListadoArticulos
using application; // For AgregarArticulo, ConsultarTodos, MenorADies

namespace application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Gestión de Artículos ---");

            while (true)
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar Artículo");
                Console.WriteLine("2. Consultar Todos los Artículos");
                Console.WriteLine("3. Consultar Artículos con Stock Menor a 10");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarNuevoArticulo();
                        break;
                    case "2":
                        ListarTodosLosArticulos();
                        break;
                    case "3":
                        ListarArticulosMenorADiez();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo de la aplicación.");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar.");
                Console.ReadKey();
            }
        }

        private static void AgregarNuevoArticulo()
        {
            Console.WriteLine("\n--- Agregar Nuevo Artículo ---");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("SKU: ");
            string sku = Console.ReadLine();

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Console.Write("Marca: ");
            string marca = Console.ReadLine();

            decimal precio;
            while (true)
            {
                Console.Write("Precio: ");
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio >= 0)
                {
                    break;
                }
                Console.WriteLine("Precio no válido. Por favor, ingrese un número decimal positivo.");
            }

            int stock;
            while (true)
            {
                Console.Write("Stock: ");
                if (int.TryParse(Console.ReadLine(), out stock) && stock >= 0)
                {
                    break;
                }
                Console.WriteLine("Stock no válido. Por favor, ingrese un número entero positivo.");
            }

            var agregarArticulo = new AgregarArticulo();
            agregarArticulo.Ejecutar(nombre, sku, color, marca, precio, stock);
            Console.WriteLine("Artículo agregado exitosamente.");
        }

        private static void ListarTodosLosArticulos()
        {
            Console.WriteLine("\n--- Listado de Todos los Artículos ---");
            var consultarTodos = new ConsultarTodos();
            List<Articulo> todosLosArticulos = consultarTodos.Ejecutar();

            if (todosLosArticulos.Count > 0)
            {
                foreach (var item in todosLosArticulos)
                {
                    Console.WriteLine($"Nombre: {item.Nombre}, SKU: {item.SKU}, Stock: {item.Stock}, Precio: {item.Precio:C}");
                }
            }
            else
            {
                Console.WriteLine("No hay artículos para mostrar.");
            }
        }

        private static void ListarArticulosMenorADiez()
        {
            Console.WriteLine("\n--- Artículos con Stock Menor a 10 ---");
            var consultarTodos = new ConsultarTodos();
            List<Articulo> todosLosArticulos = consultarTodos.Ejecutar();

            var menorADies = new MenorADies();
            List<Articulo> articulosBajoStock = menorADies.Ejecutar(todosLosArticulos);

            if (articulosBajoStock.Count > 0)
            {
                foreach (var item in articulosBajoStock)
                {
                    Console.WriteLine($"Nombre: {item.Nombre}, SKU: {item.SKU}, Stock: {item.Stock}, Precio: {item.Precio:C}");
                }
            }
            else
            {
                Console.WriteLine("No hay artículos con stock menor a 10.");
            }
        }
    }
}
