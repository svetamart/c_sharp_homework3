Console.Write("Введите пятизначное число, чтобы узнать, является ли оно палиндромом ");

string number = Console.ReadLine();

bool isNumber = int.TryParse(number, out int _);

bool ValidateNumber(string number)
{
    if(number.Length != 5)
    {
        return false;
    }
    return true;
} 



char[] numberArray = number.ToCharArray();

char[] ReverseNumber(char[] numberArray)
{
    int i = 0;
    int count = 0;
    int size = numberArray.Length;
    while(count < size / 2)
    {
        char tmp = numberArray[i];
        numberArray[i] = numberArray[size - i - 1];
        numberArray[size - i - 1] = tmp;
        i++;
        count++;
    }
    return reverse;
}



// char[] ReverseNumber(string number)
// {
//     int i = 0;
//     char[] reverse;
//     reverse = number.ToCharArray();
//     int count = 0;
//     int size = reverse.Length;
//     while(count < size / 2)
//     {
//         char tmp = reverse[i];
//         reverse[i] = reverse[size - i - 1];
//         reverse[size - i - 1] = tmp;
//         i++;
//         count++;
//     }
//     return reverse;
// }


bool isValid = ValidateNumber(number);

if(!isValid || !isNumber)
{
    Console.WriteLine("Ошибка! Пожалуйста, введите пятизначное число");
    return;
}


if(numberArray[0] == reverse[4])
{
    Console.Write("Да, это палиндром");
}
else
{
    Console.Write("Нет, это не палиндром");
}



PrintReverseNumber (ReverseNumber(number));
void PrintReverseNumber(char[] reverseArray) 
{
    int i = 0;
    int size = reverseArray.Length;
    while (i < size)
    {
        Console.Write(reverseArray[i]);
        i++;
    }
}

// char[] result = PrintReverseNumber (ReverseNumber(number));
// result = PrintReverseNumber(ReverseNumber(number)).ToCharArray();

// int result = Convert.ToInt32(ReverseNumber(number));
// int result2 = Convert.ToInt32(number);

// if(result == result2)
// {


// if(result[0] == number[4])
// {
//     Console.Write("Да, это палиндром");
// }
// else
// {
//     Console.Write("Нет, это не палиндром");
// }





// ДРУГОЕ РЕШЕНИЕ
// Console.Write("Введите пятизначное число, чтобы узнать, является ли оно палиндромом ");

// string number = Console.ReadLine();

// bool isNumber = int.TryParse(number, out int _);

// bool ValidateNumber(string number)
// {
//     if(number.Length != 5)
//     {
//         return false;
//     }
//     return true;
// } 


// char[] numberArray = number.ToCharArray();

// char[] ReverseNumber(char[] numberArray)
// {
//     int i = 0;
//     int count = 0;
//     int size = numberArray.Length;
//     while(count < size / 2)
//     {
//         char tmp = numberArray[i];
//         numberArray[i] = numberArray[size - i - 1];
//         numberArray[size - i - 1] = tmp;
//         i++;
//         count++;
//     }
//     return numberArray;
// }

// bool isValid = ValidateNumber(number);

// if(!isValid || !isNumber)
// {
//     Console.WriteLine("Ошибка! Пожалуйста, введите пятизначное число");
//     return;
// }



// PrintReverseNumber (ReverseNumber(numberArray));
// void PrintReverseNumber(char[] reverseArray) 
// {
//     int i = 0;
//     int size = reverseArray.Length;
//     while (i < size)
//     {
//         Console.Write(reverseArray[i]);
//         i++;
//     }
// }

// char[] reverseNumber = ReverseNumber(numberArray);

// if(numberArray[0] == reverseNumber[4])
// {
//     Console.WriteLine("Да, это палиндром");
// }
// else
// {
//     Console.WriteLine("Нет, это не палиндром");
// }

