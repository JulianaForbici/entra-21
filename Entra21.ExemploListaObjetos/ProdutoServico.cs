using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploListaObjetos
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        //Armazenar o código do próximo produto
        private int codigoAtual = 1;

        //ASSINATURA DPS DAS CHAVESSSSSS E CONTEM: encapsulamento + tipoRetorno + NomeMetodo(parametros)
        public void Adicionar(string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
          //CORPO DE UM METODO
          
            
            //Instalar um objeto da classe Produto
            Produto produto = new Produto();

            //ALT SHIFT PONTO

            //Atribuir valor para as propriedades com os dados passados como parâmetro
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;
            int codigoAtual = 1;

            //Atribuir o código novo para o objeto do produto
            produto.Codigo = codigoAtual;

            //Adicionar 1 no código atual para quando criar um novo produto o produto conter outro código
            codigoAtual = codigoAtual + 1;
            
            //Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }
        public bool Editar(int codigoParaAlterar, string nome, double precoUnitario, ProdutoLocalizacao localizacao, int quantidade)
        {
            //Obtem o produto desejado da lista de produto
            Produto produtoParaAlterar = ObterPorCodigo(codigoParaAlterar);

            //Verifica se não foi possível encontrar o produto
            if(produtoParaAlterar == null)
            {
                //Retorna falso pois não existe produto com o código dos parâmetros.
                return false;
            }
            //Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.Quantidade = quantidade;
            
            //Retorna verdadeiro pois foi possível alterar o produto
            return true;

        }
        public bool Apagar(int codigo)
        {
          for(int i = 0; i < produtos.Count; i++)
          {
                //Resgatando de uma lista de tipos primitivos
                //int numero = numeros[i];

                //Resgatando de uma lista de objetos
                Produto produto = produtos[i];
                if(produto.Codigo == codigo)
                {
                    //Posso remover com o indice do objeto
                    // produtos.RemoveAt(i);

                   //Posso remover com o objeto desejado 
                   produtos.Remove(produto);
                    //Retorna verdadeiro pq o produto com o codigo desejado foi removido da lista
                    return true;
                }
          }
          //Retorna falso pois n foi encontrado produto com o codigo desejado, ou seja, nenhum elemento foi removido da lista
          return false;
        }
        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            //Percorrer todos os elementos para encontrar o produto filtrando por codigo
            for(int i = 0; i <= produtos.Count; i++)
            {
                //Obter o produto da lista de produtos em determinado índice
                var produtoAtual = produtos[i];

                //Verifica se o produto atual da lista percorrida é o desejado
                if(produtoAtual.Codigo == codigo)
                {
                    //retorna o produto encontrado
                    return produtoAtual;
                }
            }
            //Retorna null, caso não encontre um produto com o código passado como parâmetro
            return null;
        }
    }
}
