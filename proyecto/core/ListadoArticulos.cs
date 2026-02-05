using System.Collections.Generic;
using core; // Required to use the Articulo class

namespace core
{
    public static class ListadoArticulos
    {
        // This static list will act as a simple in-memory storage for articles.
        // In a real application, this would be replaced by a database context or similar persistence layer.
        public static List<Articulo> Articulos { get; private set; }

        static ListadoArticulos()
        {
            Articulos = new List<Articulo>();
        }

        public static void AddArticulo(Articulo articulo)
        {
            Articulos.Add(articulo);
        }

        // Optional: A method to clear the list, useful for testing or re-initialization
        public static void ClearArticulos()
        {
            Articulos.Clear();
        }
    }
}
