using CrudProdutos.Entities;
using CrudProdutos.Settings;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Repositories
{
    public class ProdutoRepository
    {
        public void Inserir(Produto produto)
        {
            var query = @"INSERT INTO PRODUTO(ID, NOME, PRECO, QUANTIDADE, DATAHORACADASTRO, DATAHORAULTIMAALTERACAO) VALUES(@Id, @Nome, @Preco, @Quantidade, @DataHoraCadastro, @DataHoraUltimaAlteracao)";

            using (var connection = new SqlConnection(AppSettings.GetConnectionString()))
            {
                connection.Execute(query, produto);
            }
        }

        public bool Atualizar(Produto produto)
        {
            var query = @"UPDATE PRODUTO 
                          SET NOME = @Nome,
                              PRECO = @Preco,
                              QUANTIDADE = @Quantidade,
                              DATAHORAULTIMAALTERACAO = @DataHoraUltimaAlteracao
                          WHERE 
                              ID = @Id";

            using (var connection = new SqlConnection(AppSettings.GetConnectionString()))
            {
                int rowsAffected = connection.Execute(query, produto);

                return rowsAffected > 0; //true ou false
            }
        }

        public bool Excluir(Guid id)
        {
            var query = @"DELETE FROM PRODUTO
                          WHERE ID = @Id";

            using (var connection = new SqlConnection(AppSettings.GetConnectionString()))
            {
                int rowsAffected = connection.Execute(query, new { @Id = id });

                return rowsAffected > 0; //true ou false
            }
        }

        public List<Produto> Consultar(string nome)
        {
            var query = @"
                 SELECT ID, NOME, PRECO, QUANTIDADE, DATAHORACADASTRO, DATAHORAULTIMAALTERACAO 
                   FROM PRODUTO
                   WHERE NOME LIKE @Nome
                   ORDER BY NOME ASC";

            using (var connection = new SqlConnection(AppSettings.GetConnectionString()))
            {
                return connection.Query<Produto>(query, new { @Nome = $"%{nome}%" }).ToList();
            }

        }

        public Produto? ObterPorId(Guid id)
        {
            var query = @"
                 SELECT ID, NOME, PRECO, QUANTIDADE, DATAHORACADASTRO, DATAHORAULTIMAALTERACAO 
                   FROM PRODUTO
                   WHERE ID = @Id";

            using (var connection = new SqlConnection(AppSettings.GetConnectionString()))
            {
                return connection.QueryFirstOrDefault<Produto>(query, new { Id = id });
            }
        }
    }
}
