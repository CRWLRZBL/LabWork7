using Task1;

Console.WriteLine("---------------------------------------------------------");
Patient patient1 = new("Misha", 0, 2006);
patient1++;
Console.WriteLine($"                        {patient1.BirthYear}  ");
Console.WriteLine("---------------------------------------------------------");

Patient patient2 = new();
Patient patient3 = patient1 + patient2;
Console.WriteLine($"  Name: {patient3.Name}, Number of polis: {patient3.NumberPolis}, Year of birth: {patient3.BirthYear}");
Console.WriteLine("---------------------------------------------------------");

Patient patient4 = new("Denis", 0, 2005);
Console.WriteLine($"                         {patient4.BirthYear}");

if (patient4)
    Console.WriteLine("\t  year of birth >=0");
else
    Console.WriteLine("\t year of birth <0");
Console.WriteLine("---------------------------------------------------------");