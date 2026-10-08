using System;
using System.Collections.Generic;
class AtividadeDeListagem : Atividade
{

    private List<string> _respostas;
    private List<string> _perguntas;


    public AtividadeDeListagem() 
    {
        _nome = "Listagem";
        _descricao = "Esta atividade vai ajudar você a refletir sobre coisas boas da sua vida, pedindo que você liste o máximo de coisas que puder em uma determinada área.";
        _perguntas = new List<string>
        {
            "Quem são as pessoas que você mais aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo esta semana?",
            "Quem são alguns dos seus heróis espirituais?"
        };

    }

    public void Executar()
    {
        ExibirMensagemInicial();
        Console.WriteLine("Liste o máximo de itens que puder em resposta à seguinte pergunta:");
        Console.WriteLine(ObterPerguntaAleatoria());
        Console.WriteLine("Prepare-se");
        ExibirContagemRegressiva(5);
        _respostas = ObterListaDoUsuario();
        ExibirMensagemFinal();
    }

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int index = random.Next(_perguntas.Count);
        return _perguntas[index];
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> respostas = new List<string>();
        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);
        while (DateTime.Now < horaFim)
        {
            Console.Write("> ");
                string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                respostas.Add(item);
            }
        }
        return respostas;
    }
}