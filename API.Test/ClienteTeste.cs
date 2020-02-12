using Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace API.Test
{
    public class ClienteTeste
    {
        [Theory]
        [InlineData(3, 5, 8)]
        [InlineData(3, -3, 0)]
        [InlineData(10, 20, 30)]
        public void Get_DeveSomarDoisNumeros(int x, int y, int esperado)
        {
            //Arrange

            //Act
            int real = x + y;

            //Assert
            Assert.Equal(esperado, real);
        }
    }
}
