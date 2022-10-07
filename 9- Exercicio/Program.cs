using System;
using System.Data.SqlTypes;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;
        string texto;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            texto = "O IR é de 7.5% e pode deduzir na declaração o valor de R$ 142.";
            Console.WriteLine(texto);
        }
        else if(salario >= 2800.01 && salario <= 3751.0)
        {
            texto = "O IR é de 15% e pode deduzir R$ 350.";
            Console.WriteLine(texto);
            
        }
       else if (salario >= 3751.01 && salario <= 4664.00)
        {
            texto = "O IR é de 22.5% e pode deduzir R$ 636.";
            Console.WriteLine(texto);
        }

        Console.ReadLine();
    }
}