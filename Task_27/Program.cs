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

    while(true) {
        rest = value % 10;
        sum = sum + rest;
        value = value / 10;
        if(value == 0) {
            break;
        }
    }

    return sum;
}

void main()
{

    Console.WriteLine("\n-------Task-27 ------- \n");

    Console.Write("Input digit: ");
    String? strValue = Console.ReadLine();
    int value = 0;
    if( String.IsNullOrEmpty(strValue) == false)
    {
        value = Int32.Parse(strValue);
    }

    int sum = GetSumOfDigits(value);
    Console.WriteLine($"For digit: {value}, Sum is: {sum}");
}

main();


