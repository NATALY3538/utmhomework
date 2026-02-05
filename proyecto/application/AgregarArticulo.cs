using core; // Required to access the Articulo class and ListadoArticulos

namespace application
{
    public class AgregarArticulo
    {
        public void Ejecutar(string nombre, string sku, string color, string marca, decimal precio, int stock)
        {
            var nuevoArticulo = new Articulo
            {
                Nombre = nombre,
                SKU = sku,
                Color = color,
                Marca = marca,
                Precio = precio,
                Stock = stock
            };

            ListadoArticulos.AddArticulo(nuevoArticulo);
        }
    }
}
