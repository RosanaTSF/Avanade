using System;
using System.Collections.Generic;
using System.Linq;

namespace Avanade.ParkingProject.Model
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
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

        public void RemoveVehicle(string plate)
        {
            if (vehicles != null && !string.IsNullOrEmpty(plate))
            {
                if (vehicles.Contains(plate))
                {
                    Console.WriteLine($"Veículo de placa {plate} removido com sucesso.");
                    vehicles.Remove(plate);

                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    if (int.TryParse(Console.ReadLine(), out int hours))
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
                foreach (string item in vehicles)
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
