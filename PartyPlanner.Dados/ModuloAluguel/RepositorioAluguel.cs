using Microsoft.Data.SqlClient;
using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dados.ModuloCliente;
using PartyPlanner.Dados.ModuloFesta;
using PartyPlanner.Dados.ModuloTema;
using PartyPlanner.Dominio.ModuloAluguel;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloFesta;
using PartyPlanner.Dominio.ModuloTema;

namespace PartyPlanner.Dados.ModuloAluguel
{
    public class RepositorioAluguel : RepositorioBaseSql<Aluguel>
    {
        protected override string AddCommand => @"INSERT INTO [DBO].[TBALUGUEL]
                                                (
                                                         [FESTA_ID]
                                                        ,[VALORCOBRADO]
                                                        ,[DESCONTO]
                                                        ,[SINAL]
                                                        ,[VALORTOTAL]
                                                        ,[STATUSALUGUEL]
                                                        ,[DATAQUITACAO]
                                                )
                                                VALUES
                                                (
                                                         @FESTA_ID
                                                        ,@VALORCOBRADO
                                                        ,@DESCONTO
                                                        ,@SINAL
                                                        ,@VALORTOTAL
                                                        ,@STATUSALUGUEL
                                                        ,@DATAQUITACAO
                                                )
                                                SELECT SCOPE_IDENTITY();";

        protected override string EditCommand => @"UPDATE [DBO].[TBALUGUEL]

                                                      SET [FESTA_ID] =      @FESTA_ID
                                                         ,[VALORCOBRADO] =  @VALORCOBRADO
                                                         ,[DESCONTO] =      @DESCONTO
                                                         ,[SINAL] =         @SINAL
                                                         ,[VALORTOTAL] =    @VALORTOTAL
                                                         ,[STATUSALUGUEL] = @STATUSALUGUEL
                                                         ,[DATAQUITACAO] =  @DATAQUITACAO

                                                    WHERE [ID] =            @ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBALUGUEL]
                                                     WHERE [ID] =           @ID";

        protected override string SelectCommand => @"SELECT  A.[FESTA_ID]			
		                                                    ,A.[VALORCOBRADO]			
		                                                    ,A.[DESCONTO]		
		                                                    ,A.[SINAL]		
		                                                    ,A.[VALORTOTAL]		
		                                                    ,A.[ID]
		                                                    ,A.[STATUSALUGUEL]		
		                                                    ,A.[DATAQUITACAO]		
		                                                    ,F.[ENDERECO]			FESTA_ENDERECO
		                                                    ,F.[TEMA_ID]			FESTA_TEMA_ID
		                                                    ,F.[DATA]				FESTA_DATA
		                                                    ,F.[HORAINICIO]		    FESTA_HORAINICIO
		                                                    ,F.[HORAFINAL]		    FESTA_HORAFINAL
		                                                    ,F.[CLIENTE_ID]		    FESTA_CLIENTE_ID
		                                                    ,F.[ALUGUELATIVO]	    FESTA_ALUGUELATIVO
		                                                    ,T.[NOME]               TEMA_NOME
		                                                    ,T.[VALORTOTAL]			TEMA_VALORTOTAL
		                                                    ,C.[NOME]				CLIENTE_NOME
		                                                    ,C.[TELEFONE]			CLIENTE_TELEFONE

	                                                    FROM [DBO].[TBALUGUEL] AS A

	                                                    INNER JOIN [DBO].[TBFESTA] AS F
	                                                    ON A.FESTA_ID = F.ID

	                                                    INNER JOIN [DBO].[TBTEMA] AS T
	                                                    ON F.TEMA_ID = T.ID

	                                                    INNER JOIN [DBO].[TBCLIENTE] AS C
	                                                    ON F.CLIENTE_ID = C.ID

													    WHERE [ID] =		@ID";

        protected override string SelectAllCommand => @"SELECT   A.[FESTA_ID]			
		                                                        ,A.[VALORCOBRADO]			
		                                                        ,A.[DESCONTO]		
		                                                        ,A.[SINAL]		
		                                                        ,A.[VALORTOTAL]		
		                                                        ,A.[ID]
		                                                        ,A.[STATUSALUGUEL]		
		                                                        ,A.[DATAQUITACAO]		
		                                                        ,F.[ENDERECO]			FESTA_ENDERECO
		                                                        ,F.[TEMA_ID]			FESTA_TEMA_ID
		                                                        ,F.[DATA]				FESTA_DATA
		                                                        ,F.[HORAINICIO]		    FESTA_HORAINICIO
		                                                        ,F.[HORAFINAL]		    FESTA_HORAFINAL
		                                                        ,F.[CLIENTE_ID]		    FESTA_CLIENTE_ID
		                                                        ,F.[ALUGUELATIVO]	    FESTA_ALUGUELATIVO
		                                                        ,T.[NOME]               TEMA_NOME
		                                                        ,T.[VALORTOTAL]			TEMA_VALORTOTAL
		                                                        ,C.[NOME]				CLIENTE_NOME
		                                                        ,C.[TELEFONE]			CLIENTE_TELEFONE

	                                                        FROM [DBO].[TBALUGUEL] AS A

