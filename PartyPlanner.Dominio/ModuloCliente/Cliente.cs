using System.Text.RegularExpressions;

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

        public bool ValidarTelefone(string telefone)
        {
            return !Regex.IsMatch(telefone, @"^\(\d{2}\) \d{4,5}-\d{4}$");
        }
    }
}
