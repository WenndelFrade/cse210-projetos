using System;

using System;

class Program
{
    static void Main(string[] args)
    //usei aula do professora para corrigir
    {
   
        List<Figura> figuras = new List<Figura>();

        Quadrado f1 = new Quadrado("Vermelho", 3);
        figuras.Add(f1);

        Retangulo f2 = new Retangulo("Azul", 4, 5);
        figuras.Add(f2);

        Circulo f3 = new Circulo("Verde", 6);
        figuras.Add(f3);

        foreach (Figura f in figuras)
        {
            
            string cor = f.ObterCor();


            double area = f.ObterArea();

            Console.WriteLine($"A forma {cor} tem uma area de {area:F2}.");
        }
    }
}