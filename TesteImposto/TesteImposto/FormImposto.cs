using Imposto.Core.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Imposto.Core.Domain;

namespace TesteImposto
{
    //Artur Comments::
    //I know you all wanna see patterns, SOLID, Generics and Interfaces,
    //but I only got 3 hours to build this test project
    //whit this time I trying to show that I can code .NET modern apps and to document tasks.
    //I hope you get that..
	//Also, I am working to another company, so no much time free to do this test, but I wanna work with NetShoes.
	//Coincidentally, I am working with a system called NetDocs :)
    public partial class FormImposto : Form
    {
        private Pedido pedido = new Pedido();
        private bool estadoOrigemValid = false;
        private bool estadoDestinoValid = false;

        public FormImposto()
        {
            InitializeComponent();
            dataGridViewPedidos.AutoGenerateColumns = true;
            dataGridViewPedidos.DataSource = GetTablePedidos();
            ResizeColumns();
        }

        private void ResizeColumns()
        {
            double mediaWidth = dataGridViewPedidos.Width / dataGridViewPedidos.Columns.GetColumnCount(DataGridViewElementStates.Visible);

            for (int i = dataGridViewPedidos.Columns.Count - 1; i >= 0; i--)
            {
                var coluna = dataGridViewPedidos.Columns[i];
                coluna.Width = Convert.ToInt32(mediaWidth);
            }
        }

        private object GetTablePedidos()
        {
            DataTable table = new DataTable("pedidos");
            table.Columns.Add(new DataColumn("Nome do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Codigo do produto", typeof(string)));
            table.Columns.Add(new DataColumn("Valor", typeof(decimal)));
            table.Columns.Add(new DataColumn("Brinde", typeof(bool)));

            return table;
        }

        private void buttonGerarNotaFiscal_Click(object sender, EventArgs e)
        {
            if(!estadoOrigemValid && !estadoDestinoValid)
            {
                MessageBox.Show("Verifique os campos em vermelho", "Erro");
                return;
            }
            
            NotaFiscalService service = new NotaFiscalService();
            pedido.EstadoOrigem = txtEstadoOrigem.Text;
            pedido.EstadoDestino = txtEstadoDestino.Text;
            pedido.NomeCliente = textBoxNomeCliente.Text;

            DataTable table = (DataTable)dataGridViewPedidos.DataSource;

            foreach (DataRow row in table.Rows)
            {
                if (row["Codigo do produto"] != DBNull.Value
                   && row["Nome do produto"] != DBNull.Value
                   && row["Valor"] != DBNull.Value)
                {
                    pedido.ItensDoPedido.Add(
                        new PedidoItem()
                        {
                            Brinde = row["Brinde"] == DBNull.Value ? false : Convert.ToBoolean(row["Brinde"]),
                            CodigoProduto = row["Codigo do produto"].ToString(),
                            NomeProduto = row["Nome do produto"].ToString(),
                            ValorItemPedido = Convert.ToDouble(row["Valor"].ToString())
                        });
                }

            }

            service.GerarNotaFiscal(pedido);
            txtEstadoDestino.Clear();
            txtEstadoOrigem.Clear();
            textBoxNomeCliente.Clear(); //id deste campo veio fora do padrão
            MessageBox.Show("Operação efetuada com sucesso");
        }

        private void txtEstadoDestino_Leave(object sender, EventArgs e)
        {
            if(EstadoValid(((TextBox)sender).Text.ToUpper()))
            {
                lblEstadoDestino.ForeColor = Color.Black;
                errorProvider1.Clear();
                estadoDestinoValid = true;
            }
            else
            {
                lblEstadoDestino.ForeColor = Color.Red;
                errorProvider1.SetError(((TextBox)sender), "Estado inválido");
                estadoDestinoValid = false;
            }
        }

        private void txtEstadoOrigem_Leave(object sender, EventArgs e)
        {
            if (EstadoValid(((TextBox)sender).Text.ToUpper()))
            {
                lblEstadoOrigem.ForeColor = Color.Black;
                errorProvider1.Clear();
                estadoOrigemValid = true;
            }
            else
            {
                lblEstadoOrigem.ForeColor = Color.Red;
                errorProvider1.SetError(((TextBox)sender), "Estado inválido");
                estadoOrigemValid = false;
            }
        }

        private bool EstadoValid(string str)
        {
            return Enum.IsDefined(typeof(Estado), str.ToUpper());
        }
    }
}
