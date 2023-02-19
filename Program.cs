
   void Main(string[] args)
    {
        // Вводим исходный массив строк с клавиатуры
        Console.Write("Введите элементы массива через пробел: ");
        string input = Console.ReadLine();
        string[] a = input.Split(' ');

        // Создаем новый массив, содержащий только строки длиной <= 3
        string[] b = new string[a.Length];
        int count = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i].Length <= 3)
            {
                b[count] = a[i];
                count++;
            }
        }

        Array.Resize(ref b, count);

        void Show
        Console.WriteLine("Исходный массив:");
        PrintArray(a);

        Console.WriteLine("Новый массив:");
        PrintArray(b);
    }

    static void PrintArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("]");
    }
