// Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран. 
// Вводим массив через консоль

int[] array = new int[8];

for (int i = 0; i < array.Length; i++){
    Console.Write($"Input element of array ({i + 1} out of {array.Length}): ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Your array: ");
for (int i = 0; i < array.Length; i++){
    Console.Write($"{array[i]} ");
}