



using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10- Repetição ");


        double investimento = 1000;

        // rendimento de 0.5% ao mes

        

        int mes = 1;
        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            mes++;

            Console.WriteLine(investimento);
        }

        Console.WriteLine("Aperte ENTER para fechar o programa !");
        Console.ReadLine();
    }
}