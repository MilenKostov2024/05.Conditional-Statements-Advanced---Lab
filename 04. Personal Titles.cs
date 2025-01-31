double year = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'm')
{
    if (year >= 16)
        Console.WriteLine("Mr.");
    else
        Console.WriteLine("Master");
}
else
{
    if (year >= 16)
        Console.WriteLine("Ms.");
    else
        Console.WriteLine("Miss");
}