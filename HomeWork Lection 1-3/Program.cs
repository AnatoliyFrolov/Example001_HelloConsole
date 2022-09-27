Console.WriteLine ("Введите первое число ");
string input1 = Console.ReadLine();
int number1  = int.Parse(input1);

if (number1 % 2 == 0)
{
    Console.WriteLine ("Данное число четное ");
}

else
{
   Console.WriteLine ("Данное число нечетное ");
}
