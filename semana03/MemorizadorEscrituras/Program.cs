using System;

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        Escritura escritura = new Escritura(referencia,"E a Vida Eterna é esta que te conheçam como único Deus Verdadeiro e vivo.");
    

   
      
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