using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanade.ParkingProject.Model
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>(); // Encapsulamento.

        public Parking(decimal initialPrice, decimal pricePerHour) // Construtor.
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput)) // Trata o código para que não aceite placa vazia ou nula.
            {
                vehicles.Add(userInput);
                Console.WriteLine("Veículo estacionado com sucesso."); 
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
                if (vehicles.Contains(plate))
                {
                    Console.WriteLine($"Veículo de placa {plate} removido com sucesso.");
                    vehicles.Remove(plate);

                    decimal totalAmount = 0;

                    try // Acrescentando try catch.
                    {
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                        int parkingDurationHours = Convert.ToInt32(Console.ReadLine()); // Hours foi renomeada para parkingDurationsHours.
                        totalAmount = initialPrice + (pricePerHour * parkingDurationHours);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada incorreta para horas. Digite um número válido.");
                        return; // Retorna para evitar a execução adicional em caso de erro na entrada do usuário.
                    }

                    Console.WriteLine($"O valor total é {totalAmount}");

                    // Solicita a placa do veículo a ser removido após calcular o valor total.
                    Console.WriteLine("Digite a placa que deseja remover:");
                    string plateToRemove = Console.ReadLine();

                    if (vehicles.Contains(plateToRemove))
                    {
                        Console.WriteLine($"O veículo {plateToRemove} foi removido e o preço total foi de: R$ {totalAmount}");
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
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
