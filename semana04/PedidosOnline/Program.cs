using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, Mundo! Este é o Projeto PedidosOnline.");

        Endereco endereco1 = new Endereco("Rua Joao Damasceno", "Catalao", "GO", "Brasil");
        Cliente cliente = new Cliente("Joao", endereco1);

        List<Produto> listaProdutos = new List<Produto>();

        Produto produto1 = new Produto("Computador", "ID123", 3100, 2);
        Produto produto2 = new Produto("Celular", "ID456", 2300, 1);

        listaProdutos.Add(produto1);
        listaProdutos.Add(produto2);

        Pedido pedidoRealizado = new Pedido(cliente, listaProdutos);

        Console.WriteLine($"{pedidoRealizado.exibirEtiquetaEnvio()}");
        Console.WriteLine($"Pedido:{pedidoRealizado.exibirEtiquetaEmbalagem()}");
        Console.WriteLine($"Subtotal: R${pedidoRealizado.exibirPrecoTotal()}");
    
        // Pedidos para EUA

        Endereco endereco2 = new Endereco("50 W North", "Salt Lake", "UT", "EUA");
        Cliente cliente1 = new Cliente("Joao", endereco2);

        List<Produto> listaProdutos1 = new List<Produto>();

        Produto produto3 = new Produto("Computador", "ID123", 3100, 2);
        Produto produto4 = new Produto("Celular", "ID456", 2300, 1);

        listaProdutos1.Add(produto3);
        listaProdutos1.Add(produto4);

        Pedido pedidoRealizado1 = new Pedido(cliente1, listaProdutos1);

        Console.WriteLine($"Cliente: {pedidoRealizado1.exibirEtiquetaEnvio()}");
        Console.WriteLine($"Pedido:{pedidoRealizado1.exibirEtiquetaEmbalagem()}");
        Console.WriteLine($"Subtotal: R${pedidoRealizado1.exibirPrecoTotal()}");
        
        
    }
}