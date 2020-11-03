using System;
using System.Text;

namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Interfaces
{
    public interface IConversorService
    {
        /// <summary>
        /// Converte Euro para Real
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, decimal> ConverterEuroParaReal(decimal valor);
    }
}