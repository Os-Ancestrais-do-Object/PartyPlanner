using PartyPlanner.Dominio.ModuloTema.ModuloItem;
using System.Drawing;

namespace PartyPlanner.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : Entidade<Tema>
    {
        public string Nome { get; set; }
        public decimal QtdItens { get => Itens.Count; set { } }
        public decimal ValorTotal { get => Itens.Sum(item => item.Valor); set { } }
        public List<ItemTema> Itens { get; set; } = new();

        public Tema(string nome, decimal valorTotal)
        {
            Nome = nome;
            ValorTotal = valorTotal;
        }

        public Tema()
        {
            
        }
    }
}
