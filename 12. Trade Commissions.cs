// Входни данни
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

// Проверка за валидни входни данни
if (sales < 0 || (city != "Sofia" && city != "Varna" && city != "Plovdiv"))
{
    Console.WriteLine("error");
    return;
}

double commission = 0;

// Логика за изчисляване на комисионната
if (city == "Sofia")
{
    if (sales <= 500) commission = 0.05 * sales;
    else if (sales <= 1000) commission = 0.07 * sales;
    else if (sales <= 10000) commission = 0.08 * sales;
    else commission = 0.12 * sales;
}
else if (city == "Varna")
{
    if (sales <= 500) commission = 0.045 * sales;
    else if (sales <= 1000) commission = 0.075 * sales;
    else if (sales <= 10000) commission = 0.10 * sales;
    else commission = 0.13 * sales;
}
else if (city == "Plovdiv")
{
    if (sales <= 500) commission = 0.055 * sales;
    else if (sales <= 1000) commission = 0.08 * sales;
    else if (sales <= 10000) commission = 0.12 * sales;
    else commission = 0.145 * sales;
}

// Форматиране на изхода до 2 знака след десетичната точка
Console.WriteLine($"{commission:F2}");