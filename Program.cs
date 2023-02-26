using System;

class Program
{
    static void Main(string[] args)
    {
        string[] array = ReadArray(); 
        PrintArray(array); 
        string[] newArray = FilterArray(array); 
        PrintArray(newArray); 

        Console.ReadKey(); 
    }

  
    static string[] ReadArray()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine()); 

        string[] array = new string[n]; 
        for (int i = 0; i < n; i++) 
        {
            Console.Write($"Введите строку {i + 1}: ");
            array[i] = Console.ReadLine();
        }

        return array; 
    }
    
    
    static string[] FilterArray(string[] array)
    {
        int count = 0; 
                foreach (string s in array) 
        {
            if (s.Length <= 3) 
            {
                count++;
            }
        }

        string[] newArray = new string[count]; 

        int j = 0; 
        foreach (string s in array) 
        {
            if (s.Length <= 3) 
            {
                newArray[j] = s;
                j++; 
            }
        }

        return newArray; 
    }

    
    static void PrintArray(string[] array)
    {
        Console.WriteLine("\nМассив строк:");
        foreach (string s in array) 
        {
            Console.WriteLine(s);
        }
    }

}