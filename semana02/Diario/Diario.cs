using System.IO;
public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    
    public void Exibir()
    {
        foreach (Registro registro in _registros)
        {
            Console.WriteLine($"Data: {registro._data}");
            Console.WriteLine($"Hora: {registro._hora}");
            Console.WriteLine($"Pergunta: {registro._textoPergunta}");
            Console.WriteLine($"Resposta: {registro._textoResposta}");
            Console.WriteLine("");
        }
    }
    public void ExibirTodos()
    {
        string _arquivo ="diario.txt";
        string [] linhas = System.IO.File.ReadAllLines(_arquivo);

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
            
        }
    }
    
    public void SalvarNoArquivo (Registro registro, string _arquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(_arquivo,  true))
        {
            arquivoSaida.WriteLine("Data: " + registro._data);
            arquivoSaida.WriteLine("Hora: " + registro._hora);
            arquivoSaida.WriteLine(registro._textoPergunta);
            arquivoSaida.WriteLine(registro._textoResposta);
            arquivoSaida.WriteLine("");
            
        }
        
    }
}