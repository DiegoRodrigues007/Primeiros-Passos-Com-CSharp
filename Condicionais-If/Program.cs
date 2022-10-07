

using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7- Condicionais ");

        int idadeUser = 18;

        if(idadeUser >= 18)
        {
            Console.WriteLine("Você pode entrar na festa");
        }else if(idadeUser < 18)
        {
            Console.WriteLine("Você não pode entrar na festa");
        }
        else
        {
            Console.WriteLine("Nao tem idade");
        }

        Console.WriteLine("Aperte ENTER para fechar o programa !");    
        Console.ReadLine();
    }
}