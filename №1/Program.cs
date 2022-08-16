Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
int length = num.Length;
if (length == 5)
{
    if ((Convert.ToInt32(num) > 0))
    {
        if (num[0] == num[4])
        {
            if (num[1] == num[3])
            {
                Console.WriteLine("да " + num + " " + " является полиндромом");
            }
        }
        else
        {
            Console.WriteLine("Нет " + num + " " + "не является полиндромом");
        }
    }
    else
    {
        Console.WriteLine("Это число не является пятизначным");
    }
}
else
{
    if (Convert.ToInt32(num) < 0)
    {
        if (length == 6)
        {
            if (num[1] == num[5])
            {
                if (num[2] == num[4])
                {
                    Console.WriteLine("да " + num + " " + " является полиндромом");
                }
            }
            else
            {
                Console.WriteLine("Нет " + num + " " + "не является полиндромом");
            }
        }
    }
    else
    {
        Console.WriteLine("Это число не является пятизначным");
    }
}

//Куча проверок (if) для работы с отрицательными числами, можно было через методы чтоб код был короче, но проще так:)