# Služby operačních systémů

Operační systém funguje jako prostředník (manažer), který přiděluje omezené zdroje hardwaru jednotlivým aplikacím (ASW) a uživatelům. Mezi jeho hlavní funkce a služby patří:

## 1. Správa procesoru a procesů

Proces je program v běhu. OS musí zařídit, aby se jich do procesoru (CPU) vešlo co nejvíc a aby systém nezamrzl, když jeden program začne "blbnout"

### Plánování (Scheduling)
Protože procesor je mnohem rychlejší než člověk, OS používá tzv. plánovač (scheduler). Ten určuje frontu úloh

- **Queue**: Procesy stojí v řadě a čekají, až na ně přijde řada
- **Časové kvantum**: Každý proces dostane jen pár milisekund slávy. Pak ho OS násilně přeruší a pustí dalšího. Díky tomu, že se to děje tisíckrát za sekundu, máš pocit, že se video přehrává plynule, i když u toho stahuješ soubor

### Multitasking
**Multitasking (víceúlohovost) je schopnost či snaha vykonávat několik úkolů zdánlivě současně**

1. **Kooperativní multitasking:**
   - Tzv. nepreemptivní je způsob správy úloh, kdy běžící aplikace sama dobrovolně a pravidelně předává řízení procesoru operačnímu systému
2. **Preemptivní multitasking:**
   - Je způsob správy úloh operačním systémem, kdy ten automaticky a násilně (preempcí) odebírá procesorový čas běžícím aplikacím a přiděluje jej jiným, aniž by musely spolupracovat

### Synchronizace a kritické sekce

Aby se programy „nepohádaly“ (např. aby dva programy nechtěly ve stejnou mikrosekundu zapisovat do stejného dokumentu), používá OS speciální zámky:

- **Semafor / Mutex**: Jsou to bezpečnostní mechanismy. Pokud program začne pracovat s důležitými daty, OS u nich "zamkne dveře". Ostatní programy, které by chtěly se stejnými daty pracovat, musí počkat ve frontě, dokud ten první práci nedokončí a data neodemkne. Tím se zabrání chybám a přepisování dat navzájem
- **Deadlock(Uváznutí)**: Je to stav, kdy se systém "zacyklí". Program A čeká, až program B uvolní paměť, ale program B zase čeká, až program A uvolní procesor. Oba se navzájem blokují a nikdo nemůže pokračovat. OS musí umět tuhle situaci poznat a jeden z procesů ukončit, aby zbytek počítače mohl dál fungovat


## 2. Správa paměti (Memory Management)

### Alokace (Přidělování)

Když klikneš na ikonku programu (třeba prohlížeč), OS musí najít v RAM volné místo, kam ho "naskládá".

- Dynamické přidělování: OS nedává programům paměť jen tak od oka. Program si během běhu říká: „Teď potřebuju víc na tuhle fotku,“ a OS mu ji přihraje
- Dealokace (Uvolnění): Jakmile program zavřeš, OS musí tohle místo okamžitě vyčistit a označit jako volné. Kdyby to neudělal, vznikne tzv. Memory Leak (únik paměti) – paměť by se postupně zaplnila "duchy" starých programů, až by počítač musel restartovat

### Ochrana paměti (Memory Protection)

Každý program dostane od OS přidělený svůj přesný rozsah adres (tzv. adresní prostor)

- **Izolace**: OS funguje jako zeď. Program A se nesmí ani podívat na data Programu B
- **Segmentation Fault**: Pokud se nějaký program (třeba kvůli chybě nebo viru) pokusí sáhnout do paměti, která mu nepatří, OS ho okamžitě "zabije" (vypne). To je ta známá hláška „Aplikace provedla neplatnou operaci a bude ukončena“. Díky tomu nespadne celý systém, ale jen ten jeden drzý program

### Virtuální paměť

- **Stránkování (Paging)**: OS rozdělí paměť na malé kousky (stránky). Ty, které program právě teď aktivně nepoužívá, přesune z rychlé RAM na pomalejší pevný disk (do tzv. Swapu nebo stránkovacího souboru)
- **Thrashing (Výprask)**: Pokud máš RAM extrémně málo a OS musí neustále přesouvat data tam a zpět mezi diskem a RAM, počítač začne šíleně hrabat a skoro nereaguje. Tomu se říká, že systém "swapuje"
> Díky tomu můžeš mít otevřených 50 záložek v Chromu i na starším notebooku. Ty neaktivní záložky "spí" na disku a do RAM se vrátí, až na ně klikneš

