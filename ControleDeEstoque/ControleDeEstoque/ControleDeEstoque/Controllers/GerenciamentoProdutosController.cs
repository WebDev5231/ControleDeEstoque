using ControleDeEstoque.Business;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class GerenciamentoProdutosController : Controller
    {
        public ActionResult GerenciamentoProdutos()
        {
            // Criação de três produtos fictícios
            var produtos = new List<Produtos>
            {
                new Produtos
                {
                    Id = 1,
                    Nome = "Produto A",
                    Descricao = "Descrição do Produto A",
                    CodigoBarras = "1234567890123",
                    PrecoCompra = 10.00m,
                    PrecoVenda = 15.00m,
                    QuantidadeEstoque = 50,
                    DataValidade = new DateTime(2024, 12, 31),
                    Categoria = "Categoria 1",
                },
                new Produtos
                {
                    Id = 2,
                    Nome = "Produto B",
                    Descricao = "Descrição do Produto B",
                    CodigoBarras = "1234567890124",
                    PrecoCompra = 20.00m,
                    PrecoVenda = 30.00m,
                    QuantidadeEstoque = 100,
                    DataValidade = new DateTime(2024, 11, 30),
                    Categoria = "Categoria 2",
                },
                new Produtos
                {
                    Id = 3,
                    Nome = "Produto C",
                    Descricao = "Descrição do Produto C",
                    CodigoBarras = "1234567890125",
                    PrecoCompra = 5.00m,
                    PrecoVenda = 10.00m,
                    QuantidadeEstoque = 200,
                    DataValidade = new DateTime(2024, 10, 31),
                    Categoria = "Categoria 3",
                }
            };

            // Passar a lista de produtos para a view
            return View(produtos);
        }
    }
}
