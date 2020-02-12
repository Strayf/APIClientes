using Domain.Entity;
using System.Collections.Generic;

namespace Domain.Interface.Service
{
    public interface IEnderecoService : IBaseService<Endereco>
    {
        void Add(Endereco cliente);
        Endereco GetCliente(int id);
        List<Endereco> GetAllClientes();
        void Update(int id, Endereco cliente);
        void Delete(int id);
    }
}
