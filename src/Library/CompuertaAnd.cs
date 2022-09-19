using System;

namespace Library;
public class CompuertaAnd : ILogicGate
{
    public string Nombre {get;set;}
    public int Salida;
    public Dictionary<string, int> Entradas = new Dictionary<string, int>();

    public CompuertaAnd (string nombre)
    {
        this.Nombre = nombre;
    }
    public void Conectar(string Conector, ICalcular Valor)
    {
        this.Entradas.Add(Conector, Valor.Calcular());
    }
    public int Calcular()
    {
        int resultado = 1;
        foreach (KeyValuePair<string, int> elemento in Entradas)
        {
            if (elemento.Value == 0)
            {
                resultado = 0;
            }
        }
        return resultado;
    }
}
