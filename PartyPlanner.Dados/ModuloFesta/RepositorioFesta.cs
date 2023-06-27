using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;

namespace PartyPlanner.Dados.ModuloFesta
{
    public class RepositorioFesta : RepositorioBaseSql<Festa>
    {
        protected List<Festa> ListaRegistros => null;

        protected override string AddCommand => @"INSERT INTO [DBO].[TBFESTA]
                                                    (
                                                           [ENDERECO]
                                                          ,[TEMA_ID]
                                                          ,[DATA]
                                                          ,[HORAINICIO]
                                                          ,[HORAFINAL]
                                                          ,[CLIENTE_ID]
                                                    )
                                                    VALUES
                                                    (
                                                            @ENDERECO
                                                           ,@TEMA_ID
                                                           ,@DATA
                                                           ,@HORAINICIO
                                                           ,@HORAFINAL
                                                           ,@CLIENTE_ID
                                                    )
                                                    SELECT SCOPE_IDENTITY();";

        protected override string EditCommand => @"UPDATE [DBO].[TBFesta]
													SET
														 [ENDERECO] =       @ENDERECO
														,[TEMA_ID] =        @TEMA_ID
														,[DATA] =           @DATA
														,[HORAINICIO] =     @HORAINICIO
														,[HORAFINAL] =      @HORAFINAL
														,[CLIENTE_ID] =     @CLIENTE_ID
													WHERE
														[ID] =              @ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBFesta]
													WHERE [ID] =            @ID";

        protected override string SelectCommand => @"SELECT
														 [ID]
														,[ENDERECO]
														,[TEMA_ID]
														,[DATA]
														,[HORAINICIO]
														,[HORAFINAL]
														,[CLIENTE_ID]
													FROM
														[TBFesta]
													WHERE [ID] =            @ID";

        protected override string SelectAllCommand => @"SELECT 
														   [ID]
														  ,[ENDERECO]
														  ,[TEMA_ID]
														  ,[DATA]
														  ,[HORAINICIO]
														  ,[HORAFINAL]
														  ,[CLIENTE_ID]
														FROM
															[TBFESTA]";

        protected override void ConfigurarParametros(Festa festa)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("ENDERECO", festa.Endereco);
            comandoBd.Parameters.AddWithValue("TEMA_ID", festa.Tema.Id);
            comandoBd.Parameters.AddWithValue("DATA", festa.Data);
            comandoBd.Parameters.AddWithValue("HORAINICIO", festa.HoraInicio);
            comandoBd.Parameters.AddWithValue("HORAFINAL", festa.HoraFinal);
            comandoBd.Parameters.AddWithValue("CLIENTE_ID", festa.Cliente.Id);
        }

        public List<Festa> ObterFestasSemAluguel()
        {
            return ObterListaRegistros().FindAll(x => x.AluguelAtivo == false);
        }
    }
}
