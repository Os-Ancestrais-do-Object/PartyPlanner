namespace PartyPlanner.Dominio.Compartilhado
{
    [Serializable]
    public abstract class Entidade<TEntidade>
    {
        public int Id { get; set; }

        public bool ValidarCampoVazio(string campo)
        {
            return string.IsNullOrEmpty(campo);
        }
    }
}