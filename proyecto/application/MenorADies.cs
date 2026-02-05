using System.Collections.Generic;
using System.Linq;
using core; // Assuming Articulo class is in the 'core' namespace

namespace application
{
    public class MenorADies
    {
        public List<Articulo> Ejecutar(List<Articulo> todosLosArticulos)
        {
            // Filters the list of articles to return only those with Stock less than 10.
            return todosLosArticulos.Where(articulo => articulo.Stock < 10).ToList();
        }
    }
}
