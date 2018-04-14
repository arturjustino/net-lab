using Imposto.Core.Domain;

namespace Imposto.Core.Util
{
    public class Desconto
    {
        /// <summary>
        /// Exercício 7
        /// </summary>
        /// <param name="estado"></param>
        /// <returns></returns>
        public static bool TemDesconto(string estado)
        {
            estado = estado.ToUpper();
            return (estado == Estado.SP.ToString() || estado == Estado.RJ.ToString() || estado == Estado.MG.ToString() || estado == Estado.MG.ToString());
        }
    }
}
