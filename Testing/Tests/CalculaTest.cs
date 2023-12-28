using Calculator.Services;
using Xunit; // Importa biblioteca de testes. O código possui um conjunto de testes unitários para verificar o comportamento da classe Implements em relação às funções Somar e Par, assim Xunit é usado como estrutura de teste.
namespace Tests // Define a namespace Tests para encapsular as classes de teste.
{
    public class CalculaTest
    {
        private readonly Implements _calc; // Declara uma instância privada da classe Implements chamada _calc. Essa instância será usada nos métodos de teste.

        public CalculaTest() // Declara um construtor para a classe CalculaTest, que inicializa a instância _calc criando uma nova instância da classe Implements.
        {
            _calc = new Implements();
        }

        [Fact] // Define métodos de teste usando o Xunit. O método DeveSomar2Com4Retornar6 testa a função Somar da classe Implements. Os métodos seguintes testam a função Par.
        public void DeveSomar2Com4Retornar6() // Um método de teste de fato ([Fact]) que verifica se a soma de 2 e 4 é igual a 6 usando o método Assert.Equal.
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
        public void DeveVerificarSe10EhParERetornarTrue() // Um método de teste de fato ([Fact]) que verifica se o número 10 é par usando o método Assert.True.
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
        [InlineData(10)] // Um método de teste de teoria ([Theory]) que aceita vários conjuntos de dados (números) para verificar se são pares usando o método Assert.True.

        public void DeveVerificarSeNumerosSaoParesRetornarTrue(int num)
        {
            //Act
             bool result = _calc.Par(num); // Chama o método Par da instância _calc com o número fornecido no cenário de teste.
            //Assert
            Assert.True(result);  // Afirma que o resultado da chamada do método Par deve ser verdadeiro para o cenário de teste atual.
        }

        //Outra forma com arrays:
        /*[Theory]
        [InlineData(new int[] { 12, 18, 20 })]
         public void DeveVerificarSeNumerosSaoParesEmArrayRetornarTrue(int numbers)
         {
            Assert.All(numbers, number => Assert.True(_calc.Par(number)));*/ 
         
    }
}

