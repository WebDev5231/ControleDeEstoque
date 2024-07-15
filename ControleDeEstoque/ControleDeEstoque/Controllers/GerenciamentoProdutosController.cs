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
            GetProdutos();

            return View();
        }

        private void GetProdutos()
        {
            var buscarProdutos = new ProdutosBusiness();

            try
            {
                var produtos = buscarProdutos.GetProdutosGerenciamento();

                if (produtos == null)
                {
                    TempData["ErrorMessage"] = "Não foi possível obter os dados";
                }
                else
                {
                    ViewBag.ProdutosResgatados = produtos;
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Não foi possível localizar os produtos: " + ex.Message;
            }
        }

        [HttpPost]
        public ActionResult AdicionarProduto(Produtos produto)
        {
            if (ModelState.IsValid)
            {
                var produtosBusiness = new ProdutosBusiness();

                try
                {
                    produtosBusiness.AdicionarProduto(produto);
                    TempData["SuccessMessage"] = "Produto adicionado com sucesso!";
                }
                catch (Exception ex)
                {
                    TempData["ErrorMessage"] = "Erro ao adicionar o produto: " + ex.Message;
                }
            }
            else
            {
                TempData["ErrorMessage"] = "Os dados do produto são inválidos.";
            }

            return RedirectToAction("GerenciamentoProdutos");
        }
    }
}
