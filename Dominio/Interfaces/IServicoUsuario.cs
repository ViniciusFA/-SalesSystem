
using SistemaVenda.Dominio.DTO;
using SistemaVenda.Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IServicoUsuario : ISrervicoCRUD<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
