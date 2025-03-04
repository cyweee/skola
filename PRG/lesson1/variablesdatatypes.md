# Prom?nn� a datov� typy v C#

Prom?nn� jsou pojmenovan� oblasti pam?ti, kter� uchov�vaj� data. V C# m� ka�d� prom?nn� typ, kter� ur?uje, jak� data m?�e obsahovat.

****
## Deklarace prom?nn�

`typ_dat n�zev_prom?nn� = hodnota;`

P?�klad:

`int x = 5;`

- **Pravidla pojmenov�n� prom?nn�ch:**

	1. N�zev prom?nn� mus� za?�nat p�smenem nebo znakem _.

	2. M?�e obsahovat p�smena, ?�slice a _.

	3. Rozli�uje velk� a mal� p�smena (vek a Vek jsou r?zn� prom?nn�).

	4. Nelze pou��t rezervovan� slova (nap?�klad int, class).

****

## Datov� typy

Datov� typ ur?uje velikost a form�t ulo�en� hodnoty.

### Primitivn� datov� typy

| Typ       | Velikost | Rozsah hodnot |
|-----------|---------|--------------|
| `byte`    | 1 bajt  | 0 a� 255 |
| `sbyte`   | 1 bajt  | -128 a� 127 |
| `short`   | 2 bajty | -32 768 a� 32 767 |
| `ushort`  | 2 bajty | 0 a� 65 535 |
| `int`     | 4 bajty | -2 147 483 648 a� 2 147 483 647 |
| `uint`    | 4 bajty | 0 a� 4 294 967 295 |
| `long`    | 8 bajt? | -9 223 372 036 854 775 808 a� 9 223 372 036 854 775 807 |
| `ulong`   | 8 bajt? | 0 a� 18 446 744 073 709 551 615 |
| `float`   | 4 bajty | �1,5 � 10??? a� �3,4 � 10�? |
| `double`  | 8 bajt? | �5,0 � 10?��? a� �1,7 � 10�?? |
| `decimal` | 16 bajt? | Velmi vysok� p?esnost |
| `char`    | 2 bajty | Unicode znak |
| `bool`    | 1 bajt  | `true` nebo `false` |

### Ostatn� datov� typy

- `string` - ?et?zec znak?
- `object` - z�kladn� t?�da pro v�echny ostatn� t?�dy
- `dynamic` - datov� typ, kter� umo�?uje odlo�en� ur?en� typu prom?nn�

### var a dynamic

- `var` - kompil�tor ur?� datov� typ prom?nn� na z�klad? p?i?azen� hodnoty
```
var x = 5; // int
var zprava = "Ahoj"; // string
```
- dynamic - datov� typ, kter� umo�?uje odlo�en� ur?en� typu prom?nn�
```
dynamic nejakaHodnota = 10;
nejakaHodnota = "Text"; // ��dn� chyba, ale potenci�ln? nebezpe?n�
```

### ?�seln� liter�ly

- `int` - des�tkov� z�pis = `int cislo = 100;`
- `0x` - hexadecim�ln� z�pis = `int hex = 0xFF;`
- `0b` - bin�rn� z�pis = `int binarni = 0b1010;`