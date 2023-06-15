namespace PartyPlanner.Dominio.Compartilhado
{
    [Serializable]
    public abstract class Entidade<TEntidade>
    {
        public int id;

        public bool ValidarCampoVazio(string campo)
        {
            return string.IsNullOrEmpty(campo);
        }
    }
}