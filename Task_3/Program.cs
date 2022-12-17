Console.WriteLine("Task_3 \n");

Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % 2 == 0)
    Console.WriteLine($"Число {firstNumber} чётное.");
else
    Console.WriteLine($"Число {firstNumber} не чётное.");