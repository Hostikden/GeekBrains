Console.Write("Введите депозит:\t");
double depositUser = Convert.ToDouble(Console.ReadLine());

ResultDepositUser(depositUser);

void ResultDepositUser(double depositUser)
{
    if (depositUser < 100)  // 5%
    {
        depositUser += depositUser * 0.05;
        Console.WriteLine($"Депозит: {depositUser}");
    }
    if (depositUser >= 100 && depositUser < 200)  // 7%
    {
        depositUser += depositUser * 0.07;
        Console.WriteLine($"Депозит: {depositUser}");
    }
    if (depositUser >= 200)  // 10%
    {
        depositUser += depositUser * 0.1;
        Console.WriteLine($"Депозит: {depositUser}");
    }
}
