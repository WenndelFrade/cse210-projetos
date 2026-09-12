using System;

public class Program
{
    private static void Main(string[] args)
    {

        int _escolha;
        GeradorDePerguntas perguntas = new GeradorDePerguntas();
        Diario diario = new Diario();// Utilizei este comando ao seguir a IA como tutor
        do
        {
            Console.WriteLine("Bem-Vindo ao Programa Diário!");
            Console.WriteLine("Por favor selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever"); // criar uma classe que exibe as perguntas do que vai ser registrado (cria uma lista de todos os registros)
            Console.WriteLine("2. Exibir"); // exibe todas as informações registradas no terminal
            Console.WriteLine("3. Carregar"); // criar classe que carrega o que ja foi salvo no arquivo
            Console.WriteLine("4. Salvar"); // criar o arquivo txt
            Console.WriteLine("5. Sair");
            Console.Write("O que deseja fazer: ");
            _escolha = int.Parse(Console.ReadLine());
        if (_escolha == 1)
            {
                string pergunta = perguntas.RegistrarPergunta();
                Console.Write("");
                string resposta = Console.ReadLine();
                Registro registro = new Registro (pergunta,resposta);
                diario.AdicionarRegistro(registro);
            }
        else if (_escolha == 2)
            {
                diario.Exibir();
            }


        else if (_escolha == 3)
            {
                diario.ExibirTodos();
            }
        else if (_escolha == 4)
            
            {
                Console.WriteLine("Qual o nome do arquivo? ");
                string arquivo = Console.ReadLine();
                foreach (var registro in diario._registros)
                {
                    diario.SalvarNoArquivo(registro, arquivo);
                }
                
                Console.WriteLine($"Registros salvos no {arquivo}.");
            }
        else if(_escolha == 5)
            {
                Console.WriteLine("Saindo do Programa!");
            }
        } while (_escolha != 5);
        
    }
}