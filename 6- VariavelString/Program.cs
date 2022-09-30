
// PARA INICIAR UM SISTEMA UTILIZAMOS O " USING SYSTEM; "
using System;

class Programa
{
    static void Main(string[] args)
    {
        
        // STRINGS SÃO UM CONJUTO DE CARACTERES A SER EXECUTADOS
        string PrimeiraFrase = "Primeira frase utilizando string";
        Console.WriteLine(PrimeiraFrase);

        // PARA FAZER UMA LISTAGEM UTILIZANDO STRINGS, BASTA COLOCAR O @ PARA FAZER A LISTAGEM
        string Cursos = @" Cursos Disponiveis: 
-JavaScript
-GO
-JAVA
-PYTHON
-C#";

        // O CHAR NÃO RECEBE UM VALOR VAZIO DENTRO DA VARIAVEL, TEM QUE COLOCAR PELO MENOS UM ESPAÇO VAZIO DENTRO.
        char c = ' ';
        Console.WriteLine(c);

        // JA UMA STRING PODE RECEBER UM VALOR VAZIO DENTRO DA VARIAVEL
        string x = "";
        Console.WriteLine(x);
        
        // O CONSOLE.WRITELINE É UTILIZADO PARA ESCREVER ALGO NA TELA E QUEBRAR UMA LINHA
        Console.WriteLine(Cursos);

        Console.WriteLine("Aperte a tecla ENTER para fechar o programa!");

        // O CONSOLE.READLINE É UTILIZADO PARA NÃO DEIXAR O TERMINAL FECHAR AUTOMATICAMENTE
        Console.ReadLine();
        
    }
}