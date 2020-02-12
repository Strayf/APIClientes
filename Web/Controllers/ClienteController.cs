using Domain.Entity;
using Domain.Interface.Service;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Web.Helper;

namespace Web.Controllers
{
    [RoutePrefix("Cliente")]
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
        [Route("BuscarTodos")]
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
        [Route("BuscarPorId")]
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
        [Route("Atualizar")]
        public void Put(int id, Cliente cliente)
        {
            ValidaCliente(cliente);

            if (ModelState.IsValid)
            {
                _clienteService.Update(id, cliente);
            }
            else
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.Forbidden);
            }
        }

        /// <summary>
        /// Inserir cliente
        /// </summary>
        /// <remarks>
        /// Insere cliente com as informações fornecidas.
        /// </remarks>
        /// <param name="cliente">Objeto com informações do cliente.</param>
        [Route("Inserir")]
        public void Post(Cliente cliente)
        {
            ValidaCliente(cliente);

            if (ModelState.IsValid)
            {
                _clienteService.Add(cliente);
            }
            else
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.Forbidden);
            }
        }

        /// <summary>
        /// Apagar cliente.
        /// </summary>
        /// <remarks>
        /// Apaga cliente correspondente ao ID fornecido.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        [Route("Apagar")]
        public void Delete(int id)
        {
            _clienteService.Delete(id);
        }

        private void ValidaCliente(Cliente cliente)
        {
            if (!cliente.CpfValido())
                ModelState.AddModelError("CPF", "CPF Inválido");

            if (cliente.DataNascimento == null)
                ModelState.AddModelError("DataNascimento", "Data de Nascimento é obrigatória");

            if (Auxiliares.AcimaDoLimite(cliente.Nome, 30))
                ModelState.AddModelError("Nome", "Nome acima de 30 caracteres não é permitido");
        }
    }
}