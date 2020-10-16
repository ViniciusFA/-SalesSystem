﻿
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IServicoVenda : ISrervicoCRUD<Venda>
    {
        IEnumerable<GraficoViewModel> ListaGtafico();
    }
}
