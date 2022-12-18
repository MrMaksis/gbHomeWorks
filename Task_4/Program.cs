Console.WriteLine("Task_4 \n");

Console.Write("Введите число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count <= firstNumber){
    if (count % 2 == 0){
        Console.WriteLine(count);
    }
    count++;
} 