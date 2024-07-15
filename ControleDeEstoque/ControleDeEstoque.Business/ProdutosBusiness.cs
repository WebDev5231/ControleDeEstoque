using ControleDeEstoque.Data;
using ControleDeEstoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Business
{
    public class ProdutosBusiness
    {
        public List<Produtos> GetProdutosBaixoEstoque()
        {
            var produtosBaixoEstoque = new OperacoesProdutoData();

            try
            {
                var produtos = produtosBaixoEstoque.GetProdutos();

                if (produtos == null)
                {
                    Console.WriteLine("Produtos não encontrados");
                    return new List<Produtos>();
                }

                var produtosOrdenados = produtos.OrderBy(p => p.QuantidadeEstoque).ToList();

                return produtosOrdenados;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao resgatar os produtos" + ex.Message);
                return new List<Produtos>();
            }
        }

        public List<Produtos> GetProdutosValidadeBaixa()
        {
            var produtosValidadeBaixa = new OperacoesProdutoData();

            try
            {
                var produtos = produtosValidadeBaixa.GetProdutos();

                if (produtos == null)
                {
                    Console.WriteLine("Produtos não encontrados");
                    return new List<Produtos>();
                }

                var produtosOrdenados = produtos.OrderBy(p => p.DataValidade).ToList();

                return produtosOrdenados;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao resgatar os produtos" + ex.Message);
                return new List<Produtos>();
            }
        }

        public object GetProdutoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produtos> GetProdutosGerenciamento()
        {
            var buscarProdutos = new OperacoesProdutoData();

            try
            {
                var BuscarProdutos = buscarProdutos.GetProdutos();

                if (buscarProdutos == null)
                {
                    Console.WriteLine("Produtos não encontrados");
                    return new List<Produtos>();
                }
                else
                {
                    return BuscarProdutos;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao consultar os dados" + ex);
                return new List<Produtos>();
            }
        }

        public void AdicionarProduto(Produtos produto)
        {
            throw new NotImplementedException();
        }

        public void ExcluirProduto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
