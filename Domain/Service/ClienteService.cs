using Domain.Entity;
using Domain.Interface.Repository;
using Domain.Interface.Service;
using System;
using System.Collections.Generic;

namespace Domain.Service
{
    public class ClienteService : BaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Add(Cliente cliente)
        {
            if (!cliente.CpfValido())
            {
                throw new FormatException("CPF Inválido.");
            }
            if (true)
            _clienteRepository.Add(cliente);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAllClientes()
        {
            throw new NotImplementedException();
        }

        public Cliente GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        public bool TesteService()
        {
            if (_clienteRepository.ConnectionTest() > 0)
                return true;
            return false;
        }

        public void Update(int id, Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
