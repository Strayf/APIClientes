using System.Collections.Generic;
using Domain.Entity;
using Domain.Interface.Repository;

namespace Infra.Repository
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        public int ConnectionTest()
        {
            int value = 0;
            _baseConnection.Open();
            using (var cmd = _baseConnection.CreateCommand())
            {
                cmd.CommandText = @"SELECT  ID, 
                                            Nome
                                    FROM dbo.Teste";
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    value = rdr.GetInt32(rdr.GetOrdinal("ID"));
                    string teste = rdr.GetString(rdr.GetOrdinal("Nome"));
                }
            }
            _baseConnection.Close();
            return value;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Endereco> GetAllEnderecos()
        {
            throw new System.NotImplementedException();
        }

        public Endereco GetEndereco(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(int id, Endereco endereco)
        {
            throw new System.NotImplementedException();
        }
    }
}
