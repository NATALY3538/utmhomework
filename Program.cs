using System;
using System.Collections.Generic;
using Proyect.Application;
using Proyect.Core.Entities;

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Crear una instancia del caso de uso.
        IConsultarEstudiantes consultarEstudiantes = new ConsultarEstudiantes();

        // 2. Ejecutar el método para obtener los estudiantes.
        List<Estudiante> listaDeEstudiantes = consultarEstudiantes.ObtenerTodos();

        // 3. Desplegar los estudiantes en la consola.
        Console.WriteLine("--- Listado Completo de Estudiantes ---");
        foreach (var estudiante in listaDeEstudiantes)
        {
            Console.WriteLine($"Matrícula: {estudiante.Matrícula}");
            Console.WriteLine($"Nombre:    {estudiante.Nombre}");
            Console.WriteLine($"Carrera:   {estudiante.Carrera}");
            Console.WriteLine($"Edad:      {estudiante.Edad}");
            Console.WriteLine($"Cuatrimestre: {estudiante.Cuatrimestre}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
