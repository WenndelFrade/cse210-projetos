using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma nota numérica: ");
        string notadigitada = Console.ReadLine();
        int nota = int.Parse(notadigitada);
        string letra ="";

        if (nota >= 90)
            if
            (nota >= 97)
                {
                letra = "A+";
                }
            else if (nota <= 93)
            {
                letra = "A-";
            }
            else
            {
                letra = "A";
            }
        else if (nota >= 80)
            if (nota >= 87)
            {
                letra = "B+";
            }
            else if (nota <= 83)
            {
                letra = "B-";
            }
            else
            {
                letra = "B";
            }
        
        else if (nota >= 70)
            if (nota >= 77)
            {
                letra = "C+";
            }
            else  if (nota <= 73)  
            {
                letra = "C-";
            }
            else
            {
                letra = "C";
            }
        else if (nota >= 60)
            if (nota >= 67)
            {
                letra = "D+";
            }
            else if (nota <= 63)

            {
                letra = "D-";    
            }
            else
            {
                letra = "D";
            }   
            else
            {
            letra = "F";
            }
        Console.WriteLine($"Sua nota é: {letra}");
        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você passou no curso!");
        }
        else
        {
            Console.WriteLine("Infelizmente você não passou no curso. Tente novamente!");
        }
    }
}