using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
public class Pedido
{   
    private Cliente _cliente;
    private string _etiquetaEmbalagem;
    private string _etiquetaEnvio;
    private List<Produto> _produtos;
    private string v;

    public Pedido(string v)
    {
        this.v = v;
    }

    public Pedido(Cliente cliente, List<Produto> produtos)
    {
        _cliente = cliente;
        _produtos = produtos;
    }
    public double exibirPrecoTotal()

    { 
        double total = 0;
        foreach(Produto produto in _produtos)
        {
            total += produto.exibirPreco();
        }    
        
        if (_cliente.exibirMoraEUA() == "EUA")
            {
                total+= 5;
            }
        else {
        
            total += 35;
        }
        return total;
    }
    public string exibirEtiquetaEmbalagem()
    {
        
        foreach (Produto produto in _produtos)
        {
            _etiquetaEmbalagem += $" {produto.exibirNome()}|{produto.exibirIdProduto()}";
        }
        return _etiquetaEmbalagem;
    }

    public string exibirEtiquetaEnvio()
    {
        {
            _etiquetaEnvio = $"{_cliente.obterNome()} | {_cliente.obterEndereco()}";
        }
        return _etiquetaEnvio;
    }
}

