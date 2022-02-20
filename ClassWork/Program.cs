while (true)
{
    Console.Clear();
    Random r = new Random();
    int secretNumber = r.Next(1, 25);
    Console.WriteLine("Компьютер загадал число от 1 до 10.Попробуй его угадать");
    int attempts = 5;
    while (attempts > 0)
    {
        Console.WriteLine($"Кол-во попыток: {attempts}");
        Console.Write("Введите число:");
        int userNumber = int.Parse(Console.ReadLine());
        if (userNumber == secretNumber)
        {
            Console.WriteLine("Вы угадали!!");
            break;
        }
        else if (userNumber < secretNumber)
        {
            Console.WriteLine($"Секретное число больше числа {userNumber}");
        }
        else
        {
            Console.WriteLine($"Секртеное число меньше числа {userNumber}");
        }
        attempts--;

        if (attempts == 0)
        {
            Console.WriteLine($"Вы проиграли. Секретное число: {secretNumber}");
        }
    }
    Console.ReadKey();
}
