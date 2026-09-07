using System;

class Program
{
    static void Main(string[] args)
    {
        int tentativas = 0;
        
        {
            Random geradorAleatorio = new Random();
            int numero = geradorAleatorio.Next(1, 50);
            
            
            int palpite;
            do   
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());
                tentativas++;
                if (palpite < numero)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numero)
                {
                    Console.WriteLine("Mais baixo");
                }
            } while (palpite != numero);
            Console.WriteLine("Parabéns! Você acertou o número!");
            Console.WriteLine($"Número de tentativas: {tentativas}");
        }
    }
}