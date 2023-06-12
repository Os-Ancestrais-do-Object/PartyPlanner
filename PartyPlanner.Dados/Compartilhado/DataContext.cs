using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;
using System.Runtime.Serialization.Formatters.Binary;

namespace PartyPlanner.Infra.Dados.Arquivo.Compartilhado
{
    [Serializable]
    public class DataContext
    {
        private DataContext _dataContext;

        public DataContext()
        {
            Alugueis = new List<Aluguel>();

            Clientes = new List<Cliente>();

            Festas = new List<Festa>();

            Temas = new List<Tema>();
        }

        public DataContext(bool carregarDados) : this()
        {
            if (carregarDados)
                CarregarDados();
        }

        public List<Aluguel> Alugueis { get; set; }

        public List<Cliente> Clientes { get; set; }

        public List<Festa> Festas { get; set; }

        public List<Tema> Temas { get; set; }


        public const string CAMINHO_ARQUIVO = "e-agenda.bin";

        public void CarregarDados()
        {
            if (!File.Exists(CAMINHO_ARQUIVO))
                return;

            DataContext dataContext = CarregarRegistrosDoArquivoBIN();

            this.Alugueis = dataContext.Alugueis;
            this.Clientes = dataContext.Clientes;
            this.Festas = dataContext.Festas;
            this.Temas = dataContext.Temas;
        }

        public void GravarRegistrosEmArquivoBIN()
        {
            BinaryFormatter serializador = new();

            MemoryStream registroStream = new();

            serializador.Serialize(registroStream, this);

            File.WriteAllBytes(CAMINHO_ARQUIVO, registroStream.ToArray());
        }

        public DataContext CarregarRegistrosDoArquivoBIN()
        {

            BinaryFormatter serializador = new();

            byte[] registroBytes = File.ReadAllBytes(CAMINHO_ARQUIVO);

            MemoryStream registroStream = new MemoryStream(registroBytes);

            return (DataContext)serializador.Deserialize(registroStream);
        }
    }
}
