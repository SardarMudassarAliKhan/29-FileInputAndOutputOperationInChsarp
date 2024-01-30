I/O in C#. In C#, file I/O (Input/Output) operations are commonly performed using the `System.IO` namespace. Here's a basic example of how you can read from and write to a file in C#:

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Path to the file
        string filePath = "example.txt";

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
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, world!");
                writer.WriteLine("This is a test file.");
                writer.WriteLine("Writing some data using C#.");
            }

            Console.WriteLine("Data written to the file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static void ReadFromFile(string filePath)
    {
        try
        {
            // Open the file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("Reading data from the file:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
```

In this example:
- We define a `WriteToFile` method to write some data to a file.
- We define a `ReadFromFile` method to read data from the same file.
- We call these methods in the `Main` method.
- We use `StreamWriter` to write data to the file and `StreamReader` to read data from the file.
- Both `StreamWriter` and `StreamReader` are wrapped in `using` statements to ensure proper disposal of resources.

Make sure to handle exceptions appropriately in your actual code to handle scenarios like file not found, permission denied, etc.
