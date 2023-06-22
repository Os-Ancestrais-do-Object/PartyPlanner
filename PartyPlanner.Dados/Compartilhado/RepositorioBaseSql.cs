using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using PartyPlanner.Dominio.Compartilhado;
using System.Data;
using System.Reflection;

namespace PartyPlanner.Dados.Compartilhado
{
    public abstract class RepositorioBaseSql<TEntidade> where TEntidade : Entidade<TEntidade>, new()
    {
        protected int id = 1001;

        private const string ENDERECO_BD = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=PartyPlannerDb;Integrated Security=True;Pooling=False";

        private static SqlConnection conectarBd = new(ENDERECO_BD);

        protected SqlCommand comandoBd = conectarBd.CreateCommand();

        protected abstract string AddCommand { get; }

        protected abstract string EditCommand { get; }

        protected abstract string DeleteCommand { get; }

        protected abstract string SelectCommand { get; }

        protected abstract string SelectAllCommand { get; }

        public int Id { get { return id; } }

        public void Adicionar(TEntidade registro)
        {
            conectarBd.Open();

            comandoBd.CommandText = AddCommand;

            ConfigurarParametros(registro);

            object id = comandoBd.ExecuteScalar();

            registro.Id = Convert.ToInt32(id);

            conectarBd.Close();
        }

        protected abstract void ConfigurarParametros(TEntidade registro);

        public void Editar(TEntidade novoRegistro, int idSelecionado)
        {
            conectarBd.Open();

            comandoBd.CommandText = EditCommand;

            ConfigurarParametros(novoRegistro);

            comandoBd.Parameters.AddWithValue("ID", idSelecionado);

            comandoBd.ExecuteNonQuery();

            conectarBd.Close();
        }

        public void Excluir(TEntidade registroSelecionado, int idSelecionado)
        {
            conectarBd.Open();

            comandoBd.CommandText = DeleteCommand;

            comandoBd.Parameters.Clear();

            comandoBd.Parameters.AddWithValue("ID", idSelecionado);

            comandoBd.ExecuteNonQuery();

            conectarBd.Close();
        }

        public List<TEntidade> ObterListaRegistros()
        {
            conectarBd.Open();

            List<TEntidade> lista = new();

            comandoBd.CommandText = SelectAllCommand;

            SqlDataReader reader = comandoBd.ExecuteReader();

            while (reader.Read())
            {
                TEntidade entidade = new();
                PropertyInfo[] propriedades = entidade.GetType().GetProperties();

                object[] itens = new object[reader.FieldCount];
                reader.GetValues(itens);

                for (int i = 0; i < itens.Length; i++)
                {
                    foreach (var item in propriedades)
                    {
                        if(item.Name.ToUpper() == reader.GetName(i).ToUpper())
                        {
                            item.SetValue(entidade, itens[i]);
                            break;
                        }
                    }
                }

                lista.Add(entidade);
            }

            conectarBd.Close();

            return lista;
        }
    }
}
