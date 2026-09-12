using System;

public class Curriculo
{
// variaveis membros
    public string _membro;

// lista de empregos   
    public List<Emprego> _empregos = new List<Emprego>();

    public void ExibirCurriculo()
    {
        Console.WriteLine($"Nome {_membro}");
        Console.WriteLine("Empregos:");
// percorrendo a lista de emprego e exibindo       
        foreach (var emprego in _empregos)
        {
            emprego.ExibirDetalhesEmprego();
        }
    }
   
}