using Avanade.ParkingProject.Model; //importa o namespace (Em C#, um namespace organiza e agrupa códigod. Ajudando a evitar conflitos de nomes entre diferentes partes de um programa ou entre bibliotecas).

Console.OutputEncoding = System.Text.Encoding.UTF8; /*
Console: entrada e saída.
OutputEncoding: Propriedade da classe `Console` que controla a codificação de caracteres usada para a saída no console.
System.Text.Encoding: Namespace contendo classes relacionadas à codificação de caracteres.
Encoding: é uma classe que oferece métodos para converter strings em bytes e vice-versa.
UTF8: Propriedade estática da classe Encoding que representa a codificação UTF-8, um padrão Unicode capaz de suportar uma ampla variedade de caracteres (acentos e símbolos especiais).
 */

decimal initialPrice = 0; // Declara e inicializa a variável initialPrice do tipo decimal.
decimal pricePerHour = 0; //

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" + "Digite o preço inicial:");

initialPrice = Convert.ToDecimal(Console.ReadLine()); //Lê e converte a entrada do usuário para decimal, atribuindo à variável initialPrice.

Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking park = new Parking(initialPrice, pricePerHour); //Cria uma instância (cria um objeto) da classe Parking com os valores iniciais informados pelo usuário.

string opcao = string.Empty;
bool exibirMenu = true; //Inicia um loop que executa o menu enquanto a variável exibirMenu for true.

while (exibirMenu)
{
    Console.Clear(); //limpa a tela do Console.
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine(); //Lê a opção do usuário e atribui à variável opcao.

    if (int.TryParse(opcao, out int escolha) && escolha >= 1 && escolha <= 4)
    {
        switch (escolha)
        {
            case 1:
                park.AddVehicle();
                break;

            case 2:
                Console.WriteLine("Digite a placa do veículo para remover:");
                string plateToRemove = Console.ReadLine();
                park.RemoveVehicle(plateToRemove);
                break;

            case 3:
                park.ListVehicles();
                break;

            case 4:
                exibirMenu = false;
                break;
        }

        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
    else //Exibe mensagem de erro e solicita ao usuário pressionar uma tecla para continuar.
    {
        Console.WriteLine("Opção inválida. Digite um número de 1 a 4.");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou");
