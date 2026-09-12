using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int _escolha;
        GeradorDePerguntas perguntas = new GeradorDePerguntas();
        do
        {
            Console.WriteLine("Bem-Vindo ao Programa Diário!");
            Console.Write("Por favor selecione uma das seguintes opções: \n");
            Console.WriteLine("1. Criar"); // criar uma classe que exibe as perguntas do que vai ser registrado (cria uma lista de todos os registros)
            Console.WriteLine("2. Exibir"); // criar classe que exibe o que foi registrado
            Console.WriteLine("3. Carregar"); // criar classe que carrega o que ja foi realizado, especificando o arquivo para 
            Console.WriteLine("4. Salvar"); // criar o arquivo txt e salva dentro da lista
            Console.WriteLine("5. Sair");
            _escolha = int.Parse(Console.ReadLine());

            if (_escolha == 1)
            {
                string _pergunta = perguntas.ObterPerguntas();
                Console.WriteLine(_pergunta);
            }
        } while (_escolha != 5);
    }
}

internal class GeradorDePerguntas
{
    public string ObterPerguntas()
    {
        return "Qual foi a sua experiência de hoje?";
    }
}