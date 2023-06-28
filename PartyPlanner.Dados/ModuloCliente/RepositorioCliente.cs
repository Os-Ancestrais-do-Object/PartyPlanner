using Microsoft.Data.SqlClient;
using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.Dados.ModuloCliente
{
    public class RepositorioCliente : RepositorioBaseSql<Cliente>
    {
        protected override string AddCommand => @"INSERT INTO [DBO].[TBCLIENTE]
	                                            (
		                                            [NOME],
		                                            [TELEFONE]
	                                            )
	                                            VALUES
	                                            (
		                                            @NOME,
		                                            @TELEFONE
	                                            )
                                                SELECT SCOPE_IDENTITY();";

        protected override string EditCommand => @"UPDATE [DBO].[TBCliente]
													SET
														[NOME] =		@NOME,
														[TELEFONE] =	@TELEFONE
													WHERE
														[ID] =			@ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBCliente]
													WHERE [ID] =		@ID";

        protected override string SelectCommand => @"SELECT
														[ID],
														[NOME],
														[TELEFONE]
													FROM
														[TBCliente]
													WHERE [ID] =		@ID";

        protected override string SelectAllCommand => @"SELECT
															[ID],
															[NOME],
															[TELEFONE]
														FROM
															[TBCliente]";

        protected override void ConfigurarParametros(Cliente cliente)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("NOME", cliente.Nome);
            comandoBd.Parameters.AddWithValue("TELEFONE", cliente.Telefone);
        }

        protected override void ObterPropriedadesEntidade(Cliente cliente, SqlDataReader reader)
        {
			int id = (int)reader["ID"];
            string nome = Convert.ToString(reader["NOME"])!;
			string telefone = Convert.ToString(reader["TELEFONE"])!;

            cliente.Id = id;
			cliente.Nome = nome;
			cliente.Telefone = telefone;
        }
    }
}
