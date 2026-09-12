using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    private List<string> _perguntas;

    public GeradorDePerguntas()

    {
        _perguntas = new List<string>
    
        {
            "O que você fez de legal hoje?",
            "O que você aprendeu neste dia?",
            "Qual momento te fez sorrir?",
            "Quem foi importante no seu dia?",
            "Quem foi a pessoa mais interessante que interagi hoje?",
            "Qual foi a melhor parte do seu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "O que você gostaria de repetir amanhã?"
        };
    }
    // usei a IA como tutor para escrever esta parte
    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);
        return _perguntas[indice];
    }
    public string RegistrarPergunta()
    {
        string pergunta = ObterPerguntaAleatoria();
        Console.WriteLine(pergunta);
        return pergunta;
    }
}