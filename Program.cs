using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal emp,renda, vlparc, vlperm;
            int qtparc;

            Console.Beep();
            Console.Clear();
            Console.Write("Digite o valor desejado : ");
            emp = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de parcelas : ");
            qtparc = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da renda comprovada : ");
            renda = decimal.Parse(Console.ReadLine());

            vlparc = emp / qtparc;
            vlperm = renda / 100 * 30;
            
            if(vlparc < vlperm)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Empréstimo autorizado !!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Empréstimo não autorizado !!");
                Console.ResetColor();
            }

        }
    }
}
