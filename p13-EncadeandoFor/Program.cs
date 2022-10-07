
using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 13 - encadeando o for!");


          for(int contadordeLinhas = 0; contadordeLinhas <= 9; contadordeLinhas++)
        {
            

            for (int colunas = 0; colunas <= 9; colunas++)     
            {
                Console.Write("*");


                if (colunas >= contadordeLinhas)
                    break;
            }

            Console.WriteLine();
        }  



        Console.WriteLine("Tecle ENTER para fechar ...");
        Console.ReadLine();
    }


}
