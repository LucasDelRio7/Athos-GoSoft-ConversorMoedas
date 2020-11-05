using LucasDelRio.AthosGoSoft.ConversorMoedas.Domain.Dto;
using System;

namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Interfaces
{
    public interface IConversorService
    {
        /// <summary>
        /// Converte Euro para Real
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterEuroParaReal(decimal valor);

        /// <summary>
        /// Converte Euro para Dolar
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterEuroParaDolar(decimal valor);

        /// <summary>
        /// Converte Dolar para Real
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterDolarParaReal(decimal valor);

        /// <summary>
        /// Converte Dolar para Euro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterDolarParaEuro(decimal valor);

        /// <summary>
        /// Converte Real para Euro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterRealParaEuro(decimal valor);

        /// <summary>
        /// Converte Real para Dolar
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> Tuple: status da operação (true/false); string com mensagem de erro (se erro); valor convertido</returns>
        Tuple<bool, string, MoedaDto> ConverterRealParaDolar(decimal valor);
    }
}