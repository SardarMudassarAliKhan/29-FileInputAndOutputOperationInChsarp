using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the file
        string filePath = "SardarMudassarAliKhan.txt";

        // Write data to a file
        WriteToFile(filePath);

        // Read data from the file
        ReadFromFile(filePath);
    }

    static void WriteToFile(string filePath)
    {
        try
        {
            // Open the file for writing (creates a new file or overwrites existing)
            using(StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, world!");
                writer.WriteLine("This is a test file.");
                writer.WriteLine("Writing some data using C#.");
            }

            Console.WriteLine("Data written to the file successfully.");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void ReadFromFile(string filePath)
    {
        try
        {
            // Open the file for reading
            using(StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("Reading data from the file:");
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
