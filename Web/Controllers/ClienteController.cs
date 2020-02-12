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

        public bool Get()
        {
            bool teste = _clienteService.TesteService();
            return teste;
        }

        public void Post(int ID, Cliente cliente)
        {
            //Cliente c = new Cliente(ID, Nome, CPF, DataNascimento);
            _clienteService.Add(cliente);
        }
    }
}