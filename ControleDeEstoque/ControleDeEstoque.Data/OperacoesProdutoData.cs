using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace ControleDeEstoque.Data
{
    public class OperacoesProdutoData
    {
        private string _connectionString => ConfigurationManager.ConnectionStrings["ControleDeEstoque"].ConnectionString;

        public List<Produtos> GetProdutos()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"Select * from Produtos";
                var produtos = connection.Query<Produtos>(query).ToList();

                return produtos;
            }
        }
    }
}
