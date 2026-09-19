using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        Escritura escritura = new Escritura(referencia,"Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e Ele endireitará as tuas veredas.");
    
    
   
      
    while (!escritura.EstaCompletamenteOculta())
        {
        Console.Clear();
        Console.WriteLine(escritura.ObterTexto());
        Console.WriteLine("\n Pressione Enter para continuar ou 'sair' para encerrar");
        
        string entrada = Console.ReadLine();
        if (entrada.ToLower() == "sair")
        {
            break;
        }
        escritura.OcultarPalavrasAleatorias(3);
    }
    Console.Clear();
    Console.WriteLine(escritura.ObterTexto());
    Console.WriteLine("\nprograma finalizado!");
}
}