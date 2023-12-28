using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator;
using Calculator.Services;
{

}
namespace Tests // Define um namespace chamado Tests para encapsular as classes de teste.
{
    public class CharTest // Declara uma classe de teste chamada CharTest.
    {
        private ValidChar _valid; // Declara uma instância privada da classe ValidChar chamada _valid. Essa instância será usada nos métodos de teste.

        public CharTest()  // Declara um construtor para a classe CharTest, que inicializa a instância _valid criando uma nova instância da classe ValidChar.
        {
            _valid = new ValidChar(); 
        }
        
        [Fact]
        public void DeveContar3CaracteresEmGodERetornar3()
        {
        // Um método de teste de fato ([Fact]) que verifica se o método CounterChar da classe ValidChar retorna 3 ao contar os caracteres na string "God".       {
            //Arreng
            string stories = "God"; // Declara uma string chamada stories com o valor "God".
            //Act
            int result = _valid.CounterChar(stories); // Chama o método CounterChar da instância _valid passando a string stories como argumento e armazena o resultado na variável result.
            //Assert
            Assert.Equal(3, result); // Afirma que o resultado da chamada do método CounterChar deve ser igual a 3 usando o método Assert.Equal.
        }
    }
}