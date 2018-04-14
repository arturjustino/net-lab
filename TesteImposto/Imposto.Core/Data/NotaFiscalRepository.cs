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

namespace Imposto.Core.Data
{
    //Artur Comments
    //I know you all wanna see patterns, SOLID, Generics and Interfaces,
    //but I only got 3 hours to build this test project
    //whit this time I trying to show that I can code .NET modern apps and documentation tasks
    //I hope you get that..
    public class NotaFiscalRepository
    {
        public void SaveDB(Domain.NotaFiscal obj)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "P_NOTA_FISCAL";

                SqlParameter output = new SqlParameter("@pId", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    Value = obj.Id
                };

                cmd.Parameters.Add(output);
                cmd.Parameters.Add(new SqlParameter("pNumeroNotaFiscal", obj.NumeroNotaFiscal));
                cmd.Parameters.Add(new SqlParameter("pSerie", obj.Serie));
                cmd.Parameters.Add(new SqlParameter("pNomeCliente", obj.NomeCliente));
                cmd.Parameters.Add(new SqlParameter("pEstadoDestino", obj.EstadoDestino));
                cmd.Parameters.Add(new SqlParameter("pEstadoOrigem", obj.EstadoOrigem));
                
                ExecuteNonQuery(cmd);

                SaveDB(obj.ItensDaNotaFiscal);
            }
        }

        public void SaveDB(Domain.NotaFiscalItem obj)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "P_NOTA_FISCAL_ITEM";

                SqlParameter output = new SqlParameter("@pId", System.Data.SqlDbType.Int)
                {
                    Direction = System.Data.ParameterDirection.Output,
                    Value = obj.Id
                };

                cmd.Parameters.Add(output);
                cmd.Parameters.Add(new SqlParameter("pIdNotaFiscal", obj.IdNotaFiscal));
                cmd.Parameters.Add(new SqlParameter("pCfop", obj.Cfop));
                cmd.Parameters.Add(new SqlParameter("pTipoIcms", obj.TipoIcms));
                cmd.Parameters.Add(new SqlParameter("pBaseIcms", obj.BaseIcms));
                cmd.Parameters.Add(new SqlParameter("pAliquotaIcms", obj.AliquotaIcms));
                cmd.Parameters.Add(new SqlParameter("pValorIcms", obj.ValorIcms));
                cmd.Parameters.Add(new SqlParameter("pNomeProduto", obj.NomeProduto));
                cmd.Parameters.Add(new SqlParameter("pCodigoProduto", obj.CodigoProduto));
                cmd.Parameters.Add(new SqlParameter("pBaseIpi", obj.BaseIpi));
                cmd.Parameters.Add(new SqlParameter("pAliquotaIpi", obj.AliquotaIpi));
                cmd.Parameters.Add(new SqlParameter("pValorIpi", obj.ValorIpi));
                cmd.Parameters.Add(new SqlParameter("pDesconto", obj.Desconto));

                ExecuteNonQuery(cmd);
            }
        }

        public void SaveDB(List<Domain.NotaFiscalItem> list)
        {
            int countList = list.Count;

            for(int i = 0; i < countList; i++)
            {
                SaveDB(list[i]);
            }
        }

        private void ExecuteNonQuery(SqlCommand cmd)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServerTeste"].ConnectionString))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = cn;

                cn.Open();

                cmd.ExecuteNonQuery();

            }
        }

        /// <summary>
        /// Exercício 1
        /// </summary>
        /// <param name="obj"></param>
        public void SaveXML(NotaFiscal obj)
        {
            string diretorio = ConfigurationManager.AppSettings["DiretorioXml"];

            if (new DirectoryInfo(diretorio).Exists)
            {
                XmlSerializer writer = new XmlSerializer(typeof(NotaFiscal));
                var filePath = diretorio + "//netshoes.xml";

                if (File.Exists(filePath))
                    File.Delete(filePath);

                System.IO.FileStream file = System.IO.File.Create(filePath);

                writer.Serialize(file, obj);
                file.Close();
            }
        }
    }
}
