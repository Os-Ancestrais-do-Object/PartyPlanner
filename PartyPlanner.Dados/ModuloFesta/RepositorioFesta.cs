using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dados.ModuloFesta
{
    public class RepositorioFesta : RepositorioBaseSql<Festa>
    {
        protected List<Festa> ListaRegistros => null;

        protected override string AddCommand => @"INSERT INTO [TBFesta]
	                                            (
		                                            [ENDERECO],
		                                            [DATA],
		                                            [HORAINICIO],
		                                            [HORAFINAL],
		                                            [CLIENTE]
	                                            )
	                                            VALUES
	                                            (
		                                            @ENDERECO,
		                                            @DATA,
		                                            @HORAINICIO,
		                                            @HORAFINAL,
		                                            @CLIENTE
	                                            )
                                                Select Scope_Identity();";

        protected override string EditCommand => @"UPDATE [TBFesta]
													SET
														[ENDERECO] = @ENDERECO,
														[DATA] = @DATA,
														[HORAINICIO] = @HORAINICIO,
														[HORAFINAL] = @HORAFINAL,
														[CLIENTE] = @CLIENTE
													WHERE
														[ID] = @ID";

        protected override string DeleteCommand => @"DELETE FROM [TBFesta]
													WHERE [ID] = @ID";

        protected override string SelectCommand => @"SELECT
														[ID],
														[ENDERECO],
														[DATA],
														[HORAINICIO],
														[HORAFINAL],
														[CLIENTE]
													FROM
														[TBFesta]
													WHERE [ID] = @ID";

        protected override string SelectAllCommand => @"SELECT
															[ID],
															[ENDERECO],
															[DATA],
															[HORAINICIO],
															[HORAFINAL],
															[CLIENTE]
														FROM
															[TBFesta]";

        protected override void ConfigurarParametros(Festa festa)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("ENDERECO", festa.Endereco);
            comandoBd.Parameters.AddWithValue("DATA", festa.Data);
            comandoBd.Parameters.AddWithValue("HORAINICIO", festa.HoraInicio);
            comandoBd.Parameters.AddWithValue("HORAFINAL", festa.HoraFinal);
            comandoBd.Parameters.AddWithValue("CLIENTE", festa.Cliente);
        }

        public List<Festa> ObterFestasSemAluguel()
        {
            return ListaRegistros.FindAll(x => x.AluguelAtivo == false);
        }
    }
}
