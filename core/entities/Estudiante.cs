// Estudiante.cs
using System;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Carrera { get; set; }
    public int Cuatrimestre { get; set; }
    public string Matricula { get; set; }

    public Estudiante(string nombre, int edad, string carrera, int cuatrimestre, string matricula)
    {
        Nombre = nombre;
        Edad = edad;
        Carrera = carrera;
        Cuatrimestre = cuatrimestre;
        Matricula = matricula;
    }

    // You can add more methods or constructors as needed
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Carrera: {Carrera}");
        Console.WriteLine($"Cuatrimestre: {Cuatrimestre}");
        Console.WriteLine($"Matrícula: {Matricula}");
    }
}
