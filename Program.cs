//Este programa registra el horario de entrada y salida del empleado.

using System;
using System.Collections.Generic;

public class Program
{
    // Funciones
    static Dictionary<string, Dictionary<string, DateTime?>> registros = new Dictionary<string, Dictionary<string, DateTime?>>();

    static void CheckIn()
    {
        Console.Write("Ingrese su Nombre y Apellido: ");
        string empleado = Console.ReadLine();
        DateTime hora_actual = DateTime.Now;
        registros[empleado] = new Dictionary<string, DateTime?> { { "check-in", hora_actual }, { "check-out", null } };
        Console.WriteLine(empleado + " ha realizado el check-in a las " + hora_actual);
    }

    static void CheckOut()
    {
        Console.Write("Ingrese su Nombre y Apellido: ");
        string empleado = Console.ReadLine();
        DateTime hora_actual = DateTime.Now;
        if (registros.ContainsKey(empleado) && registros[empleado]["check-out"] == null)
        {
            registros[empleado]["check-out"] = hora_actual;
            Console.WriteLine(empleado + " ha realizado el check-out a las " + hora_actual);
        }
        else
        {
            Console.WriteLine(empleado + " no ha realizado el check-in o ya ha realizado el check-out");
        }
    }

    // Programa Principal
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Check-in");
            Console.WriteLine("2. Check-out");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                CheckIn();
            }
            else if (opcion == "2")
            {
                CheckOut();
            }
            else if (opcion == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione nuevamente.");
            }
        }
    }
}
