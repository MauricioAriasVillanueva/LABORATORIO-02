using System;

class Program
{
    static bool ValidarTipo(string tipo)
    {
        tipo = tipo.Trim().ToLower();
        return tipo == "matrícula" || tipo == "pagos" || tipo == "constancia" || tipo == "plataforma" || tipo == "otro";
    }

    static string ObtenerPrioridad(string tipo)
    {
        tipo = tipo.Trim().ToLower();
        if (tipo == "matrícula" || tipo == "pagos")
        {
            return "ALTA";
        }
        else if (tipo == "plataforma" || tipo == "constancia")
        {
            return "MEDIA";
        }
        else
        {
            return "BAJA";
        }
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine("    SOPORTE ACADÉMICO - MENÚ     ");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Mostrar todas las solicitudes");
        Console.WriteLine("3. Salir");
        Console.WriteLine("=================================");
    }

    static void Main(string[] args)
    {
        string codigo = "";
        string nombre = "";
        string tipo = "";
        string desc = "";

        MostrarMenu();

        while (true)
        {
            Console.Write("Código de estudiante (min. 6 letras/números): ");
            codigo = Console.ReadLine();
            if (codigo != null && codigo.Trim().Length >= 6) break;
            Console.WriteLine("Error: El código debe tener al menos 6 caracteres.");
        }

        while (true)
        {
            Console.Write("Tipo (matrícula, pagos, constancia, plataforma, otro): ");
            tipo = Console.ReadLine();
            if (ValidarTipo(tipo)) break;
            Console.WriteLine("Error: Elija una opción de la lista.");
        }

        string prioridad = ObtenerPrioridad(tipo);
    }
}