using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemploListaObjetos
{
    internal class Produto
    {

        public int Codigo;
        public string Nome;
        public double PrecoUnitario;
        public int Quantidade;
        public ProdutoLocalizacao Localizacao;

        public double CalcularPrecoTotal()
        {
            var preco = Quantidade * PrecoUnitario;

            return preco;
        }
    }
}
    

