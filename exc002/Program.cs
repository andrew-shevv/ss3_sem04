// Напишите программу, 
// которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Не используем в решении задачи строки и ее свойства

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

int count = 1;
while (num >= 10){
    num /= 10;
    count++;
}

Console.WriteLine($"{count} - amount of digits in this number");