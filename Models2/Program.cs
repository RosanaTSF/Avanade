using Models2.Models;    
using System.Globalization;

    try 
    {
        string[] linhas = File.ReadAllLines("Binder/Sheets.txt");

        foreach (string linha in linhas)
        {
            Console.WriteLine(linha);
        }
    } catch(Exception ex)
    {
        Console.WriteLine($"A generic exception occurred. {ex.StackTrace}");
    } finally 
    {
        Console.WriteLine("Cigarras - Forfun"); 
    }


