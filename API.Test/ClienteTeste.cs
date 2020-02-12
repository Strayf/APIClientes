using Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain.Entity;

namespace API.Test
{
    public class ClienteTeste
    {
        [Theory]
        [InlineData("32145698700")]
        [InlineData("650")]
        [InlineData("29041732004")]
        public void CpfDeveSerValido(string CPF)
        {
            //Act
            Cliente cliente = new Cliente();
            cliente.CPF = CPF;

            //Assert
            Assert.True(cliente.CpfValido());
        }

        public static IEnumerable<object[]> TestData
        {
            get {
                var data = new DateTime(2010, 1, 1);

                var returnVals = new List<object[]>();
                returnVals.Add(new object[] { data });
                
                return returnVals;
            }
        }

        [Theory, MemberData(nameof(TestData))]
        public void IdadeDeveSerCalculadaCorretamente(DateTime data)
        {
            Cliente cliente = new Cliente();
            cliente.DataNascimento = data;

            var esperado = 10;

            Assert.Equal(cliente.Idade, esperado);
        }
    }
}
