using Proyect.Core.Entities;
using System.Collections.Generic;

namespace Proyect.Application
{
    public class ConsultarEstudiantes : IConsultarEstudiantes
    {
        public List<Estudiante> ObtenerTodos()
        {
            // En una aplicación real, estos datos vendrían de una base de datos.
            return new List<Estudiante>
            {
                new Estudiante("Juan Perez", 20, "Ingeniería de Software", 5, "2020-001"),
                new Estudiante("Ana Gomez", 22, "Psicología", 8, "2018-045"),
                new Estudiante("Luis Rodriguez", 19, "Medicina", 3, "2021-090")
            };
        }
    }
}
