

using System;

class Programa
{
    static void Main(string[] args)
    {

        // O char recebe apenas 1 caractere, e utilizamos apenas aspas simples.
        char letra = 'c';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char) (63 + 1);
        Console.WriteLine(letra);

        letra = (char)((65 + 4));
        Console.WriteLine( "Aqui estamos utilizando o caractere char com 2 ()"  + letra);




        Console.WriteLine("Aperte a tecla ENTER para fechar o programa!");
        Console.ReadLine();
    }
}