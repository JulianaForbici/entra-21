﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOO.Exercicio01
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int Isbn;
        public string IdiomaOriginal;
        public DateTime DatadeLançamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleituras;
        public string ObterAutorTitulo()
        {
            var texto = Autor + Titulo;

            return texto;
        }
        public int ObterQuantidadePaginas()
        {
            var paginas = QuantidadePaginas - QuantidadePaginasLidas;

            return paginas;
        }
        public int ObterToTalPaginasLidas()
        {
            var paginasLidas = QuantidadePaginasLidas;

            return paginasLidas;
        }
    }
}