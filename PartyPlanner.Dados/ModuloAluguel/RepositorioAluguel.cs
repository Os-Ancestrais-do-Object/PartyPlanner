using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.ModuloAluguel;
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
                                                        ,[VALORTOTAL]                                                        ,[VALORTOTAL]
                                                        ,[STATUSALUGUEL]
                                                )
                                                VALUES
                                                (
                                                         @FESTA_ID
                                                        ,@VALORCOBRADO
                                                        ,@DESCONTO
                                                        ,@SINAL
                                                        ,@VALORTOTAL
                                                        ,@STATUSALUGUEL
                                                )
                                                SELECT SCOPE_IDENTITY();";

        protected override string EditCommand => @"UPDATE [DBO].[TBALUGUEL]

                                                      SET [FESTA_ID] =      @FESTA_ID
                                                         ,[VALORCOBRADO] =  @VALORCOBRADO
                                                         ,[DESCONTO] =      @DESCONTO
                                                         ,[SINAL] =         @SINAL
                                                         ,[VALORTOTAL] =    @VALORTOTAL
                                                         ,[STATUSALUGUEL] = @STATUSALUGUEL

                                                    WHERE [ID] =            @ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBALUGUEL]
                                                     WHERE [ID] =           @ID";

        protected override string SelectCommand => @"SELECT [FESTA_ID]
                                                           ,[VALORCOBRADO]
                                                           ,[DESCONTO]
                                                           ,[SINAL]
                                                           ,[VALORTOTAL]
                                                           ,[ID]
                                                           ,[STATUSALUGUEL]

                                                          FROM [DBO].[TBALUGUEL]

													WHERE [ID] =		@ID";

        protected override string SelectAllCommand => @"SELECT [FESTA_ID]
                                                              ,[VALORCOBRADO]
                                                              ,[DESCONTO]
                                                              ,[SINAL]
                                                              ,[VALORTOTAL]
                                                              ,[ID]
                                                              ,[STATUSALUGUEL]

                                                          FROM [DBO].[TBALUGUEL]";

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
        }
    }
}
