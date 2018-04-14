using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto.Core.Domain
{
    public class NotaFiscalItem
    {
        public int Id { get; set; }
        public int IdNotaFiscal { get; set; }
        public string Cfop { get; set; }
        public string TipoIcms { get; set; }
        public double BaseIcms { get; set; }
        public double AliquotaIcms { get; set; }
        public double ValorIcms { get; set; }
        public string NomeProduto { get; set; }
        public string CodigoProduto { get; set; }

        //Exercício 3
        /// <summary>
        /// Base de cálculo de IPI: Igual ao valor total do produto.
        /// </summary>
        public double BaseIpi { get; set; }
        /// <summary>
        /// Alíquota de IPI: Se for brinde alíquota é igual a 0% se não brinde alíquota é igual a 10%. 
        /// </summary>
        public double AliquotaIpi { get; set; }
        /// <summary>
        /// Valor de IPI: Base de cálculo * Alíquota de IPI.
        /// </summary>
        public double ValorIpi { get; set; }

        //Exercício 7
        public double Desconto { get; set; }
    }
}
