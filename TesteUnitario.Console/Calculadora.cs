using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteUnitario.Console
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;

        }
        public int Somar(int x, int y)
        {
            int resultado = x + y;
            historicoAdd(resultado, "Soma");
            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            int resultado = x - y;
            historicoAdd(resultado, "Substração");
            return resultado;
        }


        public int Multiplicar(int x, int y)
        {
            int resultado = x * y;
            historicoAdd(resultado, "Multiplicação");
            return resultado;
        }

        public int Dividir(int x, int y)
        {
            int resultado = x / y;
            historicoAdd(resultado,"Divisão");
            return resultado;
        }

        public List<string> Historico()
        {
            if (listaHistorico.Count > 3)
            {
                listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            }
            return listaHistorico;
        }

        private void historicoAdd(int resultado, string acao)
        {
            listaHistorico.Insert(0, $"Data:{data} {acao}: " + resultado);
        }
    }
}
