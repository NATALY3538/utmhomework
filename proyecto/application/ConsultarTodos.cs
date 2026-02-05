using System.Collections.Generic;
using core; // Assuming Articulo class is in the 'core' namespace

namespace application
{
    public class ConsultarTodos
    {
        public List<Articulo> Ejecutar()
        {
            return ListadoArticulos.Articulos;
        }
    }
}
