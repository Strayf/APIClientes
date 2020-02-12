using Domain.Entity;
using Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ClienteController : ApiController
    {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        /// <summary>
        /// Buscar todos os clientes.
        /// </summary>
        /// <remarks>
        /// Retorna uma array com todos os clientes cadastrados.
        /// </remarks>
        public List<Cliente> Get()
        {
            return _clienteService.GetAllClientes();
        }

        /// <summary>
        /// Buscar cliente pelo ID.
        /// </summary>
        /// <remarks>
        /// Retorna o cliente correspondente ao ID.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        public Cliente Get(int id)
        {
            return _clienteService.GetCliente(id);
        }

        /// <summary>
        /// Atualizar cliente.
        /// </summary>
        /// <remarks>
        /// Atualiza cliente pelo ID com as informações fornecidas.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        /// <param name="cliente">Objeto com informações do cliente.</param>
        public void Put(int id, Cliente cliente)
        {
            _clienteService.Update(id, cliente);
        }

        /// <summary>
        /// Inserir cliente
        /// </summary>
        /// <remarks>
        /// Insere cliente com as informações fornecidas.
        /// </remarks>
        /// <param name="cliente">Objeto com informações do cliente.</param>
        public void Post(Cliente cliente)
        {
            _clienteService.Add(cliente);
        }

        /// <summary>
        /// Apagar cliente.
        /// </summary>
        /// <remarks>
        /// Apaga cliente correspondente ao ID fornecido.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        public void Delete(int id)
        {
            _clienteService.Delete(id);
        }
    }
}