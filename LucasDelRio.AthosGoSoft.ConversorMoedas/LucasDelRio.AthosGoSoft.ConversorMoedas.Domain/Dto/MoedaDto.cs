namespace LucasDelRio.AthosGoSoft.ConversorMoedas.Domain.Dto
{
    public class MoedaDto
    {
        public Entrada Entrada { get; set; }
        public Saida Saida { get; set; }
    }

    public class Entrada
    {
        public string Moeda { get; set; }
        public decimal Cotacao { get; set; }
        public decimal Valor { get; set; }
    }

    public class Saida
    {
        public string Moeda { get; set; }
        public decimal Cotacao { get; set; }
        public decimal Valor { get; set; }
    }
}