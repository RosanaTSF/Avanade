using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanade.ParkingProject.Model
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>(); //Encapsulamento.

        public Parking(decimal initialPrice, decimal pricePerHour) // Construtor.
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle() 
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput)) //Trata o código para que não aceite placa vazia ou nula.
            {
                vehicles.Add(userInput);
                Console.WriteLine("Veículo estacionado com sucesso."); //Iteração com o usuário.
            }
            else
            {
                Console.WriteLine("Placa inválida. A placa não pode ser nula ou vazia");
            }
        }

        public void RemoveVehicle(string plate) 
        {
            if (vehicles != null && !string.IsNullOrEmpty(plate))
            {
                if (vehicles.Contains(plate)) // Verifica se a entrada do usuário pode ser convertida para um número inteiro e a armazena na variável hours.
                {
                    Console.WriteLine($"Veículo de placa {plate} removido com sucesso.");
                    vehicles.Remove(plate);

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    if (int.TryParse(Console.ReadLine(), out int hours))  //Se TryParse for bem-sucedido, o valor convertido é atribuído à variável hours, e o bloco dentro do if é executado. Se a conversão falhar, o bloco else é executado, permitindo que o programa trate a situação de entrada inválida sem lançar uma exceção.
                    {
                        decimal amount = initialPrice + (pricePerHour * hours);
                        Console.WriteLine($"O valor total é {amount}"); 

                        Console.WriteLine("Digite a placa que deseja remover:");
                        string plateToRemove = Console.ReadLine();

                        if (vehicles.Contains(plateToRemove))
                        {
                            Console.WriteLine($"O veículo {plateToRemove} foi removido e o preço total foi de: R$ {amount}");
                        }
                        else
                        {
                            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada incorreta para horas. Digite um número válido.");
                    }
                }
                else
                {
                    Console.WriteLine($"Veículo com placa {plate} não encontrado no estacionamento.");
                }
            }
            else
            {
                Console.WriteLine("Argumento nulo detectado.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in vehicles) // Loop que percorre a lista de veículos e exibe cada placa.
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
