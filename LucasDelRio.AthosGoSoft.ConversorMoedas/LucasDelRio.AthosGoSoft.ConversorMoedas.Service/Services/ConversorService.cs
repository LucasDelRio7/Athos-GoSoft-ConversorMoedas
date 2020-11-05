using LucasDelRio.AthosGoSoft.ConversorMoedas.Domain.Dto;
using LucasDelRio.AthosGoSoft.ConversorMoedas.Domain.Entities;
using LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Service.Services
{
    public class ConversorService : IConversorService
    {
        public decimal dolar = 5.5m;
        public decimal euro = 6.5m;

        public ConversorService()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string responseBody = httpClient.GetStringAsync("https://economia.awesomeapi.com.br/all/USD-BRL,EUR-BRL").Result;

                Moeda moedas = JsonConvert.DeserializeObject<Moeda>(responseBody);
                dolar = Convert.ToDecimal(moedas.USD.bid);
                euro = Convert.ToDecimal(moedas.EUR.bid);
            }
            catch { }
        }

        public Tuple<bool, string, MoedaDto> ConverterEuroParaReal(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = euro * valor;

            MoedaDto moedaDto = SetMoedaDto("Euro", "Real", valor, novoValor, euro, 0);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }
        public Tuple<bool, string, MoedaDto> ConverterEuroParaDolar(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = valor * euro / dolar;

            MoedaDto moedaDto = SetMoedaDto("Euro", "Dolar", valor, novoValor, euro, dolar);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }

        public Tuple<bool, string, MoedaDto> ConverterDolarParaEuro(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = valor * dolar / euro;

            MoedaDto moedaDto = SetMoedaDto("Dolar", "Euro", valor, novoValor, dolar, euro);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }
        public Tuple<bool, string, MoedaDto> ConverterDolarParaReal(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = dolar * valor;

            MoedaDto moedaDto = SetMoedaDto("Dolar", "Real", valor, novoValor, dolar, 0);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }

        public Tuple<bool, string, MoedaDto> ConverterRealParaEuro(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = valor / euro;

            MoedaDto moedaDto = SetMoedaDto("Real", "Euro", valor, novoValor, 0, euro);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }
        public Tuple<bool, string, MoedaDto> ConverterRealParaDolar(decimal valor)
        {
            if (valor <= 0)
                return new Tuple<bool, string, MoedaDto>(false, "Valor inválido.", null);

            decimal novoValor = valor / dolar;

            MoedaDto moedaDto = SetMoedaDto("Real", "Dolar", valor, novoValor, 0, dolar);

            return new Tuple<bool, string, MoedaDto>(true, string.Empty, moedaDto);
        }

        public MoedaDto SetMoedaDto(string moedaEntrada, string moedaSaida, decimal valor, decimal valorConvertido, decimal cotacaoEntrada, decimal cotacaoSaida)
        {
            return new MoedaDto
            {
                Entrada = new Entrada
                {
                    Moeda = moedaEntrada,
                    Cotacao = cotacaoEntrada,
                    Valor = valor
                },
                Saida = new Saida
                {
                    Moeda = moedaSaida,
                    Cotacao = cotacaoSaida,
                    Valor = valorConvertido
                }
            };
        }
    }
}