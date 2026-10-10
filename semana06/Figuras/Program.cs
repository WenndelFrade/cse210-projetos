using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        // Observe que a lista é uma lista de objetos "Forma". Isso significa que
        // você pode colocar qualquer objeto Forma nela, assim como qualquer objeto cuja
        // classe herde de Forma.
        List<Figura> figura = new List<Figura>();

        Quadrado f1 = new Quadrado("Vermelho", 3);
        figura.Add(f1);

        Retangulo f2 = new Retangulo("Azul", 4, 5);
        figura.Add(f2);

        Circulo f3 = new Circulo("Verde", 6);
        figura.Add(f3);

        foreach (Figura f in figura)
        {
            // Observe que todas as formas possuem um método ObterCor da classe base
            string cor = f.ObterCor();

            // Observe que todas as formas possuem um método ObterArea, mas o comportamento é
            // diferente para cada tipo de forma
            double area = f.ObterArea();

            Console.WriteLine($"A forma {cor} tem uma area de {area:F2}.");
        }
    }
}