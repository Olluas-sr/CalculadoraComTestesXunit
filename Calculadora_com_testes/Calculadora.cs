using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_com_testes
{
    public class Calculadora
    {
        private List<string> listaResultados;
        public Calculadora()
        {
            
            listaResultados = new List<string>();
        }
        public int somar(int fator1, int fator2)
        {
            int result = fator1 + fator2;
            listaResultados.Insert(0, "Resultado" + result);
            return result;
        }

        public int subtrair(int fator1, int fator2)
        {
            int result = fator1 - fator2;
            listaResultados.Insert(0, "Resultado" + result);
            return result;
        }

        public int multiplicar(int fator1, int fator2)
        {
            int result = fator1 * fator2;
            listaResultados.Insert(0, "Resultado" + result);
            return result;
        }

        public int dividir(int fator1, int fator2)
        {
            int result = fator1 / fator2;
            listaResultados.Insert(0, "Resultado" + result);
            return result;
        }

        public List<string> historico()
        {
            listaResultados.RemoveRange(3, listaResultados.Count - 3);
            return listaResultados;
        }
    }
}
