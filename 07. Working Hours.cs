//Console.Write("Въведете час: ");
int hour = int.Parse(Console.ReadLine());
//Console.Write("Въведете ден от седмицата: ");
string dayOfWeek = Console.ReadLine();

// Преобразуване на деня от седмицата в малки букви за лесно сравнение
dayOfWeek = dayOfWeek.ToLower();

// Проверка дали офисът е отворен
bool isOpen = false;

switch (dayOfWeek)
{
    case "monday":
    case "tuesday":
    case "wednesday":
    case "thursday":
    case "friday":
        isOpen = hour >= 10 && hour < 18;
        break;
    case "saturday":
        isOpen = hour >= 10 && hour < 16; // Събота работи до 16 часа
        break;
    default:
        isOpen = false;
        break;
}

// Извеждане на резултата
if (isOpen)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}