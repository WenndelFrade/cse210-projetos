using System;

class Program
{
    static void Main(string[] args)
    {
        string opcao = ""; 

        while (opcao != "4")

        {
            Console.WriteLine("Menu de Opções: ");
            Console.WriteLine("1. Atividade de Respiração");
            Console.WriteLine("2. Atividade de Reflexão");  
            Console.WriteLine("3. Atividade de Listagem");
            Console.WriteLine("4. Sair");
            Console.Write("Seleciona uma das opções do menu: ");
            opcao = Console.ReadLine();
        
            if (opcao == "1")
            {
                AtividadeDeRespiracao atividadeRespiracao = new AtividadeDeRespiracao();
                atividadeRespiracao.Executar();
            }
            else if (opcao == "2")
            {
                AtividadeDeReflexao atividadeReflexao = new AtividadeDeReflexao();
                atividadeReflexao.Executar();
            }
            else if (opcao == "3")
            {
                AtividadeDeListagem atividadeListagem = new AtividadeDeListagem();
                atividadeListagem.Executar();
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Saindo do programa...");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
            }
        }
    }
}