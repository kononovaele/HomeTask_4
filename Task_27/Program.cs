//
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//

int GetSumOfDigits(int value)
{
    int sum = 0;
    int rest = 0;

    while(value != 0) {
        rest = value % 10;
        sum = sum + rest;
        value = value / 10;
    }

    return sum;
}

void main()
{

    Console.WriteLine("\n-------Task-27 ------- \n");

    Console.Write("Input number: ");
    String? strValue = Console.ReadLine();
    int value = 0;
    if( String.IsNullOrEmpty(strValue) == false)
    {
        value = Int32.Parse(strValue);
    }

    int sum = GetSumOfDigits(value);
    Console.WriteLine($"For number: {value}, Sum of digits in a number: {sum}");
}

main();


