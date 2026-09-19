using System;

public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public bool Exibir()
    {
        return _estaOculta;
    }

    public string ObterTexto() // A IA como tutor sugeriu utilizar desta forma
    {
        if (_estaOculta)
        {
            return new string ('_', _texto.Length);
        }
        else
        {
            return _texto;
        }
    }
}

