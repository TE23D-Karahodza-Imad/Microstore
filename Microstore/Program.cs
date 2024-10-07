using System.Data.SqlTypes;

Console.WriteLine("Skriv in din ålder");
string age = Console.ReadLine();

int ageNum = 0;

int.TryParse(age, out ageNum);

bool success = int.TryParse(age, out ageNum);

if(success == false)
{
    Console.WriteLine("No type a number ");
}

//-------------------------------------//
Console.ReadLine();

