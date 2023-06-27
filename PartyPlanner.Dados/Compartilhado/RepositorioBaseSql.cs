using Microsoft.Data.SqlClient;
using PartyPlanner.Dados.ModuloAluguel;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.Compartilhado;
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

        public void Editar(TEntidade novoRegistro)
        {
            conectarBd.Open();

            comandoBd.CommandText = EditCommand;

            ConfigurarParametros(novoRegistro);

            comandoBd.Parameters.AddWithValue("ID", novoRegistro.Id);

            comandoBd.ExecuteNonQuery();

            conectarBd.Close();
        }

        public void Excluir(TEntidade registroSelecionado)
        {
            conectarBd.Open();

            comandoBd.CommandText = DeleteCommand;

            comandoBd.Parameters.Clear();

            comandoBd.Parameters.AddWithValue("ID", registroSelecionado.Id);

            comandoBd.ExecuteNonQuery();

            conectarBd.Close();
        }

        public List<TEntidade> ObterListaRegistros()
        {
            RepositorioAluguel _repositorioAluguel = new();
            RepositorioCliente _repositorioCliente = new();
            RepositorioFesta _repositorioFesta = new();
            RepositorioTema _repositorioTema = new();

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
                        if (item.Name.ToUpper() == reader.GetName(i).ToUpper())
                        {
                            item.SetValue(entidade, itens[i] == DBNull.Value ? null : itens[i]);
                            break;
                        }

                        if (item.Name.ToUpper() + "_ID" == reader.GetName(i).ToUpper())
                        {
                            switch (reader.GetName(i).ToUpper())
                            {
                                case "ALUGUEL_ID": item.SetValue(entidade, _repositorioAluguel.SelecionarId((int)itens[i])); break;
                                case "CLIENTE_ID": item.SetValue(entidade, _repositorioCliente.SelecionarId((int)itens[i])); break;
                                case "FESTA_ID": item.SetValue(entidade, _repositorioFesta.SelecionarId((int)itens[i])); break;
                                case "TEMA_ID": item.SetValue(entidade, _repositorioTema.SelecionarId((int)itens[i])); break;
                            }
                        }
                    }
                }

                lista.Add(entidade);
            }

            conectarBd.Close();

            return lista;
        }

        public TEntidade? SelecionarId(int idSelecionado)
        {
            RepositorioAluguel _repositorioAluguel = new();
            RepositorioCliente _repositorioCliente = new();
            RepositorioFesta _repositorioFesta = new();
            RepositorioTema _repositorioTema = new();

            conectarBd.Open();

            TEntidade entidade = new();

            PropertyInfo[] propriedades = entidade.GetType().GetProperties();

            comandoBd.CommandText = SelectCommand;

            comandoBd.Parameters.AddWithValue("ID", idSelecionado);

            SqlDataReader reader = comandoBd.ExecuteReader();

            if (reader.Read())
            {
                object[] itens = new object[reader.FieldCount];
                reader.GetValues(itens);

                for (int i = 0; i < itens.Length; i++)
                {
                    foreach (var item in propriedades)
                    {
                        if (item.Name.ToUpper() == reader.GetName(i).ToUpper())
                        {
                            item.SetValue(entidade, itens[i] == DBNull.Value ? null : itens[i]);
                            break;
                        }

                        if (item.Name.ToUpper() + "_ID" == reader.GetName(i).ToUpper())
                        {
                            switch (reader.GetName(i).ToUpper())
                            {
                                case "ALUGUEL_ID": item.SetValue(entidade, _repositorioAluguel.SelecionarId((int)itens[i])); break;
                                case "CLIENTE_ID": item.SetValue(entidade, _repositorioCliente.SelecionarId((int)itens[i])); break;
                                case "FESTA_ID": item.SetValue(entidade, _repositorioFesta.SelecionarId((int)itens[i])); break;
                                case "TEMA_ID": item.SetValue(entidade, _repositorioTema.SelecionarId((int)itens[i])); break;
                            }
                        }
                    }
                }
            }

            conectarBd.Close();

            return entidade;
        }
    }
}