	                                                        INNER JOIN [DBO].[TBFESTA] AS F
	                                                        ON A.FESTA_ID = F.ID

	                                                        INNER JOIN [DBO].[TBTEMA] AS T
	                                                        ON F.TEMA_ID = T.ID

	                                                        INNER JOIN [DBO].[TBCLIENTE] AS C
	                                                        ON F.CLIENTE_ID = C.ID";

        //protected override string SelectCommand => @"SELECT [FESTA_ID]
        //                                                   ,[VALORCOBRADO]
        //                                                   ,[DESCONTO]
        //                                                   ,[SINAL]
        //                                                   ,[VALORTOTAL]
        //                                                   ,[ID]
        //                                                   ,[STATUSALUGUEL]
        //                                                   ,[DATAQUITACAO]

        //                                                  FROM [DBO].[TBALUGUEL]

								//					WHERE [ID] =		@ID";

        //protected override string SelectAllCommand => @"SELECT [FESTA_ID]
        //                                                      ,[VALORCOBRADO]
        //                                                      ,[DESCONTO]
        //                                                      ,[SINAL]
        //                                                      ,[VALORTOTAL]
        //                                                      ,[ID]
        //                                                      ,[STATUSALUGUEL]
        //                                                      ,[DATAQUITACAO]

        //                                                  FROM [DBO].[TBALUGUEL]";

        public void AtualizarStatusAluguel(Aluguel aluguelSelecionado, StatusAluguel statusSelecionado, DateTime? dataQuitacao)
        {
            aluguelSelecionado.StatusAluguel = statusSelecionado;

            aluguelSelecionado.DataQuitacao = dataQuitacao.HasValue ? dataQuitacao.Value : null;

            Editar(aluguelSelecionado);
        }

        protected override void ConfigurarParametros(Aluguel aluguel)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("FESTA_ID", aluguel.Festa.Id);
            comandoBd.Parameters.AddWithValue("VALORCOBRADO", aluguel.ValorCobrado);
            comandoBd.Parameters.AddWithValue("DESCONTO", aluguel.Desconto);
            comandoBd.Parameters.AddWithValue("SINAL", aluguel.Sinal);
            comandoBd.Parameters.AddWithValue("VALORTOTAL", aluguel.ValorTotal);
            comandoBd.Parameters.AddWithValue("STATUSALUGUEL", ((int)aluguel.StatusAluguel));
            comandoBd.Parameters.AddWithValue("DATAQUITACAO", aluguel.DataQuitacao.HasValue ? aluguel.DataQuitacao.Value : DBNull.Value);
        }

        protected override void ObterPropriedadesEntidade(Aluguel aluguel, SqlDataReader reader)
        {
            Tema tema = new();

            int idTema = (int)reader["FESTA_TEMA_ID"];
            string nomeTema = Convert.ToString(reader["TEMA_NOME"])!;
            decimal valorTotalTema = Convert.ToDecimal(reader["TEMA_VALORTOTAL"]);

            tema.Id = idTema;
            tema.Nome = nomeTema;
            tema.ValorTotal = valorTotalTema;

            Cliente cliente = new();

            int idCliente = (int)reader["FESTA_CLIENTE_ID"];
            string nomeCliente = Convert.ToString(reader["CLIENTE_NOME"])!;
            string telefone = Convert.ToString(reader["CLIENTE_TELEFONE"])!;

            cliente.Id = idCliente;
            cliente.Nome = nomeCliente;
            cliente.Telefone = telefone;

            int idFesta = (int)reader["FESTA_ID"];
            string endereco = Convert.ToString(reader["FESTA_ENDERECO"]);
            DateTime data = Convert.ToDateTime(reader["FESTA_DATA"]);
            DateTime horaInicio = Convert.ToDateTime(reader["FESTA_HORAINICIO"]);
            DateTime horaFinal = Convert.ToDateTime(reader["FESTA_HORAFINAL"]);
            bool aluguelAtivo = Convert.ToBoolean(reader["FESTA_ALUGUELATIVO"]);

            Festa festa = new(endereco, tema, data, horaInicio, horaFinal, cliente);
            festa.AluguelAtivo = false;

            int idAluguel = (int)reader["ID"];
            DateTime? dataQuitacao = reader["DATAQUITACAO"] == DBNull.Value ? null : Convert.ToDateTime(reader["DATAQUITACAO"]);
            decimal valorCobrado = Convert.ToDecimal(reader["VALORCOBRADO"]);
            decimal desconto = Convert.ToDecimal(reader["DESCONTO"]);
            decimal sinal = Convert.ToDecimal(reader["SINAL"]);
            decimal valorTotal = Convert.ToDecimal(reader["VALORTOTAL"]);
            StatusAluguel statusAluguel = (StatusAluguel)(int)reader["STATUSALUGUEL"];

            aluguel.Id = idAluguel;
            aluguel.Festa = festa;
            aluguel.DataQuitacao = dataQuitacao;
            aluguel.ValorCobrado = valorCobrado;
            aluguel.Desconto = desconto;
            aluguel.Sinal = sinal;
            aluguel.ValorTotal = valorTotal;
            aluguel.StatusAluguel = statusAluguel;
        }
    }
}
