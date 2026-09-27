using System;


public class Produto
{

    private string _nomeProduto;
    private string _idProduto;
    private int _qtdProduto;
    private double _precoUnidade;


public Produto (string nomeProduto, string idProduto, int qtdProduto, double precoUnidade)
    {
        _nomeProduto = nomeProduto;
        _idProduto = idProduto;
        _qtdProduto = qtdProduto;
        _precoUnidade = precoUnidade;

    }
public double exibirPreco()
    {
        return _precoUnidade * _qtdProduto;
    }


public string exibirNome()
    {
        return _nomeProduto;
    }

public string exibirIdProduto()
    {
        return _idProduto;
    }
    
}