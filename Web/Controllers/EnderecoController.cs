﻿using Domain.Entity;
using Domain.Interface.Service;
using System.Collections.Generic;
using System.Web.Http;
using Web.Helper;

namespace Web.Controllers
{
    [RoutePrefix("Endereco")]
    public class EnderecoController : ApiController
    {

        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        /// <summary>
        /// Buscar todos os endereços.
        /// </summary>
        /// <remarks>
        /// Retorna uma array com todos os endereços cadastrados.
        /// </remarks>
        [Route("BuscarTodos")]
        public List<Endereco> Get()
        {
            return _enderecoService.GetAllEnderecos();
        }

        /// <summary>
        /// Buscar endereço pelo ID.
        /// </summary>
        /// <remarks>
        /// Retorna o endereço correspondente ao ID.
        /// </remarks>
        /// <param name="id">ID do endereço.</param>
        [Route("BuscarPorId")]
        public Endereco Get(int id)
        {
            return _enderecoService.GetEndereco(id);
        }

        /// <summary>
        /// Atualizar endereço.
        /// </summary>
        /// <remarks>
        /// Atualiza endereço pelo ID com as informações fornecidas.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        /// <param name="endereco">Objeto com informações do endereço.</param>
        [Route("Atualizar")]
        public void Put(int id, Endereco endereco)
        {
            _enderecoService.Update(id, endereco);
        }

        /// <summary>
        /// Inserir endereço
        /// </summary>
        /// <remarks>
        /// Insere endereço com as informações fornecidas.
        /// </remarks>
        /// <param name="endereco">Objeto com informações do endereço.</param>
        [Route("Inserir")]
        public void Post(Endereco endereco)
        {
            _enderecoService.Add(endereco);
        }

        /// <summary>
        /// Apagar endereço.
        /// </summary>
        /// <remarks>
        /// Apaga endereço correspondente ao ID fornecido.
        /// </remarks>
        /// <param name="id">ID do cliente.</param>
        [Route("Apagar")]
        public void Delete(int id)
        {
            _enderecoService.Delete(id);
        }

        private void ValidaEndereco(Endereco endereco)
        {
            if (Auxiliares.AcimaDoLimite(endereco.Logradouro, 50))
                ModelState.AddModelError("Logradouro", "Logradouro acima de 50 caracteres não é permitido");

            if (Auxiliares.AcimaDoLimite(endereco.Estado, 40))
                ModelState.AddModelError("Estado", "Estado acima de 40 caracteres não é permitido");

            if (Auxiliares.AcimaDoLimite(endereco.Cidade, 40))
                ModelState.AddModelError("Cidade", "Cidade acima de 40 caracteres não é permitido");

            if (Auxiliares.AcimaDoLimite(endereco.Bairro, 40))
                ModelState.AddModelError("Bairro", "Bairro acima de 40 caracteres não é permitido");
        }
    }
}