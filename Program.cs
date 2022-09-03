Console.WriteLine ("Введите число ");
string input; //ввод пользователя
input = Console.ReadLine();

int number = int.Parse(input);

int square = number*number;

Console.WriteLine($"Число в квадрате равно {square} ");
