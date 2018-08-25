using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Loja.DAO;
using Loja.Models;

namespace LojaAPI.Controllers
{
    public class CarrinhoController : ApiController
    {
        //public string Get(int id)
        public Carrinho Get(int id)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            Carrinho carrinho = dao.Busca(id);
            //return carrinho.ToXml();
            return carrinho;
        }

        public string Post([FromBody] Carrinho carrinho)
        {
            CarrinhoDAO dao = new CarrinhoDAO();
            dao.Adiciona(carrinho);
            return "sucess";
        }
    }
}
