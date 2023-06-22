using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloCliente;

namespace PartyPlanner.Dados.ModuloCliente
{
    public class RepositorioCliente : RepositorioBaseSql<Cliente>
    {
        protected override string AddCommand => @"INSERT INTO [TBCliente]
	                                            (
		                                            [NOME],
		                                            [TELEFONE]
	                                            )
	                                            VALUES
	                                            (
		                                            @NOME,
		                                            @TELEFONE
	                                            )
                                                Select Scope_Identity();";

        protected override string EditCommand => @"UPDATE [TBCliente]
													SET
														[NOME] = @NOME,
														[TELEFONE] = @TELEFONE
													WHERE
														[ID] = @ID";

        protected override string DeleteCommand => @"DELETE FROM [TBCliente]
													WHERE [ID] = @ID";

        protected override string SelectCommand => @"SELECT
														[ID],
														[NOME],
														[TELEFONE]
													FROM
														[TBCliente]
													WHERE [ID] = @ID";

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
    }
}
