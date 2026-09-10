using System;

public class Emprego
{
    public string _emprego;
    public string _cargo;
    public int _AnoInicial;
    public int _AnoFinal;

    public void ExibirDetalhesEmprego()
    {
        Console.WriteLine($"{_cargo} ({_emprego}) {_AnoInicial} - {_AnoFinal}");
    }
}