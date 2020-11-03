using LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Interfaces;
using System;

namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Services
{
    public class ConversorService : IConversorService
    {
        public Tuple<bool, string, decimal> ConverterEuroParaReal(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, decimal>(false, "Valor inválido.", 0);

            decimal novoValor = valor + 1;

            return new Tuple<bool, string, decimal>(true, string.Empty, novoValor);

        }
    }
}