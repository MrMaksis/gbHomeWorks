Console.WriteLine("Task_1 \n");

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
    Console.WriteLine($"Число {firstNumber} больше.");
if (secondNumber > firstNumber)
    Console.WriteLine($"Число {secondNumber} больше.");
if (firstNumber < secondNumber)
    Console.WriteLine($"Число {firstNumber} меньше.");
if (secondNumber < firstNumber)
    Console.WriteLine($"Число {secondNumber} меньше.");
    