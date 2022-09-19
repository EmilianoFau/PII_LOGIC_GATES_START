using System;
namespace Library;
public interface IConectar
{
    void Conectar(string Conector, ICalcular Valor);
}