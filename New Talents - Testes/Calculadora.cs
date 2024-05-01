using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Talents___Testes
{
    public class Calculadora
    {
        private List<string> _listahistorico;

        public Calculadora()
        {
            _listahistorico = new List<string>();
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;

            _listahistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;

            _listahistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;

            _listahistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;

            _listahistorico.Insert(0, "Resultado: " + res);

            return res;
        }
        public List<string> Historico()
        {
            _listahistorico.RemoveRange(3, _listahistorico.Count - 3);
            return _listahistorico;
        }
    }
}