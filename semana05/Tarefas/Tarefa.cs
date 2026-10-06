using System;

class Tarefa
{
    protected string _nomeEstudante;
    protected string _topico;

    public Tarefa(string nomeEstudante, string topico)
    {
        _nomeEstudante = nomeEstudante;
        _topico = topico;
    }

    public string ObterNomeEstudante()
    {
        return _nomeEstudante;
    }
    
    public string ObterResumo()
    {
        return _nomeEstudante + " - " + _topico;
    }
}