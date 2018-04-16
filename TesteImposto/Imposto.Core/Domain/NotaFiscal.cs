using Imposto.Core.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Imposto.Core.Domain
{
    //Artur Comments::
    //I know you all wanna see patterns, SOLID, Generics and Interfaces,
    //but I only got 3 hours to build this test project
    //whit this time I trying to show that I can code .NET modern apps and to document tasks.
    //I hope you get that..
	//Also, I am working to another company, so no much time free to do this test, but I wanna work with NetShoes.
	//Coincidentally, I am working with a system called NetDocs :)
    public class NotaFiscal
    {
        public int Id { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public int Serie { get; set; }
        public string NomeCliente { get; set; }
        public string EstadoDestino { get; set; }
        public string EstadoOrigem { get; set; }
        public List<NotaFiscalItem> ItensDaNotaFiscal { get; set; }

        public NotaFiscal()
        {
            ItensDaNotaFiscal = new List<NotaFiscalItem>();
            Id = 0;
            NumeroNotaFiscal = 0;
            Serie = 0;
            NomeCliente = string.Empty;
            EstadoDestino = string.Empty;
        }

        public void EmitirNotaFiscal(Pedido pedido)
        {
            this.NumeroNotaFiscal = 99999;
            this.Serie = new Random().Next(Int32.MaxValue);
            this.NomeCliente = pedido.NomeCliente;

            this.EstadoDestino = pedido.EstadoOrigem;
            this.EstadoOrigem = pedido.EstadoDestino;
            

            List<NotaFiscalItem> list = new List<NotaFiscalItem>();

            foreach (PedidoItem itemPedido in pedido.ItensDoPedido)
            {
                NotaFiscalItem notaFiscalItem = new NotaFiscalItem();
                
                if(Desconto.TemDesconto(this.EstadoDestino))
                    itemPedido.ValorItemPedido = itemPedido.ValorItemPedido * 0.9;

                if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.RJ.ToString()))
                {
                    notaFiscalItem.Cfop = "6.000";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.PE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.001";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.MG.ToString()))
                {
                    notaFiscalItem.Cfop = "6.002";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.PB.ToString()))
                {
                    notaFiscalItem.Cfop = "6.003";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.PR.ToString()))
                {
                    notaFiscalItem.Cfop = "6.004";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.PI.ToString()))
                {
                    notaFiscalItem.Cfop = "6.005";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.RO.ToString()))
                {
                    notaFiscalItem.Cfop = "6.006";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.SE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.007";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.TO.ToString()))
                {
                    notaFiscalItem.Cfop = "6.008";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.SE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.009";
                }
                else if ((this.EstadoOrigem == Estado.SP.ToString()) && (this.EstadoDestino == Estado.PA.ToString()))
                {
                    notaFiscalItem.Cfop = "6.010";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.RJ.ToString()))
                {
                    notaFiscalItem.Cfop = "6.000";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.PE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.001";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.MG.ToString()))
                {
                    notaFiscalItem.Cfop = "6.002";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.PB.ToString()))
                {
                    notaFiscalItem.Cfop = "6.003";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.PR.ToString()))
                {
                    notaFiscalItem.Cfop = "6.004";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.PI.ToString()))
                {
                    notaFiscalItem.Cfop = "6.005";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.RO.ToString()))
                {
                    notaFiscalItem.Cfop = "6.006";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.SE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.007";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.TO.ToString()))
                {
                    notaFiscalItem.Cfop = "6.008";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.SE.ToString()))
                {
                    notaFiscalItem.Cfop = "6.009";
                }
                else if ((this.EstadoOrigem == Estado.MG.ToString()) && (this.EstadoDestino == Estado.PA.ToString()))
                {
                    notaFiscalItem.Cfop = "6.010";
                }

                if (this.EstadoDestino == this.EstadoOrigem)
                {
                    notaFiscalItem.TipoIcms = "60";
                    notaFiscalItem.AliquotaIcms = 0.18;
                    notaFiscalItem.Cfop = "6.006";
                }
                else
                {
                    notaFiscalItem.TipoIcms = "10";
                    notaFiscalItem.AliquotaIcms = 0.17;
                }

                if (notaFiscalItem.Cfop == "6.009")
                {
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido * 0.90; //redução de base
                }
                else
                {
                    notaFiscalItem.BaseIcms = itemPedido.ValorItemPedido;
                }

                notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
                notaFiscalItem.BaseIpi = itemPedido.ValorItemPedido;

                if (itemPedido.Brinde)
                {
                    notaFiscalItem.TipoIcms = "60";
                    notaFiscalItem.AliquotaIcms = 0.18;
                    notaFiscalItem.ValorIcms = notaFiscalItem.BaseIcms * notaFiscalItem.AliquotaIcms;
                    notaFiscalItem.AliquotaIpi = 0;
                }
                else
                {
                    notaFiscalItem.AliquotaIpi = 0.10;
                }

                notaFiscalItem.NomeProduto = itemPedido.NomeProduto;
                notaFiscalItem.CodigoProduto = itemPedido.CodigoProduto;
                notaFiscalItem.ValorIpi = notaFiscalItem.BaseIpi * notaFiscalItem.AliquotaIpi;

                ItensDaNotaFiscal.Add(notaFiscalItem);
            }
        }
    }
}
