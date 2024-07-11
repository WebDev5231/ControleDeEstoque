using ControleDeEstoque.Business;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class AlertaENotificacoesController : Controller
    {
        public ActionResult AlertasENotificacoes()
        {
            SetProdutosBaixoEstoque();
            SetProdutosProximosValidade();

            return View();
        }

        private void SetProdutosBaixoEstoque()
        {
            var produtosBusiness = new ProdutosBusiness();

            try
            {
                var produtosBaixoEstoque = produtosBusiness.GetProdutosBaixoEstoque();

                if (produtosBaixoEstoque == null || !produtosBaixoEstoque.Any())
                {
                    ViewBag.ProdutosBaixoEstoqueError = "Não foram encontrados produtos com estoque baixo.";
                }
                else
                {
                    ViewBag.ProdutosBaixoEstoque = produtosBaixoEstoque;
                }
            }
            catch (Exception ex)
            {
                ViewBag.ProdutosBaixoEstoqueError = "Erro ao consultar a tabela de produtos: " + ex.Message;
            }
        }

        private void SetProdutosProximosValidade()
        {
            var produtosBusiness = new ProdutosBusiness();

            try
            {
                var produtosProximosValidade = produtosBusiness.GetProdutosValidadeBaixa();

                if (produtosProximosValidade == null || !produtosProximosValidade.Any())
                {
                    ViewBag.ProdutosProximosValidadeError = "Não foram encontrados produtos com baixa validade.";
                }
                else
                {
                    ViewBag.ProdutosProximosValidade = produtosProximosValidade;
                }
            }
            catch (Exception ex)
            {
                ViewBag.ProdutosProximosValidadeError = "Erro ao consultar a tabela de produtos: " + ex.Message;
            }
        }
    }
}
