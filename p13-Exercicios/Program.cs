



using System;

class Programa
{
    static void Main(string[] args)
    {

       for(int numero = 0; numero <= 100; numero++)
        {
            if(numero % 3 == 0)
            {
                Console.WriteLine(numero + " é multiplo de 3");
                
            }
        }

        Console.WriteLine("Aperte a tecla ENTER para fecar o programa");
        Console.ReadLine();



    }



}