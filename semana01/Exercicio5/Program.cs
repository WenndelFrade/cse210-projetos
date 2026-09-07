using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirBoasVindas();
        string nome = PerguntarNome();
        int numeroFavorito = PerguntarNumeroFavorito();
        int total = ElevarAoQuadrado(numeroFavorito);
        ExibirResultado(nome, total);
        ElevarAoQuadrado(numeroFavorito);
    
    }
    
        static void ExibirBoasVindas ()
    {
        Console.WriteLine("Bem vindo ao Programa!");
    }
        static string PerguntarNome()
    {   
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();

        return nome;
    }
        static int PerguntarNumeroFavorito()
    { 
        Console.Write("Por favor, insira seu número favorito: ");
        int numeroFavorito = int.Parse(Console.ReadLine());
        return numeroFavorito;
    }
       static int ElevarAoQuadrado(int numeroFavorito)
    {
        return numeroFavorito * numeroFavorito;
    }
        static void ExibirResultado(string nome, int total)
    {
        Console.WriteLine($"Irmão {nome}, o quadrado do seu número favorito é: {total}");
    }
}