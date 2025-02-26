// Proměnné a datové typy v C# //

	Proměnné
Proměnná je oblast paměti, která uchovává data.
Deklarace:
< datový typ > < název proměnné >;

Inicializace:

int num = 10;

	Základní datové typy

	 Celá čísla:

byte a = 255;   // 1 bajt, 0...255  
short b = -32000; // 2 bajty  
int c = 2147483647; // 4 bajty  
long d = 9223372036854775807; // 8 bajtů  

	Čísla s plovoucí desetinnou čárkou:

float f = 3.14f;  // 4 bajty (~7 číslic)  
double d = 3.14159; // 8 bajtů (~15 číslic)  
decimal m = 3.141592653589793238m; // 16 bajtů (vysoká přesnost)  

	Znaky a řetězce:

char symbol = 'A';  // Unicode znak (2 bajty)  
string text = "Hello"; // Řetězec  

	Logický typ:

bool flag = true; // true nebo false  


// todo: to expand a little bit more and explain //