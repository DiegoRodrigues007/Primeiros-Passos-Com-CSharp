

using System;
using System.Text.Json;

class Programa
{
    static void Main(string[] args)
    {
        double salario;
        salario = 3000.15;

             Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int) salario;

             Console.WriteLine(salarioInteiro);

        // O long é um tipo de variável de 64 bits
        long x;
        x = 200000000000;
            Console.WriteLine(x);

        float f;
        f = 2.500f;
            Console.WriteLine(f);

        short z = 15000;
             Console.WriteLine(z);

        Console.WriteLine("Aperte ENTER para fechar o programa!");
        Console.ReadLine();
    }
}