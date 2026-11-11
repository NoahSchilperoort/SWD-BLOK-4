// Je gebruikt een float als je een kleiner getal wilt gebruiken of minder geheugen wilt gebruiken. Een double gebruikt meer geheugen en kan daardoor wel meer preciesie bieden.
// Een decimal gebruik je als je een getal wilt gebruiken dat een hoge precisie nodig heeft.
// Wanneer je 0.1 optelt in een double kan dit leiden tot afrondingsfouten omdat 0.1 niet exact kan worden weergegeven in binaire vorm. Decimal heeft deze problemen niet aangezien het een decimale floating-point type is en kan daardoor 0.1 exact weergeven.
// Je kunt decimal gebruiken voor exacte afrondingen door middel van de Math.Round methode, die een decimal waarde kan afronden naar een bepaald aantal decimalen.
// De suffixen f en m worden gebruikt om aan te geven dat een variable een float of decimal type is. Als dit niet gedaan wordt dan wordt het getal standaard als een double beschouwd.

float myFloat = 0.1f;

double myDouble = 0.1;

decimal myDecimal = 0.1m;

Console.WriteLine("Float: " + myFloat);

Console.WriteLine("Double: " + myDouble);

Console.WriteLine("Decimal: " + myDecimal);

// Ik verwacht dat deze alledrie hetzelfde getal zullen weergeven maar dat ze een andere precisie hebben. De float heeft de minste precisie, gevolgd door de double en de decimal heeft de hoogste precisie.
// Uiteindelijk lieten ze exact hetzelfde zien.

Console.WriteLine("Float: " + myFloat * myFloat);
Console.WriteLine("Double: " + myDouble * myDouble);
Console.WriteLine("Decimal: " + myDecimal * myDecimal);

// Om een of andere reden komt er een getal veel verder achter de punt erbij bij de Floar en bij Double.
// De oorzaak ligt waarschijnlijk in de manier waarop deze types worden opgeslagen in het geheugen. De float en double zijn binaire floating-point types, wat betekent dat sommige decimale getallen niet exact kunnen worden weergeven in binaire vorm. Hierdoor kunnen afrondingsfouten optreden bij berekeningen, wat resulteert in een getal dat verder achter de komma ligt.

Console.WriteLine("Bytes float: " + sizeof(float));
Console.WriteLine("Bytes double: " + sizeof(double));
Console.WriteLine("Bytes decimal: " + sizeof(decimal));

// Deciaml gebruikt de meeste bytes, 16. Dit is omdat decimal een hogere precisie heeft en meer geheugen nodig heeft om de extra cijfers op te slaan.

float myFloatValue = 5.5f;
double myDoubleValue = myFloatValue;
Console.WriteLine("Float to Double: " + myDoubleValue);

// Een cast is hier niet nodig omdat de float waarde binnen de range van een double valt.

double myBigDouble = 9.99;
float mySmallFloat = (float)myBigDouble;
Console.WriteLine("Double to Float: " + mySmallFloat);

// Hier is een cast wel nodig omdat de double waarde mogelijk buiten de range van een float kan vallen, wat kan leiden tot verlies van precisie of een foutmelding.

decimal priceDecimal = 19.999m;
decimal roundedDecimal = Math.Round(priceDecimal, 2);
Console.WriteLine("Afgeronde prijs: " + roundedDecimal);

// Afronden met decimal is nuttig voor prijzen en nauwkeurige berekeningen wanneer er maar een bepaald niveau van preciezie nodig is.