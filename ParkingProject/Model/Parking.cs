using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanade.ParkingProject.Model
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>(); //Declaração e inicialização de uma lista privada de strings vehicles para armazenar as placas dos veículos no estacionamento.

        public Parking(decimal initialPrice, decimal pricePerHour) // Construtor da classe Parking que recebe o preço inicial e o preço por hora como parâmetros e inicializa as variáveis.
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle() // Método que solicita ao usuário a entrada da placa do veículo, verifica se a entrada é válida e adiciona a placa à lista de veículos.
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                vehicles.Add(userInput);
                Console.WriteLine("Veículo estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. A placa não pode ser nula ou vazia");
            }
        }

        public void RemoveVehicle(string plate) // Método que remove um veículo da lista, calcula o valor total com base no tempo estacionado e exibe informações sobre a remoção.
        {
            if (vehicles != null && !string.IsNullOrEmpty(plate))
            {
                if (vehicles.Contains(plate)) // Verifica se a entrada do usuário pode ser convertida para um número inteiro e a armazena na variável hours.
                {
                    Console.WriteLine($"Veículo de placa {plate} removido com sucesso.");
                    vehicles.Remove(plate);

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    if (int.TryParse(Console.ReadLine(), out int hours))
                    {
                        decimal amount = initialPrice + (pricePerHour * hours);
                        Console.WriteLine($"O valor total é {amount}"); // Calcula o valor total com base no preço inicial e no preço por hora multiplicado pelo número de horas.

                        Console.WriteLine("Digite a placa que deseja remover:");
                        string plateToRemove = Console.ReadLine();

                        if (vehicles.Contains(plateToRemove)) // Verifica se a placa a ser removida está na lista de veículos.
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
