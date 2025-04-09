

## 1. HDD (pevný disk)

### Jak funguje:
- Uvnitř jsou rotující magnetické plotny.
- Čtecí/zapisovací hlava se pohybuje nad povrchem disků.

### Zápis dat:
- Plotny se otáčí (5400–7200 ot./min).
- Hlava zapisuje magnetické náboje (0 a 1) na povrch.
- Přístup je pomalejší, zvláště blízko středu disku.

> Příklad:  
> Uložíš dokument – hlava najde volné místo, disk se točí a zapisuje magnetické informace.

---

## 2. SSD (solid-state drive)

### Jak funguje:
- Nemá žádné pohyblivé části.
- Používá NAND flash paměť (jako ve flashce).
- Data se ukládají jako elektrony v buňkách.

### Zápis dat:
- Řadič vybere, kam zapsat data.
- Data se zapisují elektrickým nábojem.
- Pro přepsání je třeba nejprve buňku smazat.
- Postup: čtení → změna → mazání → zápis

### Typy buněk:
- SLC – 1 bit (rychlý, drahý)  
- MLC – 2 bity (kompromis)  
- TLC – 3 bity (pomalejší, levnější)  
- QLC – 4 bity (nejlevnější, méně spolehlivý)

---

## 3. M.2 (formát, často NVMe)

### Jak funguje:
- M.2 je formát modulu, často bez kabelů.
- Používá NVMe přes PCIe, což umožňuje extrémně rychlý přenos.
- Stejná NAND flash paměť jako SSD.

### Zápis dat:
- Stejně jako SSD, ale rychleji díky NVMe.
- Data jdou přímo přes základní desku bez zpoždění.
- NVMe zvládne desetitisíce požadavků současně.

> Příklad:  
> Spuštění náročné hry – M.2 dodá data okamžitě do RAM a CPU.

---

## Porovnání úložišť

| Parametr        | HDD               | SSD (SATA)        | M.2 (NVMe)         |
|------------------|-------------------|--------------------|--------------------|
| Princip           | Mechanika + magnetismus | Elektrony v buňkách | Stejné jako SSD, ale rychlejší |
| Přenos dat        | Sekvenční         | Paralelní (pomalejší) | Paralelní (rychlý PCIe) |
| Odezva            | ~10 ms            | ~0,1 ms            | < 0,05 ms          |
| Cena              | Nízká             | Střední            | Vysoká             |
| Odolnost          | Nízká             | Vysoká             | Vysoká             |
| Velikost          | Velký             | Střední            | Velmi malý         |

---
