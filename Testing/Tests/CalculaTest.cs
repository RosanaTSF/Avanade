using Calculator.Services;
using Xunit;

namespace Tests
{
    public class CalculaTest
    {
        private readonly Implements _calc;

        public CalculaTest()
        {
            _calc = new Implements();
        }

        [Fact]
        public void DeveSomar2Com4Retornar6()
        {
            // Arrange
            int num1 = 2;
            int num2 = 4;

            // Act 
            int result = _calc.Somar(num1, num2);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void DeveVerificarSe10EhParERetornarTrue()
        {
            // Arrange
            int num = 10;

            // Act
            bool result = _calc.Par(num);

            // Assert
            Assert.True(result);
        }
        
        [Theory] //Conj. de cenários para testar um msm resultado.
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]

        public void DeveVerificarSeNumerosSaoParesRetornarTrue(int num)
        {
            //Act
             bool result = _calc.Par(num);
            //Assert
            Assert.True(result);
        }

        //Outra forma com arrays:
        /*[Theory]
        [InlineData(new int[] { 12, 18, 20 })]
         public void DeveVerificarSeNumerosSaoParesEmArrayRetornarTrue(int numbers)
         {
            Assert.All(numbers, number => Assert.True(_calc.Par(number)));*/ 
         
    }
}

