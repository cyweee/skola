# IKT - test SQL

## `SELECT` Statement

- Příkaz `SELECT` se používá k výběru dat z databáze.
- Vrácená data se ukládají do výsledné tabulky, která se nazývá výsledný soubor.

### `SELECT` Syntax

```sql
SELECT column1, column2, ...
FROM table_name; 
```
- Zde jsou column1, column2, ... názvy polí tabulky, ze které chcete vybrat data.
- Pokud chcete vybrat všechna pole dostupná v tabulce, použijte následující syntaxi:

```sql
SELECT * from table_name;
```

## MySQL `SELECT DISTINCT` Statement

- Příkaz `SELECT DISTINCT` se používá k vrácení pouze odlišných (různých) hodnot.
- V tabulce často obsahuje sloupec mnoho duplicitních hodnot a někdy chcete zobrazit pouze odlišné (různé) hodnoty.

### `SELECT DISTINCT` Syntax

```sql
SELECT DISTINCT column1, column2, ...
FROM table_name; 
```

---

## `WHERE` Statement

- Příkaz WHERE  se používá k filtrování záznamů.
- Slouží k extrakci pouze těch záznamů, které splňují zadanou podmínku.

### `WHERE` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
WHERE condition; 
```

> Note: The WHERE clause is not only used in SELECT statements, it is also used in UPDATE, DELETE, etc.!

---

## `AND`, `OR` and `NOT` Operators

- Příkaz `WHERE` lze kombinovat s operátory `AND`, `OR` a `NOT`.
- Operátory `AND` a `OR` se používají k filtrování záznamů na základě více než jedné podmínky:
  - Operátor `AND` zobrazí záznam, pokud jsou všechny podmínky oddělené operátorem `AND` **PRAVDIVÉ**.
  - Operátor `OR` zobrazí záznam, pokud je některá z podmínek oddělených operátorem `OR` **PRAVDIVÁ**.
- Operátor `NOT` zobrazí záznam, pokud podmínka (podmínky) **NENÍ PRAVDIVÁ**.

### `AND` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
WHERE condition1 AND condition2 AND condition3 ...; 
```

### `OR` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
WHERE condition1 OR condition2 OR condition3 ...; 
```

### `NOT` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
WHERE NOT condition; 
```

---

## `ORDER BY` Keyword

- Klíčové slovo `ORDER BY` se používá k seřazení výsledků ve rostoucím nebo klesajícím pořadí.
- Klíčové slovo `ORDER BY` seřazuje záznamy ve výchozím nastavení v rostoucím pořadí. Chcete-li seřadit záznamy v klesajícím pořadí, použijte klíčové slovo `DESC`.

### `ORDER BY` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
ORDER BY column1, column2, ... ASC|DESC; 
```
> - ASC (Ascending) — Vzestupně (od nejmenšího, je to výchozí nastavení, lze vynechat). 
> - DESC (Descending) — Sestupně (od největšího).
---

## `LIKE` Operator

- Operátor `LIKE` se používá v příkazu `WHERE` k vyhledání zadaného vzoru ve sloupci.
- Existují dva zástupné znaky(**wildcards**), které se často používají ve spojení s operátorem `LIKE`:
  - Znak procenta (%) představuje nulový, jeden nebo více znaků.
  - Znak podtržítka (_) představuje jeden znak.
> Znak procenta a podtržítko lze také použít v kombinaci

### `LIKE` Syntax

```sql
SELECT column1, column2, ...
FROM table_name
WHERE columnN LIKE pattern; 
```
---

## `BETWEEN` Operator

- Operátor `BETWEEN` vybírá hodnoty v daném rozsahu. Hodnoty mohou být čísla, text nebo data.
- Operátor `BETWEEN` je inkluzivní: počáteční a koncová hodnota jsou zahrnuty.

### `BETWEEN` Syntax

```sql
SELECT column_name(s)
FROM table_name
WHERE column_name BETWEEN value1 AND value2; 
```

---

## Wildcard Characters

- Zástupný znak se používá k nahrazení jednoho nebo více znaků v řetězci.
- Zástupné znaky se používají s operátorem `LIKE`. Operátor LIKE se používá v příkazu `WHERE` k vyhledání zadaného vzoru ve sloupci.

### Zástupné znaky (Wildcard Characters) v MySQL

| Symbol | Popis (Česky)                                   | Příklad (Example)                                |
|--------|--------------------------------------------------|--------------------------------------------------|
| %      | Zastupuje žádný nebo libovolný počet znaků.      | bl% najde: bl, black, blue a blob                |
| _      | Zastupuje přesně jeden libovolný znak.           | h_t najde: hot, hat, a hit                       |
