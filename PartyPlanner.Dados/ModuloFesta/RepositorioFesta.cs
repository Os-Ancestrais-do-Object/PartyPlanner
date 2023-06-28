using Microsoft.Data.SqlClient;
using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;
using System.Data;

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
														  ,[ALUGUELATIVO]
                                                    )
                                                    VALUES
                                                    (
                                                            @ENDERECO
                                                           ,@TEMA_ID
                                                           ,@DATA
                                                           ,@HORAINICIO
                                                           ,@HORAFINAL
                                                           ,@CLIENTE_ID
														   ,@ALUGUELATIVO
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
														,[ALUGUELATIVO] =   @ALUGUELATIVO
													WHERE
														[ID] =              @ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBFesta]
													WHERE [ID] =            @ID";

        protected override string SelectCommand => @"SELECT  F.[ID]
		                                                    ,F.[ENDERECO]
		                                                    ,F.[TEMA_ID]
		                                                    ,F.[DATA]
		                                                    ,F.[HORAINICIO]
		                                                    ,F.[HORAFINAL]
		                                                    ,F.[CLIENTE_ID]
		                                                    ,F.[ALUGUELATIVO]
		                                                    ,T.[NOME]               TEMA_NOME
		                                                    ,T.[VALORTOTAL]			TEMA_VALORTOTAL
		                                                    ,C.[NOME]				CLIENTE_NOME
		                                                    ,C.[TELEFONE]			CLIENTE_TELEFONE

	                                                    FROM [DBO].[TBFESTA] AS F

	                                                    INNER JOIN [DBO].[TBTEMA] AS T
	                                                    ON F.TEMA_ID = T.ID

	                                                    INNER JOIN [DBO].[TBCLIENTE] AS C
	                                                    ON F.CLIENTE_ID = C.ID

													WHERE [ID] =            @ID";

        protected override string SelectAllCommand => @"SELECT   F.[ID]
		                                                        ,F.[ENDERECO]
		                                                        ,F.[TEMA_ID]
		                                                        ,F.[DATA]
		                                                        ,F.[HORAINICIO]
		                                                        ,F.[HORAFINAL]
		                                                        ,F.[CLIENTE_ID]
		                                                        ,F.[ALUGUELATIVO]
		                                                        ,T.[NOME]               TEMA_NOME
		                                                        ,T.[VALORTOTAL]			TEMA_VALORTOTAL
		                                                        ,C.[NOME]				CLIENTE_NOME
		                                                        ,C.[TELEFONE]			CLIENTE_TELEFONE

	                                                        FROM [DBO].[TBFESTA] AS F

	                                                        INNER JOIN [DBO].[TBTEMA] AS T
	                                                        ON F.TEMA_ID = T.ID

	                                                        INNER JOIN [DBO].[TBCLIENTE] AS C
	                                                        ON F.CLIENTE_ID = C.ID";

        protected override void ConfigurarParametros(Festa festa)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("ENDERECO", festa.Endereco);
            comandoBd.Parameters.AddWithValue("TEMA_ID", festa.Tema.Id);
            comandoBd.Parameters.AddWithValue("DATA", festa.Data);
            comandoBd.Parameters.AddWithValue("HORAINICIO", festa.HoraInicio);
            comandoBd.Parameters.AddWithValue("HORAFINAL", festa.HoraFinal);
            comandoBd.Parameters.AddWithValue("CLIENTE_ID", festa.Cliente.Id);
            comandoBd.Parameters.AddWithValue("ALUGUELATIVO", SqlDbType.Bit).Value = festa.AluguelAtivo;
        }

        public List<Festa> ObterFestasSemAluguel()
        {
            return ObterListaRegistros().FindAll(x => x.AluguelAtivo == false);
        }

        protected override void ObterPropriedadesEntidade(Festa festa, SqlDataReader reader)
        {
            Tema tema = new();

            int idTema = (int)reader["TEMA_ID"];
            string nomeTema = Convert.ToString(reader["TEMA_NOME"])!;
            decimal valorTotalTema = Convert.ToDecimal(reader["TEMA_VALORTOTAL"]);

            tema.Id = idTema;
            tema.Nome = nomeTema;
            tema.ValorTotal = valorTotalTema;

            Cliente cliente = new();

            int idCliente = (int)reader["CLIENTE_ID"];
            string nomeCliente = Convert.ToString(reader["CLIENTE_NOME"])!;
            string telefone = Convert.ToString(reader["CLIENTE_TELEFONE"])!;

            cliente.Id = idCliente;
            cliente.Nome = nomeCliente;
            cliente.Telefone = telefone;

            int id = (int)reader["ID"];
            string endereco = Convert.ToString(reader["ENDERECO"])!;
            DateTime data = Convert.ToDateTime(reader["DATA"]);
            DateTime horaInicio = Convert.ToDateTime(reader["HORAINICIO"]);
            DateTime horaFinal = Convert.ToDateTime(reader["HORAFINAL"]);
            bool aluguelAtivo = Convert.ToBoolean(reader["ALUGUELATIVO"]);

            festa.Id = id;
            festa.Endereco = endereco;
            festa.Tema = tema;
            festa.Data = data;
            festa.HoraInicio = horaInicio;
            festa.HoraFinal = horaFinal;
            festa.Cliente = cliente;
            festa.AluguelAtivo = false;
        }
    }
}
