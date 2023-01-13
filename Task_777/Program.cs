//
// Pflfxf 777. Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0

// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)

// 2. Создание массива
// int[] <- (int)

// 3. Заполнение массива 0 и 1
// void <- (int[])

// 4. Печать массива
// string <- (int[])

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 6. 10110100 >> 180
// string <- (int[] , int)

string GoodPrint(int[] bin, int dec)
{
return $"{String.Join("", bin)} >> {dec}";
}

//Console.WriteLine(GoodPrint(new int[] { 1, 0, 1, 1, 1, 1, 0 }, 56));

int InputAndGetBinaryDigit()
{
    int value = 0;

    Console.Write("Input digit as binary (as example 11100101010): ");
    String? strValue = Console.ReadLine();
    if( String.IsNullOrEmpty(strValue) == false)
    {
        value = Int32.Parse(strValue);
    }

    return value;

}

int[] CreateAndGetArray(int value)
{
    // Вычилим длину массива. Колво цифр в value и будет длинной массива
    int len = 0;
    while(value > 0)
    {
        len = len + 1;
        value = value / 10;
    }

    int[] array = new int[len];

    return array;
}

void FillArray(int[] array, int value)
{

    int temp;
    while(true)
    {
        temp = value % 2;
        array.Append(temp);
        value = value / 10;
        if(value == 0) {
            break;
        }
    }

}

void PrintBinaryArray(int[] array)
{

    for(int i = 0; i < array.Length; ++i)
    {
        if(i == array.Length - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }

}

void main()
{

    Console.WriteLine("\n-------Task-777 ------- \n");

    int value = InputAndGetBinaryDigit();
    int[] array = CreateAndGetArray(value);
    FillArray(array, value);

    Console.WriteLine($"Sourse value: {value}");
    //Console.WriteLine(array);
    PrintBinaryArray(array);

}

main();


