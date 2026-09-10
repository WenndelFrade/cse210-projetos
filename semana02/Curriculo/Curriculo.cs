using System;

public class Curriculo
{
    public string _membro;
   
    public List<Emprego> _empregos = new List<Emprego>();

    public void ExibirCurriculo()
    {
        Console.WriteLine($"Nome {_membro}");
        Console.WriteLine("Empregos:");
        foreach (var emprego in _empregos)
        {
            emprego.ExibirDetalhesEmprego();
        }
    }
   
}