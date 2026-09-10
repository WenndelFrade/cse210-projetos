using System;

class Program
{
    static void Main(string[] args)
    {
        
       
        Emprego emprego = new Emprego();
        emprego._emprego = "Apple";
        emprego._cargo = "Gerente";
        emprego._AnoInicial = 2019;
        emprego._AnoFinal = 2022;
        


        Emprego emprego1 = new Emprego();
        emprego1._emprego = "Microsoft";
        emprego1._cargo = "Engenheiro de Software";
        emprego1._AnoInicial = 2022;
        emprego1._AnoFinal = 2023;
        

        Curriculo curriculo = new Curriculo();
        curriculo._membro = "Wenndel";
        curriculo._empregos.Add(emprego);
        curriculo._empregos.Add(emprego1);
        curriculo.ExibirCurriculo();
    }
}