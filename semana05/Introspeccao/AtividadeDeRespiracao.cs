using System;

class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao()
    {
        _nome = "Respiração";
        _descricao = "Esta atividade ajudará você a relaxar, guiando-o a inspirar e explirar lentamente. Esvazie sua mente e foque na sua respiração.";
    }
    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(_duracao);


        while(DateTime.Now < horaFim)
        {
            Console.Write("Inspire...");
            ExibirContagemRegressiva(4);

            Console.WriteLine();

            Console.Write("Agora expire...");
            ExibirContagemRegressiva(4);
            Console.WriteLine();

        }
        ExibirMensagemFinal();
    }
}