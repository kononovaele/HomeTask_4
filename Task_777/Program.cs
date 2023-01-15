//
// Задача - 777. Напишите программу, которая выводит массив из N элементов,
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

// Ввод двоичного числа, как строку. Возврат его как целое число
int InputAndGetBinaryDigit()
{
    int value = 0;

    Console.Write(" --- Input digits as binary (as example 11100101010), the first digit must be 1 (one).");
    Console.Write("\n --- The number of binary digits is any.");

    Console.Write("\nInput digits as binary, please: ");
    String? strValue = Console.ReadLine();
    if( String.IsNullOrEmpty(strValue) == false)
    {
        value = Convert.ToInt32(strValue);
    }

    return value;

}

// Создаем массив целых чисел. Т. к., длинна массива в C# должна быть задана при его инициализации, вычиляем кол-во разрядов value,
// это и есть длина нашего масива
int[] CreateAndGetArray(int value)
{
    // Вычислим длину массива. Колво цифр в value и будет длинной массива. "10111" - длинна массива равно 5.
    int len = 0;
    while(value > 0)
    {
        len = len + 1;
        value = value / 10;
    }

    int[] array = new int[len];

    return array;
}

// Заполняем массив бинарными числами 0 и 1 из value
// Пример: value = 10111, массив будет array = [1, 0, 1, 1, 1]
void FillArray(int[] array, int value)
{

    int rest;
    int i = array.Length - 1;
    while(value != 0)
    {
        rest = value % 10;
        array[i] = rest;
        value = value / 10;
        i = i - 1;
    }
}

// Печатаем двоичный массив. Разделитель между элементами массива - запятая
void PrintBinaryArray(int[] array)
{

    Console.Write("Print binary array: ");
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

// Конвертируем двоичный массив в целое десятичное число и возвращаем его.
int ConvertBinaryArrayToInt(int[] array)
{
    int value = 0;
    int lenArray = array.Length;

    for(int i = 0; i < lenArray; ++i)
    {
        // Обязательно привидение типов, т. к, Pow() возвращает double
        value = value + array[lenArray - i - 1] * (int)Math.Pow(2, i);
        // Для отладки
        //Console.WriteLine($"i: {i}, {array[lenArray - i - 1]}, Math: {(int)Math.Pow(2, i)}, {array[lenArray - i - 1] * (int)Math.Pow(2, i)}, value: {value}");
    }

    return value;
}

void main()
{

    Console.WriteLine("\n-------Task-777 ------- \n");

    // Ввод числа
    int value = InputAndGetBinaryDigit();

    // Создание массива
    int[] array = CreateAndGetArray(value);

    // Заполнение массива. Переменную value передаем, чтобы вычислить размер массива
    FillArray(array, value);

    // Печатаем введеное число 
    Console.WriteLine($"Sourse value: {value}");

    // Печать массива двоичных чисел, элементы массива печатаем через запятую
    PrintBinaryArray(array);

    // Конвертируем двоичный массив в целое десятичное число и возвращаем его
    int valueDec = ConvertBinaryArrayToInt(array);

    // Для отладки
    //Console.WriteLine($"\nvalue (decimal): {valueDec}");

    // Печатаем массив двоичного числа в виде строки и его значение как десятичное число
    Console.WriteLine("\n" + GoodPrint(array, valueDec));
}

main();


