using Entra21.ExemploOrientacaoObjetos.Produtos;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Entra21.ExemploOrientacaoObjetos.Tests.Produtos
{
    public class ProdutoTests
    {
        [Fact]

        public void Validar_EhVencido_Com_DataVencimento_Menor_Hoje()
        {
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(-1);

            //Act (ato de execução do metodo que deseja testar
            var produtoVencido = produto.EhVencido();

            // assert (validação do que foi gerado)
            produtoVencido.Should().BeTrue();


        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Maior_Hoje()
        {
            // Arrange 
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(1);

            // act
            var vencido = produto.EhVencido();

            // Assert
            vencido.Should().BeFalse();

        }

        [Fact]
        public void Validar_EhVencido_Com_DataVencimento_Hoje()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //act
            var vencido = produto.EhVencido();

            //assert
            vencido.Should().BeTrue();

        }

        [Fact]
        public void Validar_EstaEmPromocao_Verdeiro()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today.AddDays(3);

            //act 
            var emPromocao = produto.EstaEmPromocao();

            //assert 
            emPromocao.Should().BeTrue();

        }

        [Fact]
        public void Validar_EstaEmPromocao_False()
        {
            //Arrange
            var produto = new Produto();
            produto.DataVencimento = DateTime.Today;

            //Act
            var emPromocao = produto.EstaEmPromocao();

            // Assert
            emPromocao.Should().BeFalse();

        }


    }
}
