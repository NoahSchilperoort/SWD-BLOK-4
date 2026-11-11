// Het verschil tussen 'int' en 'uint' is dat 'int' negatief kan zijn en 'uint' kan alleen positief zijn, dit komt omdat int signed is en uint unsigned is.
// Een "signed integer" betekent dat het een teken kan hebben, zoals het minus teken.
// Een "unsigned integer" alleen positieve waarden kan hebben omdat het geen toegevoegd teken kan hanteren.

byte myFirstByte = 200;
Console.WriteLine(myFirstByte);
int myFirstInt = 1000;
Console.WriteLine(myFirstInt);
long myFirstLong = 10000000000;
Console.WriteLine(myFirstLong);

int negativeInt = -500;
Console.WriteLine(negativeInt);
//uint negativeUInt = -500;
//Console.WriteLine(negativeUInt);
byte minimumByte = byte.MinValue;
Console.WriteLine(minimumByte);
byte maximumByte = byte.MaxValue;
Console.WriteLine(maximumByte);
int minimumInt = int.MinValue;
Console.WriteLine(minimumInt);
int maximumInt = int.MaxValue;
Console.WriteLine(maximumInt);
uint minimumUInt = uint.MinValue;
Console.WriteLine(minimumUInt);
uint maximumUInt = uint.MaxValue;
Console.WriteLine(maximumUInt);
long minimumLong = long.MinValue;
Console.WriteLine(minimumLong);
long maximumLong = long.MaxValue;
Console.WriteLine(maximumLong);

int mathVar = 0;
mathVar = mathVar + 10;
Console.WriteLine(mathVar);
mathVar = mathVar - 5;
Console.WriteLine(mathVar);
mathVar = mathVar * 2;
Console.WriteLine(mathVar);
mathVar = mathVar / 5;
Console.WriteLine(mathVar);
mathVar = mathVar % 3;
Console.WriteLine(mathVar);

int myCounter = 0;
myCounter++;
Console.WriteLine(myCounter);
myCounter--;
Console.WriteLine(myCounter);
// De ++ operator telt 1 op bij de waarde van de variabele en de -- operator haalt 1 af van de waarde van de variabele.

