using System;

class Program
{
    static void Main(string[] args)
    {
        string codigo = "";
        string nombre = "";
        string tipo = "";
        string desc = "";

        while (true)
        {
            Console.Write("Código de estudiante (min. 6 letras/números): ");
            codigo = Console.ReadLine();
            if (codigo != null && codigo.Trim().Length >= 6) break;
            Console.WriteLine("Error: El código debe tener al menos 6 caracteres.");
        }
    }
}