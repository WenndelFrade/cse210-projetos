using System;


public class Comentario
{
    private string _nomePessoa;

    private string _texto;


public Comentario (string pessoa, string texto)
{
    _nomePessoa = pessoa;

    _texto = texto;
}

public string ObterNomePessoa()
    {
        return _nomePessoa;
    }

public string ObterTexto()
    {
        return _texto;
    }


}