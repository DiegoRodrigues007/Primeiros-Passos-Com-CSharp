


using System;

class Programa
{
    static void Main(string[] args)
    {

        double investimento = 1000;


        for (int i = 1; i <= 12; i++)
        {
            investimento *=  1.005;
            Console.WriteLine(investimento);
        }


        Console.WriteLine("Aperte a tecla ENTER para fechar o programa!");
        Console.ReadLine();
    }
}