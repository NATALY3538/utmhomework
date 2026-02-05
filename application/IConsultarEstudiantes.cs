using Proyect.Core.Entities;
using System.Collections.Generic;

namespace Proyect.Application
{
    public interface IConsultarEstudiantes
    {
        List<Estudiante> ObtenerTodos();
    }
}
