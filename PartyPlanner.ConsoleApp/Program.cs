using Microsoft.Data.SqlClient;
using PartyPlanner.Dominio.ModuloCliente;
using System.Windows.Input;

namespace PartyPlanner.ConsoleApp
{
    internal class Program
    {
        public static SqlConnection conectar = new();

        public static SqlCommand comando = new();

        static void Main(string[] args)
        {
            ConectarBancoDeDados();

            Cliente cliente = new("Pedro", "(49)9995-4578");

            //Adicionar(cliente);

            //Editar(1001);

            //Excluir(1001);

            //SelecionarPorId(1002);

            //List<Cliente> listaClientes = SelecionarTodos();

            conectar.Close();
        }

        public static void Adicionar(Cliente cliente)
        {
            comando.CommandText = @"INSERT INTO [TBCliente]
	                                (
		                                [NOME],
		                                [TELEFONE]
	                                )
	                                VALUES
	                                (
		                                @N,
		                                @T
	                                )
                                    Select Scope_Identity();";

            comando.Parameters.AddWithValue("N", cliente.Nome);
            comando.Parameters.AddWithValue("T", cliente.Telefone);

            object id = comando.ExecuteScalar();

            cliente.id = Convert.ToInt32(id);

            conectar.Close();
        }

        public static void Editar(int idSelecionado)
        {
            Cliente cliente = ObterCliente();

            comando.CommandText = @"UPDATE [TBCliente]
	                                SET
		                                [NOME] = @N,
		                                [TELEFONE] = @T
	                                WHERE
		                                [ID] = @ID";

            comando.Parameters.AddWithValue("ID", idSelecionado);
            comando.Parameters.AddWithValue("N", cliente.Nome);
            comando.Parameters.AddWithValue("T", cliente.Telefone);

            comando.ExecuteNonQuery();

            conectar.Close();
        }

        public static void Excluir(int idSelecionado)
        {
            comando.CommandText = @"DELETE FROM [TBCliente]
	                                      WHERE [ID] = @ID";

            comando.Parameters.AddWithValue("ID", idSelecionado);

            comando.ExecuteNonQuery();

            conectar.Close();
        }

        public static Cliente SelecionarPorId(int idSelecionado)
        {
            comando.CommandText = @"SELECT
	                                    [ID],
	                                    [NOME],
	                                    [TELEFONE]
                                    FROM
	                                    [TBCliente]
                                    WHERE [ID] = @ID";

            comando.Parameters.AddWithValue("ID", idSelecionado);

            SqlDataReader leitor = comando.ExecuteReader();

            Cliente cliente = null;

            if (leitor.Read())
            {
                cliente = new Cliente(leitor[1].ToString(), leitor[2].ToString());

                cliente.id = Convert.ToInt32(leitor[0]);
            }

            return cliente;
        }

        public static List<Cliente> SelecionarTodos()
        {
            List<Cliente> listaClientes = new();

            comando.CommandText = @"SELECT
	                                    [ID],
	                                    [NOME],
	                                    [TELEFONE]
                                    FROM
	                                    [TBCliente]";

            SqlDataReader leitor = comando.ExecuteReader();

            while (leitor.Read())
            {
                Cliente cliente = new Cliente(leitor[1].ToString(), leitor[2].ToString());

                cliente.id = Convert.ToInt32(leitor[0]);

                listaClientes.Add(cliente);
            }

            return listaClientes;
        }

        private static Cliente ObterCliente()
        {
            Console.Write("Escreva o Nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Escreva o Telefone do Cliente: ");
            string telefone = Console.ReadLine();

            return new Cliente(nome, telefone);
        }

        private static void ConectarBancoDeDados()
        {
            conectar.ConnectionString = @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=PartyPlannerDb;Integrated Security=True;Pooling=False";

            comando.Connection = conectar;

            conectar.Open();
        }
    }
}