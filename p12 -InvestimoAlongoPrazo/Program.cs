
using System;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Executando o projeto de Investimento a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int i = 0; i < 5; i++)
        {
            for(int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        Console.WriteLine("Depois de 5 anos você tera R$ " + investimento);

        Console.WriteLine("Aperte a tecla ENTER para fechar o programa!");
        Console.ReadLine();
    }
}