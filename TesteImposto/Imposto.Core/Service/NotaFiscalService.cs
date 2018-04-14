using Imposto.Core.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Imposto.Core.Service
{
    public class NotaFiscalService
    {
        private Data.NotaFiscalRepository repository = new Data.NotaFiscalRepository();
        
        public void GerarNotaFiscal(Domain.Pedido pedido)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.EmitirNotaFiscal(pedido);

            SaveDB(notaFiscal);

            SaveXML(notaFiscal);    
        }

        /// <summary>
        /// Exercício 1
        /// </summary>
        /// <param name="obj"></param>
        private void SaveXML(NotaFiscal obj)
        {
            repository.SaveXML(obj);
        }

        /// <summary>
        /// Exercício 2
        /// </summary>
        /// <param name="obj"></param>
        private void SaveDB(NotaFiscal obj)
        {
            repository.SaveDB(obj);
        }
    }
}
