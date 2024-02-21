using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Logica
    {
        /// <summary>
        /// Metodo recebe um numero em texto usando separador . como separador de milhar e , como separador decimal
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        internal decimal ConverteStringParaDecimal(string numeroString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Metodo recebe uma data em texto no formato dd/MM/yyyy e retorna a data convertida
        /// </summary>
        /// <param name="dataString"></param>
        /// <returns></returns>
        internal DateTime ConverteStringParaData(string dataString)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vendedor Gustavo
        /// Código Produto	quantidade    valor total          Data venda
        /// ARA-1012        17 UN          R$ 3.642,17              08/04/2021
        /// </summary>
        /// <param name="produtosString"></param>
        /// <returns></returns>
        /// Dica, pode ser usado regex para separar a string pro padrões.

        internal List<VendaTO> ConverteStringParaVendas(string produtosString)
        {
            throw new NotImplementedException();
        }

        internal int ConvertStringParaInt(string value)
        {
            throw new NotImplementedException();
        }
    }
}
