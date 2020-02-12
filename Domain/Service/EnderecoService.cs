using System.Collections.Generic;
using Domain.Entity;
using Domain.Interface.Repository;
using Domain.Interface.Service;

namespace Domain.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository)
            : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
        
        public void Add(Endereco cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Endereco> GetAllClientes()
        {
            throw new System.NotImplementedException();
        }

        public Endereco GetCliente(int id)
        {
            throw new System.NotImplementedException();
        }
        
        public void Update(int id, Endereco cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
