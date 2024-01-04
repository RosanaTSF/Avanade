namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres; // Entrada: Uma string. Saída: Um número inteiro representando a quantidade de caracteres na string. Lógica: Utiliza a propriedade Length da string para obter o número de caracteres.
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem; // Entrada: Duas strings, a string principal e a substring a ser procurada. Saída: Valor booleano indicando se a substring está presente na string principal. Lógica: Utiliza a função Contains para verificar se a substring está contida na string principal.
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina; // Entrada: Duas strings, a string principal e a substring a ser verificada no final da string principal. Saída: Valor booleano indicando se a string principal termina com a substring especificada. Lógica: Utiliza a função EndsWith para verificar se a string principal termina com a substring fornecida.
        }
    }
}