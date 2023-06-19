using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.Dominio.ModuloFesta
{
    [Serializable]
    public class Festa : Entidade<Festa>
    {
        public string NomeCliente => Cliente.Nome;
        public string Endereco { get; set; }
        public Tema Tema { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public Cliente Cliente { get; set; }
        public bool AluguelAtivo { get; set; }

        public Festa(string endereco, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, Cliente cliente)
        {
            Endereco = endereco;
            Tema = tema;
            Data = data;
            HoraInicio = horaInicio;
            HoraFinal = horaFinal;
            Cliente = cliente;
        }

        public Festa()
        {

        }
    }
}