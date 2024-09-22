using System;
using System.Collections.Generic;
using System.Text;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> _historico;
        private string _Data;
        public Calculadora(string data)
        {
            _historico = new List<string>();
            _Data = data;
        }
        public int Somar(int x, int y)
        {
            int result = x + y;
            _historico.Insert(0, "Resultado soma:" + result + "Data:" + _Data);
            return result;
        }
        public int Subtrair(int x, int y)
        {
            int result = x - y;
            _historico.Insert(0, "Resultado subtracao:" + result + "Data:" + _Data);
            return result;
        }
        public int Dividir(int x, int y)
        {
            int result = x / y;
            _historico.Insert(0, "Resultado divisao:" + result + "Data:" + _Data);
            return result;
        }
        public int Multiplicar(int x, int y)
        {
            int result = x * y;
            _historico.Insert(0, "Resultado multiplicacao:" + result + "Data:" + _Data);
            return result;
        }
        public List<string> Historico()
        {
            _historico.RemoveRange(3, _historico.Count - 3); 
            return _historico;
        }
    }
}
