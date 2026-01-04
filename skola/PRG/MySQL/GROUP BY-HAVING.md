# GROUP BY a HAVING

## `GROUP BY`

Příkaz `GROUP BY` seskupuje řádky, které mají stejné hodnoty v určených sloupcích, do souhrnných řádků (např. „najdi počet zákazníků v každé zemi“)

Tento příkaz se téměř vždy používá s agregačními funkcemi:
- `COUNT()`
- `SUM()`
- `AVG()`
- `MIN()` / `MAX()`

### `GROUP BY` syntaxe

```sql
SELECT sloupec_name, COUNT(*)
FROM tabulka
WHERE podminka
GROUP BY sloupec_name;
```

## `HAVING`

Klauzule HAVING byla do SQL přidána proto, že klíčové slovo WHERE nelze použít s agregačními funkcemi. Pokud chcete filtrovat výsledky na základě vypočítaných hodnot (např. „zobraz jen země s více než 5 zákazníky“), musíte použít HAVING

### `HAVING` syntaxe

```sql
SELECT sloupec_name, COUNT(*)
FROM tabulka
GROUP BY sloupec_name
HAVING COUNT(*) > hodnota;
```
