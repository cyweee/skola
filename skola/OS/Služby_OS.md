# Služby operačních systémů

Operační systém funguje jako prostředník (manažer), který přiděluje omezené zdroje hardwaru jednotlivým aplikacím (ASW) a uživatelům. Mezi jeho hlavní funkce a služby patří:

### 1. Správa procesoru a procesů

OS rozhoduje, jak bude využit výkon "mozku" počítače

- Plánování (Scheduling):
  - OS rychle přepíná mezi programy, takže to vypadá, že běží všechny najednou (multitasking)
- Synchronizace:
  - Hlídá, aby se programy "nepohádaly", když chtějí používat stejnou věc ve stejnou chvíli
> nepohádaly - не поссорились

### 2. Správa paměti (Memory Management)

- Alokace:
  - OS půjčí programu kus RAM, když ho zapneš, a vezme si ho zpět, když ho vypneš
- Ochrana:
  - Každý program má svůj píseček. OS nepustí jeden program do dat druhého
- Virtuální paměť:
  - Když dojde RAM, OS si "půjčí" místo na disku, aby počítač nezamrzl

### 3. Správa souborů (File Management)

- Abstrakce:
  - Místo nul a jedniček vidíš normální jména souborů (např. fotka.jpg)
- Hierarchie:
  - Umožňuje třídit věci do složek a podsložek
- Přístupová práva (Permissions):
  - Určuje, kdo smí soubor otevřít a kdo ho smí smazat
- Souborový manažer:
  - Stará se o formátování disků a hlídá volné místo

### 4. Správa I/O zařízení (Input/Output)

- Ovladače (Drivers):
  - Překladače mezi OS a hardwarem (tiskárna, myš). Díky nim OS rozumí, co hardware dělá
- Bufferování:
  - Dočasná schránka na data. Např. procesor pošle data k tisku do fronty a může hned dělat něco jiného

### 5. Síťová komunikace (Networking)

- Protokoly: 
  - Pravidla (jazyk), kterými si počítače povídají přes internet
- Rozhraní: 
  - OS ovládá Wi-Fi a síťové karty
- Zabezpečení: 
  - Hlídá, aby data po cestě nikdo neukradl

### 6. Bezpečnost a ochrana (Security)
- Autentizace: 
  - Kontrola, že jsi to ty (heslo, PIN)
- Logování: 
  - OS si píše deníček o tom, co se v systému děje a jestli nedošlo k chybě
- Ochrana: 
  - Aktivní obrana proti virům a škodlivému softwaru

> - Autentizace (Kdo jsi?) - Je to proces ověření identity. Systém se ptá: „Jsi to opravdu ty?“
> - Autentifikace (Co smíš dělat) - kontrola tvých práv

### 7. Uživatelské rozhraní (User Interface)
- GUI: 
  - Klasické grafické prostředí (okna, ikonky, myš)
- CLI: 
  - Černé okno na psaní textových příkazů

# 8. Systémové služby a nástroje (Utilities)

- Údržba: 
  - Nástroje na čištění disku, zálohování dat a sledování toho, jak moc se počítač zahřívá.