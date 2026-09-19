using System;
using System.Collections.Generic;


public class Escritura
{
    private Referencia _referencia;

    private List<Palavra> _palavras;

    public Escritura (Referencia referencia, string texto)
    {
       _referencia = referencia;
       _palavras = new List<Palavra>();
       string[] palavrasArray = texto.Split(' ');
       foreach (string item in palavrasArray)
       {Palavra novaPalavra = new Palavra(item);
       _palavras.Add(novaPalavra);
       }
    }
    // IA me guiou como tutor para desenvolvimento desta parte
    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        Random sorteador = new Random();
        for (int i = 0; i <numeroParaOcultar; i++)
        {
            if (EstaCompletamenteOculta())
            {
                break;
            }
            int indice;
            do
            {
                indice = sorteador.Next(_palavras.Count);
            
            }
            while (_palavras[indice].Exibir());
            _palavras[indice].Ocultar();
        }
    }
    public string ObterTexto()
    {
        string textoEscritura = _referencia.ObterTexto() + " ";
        foreach (Palavra palavra in _palavras)
        {
            textoEscritura += palavra.ObterTexto() + " ";        
        }
        return textoEscritura;
    }
    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.Exibir())
            {return false;}
        }
        return true;
    }
}

