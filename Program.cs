// Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = Convert.ToInt32(Math.Pow(number1, number2));
// Console.WriteLine(result);


// Задача 27: Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (number != 0){
//     sum += number % 10;
//     number /= 10;
// }
// Console.WriteLine($"Сумма цифр в числе = {sum}");




// Задача 29: Напишите метод, который задаёт массив из 8 элементов и выводит его на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];


for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0, 100);
    Console.Write($"{array[i]} ");
}


