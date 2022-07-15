﻿using Entra21.BancoDados01.Ado.Nett.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Nett.Services
{
    internal interface ITipoPersonagemService
    {
        void Cadastrar(TipoPersonagem tipoPersonagem);

        List<TipoPersonagem> ObterTodos();

        void Apagar(int id);

    }
}
