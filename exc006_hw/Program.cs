// Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Input number: ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int sum = 0;
while (num > 0){
    int numLast = num % 10;
    sum += numLast;
    num /= 10;
}

Console.WriteLine(sum);