namespace PartyPlanner.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : Entidade<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Cliente()
        {

        }
    }
}
