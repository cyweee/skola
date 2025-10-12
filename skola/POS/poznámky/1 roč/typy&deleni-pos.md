# Typy a dělení počítačových sítí

### Dĕli se:

1. podle rozlehlosti a účelu 
2. podle přenosového média 
3. podle postavení uzlů 
4. podle přepojování 
5. podle topologie 
6. podle provozovatele

****

### Typy:

**BAN (Body Area Network)**:  
Síť, která propojuje zařízení přímo na těle člověka nebo v jeho blízkosti. Používá se například ve zdravotnictví pro monitorování zdravotního stavu pomocí senzorů, chytrých hodinek nebo jiných nositelných zařízení.

**PAN (Personal Area Network)**:  
Osobní síť s malým dosahem, obvykle do několika metrů. Typickým příkladem je propojení mobilního telefonu s bezdrátovými sluchátky přes Bluetooth nebo sdílení dat mezi zařízeními přes Wi-Fi Direct.

**LAN (Local Area Network)**:  
Lokální síť, která spojuje zařízení na omezené ploše, například v domě, kanceláři nebo škole. LAN je často realizována pomocí Ethernetu nebo Wi-Fi a umožňuje sdílení dat a tiskáren mezi připojenými zařízeními.

**MAN (Metropolitan Area Network)**:  
Městská síť, která propojuje více lokálních sítí (LAN) v rámci jednoho města nebo větší oblasti. Často ji využívají univerzity, firmy nebo poskytovatelé internetu ke spojení různých lokalit.

**GAN (Global Area Network)**:  
Globální síť, která propojuje zařízení a menší sítě po celém světě. Příkladem GAN je síť satelitů, které poskytují internet na globální úrovni, nebo propojení poboček velkých firem v různých státech.

**WAN (Wide Area Network)**:  
Rozsáhlá síť, která propojuje lokální sítě (LAN) na velké vzdálenosti. WAN často využívá telekomunikační technologie, jako jsou optická vlákna, satelity nebo mikrovlnné spoje. Nejznámějším příkladem WAN je internet.


****
## Dělení sítí dle typu propojení uzlů:

P2P (peer-to-peer)— je síť, kde jsou všechna zařízení rovnocenná a mohou si vyměňovat data přímo, bez centrálního serveru.

### Jak to funguje:

- Zařízení se připojují přímo k sobě.
- Soubory nebo data se přenášejí po částech od více účastníků najednou.

### Výhody:

- Funguje, i když se některý účastník odpojí.
- Rychlejší přenos dat, pokud je hodně účastníků.
- Není potřeba centrální server, který by mohl selhat.

### Nevýhody:

- Menší kontrola nad bezpečností.
- Závislost na aktivitě účastníků (málo lidí = nízká rychlost).

Příklady: Torrenty, decentralizované sítě, jako je blockchain.


Klient-server — je model sítě, kde zařízení (klienti) komunikují přes centrální server, který poskytuje služby nebo data.

### Jak to funguje:

- Klienti posílají požadavky serveru.
- Server zpracuje požadavek a pošle odpověď (např. data, webovou stránku).

### Výhody:

- Centrální kontrola nad daty a zabezpečením.
- Stabilní výkon a spolehlivost.
- Snadná správa a zálohování dat.

### Nevýhody:

- Pokud server selže, celá síť může přestat fungovat.
- Vyšší náklady na provoz a údržbu serveru.

Příklady: Webové stránky, e-maily, databázové systémy.


## Dělení sítí podle přenosového média:

**Metalické kabely (UTP/STP, koaxiální kabel)**  
Používají se hlavně v LAN sítích. Jsou levné, snadno instalovatelné, ale náchylné na rušení.  
- Výhody: nízká cena, jednoduchá instalace.  
- Nevýhody: omezený dosah a rychlost, elektromagnetické rušení.  

**Optická vlákna**  
Používají se v MAN a WAN sítích. Přenášejí data pomocí světelných impulsů.  
- Výhody: vysoká rychlost, velký dosah, odolnost proti rušení.  
- Nevýhody: vyšší cena, složitější instalace.  

**Bezdrátové přenosy (Wi-Fi, Bluetooth, LTE, 5G, satelit)**  
Používají se tam, kde není možné nebo výhodné vést kabel.  
- Výhody: mobilita, flexibilita.  
- Nevýhody: menší bezpečnost, náchylnost k rušení, omezený dosah.  


## Dělení sítí podle přepojování:

**Okruhové přepojování (Circuit Switching)**  
Mezi dvěma účastníky se vytvoří vyhrazený spoj, který zůstává aktivní po celou dobu komunikace (např. klasická telefonní síť).  
- Výhody: stabilní a stálá kvalita spojení.  
- Nevýhody: neefektivní využití linek.  

**Paketové přepojování (Packet Switching)**  
Data se rozdělí na menší pakety, které se posílají nezávisle různými cestami (internet).  
- Výhody: efektivní využití, odolnost vůči výpadkům.  
- Nevýhody: možnost zpoždění (latence).  

**Bunkové přepojování (Cell Switching, ATM)**  
Podobné jako paketové, ale všechny bloky mají stejnou velikost.  
- Výhody: předvídatelná rychlost, vhodné pro přenos hlasu a videa.  
- Nevýhody: složitější a dražší technologie.  


## Dělení sítí podle topologie:

**Sběrnicová (Bus)**  
Všechna zařízení jsou připojena na jednu přenosovou linku.  
- Výhody: jednoduchá instalace, nízká cena.  
- Nevýhody: porucha kabelu vyřadí celou síť.  

**Hvězdicová (Star)**  
Všechna zařízení jsou připojena k centrálnímu uzlu (switch, AP).  
- Výhody: snadná správa, výpadek jednoho PC neovlivní ostatní.  
- Nevýhody: porucha centrálního uzlu vyřadí síť.  

**Kruhová (Ring)**  
Zařízení jsou propojena do kruhu, data procházejí přes každý uzel.  
- Výhody: rovnoměrné rozložení zatížení.  
- Nevýhody: výpadek jednoho uzlu může zastavit celou síť.  

**Stromová (Tree)**  
Hierarchické propojení více hvězd.  
- Výhody: dobrá rozšiřitelnost.  
- Nevýhody: závislost na hlavním uzlu.  

**Síťová (Mesh)**  
Každé zařízení je propojeno s více dalšími.  
- Výhody: vysoká spolehlivost, odolnost proti výpadku.  
- Nevýhody: drahá a složitá instalace.  

**Hybridní**  
Kombinace více topologií podle potřeb.  


## Dělení sítí podle provozovatele:

**Privátní (soukromé)**  
Síť jedné firmy, instituce nebo domácnosti.  
- Výhody: plná kontrola, vyšší bezpečnost.  
- Nevýhody: náklady na správu.  

**Veřejné**  
Síť dostupná pro širokou veřejnost (např. internet od poskytovatele, městská Wi-Fi).  
- Výhody: snadná dostupnost.  
- Nevýhody: nižší bezpečnost, sdílená kapacita.  

**Komerční**  
Síť provozovaná podnikatelským subjektem za účelem poskytování služeb (mobilní operátor, ISP).  
- Výhody: profesionální správa, garance služeb.  
- Nevýhody: závislost na poskytovateli.  

**Komunitní/neziskové**  
Síť vytvořená a spravovaná komunitou uživatelů (např. komunitní Wi-Fi).  
- Výhody: nízké náklady, otevřený přístup.  
- Nevýhody: menší spolehlivost a bezpečnost.  