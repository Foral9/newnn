using System;
using System.IO;

class Program
{
    static void Main()
    {
       
        string inputFilePath = "numbers.txt";
        string outputFilePath = "numbers_sep.txt";

        try
        {
            
            string data = File.ReadAllText(inputFilePath);

            
            string modifiedData = data.Replace(",", "|");

            
            File.WriteAllText(outputFilePath, modifiedData);

            Console.WriteLine("Запись завершена. Проверьте файл numbers_sep.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
