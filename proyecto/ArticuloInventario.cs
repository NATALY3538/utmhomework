using System;
using System.Collections.Generic;
using System.Linq;

// 1. Clase de dominio que representa un Artículo
public class Articulo
{
    public string Nombre { get; set; }
    public string Sku { get; set; }
    public string Color { get; set; }
    public string Marca { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    public Articulo(string nombre, string sku, string color, string marca, decimal precio, int stock)
    {
        Nombre = nombre;
        Sku = sku;
        Color = color;
        Marca = marca;
        Precio = precio;
        Stock = stock;
    }

    public Articulo() { }

    // Método para mostrar la información del artículo de forma legible
    public override string ToString()
    {
        return $"SKU: {Sku}, Nombre: {Nombre}, Marca: {Marca}, Color: {Color}, Precio: {Precio:C}, Stock: {Stock}";
    }
}

// 2. Clase para gestionar el inventario y los casos de uso
public class Inventario
{
    private List<Articulo> articulos;

    public Inventario()
    {
        // Inicializamos la lista con algunos datos de ejemplo
        articulos = new List<Articulo>
        {
            new Articulo("Laptop Gamer", "LP-GMR-001", "Negro", "MarcaX", 25000.50m, 15),
            new Articulo("Mouse Inalámbrico", "MS-WRL-002", "Blanco", "MarcaY", 350.00m, 8),
            new Articulo("Teclado Mecánico", "KB-MEC-003", "Negro", "MarcaX", 1200.75m, 5),
            new Articulo("Monitor 4K", "MN-4K-004", "Plata", "MarcaZ", 7500.00m, 20),
            new Articulo("Webcam HD", "WC-HD-005", "Negro", "MarcaY", 850.00m, 3)
        };
    }

    /// <summary>
    /// Caso de uso: Consultar todos los artículos existentes.
    /// </summary>
    /// <returns>Una lista con todos los artículos del inventario.</returns>
    public List<Articulo> ConsultarTodos()
    {
        Console.WriteLine("--- Consultando todos los artículos ---");
        return articulos;
    }

    /// <summary>
    /// Caso de uso: Consultar artículos con existencia menor a un umbral (por defecto 10).
    /// </summary>
    /// <returns>Una lista de artículos con stock bajo.</returns>
    public List<Articulo> ConsultarArticulosConBajoStock()
    {
        Console.WriteLine("\n--- Consultando artículos con stock menor a 10 ---");
        int umbralStock = 10;
        return articulos.Where(a => a.Stock < umbralStock).ToList();
    }

    /// <summary>
    /// Caso de uso: Agregar un nuevo artículo al listado.
    /// </summary>
    /// <param name="nuevoArticulo">El objeto del artículo a agregar.</param>
    public void AgregarArticulo(Articulo nuevoArticulo)
    {
        Console.WriteLine($"\n--- Agregando nuevo artículo: {nuevoArticulo.Nombre} ---");
        // Aquí se podría agregar validación para no repetir SKU, por ejemplo.
        if (articulos.Any(a => a.Sku.Equals(nuevoArticulo.Sku, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine($"Error: El SKU '{nuevoArticulo.Sku}' ya existe. No se agregó el artículo.");
        }
        else
        {
            articulos.Add(nuevoArticulo);
            Console.WriteLine("Artículo agregado con éxito.");
        }
    }
}

// 3. Ejemplo de uso en una aplicación de consola
public class Program
{
    public static void Main(string[] args)
    {
        Inventario miInventario = new Inventario();

        // --- Ejecutar caso de uso: Consultar todos ---
        var todosLosArticulos = miInventario.ConsultarTodos();
        foreach (var articulo in todosLosArticulos)
        {
            Console.WriteLine(articulo);
        }

        // --- Ejecutar caso de uso: Consultar con bajo stock ---
        var articulosBajoStock = miInventario.ConsultarArticulosConBajoStock();
        if (articulosBajoStock.Any())
        {
            foreach (var articulo in articulosBajoStock)
            {
                Console.WriteLine(articulo);
            }
        }
        else
        {
            Console.WriteLine("No hay artículos con bajo stock.");
        }


        // --- Ejecutar caso de uso: Agregar un nuevo artículo ---
        Articulo nuevoArticulo = new Articulo("Disco Duro SSD 1TB", "SSD-1TB-006", "Negro", "MarcaZ", 1800.00m, 25);
        miInventario.AgregarArticulo(nuevoArticulo);
        
        // --- Ejecutar caso de uso: Agregar un artículo con SKU repetido ---
        Articulo articuloRepetido = new Articulo("Otro monitor", "MN-4K-004", "Negro", "MarcaA", 500.00m, 10);
        miInventario.AgregarArticulo(articuloRepetido);


        // --- Volvemos a consultar todos para ver el nuevo artículo ---
        var listaActualizada = miInventario.ConsultarTodos();
        foreach (var articulo in listaActualizada)
        {
            Console.WriteLine(articulo);
        }
    }
}
