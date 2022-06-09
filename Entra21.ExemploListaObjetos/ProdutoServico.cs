﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploListaObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        // encapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Instalar um objeto da classe Produto
            Produto produto = new Produto();     

            //Atribuir valor para as propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;
            
            //Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        public void Editar()
        {

        }
        public void Apagar()
        {

        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
