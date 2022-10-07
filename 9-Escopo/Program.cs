


using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7- Condicionais ");

        int idadeUser = 17;
        int quatidadePessoas = 2;

        bool acompanhado = quatidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "A pessoa esta acompanhada";
        }
        else
        {
            textoAdicional = "A pessoa não esta acompanhada";
        }

        if (idadeUser >= 18 || acompanhado)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Você pode entrar na festa");
        }
        else
        {
            Console.WriteLine("Não pode entrar");
        }


        Console.WriteLine("Aperte ENTER para fechar o programa !");
        Console.ReadLine();
    }
}