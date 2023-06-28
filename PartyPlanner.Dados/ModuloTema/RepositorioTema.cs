using Microsoft.Data.SqlClient;
using PartyPlanner.Dados.Compartilhado;
using PartyPlanner.Dominio.Compartilhado;
using PartyPlanner.Dominio.ModuloCliente;
using PartyPlanner.Dominio.ModuloTema;
using PartyPlanner.Dominio.ModuloTema.ModuloItem;

namespace PartyPlanner.Dados.ModuloTema
{
    public class RepositorioTema : RepositorioBaseSql<Tema>
    {
        protected override string AddCommand => @"INSERT INTO [DBO].[TBTEMA]
                                                        (
                                                             [NOME]
                                                            ,[VALORTOTAL]
                                                        )

                                                        VALUES
                                                        (
                                                             @NOME
                                                            ,@VALORTOTAL
                                                        )
                                                        SELECT SCOPE_IDENTITY();";

        protected override string EditCommand => @"UPDATE [DBO].[TBTEMA]

                                                      SET [NOME] =          @NOME
                                                         ,[VALORTOTAL] =    @VALORTOTAL

                                                    WHERE [ID] = @ID";

        protected override string DeleteCommand => @"DELETE FROM [DBO].[TBTema]
                                                           WHERE [ID] =     @ID";

        protected override string SelectCommand => @"SELECT
														 [NOME]
														,[VALORTOTAL]
                                                        ,[ID]

													FROM [DBO].[TBTEMA]

													WHERE [ID] =		@ID";

        protected override string SelectAllCommand => @"SELECT [NOME]
                                                              ,[VALORTOTAL]
                                                              ,[ID]

                                                          FROM [DBO].[TBTEMA]";

        public void AdicionarItemTema(Tema temaSelecionado, List<ItemTema> itens)
        {
            temaSelecionado.Itens = itens;
        }

        protected override void ConfigurarParametros(Tema tema)
        {
            comandoBd.Parameters.Clear();
            comandoBd.Parameters.AddWithValue("NOME", tema.Nome);
            comandoBd.Parameters.AddWithValue("VALORTOTAL", tema.ValorTotal);
        }

        protected override void ObterPropriedadesEntidade(Tema tema, SqlDataReader reader)
        {
            int id = (int)reader["ID"];
            string nome = Convert.ToString(reader["NOME"])!;
            decimal valorTotal = Convert.ToDecimal(reader["VALORTOTAL"]);

            tema.Id = id;
            tema.Nome = nome;
            tema.ValorTotal = valorTotal;
        }
    }
}
