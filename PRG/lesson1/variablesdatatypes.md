# Prom?nné a datové typy v C#

Prom?nné jsou pojmenované oblasti pam?ti, které uchovávají data. V C# má každá prom?nná typ, který ur?uje, jaká data m?že obsahovat.

****
## Deklarace prom?nné

`typ_dat název_prom?nné = hodnota;`

P?íklad:

`int x = 5;`

- **Pravidla pojmenování prom?nných:**

	1. Název prom?nné musí za?ínat písmenem nebo znakem _.

	2. M?že obsahovat písmena, ?íslice a _.

	3. Rozlišuje velká a malá písmena (vek a Vek jsou r?zné prom?nné).

	4. Nelze použít rezervovaná slova (nap?íklad int, class).

****

## Datové typy

Datový typ ur?uje velikost a formát uložení hodnoty.

### Primitivní datové typy

| Typ       | Velikost | Rozsah hodnot |
|-----------|---------|--------------|
| `byte`    | 1 bajt  | 0 až 255 |
| `sbyte`   | 1 bajt  | -128 až 127 |
| `short`   | 2 bajty | -32 768 až 32 767 |
| `ushort`  | 2 bajty | 0 až 65 535 |
| `int`     | 4 bajty | -2 147 483 648 až 2 147 483 647 |
| `uint`    | 4 bajty | 0 až 4 294 967 295 |
| `long`    | 8 bajt? | -9 223 372 036 854 775 808 až 9 223 372 036 854 775 807 |
| `ulong`   | 8 bajt? | 0 až 18 446 744 073 709 551 615 |
| `float`   | 4 bajty | ±1,5 × 10??? až ±3,4 × 10³? |
| `double`  | 8 bajt? | ±5,0 × 10?³²? až ±1,7 × 10³?? |
| `decimal` | 16 bajt? | Velmi vysoká p?esnost |
| `char`    | 2 bajty | Unicode znak |
| `bool`    | 1 bajt  | `true` nebo `false` |

### Ostatní datové typy

- `string` - ?et?zec znak?
- `object` - základní t?ída pro všechny ostatní t?ídy
- `dynamic` - datový typ, který umož?uje odložené ur?ení typu prom?nné

### var a dynamic

- `var` - kompilátor ur?í datový typ prom?nné na základ? p?i?azené hodnoty
```
var x = 5; // int
var zprava = "Ahoj"; // string
```
- dynamic - datový typ, který umož?uje odložené ur?ení typu prom?nné
```
dynamic nejakaHodnota = 10;
nejakaHodnota = "Text"; // Žádná chyba, ale potenciáln? nebezpe?né
```

### ?íselné literály

- `int` - desítkový zápis = `int cislo = 100;`
- `0x` - hexadecimální zápis = `int hex = 0xFF;`
- `0b` - binární zápis = `int binarni = 0b1010;`