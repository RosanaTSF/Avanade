namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            var listaSemNegativos = lista.Where(x => x > 0);
            return listaSemNegativos.ToList(); // Entrada: Lista de números inteiros.Saída: Nova lista contendo apenas números positivos.Lógica: Utiliza a função Where para filtrar os números maiores que zero.
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            var contem = lista.Contains(numero);
            return contem; // Entrada: Lista de números inteiros, número a ser verificado. Saída: Valor booleano indicando se o número está presente na lista.Lógica: Utiliza a função Contains para verificar a presença do número na lista.
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int numero)
        {
            var listaMultiplicada = lista.Select(x => x * numero).ToList();
            return listaMultiplicada; // Entrada: Lista de números inteiros, número pelo qual multiplicar. Saída: Lista resultante da multiplicação. Lógica: Utiliza a função Select para multiplicar cada elemento da lista pelo número especificado.
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            return lista.Max(); // Entrada: Lista de números inteiros.Saída: Maior número presente na lista. Lógica: Utiliza a função Max para encontrar o valor máximo na lista.
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            return lista.Min(); // Entrada: Lista de números inteiros. Saída: Menor número presente na lista. Lógica: Utiliza a função Min para encontrar o valor mínimo na lista.
        }
    }
}
