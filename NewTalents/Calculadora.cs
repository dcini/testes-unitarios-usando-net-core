using System.ComponentModel;

namespace NewTalents;

public class Calculadora
{
    private List<string> _historico;
    private string data;

    public Calculadora(string data)
    {
        _historico = new List<string>();
        this.data = data;
    }

    public int Soma(int val1, int val2)
    {
        int res = val1 + val2;
        _historico.Insert(0, $"Res: {res} - {data}");
        return res;
    }
    public int Subtrair(int val1, int val2)
    {
        int res = val1 - val2;
         _historico.Insert(0, $"Res: {res} - {data}");
       return res;
    }
    public int Multiplicar(int val1, int val2)
    {
        int res = val1 * val2;
         _historico.Insert(0, $"Res: {res} - {data}");
       return res;
    }
    public int Dividir(int val1, int val2)
    {
        // if val2 == 0  
        //     DivideByZeroException

        int res = val1 / val2;
         _historico.Insert(0, $"Res: {res} - {data}");
       return res;
    }
    public List<string> Historico()
    {
        _historico.RemoveRange(3,_historico.Count()-3);
        return _historico;
    }
}
