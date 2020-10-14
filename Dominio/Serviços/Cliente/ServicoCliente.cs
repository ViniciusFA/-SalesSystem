﻿using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;
using Dominio.Repositorio;
using Dominio.Interfaces;

namespace Dominio.Serviços
{
    public class ServicoCliente : IServicoCliente
    {
        IRepositorioCliente RepositorioCliente;

        public ServicoCliente(IRepositorioCliente repositorioCliente)
        {
            RepositorioCliente = repositorioCliente;
        }

        public void Cadastrar(Cliente cliente)
        {
            RepositorioCliente.Create(cliente);
        }
        
        public Cliente CarregarRegistro(int id)
        {
            return RepositorioCliente.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioCliente.Delete(id);
        }

        public IEnumerable<Cliente> Listagem()
        {
            return RepositorioCliente.Read();
        }
    }
}
