using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : Entidade<Aluguel>
    {
        public Festa Festa { get; set; }
        public DateTime DataQuitacao { get; set; }
        public decimal ValorCobrado { get => Festa.Tema.ValorTotal; set { } }
        public decimal Desconto { get; set; }
        public decimal Sinal { get; set; }
        public decimal ValorTotal { get; set; }

        public Aluguel(Festa festa, DateTime dataQuitacao, decimal valorCobrado, decimal desconto, decimal sinal, decimal valorTotal)
        {
            Festa = festa;
            DataQuitacao = dataQuitacao;
            ValorCobrado = valorCobrado;
            Desconto = desconto;
            Sinal = sinal;
            ValorTotal = valorTotal;
        }

        public Aluguel()
        {
            
        }

        public bool ValidarCampoVazio(string campo)
        {
            return string.IsNullOrEmpty(campo);
        }
    }
}