---

## 3. Správa souborů (File Management)

### Abstrakce

Tohle je největší "kouzlo" OS. Disk reálně neví, co je to "fotka z dovolené". On zná jen sektory a bloky na hardwaru

- **Logický pohled**: OS ti ukáže ikonu, název `dovolena.jpg` a velikost v MB
- **Fyzický pohled**: OS v pozadí překládá tvůj požadavek "otevřít fotku" na konkrétní adresy na disku, kde jsou ta data fyzicky zapsaná
- **Přípony**: OS podle přípony (např. .docx, .mp3) pozná, který program má k souboru zavolat, aby ho správně přečetl

### Hierarchie (Stromová struktura)

OS organizuje data do systému, kterému říkáme souborový systém (např. **NTFS, FAT32, ext4**)

- **Adresářová struktura**: Umožňuje vytvářet složky a vnořené podsložky. Tím vzniká tzv. cesta k souboru (např. `C:\Uzivatele\Karel\Dokumenty\skola.pdf`)
- **Kořenový adresář (Root)**: Každý disk má svůj počátek (ve Windows je to `C:\`), od kterého se všechno větví jako strom

### Permissions(Přístupová práva)

- **Základní práva**: Většinou se rozlišuje Čtení (můžeš soubor vidět), Zápis (můžeš ho změnit) a Spuštění (pokud je to program)
- **Vlastník vs. Ostatní**: OS si pamatuje, kdo soubor vytvořil. Můžeš nastavit, že tvůj deníček si můžeš přečíst jen ty, ale ostatní uživatelé v počítači ho ani neotevřou

### Souborový manažer a údržba

- **Formátování**: Když koupíš nový disk, OS na něm musí vytvořit "tabulku", do které si bude psát, co kde leží. Bez formátování je disk pro OS jen kus nepoužitelného plastu a kovu.
- **Správa volného místa**: OS má speciální seznam (bitovou mapu) všech volných bloků na disku. Když něco ukládáš, OS se podívá do seznamu a řekne: „Tady na konci je místo, tam to dej.“
- **Metadata**: OS u každého souboru tajně ukládá info navíc: kdy byl naposledy otevřen, jestli je skrytý nebo jestli je poškozený.

## 4. Správa I/O zařízení (Input/Output)

### Bufferování a Spooling(Dočasné schránky)

- **Buffer (Vyrovnávací paměť)**: Je to malý kousek paměti, kam OS "nasype" data, která se mají odeslat. Např. když píšeš na klávesnici, OS si údery ukládá do bufferu a pak je naráz vykreslí na obrazovku.
- **Spooling (Fronta)**: Typické pro tisk. OS vytvoří na disku speciální soubor (frontu). Procesor tam "vyhodí" celý dokument během sekundy a jde si po svém (můžeš dál hrát hry). Tiskárna si pak z téhle fronty pomalu tahá data podle toho, jak stíhá tisknout.
- **Caching**: Podobné jako buffer, ale pro čtení. OS si pamatuje, co jsi z disku četl naposledy. Když to chceš znovu, nedoluje to z pomalého disku, ale bleskově to vytáhne z paměti


## 6. Bezpečnost a ochrana (Security)
- **Autentizace**: Kontrola, že jsi to ty (heslo, PIN)
- **Logování**: OS si píše deníček o tom, co se v systému děje a jestli nedošlo k chybě
- **Ochrana**: Aktivní obrana proti virům a škodlivému softwaru

> - Autentizace (Kdo jsi?) - Je to proces ověření identity. Systém se ptá: „Jsi to opravdu ty?“
> - Autentifikace (Co smíš dělat) - kontrola tvých práv

## 7. Uživatelské rozhraní (User Interface)
- GUI: 
  - Klasické grafické prostředí (okna, ikonky, myš)
- CLI: 
  - Černé okno na psaní textových příkazů