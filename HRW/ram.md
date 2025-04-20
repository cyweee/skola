# Operační paměť (RAM)

RAM (Random Access Memory) je volatilní paměť, což znamená, že po vypnutí počítače se data smažou. RAM slouží k dočasnému ukládání dat a instrukcí, které počítač právě používá.

> Hlavní vlastnost: RAM je extrémně rychlá v porovnání s jinými typy paměti (např. HDD, SSD).

****

## K čemu RAM slouží?

- Ukládá dočasná data pro běžící programy a operační systém.
- Umožňuje rychlý přístup procesoru k potřebným informacím.
- Více RAM = možnost spouštět více aplikací najednou bez zpomalení.

****

## Jak RAM funguje?

1. Při spuštění aplikace se její data načítají z disku (HDD/SSD) do RAM.
1. Procesor (CPU) pracuje s těmito daty přímo z RAM, protože je to mnohem rychlejší.
1. Po vypnutí počítače se data v RAM vymažou.

****

## Druhy RAM

### 1. DRAM (Dynamická RAM)

-  Nejčastější typ RAM v počítačích.
-  Ukládá data pomocí kondenzátorů, které je nutné neustále obnovovat.
-  Je levná, ale pomalejší než SRAM.
-  Používá se jako hlavní paměť systému.
---
### 2. SRAM (Statická RAM)

-    Data ukládá pomocí klopných obvodů, které nepotřebují obnovování.
-    Rychlejší, ale dražší a zabírá víc místa.
-    Používá se hlavně jako cache paměť (L1, L2, L3) uvnitř procesoru.
---
### SDRAM (Synchronous DRAM)

-  Synchronizována s hodinami systému (na rozdíl od klasické DRAM).
-  Rychlejší a efektivnější při přenosu dat.
-  Předchůdce všech DDR pamětí.
-  Dnes už zastaralá.
---
### 5. RDRAM (Rambus DRAM)

- Vyvinuto firmou Rambus v 90. letech jako „budoucnost pamětí“.
- Extrémně drahá, komplikovaná a měla vysokou latenci.
- Rychle upadla v zapomnění. Dnes nepoužívaná.
---
### 6. ROM – Read-Only Memory

ROM je neenergeticky závislá paměť – to znamená, že uchovává data i po vypnutí zařízení. Na rozdíl od RAM není určena pro časté přepisování, ale pro trvalé uložení důležitých dat, jako je např. BIOS, firmware nebo základní kód mikrořadičů.

#### Typy ROM paměti:

1. ROM (klasická)

- Data jsou zapsána výrobcem a uživatel je nemůže změnit.
- Používala se v jednoduché elektronice a starších počítačích.
- Dnes téměř nepoužívaná.

2. PROM (Programmable ROM)

-  Paměť, kterou lze naprogramovat jen jednou pomocí speciálního zařízení (programátoru).
-  Po zapsání dat již nelze změnit.

****

## Co je DDR?

DDR (`Double Data Rate`) je typ DRAM, který přenáší data dvakrát během jednoho hodinového cyklu (na náběžné i sestupné hraně signálu).

| Název  | Rok uvedení | Přenosová rychlost        | Typická frekvence     |
|--------|-------------|----------------------------|------------------------|
| DDR1   | ~2000       | 200–400 MT/s               | 100–200 MHz            |
| DDR2   | ~2003       | 400–800 MT/s               | 200–400 MHz            |
| DDR3   | ~2007       | 800–2133 MT/s              | 400–1066 MHz           |
| DDR4   | ~2014       | 2133–3200+ MT/s            | 1066–1600+ MHz         |
| DDR5   | ~2020       | 4800–8000+ MT/s            | 2400–4000+ MHz         |
> MT/s = milion přenosů za sekundu. Neplést s MHz.

### Proč je DDR5 lepší než DDR4?

1. Vyšší propustnost (více dat za sekundu).
1. Nižší napětí → menší zahřívání, úspora energie.
1. Vyšší frekvence → rychlejší odezva.

### Piny u DDR pamětí

Každá generace DDR má jiný počet pinů (kontaktů), které propojují modul s základní deskou. Sloty na základní desce jsou mechanicky odlišné, aby nešlo vložit nesprávný typ.

| Typ DDR | Počet pinů (DIMM) | Počet pinů (SO-DIMM) |
|---------|--------------------|------------------------|
| DDR1    | 184                | 200                    |
| DDR2    | 240                | 200                    |
| DDR3    | 240                | 204                    |
| DDR4    | 288                | 260                    |
| DDR5    | 288                | 262                    |
****

## Jak RAM komunikuje s procesorem

- RAM je propojena s CPU přes řadič paměti (memory controller).
- U moderních CPU je řadič integrovaný přímo v procesoru.
- Data jdou přes paměťovou sběrnici.

### Klíčové parametry:

- **Propustnost**: kolik dat může projít za sekundu.
- **Latence (zpoždění)**: čas mezi požadavkem a odpovědí.
- **Šířka sběrnice**: typicky 64 bitů (1 modul RAM).
****

## Paměťové kanály

- **Single-channel** = 1 kanál.
- **Dual-channel** = 2 kanály → dvojnásobná propustnost.
- **Quad-channel** = pro servery, pracovní stanice.
****

## Formáty RAM modulů

- DIMM – běžné moduly pro stolní PC.
- SO-DIMM – kratší moduly pro notebooky.
****

## Důležité parametry při výběru RAM

| Parametr         | Popis                                                |
|------------------|------------------------------------------------------|
| Kapacita         | Čím více, tím lépe pro multitasking                 |
| Frekvence        | Vyšší = rychlejší                                    |
| Časování (např. CL16) | Nižší = rychlejší odezva                        |
| Napětí           | Nižší = menší spotřeba a zahřívání                  |
| Kompatibilita    | Ujisti se, že CPU a základní deska podporují zvolený typ a frekvenci |
