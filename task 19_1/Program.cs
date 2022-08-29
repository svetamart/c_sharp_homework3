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

bool isValid = ValidateNumber(number);

if(!isValid || !isNumber)
{
    Console.WriteLine("Ошибка! Пожалуйста, введите пятизначное число");
    return;
}

char[] numberArray = number.ToCharArray();

if(numberArray[0] == numberArray[4] & numberArray[1] == numberArray[3])
{
    Console.WriteLine("Да, это палиндром");
}
else
{
    Console.WriteLine("Нет, это не палиндром");
}

