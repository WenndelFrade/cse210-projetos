using System;

public class Endereco
{
    private string _nomeRua;
    private string _nomeCidade;
    private string _nomeEstado;
    private string _nomePais;

public Endereco(string nomeRua, string nomeCidade, string nomeEstado, string nomePais)
    {
        _nomeRua = nomeRua;
        _nomeCidade = nomeCidade;
        _nomeEstado = nomeEstado;
        _nomePais = nomePais;
    }
public string exibirLocal()

    {
        if (_nomePais == "EUA")
        {
          return "EUA";  
        }
        
        return "Não é EUA";
        
    }
public string exibirEndereco()

    {
        return ($"{_nomeRua}, {_nomeCidade}, {_nomeEstado}, {_nomePais}");
    }
}