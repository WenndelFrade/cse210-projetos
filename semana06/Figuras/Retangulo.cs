using System;

public class Retangulo : Figura
{
    double _altura;
    double _baseRetangulo;

    public Retangulo(string cor, double altura, double baseRetangulo) : base(cor)
    {
        _altura = altura;
        _baseRetangulo = baseRetangulo;
    }

    public override double ObterArea()
    {
        return _altura * _baseRetangulo;
    }
}