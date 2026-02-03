namespace Proyect.Core.Entities
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Carrera { get; set; }
        public int Cuatrimestre { get; set; }
        public string Matrícula { get; set; }

        public Estudiante(string nombre, int edad, string carrera, int cuatrimestre, string matrícula)
        {
            Nombre = nombre;
            Edad = edad;
            Carrera = carrera;
            Cuatrimestre = cuatrimestre;
            Matrícula = matrícula;
        }
    }
}
