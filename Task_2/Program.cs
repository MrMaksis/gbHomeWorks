Console.WriteLine("Task_2 \n");

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {Math.Max(Math.Max(firstNumber, secondNumber), thirdNumber)} самое большое."); //Тут я решил воспользоваться готовой функцией нахождения max числа


