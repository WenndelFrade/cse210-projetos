using System;
using System.Collections.Generic;

class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;
    private List<string> _perguntasDisponiveis; // Acrescentado para nao repetir a mesma pergunta antes de exibir todas da lista
    private Random _random; // Acrescentado para nao repetir a mesma pergunta antes de exibir todas da lista
    private string _ultimaPergunta = "";// Acrescentado para nao repetir a mesma pergunta antes de exibir todas da lista

    public AtividadeDeReflexao()
    {
        _nome = "Reflexão";
        _descricao = "Esta atividade ajudará você a refletir sobre momentos da sua vida em que demonstrou força e resiliência. Isso vai ajudar você a reconhecer o poder que possui e como pode ajudá-lo em outros aspectos da sua vida.";
        _random = new Random();

        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguem necessitado.",
            "Considere um momento em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "O que você aprendeu com essa experiência?",
            "Como essa experiência mudou sua perspectiva?",
            "Qual foi o maior desafio que você enfrentou?",
            "O que você faria diferente se tivesse a chance de repetir?",
            "Como essa experiência se relaciona com seus valores?",
            "Como você pode aplicar o que aprendeu em situações futuras?"
        };

        _perguntasDisponiveis = new List<string>();
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        ExibirReflexoes();
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);
        while (DateTime.Now < horaFim)
        {
            ExibirPerguntas();
        }
        ExibirMensagemFinal();
    }

    private string ObterReflexoesAleatorias()
    {
        int index = _random.Next(_reflexoes.Count);
        return _reflexoes[index];
    }

    private string ObterPerguntasAleatorias()
    {
      
        if (_perguntasDisponiveis.Count == 0)// Acrescentado para nao repetir a mesma pergunta antes de exibir todas da lista
        {
            _perguntasDisponiveis = new List<string>(_perguntas);

            if (_perguntasDisponiveis.Count > 1)
            {
                _perguntasDisponiveis.Remove(_ultimaPergunta);

            }
        }

        int index = _random.Next(_perguntasDisponiveis.Count);
        string pergunta = _perguntasDisponiveis[index];
        _perguntasDisponiveis.RemoveAt(index);

        _ultimaPergunta = pergunta;
        return pergunta;
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine("Reflita sobre a seguinte frase");
        Console.WriteLine($"----{ObterReflexoesAleatorias()}----");
        Console.WriteLine("Quando tiver algo em mente, pressione enter para continuar");
        Console.ReadLine();
        Console.WriteLine("Agora reflita sobre cada uma das perguntas a seguir em relação a essa experiência.");
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
    }

    public void ExibirPerguntas()
    {
        Console.WriteLine(ObterPerguntasAleatorias());
        ExibirProgresso(5);
    }
}