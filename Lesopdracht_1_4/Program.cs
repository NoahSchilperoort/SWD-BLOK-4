string firstName = "Jan";
// Data type is string, waarde is "Jan".
string lastName = "Jansen";
// Data type is string, waarde is "Jansen".
int age = 21;
// Data type is int, waarde is 21.

Console.WriteLine("Naam: " + firstName + " " + lastName + ", Leeftijd: " + age);

// Als je een string en een gatal samen zou voegen ontstaat er een fout in het programma. Deze data types kunnen niet zomaar bij elkaar opgeteld worden.

Console.WriteLine($"Naam: {firstName} {lastName}, Leeftijd: {age}");
// Deze methode vind ik zelf overzichtelijker omdat er geen extra stappen nodig zijn om de data in de print te krijgen.

string city = "Ede";
Console.WriteLine($"Stad: {city}");
Console.WriteLine("Stad: " + city);
city = city + " (Gelderland)";
Console.WriteLine($"Stad: {city}");
city = city + " 11/11/2026";
Console.WriteLine($"Stad: {city}");
