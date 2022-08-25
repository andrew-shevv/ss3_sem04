// Напишите программу, 
// которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Input number: ");
int numA = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= numA; i++){
    sum += i;
}

Console.WriteLine($"{sum} - sum of numbers from 1 to {numA}");