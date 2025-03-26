using Microsoft.AspNetCore.Mvc;
using pjt.apc.crud.produto.api.Models;

namespace pjt.apc.crud.produto.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ProdutosContext produtosContext;
        public ProdutosController(ProdutosContext produtosContext)
        {
            this.produtosContext = produtosContext;
        }

        [HttpGet]
        [Route("GetProdutos")]
        public List<Produtos> GetProdutos()
        {
            return produtosContext.Produtos.ToList();
        }

        [HttpGet]
        [Route("GetProdutoId")]
        public object GetProdutoId(int id)
        {           
            Produtos produto = produtosContext.Produtos.Where(x => x.ID == id).FirstOrDefault();
            if (produto != null)
            {               
                return produto;
            }
            else
            {
                return "Não há produto cadastrado com esse ID, ou o mesmo foi removido.";
            }
        }

        [HttpGet]
        [Route("GetProdutoNome")]
        public object GetProdutoNome(string nome)
        {
            Produtos produto = produtosContext.Produtos.Where(x => x.Nome == nome).FirstOrDefault();
            if (produto != null)
            {
                return produto;
            }
            else
            {
                return "Não há produto cadastrado com esse nome, certifique-se de estar descrevendo-o corretamente.";
            }
        }

        [HttpPost]
        [Route("AddProduto")]
        public string AddProduto(Produtos produto)
        {
            string response = string.Empty;
            produtosContext.Produtos.Add(produto);
            produtosContext.SaveChanges();
            return "Produto adicionado com sucesso.";
        }

        [HttpPut]
        [Route("UpdateProduto")]
        public string UpdateProduto(Produtos produto)
        {
            produtosContext.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            produtosContext.SaveChanges();
            return "Produto editado com sucesso.";
        }

        [HttpDelete]
        [Route("DeleteProduto")]
        public string DeleteProduto(int id)
        {
            Produtos produto = produtosContext.Produtos.Where(x => x.ID == id).FirstOrDefault();
            if (produto != null)
            {
                produtosContext.Produtos.Remove(produto);
                produtosContext.SaveChanges();
                return "Produto removido da base de dados com sucesso.";
            }
            else
            {
                return "Não há produto cadastrado com esse ID, ou o mesmo foi removido.";
            }
        }
    }
}