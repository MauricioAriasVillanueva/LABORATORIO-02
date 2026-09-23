using System;

class Program
{
    static bool ValidarTexto(string texto, int minLargo)
    {
        if (texto == null) return false;
        return texto.Trim().Length >= minLargo;
    }

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

    static void MostrarResumen(string codigo, string nombre, string tipo, string desc, string prioridad)
    {
        Console.WriteLine("\n---------------------------------");
        Console.WriteLine($"Código   : {codigo}");
        Console.WriteLine($"Nombre   : {nombre}");
        Console.WriteLine($"Tipo     : {tipo}");
        Console.WriteLine($"Detalle  : {desc}");
        Console.WriteLine($"Prioridad: {prioridad}");
        Console.WriteLine("---------------------------------");
    }

    static void Main(string[] args)
    {
        string codigo = "";
        while (true)
        {
            Console.Write("Código de estudiante (min. 6 letras/números): ");
            codigo = Console.ReadLine();
            if (ValidarTexto(codigo, 6)) break;
            Console.WriteLine("Error: El código debe tener al menos 6 caracteres.");
        }

        string nombre = "";
        while (true)
        {
            Console.Write("Nombre del estudiante: ");
            nombre = Console.ReadLine();
            if (ValidarTexto(nombre, 2)) break;
            Console.WriteLine("Error: Ingrese un nombre válido.");
        }

        string tipo = "";
        while (true)
        {
            Console.Write("Tipo (matrícula, pagos, constancia, plataforma, otro): ");
            tipo = Console.ReadLine();
            if (ValidarTipo(tipo)) break;
            Console.WriteLine("Error: Elija una opción de la lista.");
        }

        string desc = "";
        while (true)
        {
            Console.Write("Descripción del problema: ");
            desc = Console.ReadLine();
            if (ValidarTexto(desc, 5)) break;
            Console.WriteLine("Error: Ingrese al menos 5 caracteres.");
        }

        // Enviando variables locales mediante argumentos
        string prioridadCalculada = ObtenerPrioridad(tipo);
        MostrarResumen(codigo, nombre, tipo, desc, prioridadCalculada);
    }
}