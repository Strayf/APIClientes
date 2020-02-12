using Domain.Entity;
using Domain.Interface.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace Web.Controllers
{
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
        public void Delete(int id)
        {
            _enderecoService.Delete(id);
        }
    }
}