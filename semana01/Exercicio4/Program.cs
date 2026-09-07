using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        float soma = 0;
    
    {

        List<int> palavras = new List<int>();
        int resposta;
        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");
    do
        {
            Console.Write("Insira o número: ");
            resposta = int.Parse(Console.ReadLine());
            
            if (resposta != 0)
            {
                palavras.Add(resposta);
                contador++;
                soma += resposta;
            }

        } while (resposta != 0);
        Console.WriteLine("A soma é " + soma);
        Console.WriteLine("A média é " + (double)soma / contador);
        Console.WriteLine("O maior número é " + palavras.Max());
    }
    }
}