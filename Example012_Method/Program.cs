// Вид 1. Методы которые ничего не возвращают и не приимают.

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид 2. Ничего не возвращают, но могут принимать аргументы.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения"); // Method2(msg:"Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // увеличение на 1 - инкркмент, уменишение - декримент
    }

}
// Method2_1("Тект", 4); // Method2_1(msg:"Тект", count: 4); - в именованном не обязательно по порядку 

// Вид 3. Метод который возвращает значение.

int Method3()
{
    return DateTime.Now.Year;
}
//int year = Method3();
//Console.WriteLine(year);

//Вид 4. Методы которые что-то принимают и возвращают.

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
//string res = Method4(10, "zzz");
//Console.WriteLine(res);

//Цикл for.

string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "zzz");
//Console.WriteLine(res);

// Таблица умножения.

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//  Работа с текстом.
// Дан текст. В тексте все пробелы нужно заменить чёрточками, маленькие буквы "к" 
//завменить большими "К", а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали весто нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так краснноречивы. Вы дадите мне чаю?";

// strung = s "qwerty"
//             123456
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }

    return result;
}

//string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);

//string newText = Replace(text, 'к', 'К');
//Console.WriteLine(newText);

string newText = Replace(text, 'С', 'с');
//Console.WriteLine(newText);

// Сортировка массива.

int[] arr = { 8, 2, 4, 5, 3, 5, 6, 1, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
//SelectionSort(arr);

arr[0] = arr[1];
PrintArray(arr);