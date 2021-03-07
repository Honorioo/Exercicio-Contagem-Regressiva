using System;

namespace Exercicio_Contagem_Regressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CONTAGEM REGRASSIVA!... ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PRESSIONE UMA TECLA QUANDO ESTIVER PRONTO...");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Preparar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Apontar...");
            Console.ResetColor();
            Console.ReadKey();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FOGO!");
            Console.ResetColor();

        }
    }
}
