using Avanade.ParkingProject.Model;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal initialPrice = 0;
decimal pricePerHour = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");
initialPrice = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
pricePerHour = Convert.ToDecimal(Console.ReadLine());

Parking park = new Parking(initialPrice, pricePerHour);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

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
    else
    {
        Console.WriteLine("Opção inválida. Digite um número de 1 a 4.");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadLine();
    }
}

Console.WriteLine("O programa se encerrou");
