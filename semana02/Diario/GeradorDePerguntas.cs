using System;

public class GeradorDePerguntas
{
    public void CriarRegistro()
    {
        List<string> _perguntas = new List<string>
        {
            "O que você fez de legal hoje?",
            "O que você aprendeu neste dia?",
            "Qual momento te fez sorrir?",
            "Quem foi importante no seu dia?",
            "Qual foi a melhor parte do seu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "O que você gostaria de repetir amanhã?"
        };
        foreach (string pergunta in _perguntas)
        {
            Console.WriteLine(pergunta);
            string resposta = Console.ReadLine();
            Console.WriteLine("voce respondeu: " + resposta);
        }
}
}