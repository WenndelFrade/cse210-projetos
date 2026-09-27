using System;

public class Cliente
{
    private string _nomeCliente;
    private Endereco _endereco;


    public Cliente(string nomeCliente, Endereco endereco)

        {
            _nomeCliente = nomeCliente;
            _endereco = endereco;
        }
    public string exibirMoraEUA()
        {
            return _endereco.exibirLocal();
        }
    public string obterNome()
    {
        return _nomeCliente;
    }

    public string obterEndereco()
    {
        return _endereco.exibirEndereco();
    }
}