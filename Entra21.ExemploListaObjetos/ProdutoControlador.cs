using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploListaObjetos
{
    internal class ProdutoControlador
    {
        public void GerenciarMenu()
        {
            int codigo = 0;
            while(codigo != 6)
            {
                Console.Clear();
                //Apresenta o menu e solicita o código
                codigo = ApresentarSolicitarMenu();

                Console.Clear();

                if(codigo == 1)
                {
                    //MENU escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if(codigo == 2)
                {
                    //MENU escolhido para cadastrar produtos
                    Cadastrar();
                }
                else if(codigo == 3)
                {
                     //MENU escolhido para editar produtos
                    Editar();
                }
                else if(codigo == 4)
                {
                    //MENU escolhido para apagar produtos
                    Apagar();
                }
                else if(codigo == 5)
                {
                    //MENU escolhido para apresentar um produto
                     ApresentarProduto();
                }
                //ReadKey
                Console.Write("\n\nAperte alguma tecla para continuar...");
                Console.ReadKey();
            }
            Cadastrar();
            ApresentarProdutos();
            Cadastrar();
            private void ApresentarProduto()
            {
                ApresentarProdutos();

                Console.Write("Digite o código do produto a ser detalhado: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                var produto = ProdutoServico.ObterPorCodigo(codigo);

                //Verifica se o produto não está cadastrado na lista
                if(produto == null)
                {
                    Console.WriteLine("Produto não cadastrado.");

                    return;
                }
                Console.Clear();
                Console.WriteLine(@$"Código: {produto.Codigo}
                    Nome: {produto.Nome}
                    Preço Unitário: {produto.PrecoUnitario}
                    Quantidade: {produto.Quantidade}
                    Total: {produto.CalcularPrecoTotal()}");
            }
            private void Apagar()
            {
                ApresentarProdutos();

                Console.WriteLine("Digite o código do produto para apagar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());  

                var registroApagado = ProdutoServico.Apagar(codigo);

                Console.WriteLine(registroApagado == true
                    ? "Registro removido com sucesso"
                    : "Nenhum produto cadastrado com o código informado");
            }
             private void Editar()
             {
                ApresentarProdutos();

                Console.WriteLine("Código produto desejado: ");
                var codigo = Convert.ToInt32(Console.ReadLine());   

                Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(@"Localizações Disponíveis:
- Armazém
- Área Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);
                
                var alterou = ProdutoServico.Editar(codigo, nome, precoUnitario, localizacaoProduto, quantidade);
                if(alterou == false)
                {
                    Console.WriteLine("Código digitado não existe.");
                }
                else
                {
                    Console.WriteLine("Produto alterado com sucesso.");
                }
             }
           
        }
        private int ApresentarSolicitarMenu()
        {
            Console.WriteLine(@"Menu: 
1- Listar todos
2- Cadastrar
3- Editar
4- Apagar
5- Apresentar produto desejado
6- Sair");
            int codigo = SolicitarCodigo();
            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;
            //Continua solicitando o código até que seja um código de 1 e 6
            while(codigo < 1 || codigo >= 6)
            {
                try
                {
                    Console.Write("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Digite um MENU válido.");
                }
            }
            return codigo;
        }

        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(@"Localizações Disponíveis:
- Armazém
- Área Venda
- Loja");
            Console.Write("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);


            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);

            private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
                
            {
                if(localizacao.ToLower() == "armazem")
                {
                    return ProdutoLocalizacao.Armazem;
                }
                else if(localizacao.ToLower() == "loja")
                {
                    return ProdutoLocalizacao.Loja;
                }
                else
                {
                    return ProdutoLocalizacao.AreaVenda;
                }
            }

        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if(produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado.");
                //Para EXECUÇÃO deste método
                return;
            }
            Console.WriteLine("Lista de Produtos: ");

            for(var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];

                Console.WriteLine("\nNome: " + produtoAtual.Nome + "\nCódigo: " + produtoAtual.Codigo + "\n");
            }
        }
    }
}
