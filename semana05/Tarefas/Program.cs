using System;


class Program
{
    static void Main(string[] args)
    {
        Tarefa tarefa = new Tarefa("Rafael Silva", "Multiplicação");
        Console.WriteLine(tarefa.ObterResumo());

        TarefaDeMatematica tarefadematematica = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine (tarefadematematica.ObterResumo());
        Console.WriteLine (tarefadematematica.ObterListaDeTarefas());


        TarefaDeRedacao tarefadaredacao = new TarefaDeRedacao("Maria Antunes", "História Européia", "As Causas da Segunda Guerra Mundial");
        Console.WriteLine(tarefadaredacao.ObterResumo());
        Console.WriteLine(tarefadaredacao.ObterInformacoesDaRedacao());
    }    

}