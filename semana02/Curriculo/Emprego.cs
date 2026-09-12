using System;
// classe emprego
public class Emprego
{
// variaveis membros definido como public para ser acessada na classe Program
    public string _emprego;
    public string _cargo;
    public int _AnoInicial;
    public int _AnoFinal;

// exibir detalhes do emprego
    public void ExibirDetalhesEmprego()
    {
        Console.WriteLine($"{_cargo} ({_emprego}) {_AnoInicial} - {_AnoFinal}");
    }
}