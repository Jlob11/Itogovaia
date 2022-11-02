// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void Numbers(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write(number);
    Numbers(number - 1);
}

Numbers(number); 


// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());


void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);
 



//   Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int Akkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}