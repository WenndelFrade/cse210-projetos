using System.IO;

public class Registro
{
    public string _data;
    public string _hora;
    public string _textoPergunta;
   
    public string _textoResposta;
    public Registro(string pergunta, string resposta)
    {
        DateTime horaAtual = DateTime.Now;
        _hora = horaAtual.ToShortTimeString();
        _data = horaAtual.ToShortDateString();
        _textoPergunta = pergunta;
        _textoResposta = resposta;
    } 
}