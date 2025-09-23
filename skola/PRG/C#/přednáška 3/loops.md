# Cykly

Cyklus je konstrukce, která umožňuje opakovat nějaký kód. Cyklus se skládá z podmínky, která určuje, zda se má kód opakovat, a těla cyklu, které obsahuje kód, který se má opakovat.

## Cyklus `for`

Cyklus `for` se používá, když chceme opakovat kód pro každý prvek v nějaké sekvenci. Například pro každý prvek v seznamu nebo pro každý znak v řetězci.
```

for i in range(5):
	print(i)
```

Výstup:
```
0
1
2
3
4
```

## Cyklus `while`

Cyklus `while` se používá, když chceme opakovat kód, dokud je splněná nějaká podmínka.
```
i = 0
while i < 5:
	print(i)
	i += 1
```

Výstup:
```
0
1
2
3
4
```


## Příkaz `break`

Příkaz `break` slouží k ukončení cyklu. Pokud je `break` vyvolán uvnitř cyklu, cyklus se okamžitě ukončí.
```
for i in range(10):
	if i == 5:
		break
	print(i)
```

Výstup:
```
0
1
2
3
4
```

## Příkaz `continue`

Příkaz `continue` slouží k přeskočení zbytku těla cyklu a pokračování s dalším průchodem cyklem.
```
for i in range(5):
	if i == 2:
		continue
	print(i)
```

Výstup:
```
0
1
3
4
```
