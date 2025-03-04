# Podmíněné výrazy v C# (if, else, else if)

Podmíněné výrazy umožňují programu vykonat různé části kódu podle podmínky. V C# se používají klíčová slova `if`, `else` a `else if`.
****
## `if`

```
if (podmínka)
{
    // Kód, který se vykoná, pokud je podmínka splněna (true)
}
```

Příklad:
```
int x = 5;
if (x > 0)
{
    Console.WriteLine("x je kladné číslo.");
}
```
****

## `if` s `else` 

Blok else se vykoná, pokud podmínka v if není splněna.

```
if (podmínka)
{
    // Kód, který se vykoná, pokud je podmínka splněna (true)
}
else
{
    // Kód, který se vykoná, pokud podmínka není splněna (false)
}
```

Příklad:
```
int x = -5;
if (x > 0)
{
    Console.WriteLine("x je kladné číslo.");
}
else
{
    Console.WriteLine("x je záporné číslo.");
}
```
****

## `else if` pro více podmínek

Pokud máme více možných podmínek, můžeme použít else if.

```
if (podmínka1)
{
    // Kód, který se vykoná, pokud je podmínka1 splněna (true)
}
else if (podmínka2)
{
    // Kód, který se vykoná, pokud je podmínka2 splněna (true)
}
else
{
    // Kód, který se vykoná, pokud žádná z předchozích podmínek není splněna
}
```

****

## Vnořené `if` 

Podmínky lze také vnořovat do sebe.

Příklad:
```
int x = 5;
if (x > 0)
{
    if (x % 2 == 0)
    {
        Console.WriteLine("x je kladné sudé číslo.");
    }
    else
    {
        Console.WriteLine("x je kladné liché číslo.");
    }
}
```
