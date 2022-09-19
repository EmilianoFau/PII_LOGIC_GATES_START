using System;

namespace Library;
public class CompuertaOr : ILogicGate
{
    public string Nombre {get;set;}
    public int Salida;
    public Dictionary<string, int> Entradas = new Dictionary<string, int>();

    public CompuertaOr (string nombre)
    {
        this.Nombre = nombre;
    }
    public void Conectar(string Conector, ICalcular Valor)
    {
        this.Entradas.Add(Conector, Valor.Calcular());
    }
    public int Calcular()
    {
        int resultado = 0;
        foreach (KeyValuePair<string, int> elemento in Entradas)
        {
            if (elemento.Value == 1)
            {
                resultado = 1;
            }
        }
        return resultado;
    }
}