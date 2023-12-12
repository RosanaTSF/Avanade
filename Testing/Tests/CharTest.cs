using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator;
using Calculator.Services;
{
    
}

namespace Tests
{
    public class CharTest
    {
        private ValidChar _valid;

        public CharTest()
        {
            _valid = new ValidChar();
        }
        [Fact]
        public void DeveContar3CaracteresEmGodERetornar3()
        {
            //Arreng
            string stories = "God";
            //Act
            int result = _valid.CounterChar(stories);
            //Assert
            Assert.Equal(3, result);

        }
    }
}