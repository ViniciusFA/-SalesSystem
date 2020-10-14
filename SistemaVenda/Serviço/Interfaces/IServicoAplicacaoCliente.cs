﻿using SistemaVenda.Entidades;
using SistemaVenda.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Serviço.Interfaces
{
    public interface IServicoAplicacaoCliente
    {
        ClienteViewModel CarregarRegistro(int codigoCliente);

        IEnumerable<ClienteViewModel> Listagem();

        void Cadastrar(ClienteViewModel clienteViewModel);

        void Excluir(int id);
    }
}
