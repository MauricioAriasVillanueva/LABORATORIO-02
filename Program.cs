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
        string[] codigos = new string[10];
        string[] nombres = new string[10];
        string[] tipos = new string[10];
        string[] descripciones = new string[10];
        string[] prioridades = new string[10];
        
        int cantidad = 0;
        string opcion = "";

        while (opcion != "3")
        {
            MostrarMenu();
            Console.Write("Elija una opción (1-3): ");
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("\n>>> NUEVO REGISTRO <<<");

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

                string prioridad = ObtenerPrioridad(tipo);

                codigos[cantidad] = codigo;
                nombres[cantidad] = nombre;
                tipos[cantidad] = tipo;
                descripciones[cantidad] = desc;
                prioridades[cantidad] = prioridad;
                cantidad++;

                Console.WriteLine("\n¡REGISTRADO CON ÉXITO!");
                MostrarResumen(codigo, nombre, tipo, desc, prioridad);
            }
            else if (opcion == "2")
            {
                if (cantidad == 0)
                {
                    Console.WriteLine("\nNo hay registros guardados.");
                }
                else
                {
                    Console.WriteLine($"\nTOTAL DE SOLICITUDES: {cantidad}");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine($"\nREGISTRO #{i + 1}");
                        MostrarResumen(codigos[i], nombres[i], tipos[i], descripciones[i], prioridades[i]);
                    }
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("\n¡Gracias por usar el sistema!");
            }
            else
            {
                Console.WriteLine("\nOpción no válida.");
            }
        }
    }
}
