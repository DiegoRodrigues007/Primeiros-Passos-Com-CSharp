
using System;

class Programa
{
    static void Main(string[] args)
    {

        int fatorial = 1;

        for (int numero = 1; numero <= 10; numero++)
        {
            fatorial *= numero;
            Console.WriteLine(numero + "! = " + fatorial);
        }

        Console.WriteLine("Aperte a tecla ENTER para fecar o programa");
        Console.ReadLine();
    }
}