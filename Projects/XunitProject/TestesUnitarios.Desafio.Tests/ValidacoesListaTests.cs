using TestesUnitarios.Desafio.Console.Services;
namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };
        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);
        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        var resultadoAtual = new List<int>();
        foreach (var item in lista)
        {
            resultadoAtual.Add(item * 2); 
        };
        // Assert
        Assert.Equal(resultadoAtual, resultadoEsperado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = 9;
        // Act
        var resultadoAtual = EncontrarMaiorNumero(lista); 
        // Assert
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }
    private int EncontrarMaiorNumero(List<int> lista)
        {
            return lista.Max();
        }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = -8;
        // Act
        var resultadoAtual = RetornarMenorNumero(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }
    private int RetornarMenorNumero(List<int> lista)
        {
            return lista.Min();
        }
}
