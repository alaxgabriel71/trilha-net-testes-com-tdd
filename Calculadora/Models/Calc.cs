using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calc
    {
        private List<string> HistoricoOperacoes = new();
        public int Somar(int num1, int num2)
        {
            HistoricoOperacoes.Insert(0, $"{num1} + {num2} = {num1 + num2}");
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            HistoricoOperacoes.Insert(0, $"{num1} - {num2} = {num1 - num2}");
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            HistoricoOperacoes.Insert(0, $"{num1} * {num2} = {num1 * num2}");
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            HistoricoOperacoes.Insert(0, $"{num1} / {num2} = {num1 / num2}");
            return num1 / num2;
        }

        public List<string> Historico()
        {
            HistoricoOperacoes.RemoveRange(3, HistoricoOperacoes.Count - 3);
            return HistoricoOperacoes;
        }
    }
}