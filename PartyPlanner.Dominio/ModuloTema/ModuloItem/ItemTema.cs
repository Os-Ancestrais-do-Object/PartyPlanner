using PartyPlanner.Dominio.Compartilhado;

namespace PartyPlanner.Dominio.ModuloTema.ModuloItem
{
    [Serializable]
    public class ItemTema : Entidade<ItemTema>
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public ItemTema(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public ItemTema()
        {
            
        }

        public bool ValidarCampoVazio(string campo)
        {
            return string.IsNullOrEmpty(campo);
        }
    }
}
