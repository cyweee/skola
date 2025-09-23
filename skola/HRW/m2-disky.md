# M.2 disky (SATA a NVMe)

---

## Co je M.2?

- M.2 je moderní formát (fyzický tvar) disku, který je menší a kompaktnější než tradiční 2.5" SSD nebo HDD. Používá se hlavně v noteboocích a nových desktopech. M.2 není typ disku ani protokol, ale pouze formát. Do slotu M.2 mohou být připojeny různé druhy zařízení, včetně SSD disků.

---

## Druhy M.2 SSD disků 

- **Existují dva hlavní typy SSD disků ve formátu M.2:**

### **M.2 SATA SSD**

#### Jak funguje?

- Používá tradiční rozhraní SATA (stejně jako 2.5" SSD).
- Komunikuje přes starší protokol `AHCI`
- Připojuje se přes M.2 slot, ale rychlost je stejná jako u běžného SATA SSD.
- Maximální rychlost přenosu dat je kolem **500 MB/s.**

| Výhody                  | Nevýhody                                |
|--------------------------|------------------------------------------|
| Kompaktní tvar           | Pomalejší než NVMe                     |
| Vhodné pro starší zařízení | Starší technologie (AHCI)               |
| Nízká spotřeba energie   | Omezená přenosová rychlost             |

### 1. Použití v praxi
- M.2 SATA SSD je oblíbený hlavně v noteboocích a ultraboocích kvůli kompaktním rozměrům.
- Je vhodný jako upgrade pro starší systémy, které mají M.2 slot, ale nepodporují PCIe/NVMe.
- Vhodné pro běžnou práci, kancelář, prohlížení internetu, nenáročné aplikace.

### 2. Technické detaily
-  M.2 SATA SSD využívá stejné NAND flash čipy jako ostatní SSD (SLC, MLC, TLC, QLC).
-  Stejně jako ostatní SSD má řadič, cache (DRAM nebo HMB) a buňky NAND.
-  Nepřekračuje limit SATA 6 Gb/s, což je teoreticky cca 600 MB/s, prakticky ~500 MB/s.

### 3. Kompatibilita

- Některé základní desky (hlavně starší nebo levné modely) mají M.2 slot pouze pro SATA.
- Nelze očekávat žádné zrychlení proti 2.5" SSD, jen menší velikost a méně kabelů.
- Důležité je zkontrolovat, zda slot podporuje SATA – některé podporují jen NVMe.

### 4. Form Factor a klíče
> **Form Factor** norma specifikující celkové rozměry technického výrobku a popisující další soubory technických parametrů, jako je tvar, typy přídavných prvků, které mají být umístěny na zařízení, jejich umístění a orientace
- Většinou má Key B nebo Key B+M.
- Délky: běžné velikosti M.2 disků — 2242, 2260, 2280 (poslední je nejběžnější: 22 mm šířka × 80 mm délka).

****

### **M.2 NVMe SSD**

#### Jak funguje?

- Používá moderní rozhraní `PCI Express (PCIe)`
- Komunikuje pomocí rychlého protokolu NVMe (`Non-Volatile Memory Express`).
- Mnohem rychlejší než SATA – rychlosti od 1500 MB/s až přes 7000 MB/s.
- Využívá více paralelních datových linek (PCIe ×4).

### Výhody a nevýhody: M.2 NVMe SSD

| Výhody                           | Nevýhody                                |
|----------------------------------|------------------------------------------|
| Extrémně vysoká rychlost         | Vyšší cena než SATA SSD                 |
| Nízká latence                    | Vyšší zahřívání – může potřebovat chlazení |
| Rychlé načítání OS, her a aplikací | Nutnost podpory NVMe od základní desky |


### 1. Použití v praxi

- M.2 NVMe SSD se používá hlavně v výkonných noteboocích, pracovních stanicích a herních počítačích.
- Ideální pro rychlé načítání operačního systému, her, virtualizaci, práci s videem a velkými soubory.
- Umožňuje extrémně rychlé spouštění programů a přenos dat díky vysoké propustnosti PCIe.
- Vhodný jako primární disk (např. disk C:\ s OS) pro maximální výkon.

### 2. Technické detaily

- Využívá rozhraní PCIe Gen3 ×4, Gen4 ×4 nebo dokonce Gen5 ×4 (v nejnovějších zařízeních).
- Komunikuje přes moderní protokol NVMe, který je optimalizovaný pro práci s flash pamětí.
- Obsahuje NAND flash, řadič (controller) a obvykle i DRAM cache (výrazně zvyšuje výkon).
- Některé levnější modely používají tzv. HMB (Host Memory Buffer) místo vlastní DRAM.
> `Host Memory Buffer` - technologie, která umožňuje diskům SSD využívat systémovou paměť (DRAM) jako vyrovnávací paměť pro ukládání dat do mezipaměti namísto vlastní vyrovnávací paměti DRAM na samotném disku

### 3. Kompatibilita

- Ne všechny M.2 sloty podporují NVMe – je nutné zkontrolovat, že základní deska podporuje PCIe a NVMe.
- U starších desek může být slot M.2 pouze SATA.
- V BIOSu je potřeba mít zapnutý NVMe režim (někdy označeno jako „PCIe SSD“ nebo „NVMe support

### 4. Form Factor a klíče

- Nejčastější typ konektoru: Key M nebo Key M (samostatný) – určený pro NVMe SSD.
- Délky disků: běžně M.2 2280 (22 mm šířka, 80 mm délka), ale existují i delší (22110) pro servery.
- Pozor na chlazení – výkonné NVMe disky se mohou přehřívat, proto se často používají chladiče nebo je třeba zajistit dobré proudění vzduchu.

****

**Užitečná videa** pro m2 disky a obecně

1. [ SSD vs Hard Drive vs Hybrid Drive ](https://www.youtube.com/watch?v=1cyMTl_QXSc)
2. [How do Hard Disk Drives Work? 💻💿🛠](https://www.youtube.com/watch?v=wtdnatmVdIg)
3. [SSD vs HDD vs NVMe vs SATA vs mSATA vs M2: Storage Devices EXPLAINED!](https://www.youtube.com/watch?v=r3Jy5dHOj3g)
4. [Explaining M.2 NVMe SSDs - M.2 vs. SSDs ](https://www.youtube.com/watch?v=HvfIeTieXOI)
