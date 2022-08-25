// Напишите программу, 
// которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Input number: ");
int numN = Convert.ToInt32(Console.ReadLine());

int factor = 1;
for (int i = 1; i <= numN; i++){
    factor *= i;
}

Console.WriteLine($"{numN}! = {factor}");