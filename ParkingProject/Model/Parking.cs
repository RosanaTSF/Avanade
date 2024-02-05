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

        public string AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                vehicles.Add(userInput);
                return "Veículo estacionado com sucesso.";
            }
            else
            {
                return "Placa inválida. A placa não pode ser nula ou vazia";
            }
        }

        public void RemoveVehicle(string plate)
        {
            if (vehicles.Contains(plate))
            {
                int parkingDurationHours;

                while (true)
                {
                    Console.WriteLine("Digite quantas horas permaneceu estacionado:");

                    try
                    {
                        parkingDurationHours = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada incorreta para horas. Digite novamente.");
                    }
                }

                decimal totalAmount = initialPrice + (pricePerHour * parkingDurationHours);
                Console.WriteLine($"Valor total: {totalAmount}");

                vehicles.Remove(plate);
                Console.WriteLine($"O veículo {plate} foi removido com sucesso.");

                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Veículo com placa {plate} não encontrado no estacionamento.");
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