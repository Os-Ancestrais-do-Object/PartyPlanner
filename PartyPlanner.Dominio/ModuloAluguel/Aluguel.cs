using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : Entidade<Aluguel>
    {
        public Festa Festa { get; set; }
        public DateTime? DataQuitacao { get; set; }
        public decimal ValorCobrado { get; set; }
        public decimal Desconto { get; set; }
        public decimal Sinal { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusAluguel StatusAluguel { get; set; }

        public Aluguel(Festa festa, decimal valorCobrado, decimal desconto, decimal sinal, decimal valorTotal, StatusAluguel statusAluguel)
        {
            Festa = festa;
            ValorCobrado = valorCobrado;
            Desconto = desconto;
            Sinal = sinal;
            ValorTotal = valorTotal;
            StatusAluguel = statusAluguel;
        }

        public Aluguel()
        {

        }
    }
}
