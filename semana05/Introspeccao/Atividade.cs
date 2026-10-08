using System;

class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao, int duracao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = duracao;
    }


    public Atividade()
    {
        _nome = "";
        _descricao = "";
        _duracao = 0;
    }
    public void ExibirMensagemInicial()
    {
        Console.WriteLine($"Bem vindo a atividade {_nome}.\n {_descricao}");
        Console.Write("Por quanto tempo, em segundos, você deseja realizar a atividade? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.WriteLine("Prepare-se");
        ExibirProgresso(5);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("Muito bem!");

        Console.WriteLine($"Você completou outros {_duracao}segundos da {_nome}");
        ExibirProgresso(5);
    }

    public void ExibirProgresso (int segundos)
    {
  
        List<string> simbolos = new List<string>();
        simbolos.Add("|");
        simbolos.Add("/");
        simbolos.Add("-");
        simbolos.Add("\\");
        simbolos.Add("|");
        simbolos.Add("/");
        simbolos.Add("-");
        simbolos.Add("\\");

        DateTime horaInicio = DateTime.Now;
        DateTime horaFim = horaInicio.AddSeconds(segundos);

        int i = 0;
        while (DateTime.Now < horaFim)
        {
            string s = simbolos[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i>= simbolos.Count)
            {
                i = 0;
            }
        }

    }

    public void ExibirContagemRegressiva(int segundos)
    {
        
        for (int i = segundos; i > 0; i--)
    {

        Console.Write(i);
	    Thread.Sleep(1000);
        Console.Write("\b \b");

    }
    }
    
}   