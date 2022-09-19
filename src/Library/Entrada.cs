using System;
namespace Library;

public class Entrada : ICalcular
{
    public int Value;
    public Entrada(int valor)
    {
        this.Value = valor;
        Calcular();
    }

    public int Calcular()
    {
        return this.Value;
    }
}