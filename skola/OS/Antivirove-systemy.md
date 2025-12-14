# Antivirové systémy

## Funkce antivirového systému

Základní role antivirového softwaru, jako je například Microsoft Defender, je poskytovat ochranu v reálném čase i při skenování na vyžádání.

- Ochrana v reálném čase (Real-Time Protection): Neustálé monitorování systému, souborů, příchozích dat a procesů pro okamžité zachycení hrozeb
- Detekce a odstranění Malwaru: Identifikace a neutralizace škodlivého softwaru (včetně virů, trojských koní, spyware) a Ransomwaru
- Skenování na vyžádání (On-Demand Scanning): Uživatel nebo administrátor spustí kontrolu celého systému, konkrétního disku nebo složky
  - Typy skenování:
    - **Real-Time Protection**
      - Neustálé monitorování souborů a procesů, jakmile jsou spouštěny.
    - **Quick Scan**
      - Kontrola pouze kritických a často napadaných systémových míst.
    - **Full Scan**
      - Důkladná kontrola všech souborů na discích
    - **Custom Scan**
      - Kontrola specifických souborů nebo složek definovaných uživatelem.
- Aktualizace definic (Definition Updates): Pravidelné stahování a instalace databází známých hrozeb pro udržení aktuálnosti ochrany
- Ochrana proti síťovým útokům: Blokování pokusů o narušení, které přicházejí přes síť
- Reportování a monitoring: Poskytování informací o stavu zařízení a detekovaných hrozbách

## Perzistence virů

- **Uložení v paměti (Memory Residency)**:
  - Kód se načte do RAM při spuštění a zůstává aktivní, dokud se systém nevypne, mezitím infikuje další soubory
- **Injekce kódu (Tělo programu)**:
  - Vir se vloží do legitimního programu a spustí se jako první, když je program aktivován.
- **Makra**: 
  - Infikují soubory Office; kód se spustí při otevření dokumentu
- **Rootkity/Bootkity**:
  - Vir se skrývá v bootovacím sektoru nebo hlubokých částech OS, aby získal kontrolu při startu systému

## Dělení (Kategorie) virů a Malwaru

- Viry (Viruses): Vyžadují hostitele (soubor, program) a šíří se replikací, kdy se vkládají do jiných spustitelných souborů.
- Červi (Worms): Samostatně se šířící malware, který ke své replikaci nepotřebuje hostitelský soubor. Využívá síťové zranitelnosti k šíření na další počítače.
- Trojské koně (Trojans): Maskují se jako užitečný nebo legitimní software, ale po spuštění provádějí škodlivé akce (např. krádež dat, otevření zadních vrátek).
- Ransomware: Šifruje data oběti a požaduje výkupné za jejich dešifrování.
- Spyware: Sbírá informace o uživateli, jeho aktivitě nebo stisknutých klávesách bez jeho souhlasu.

## Typy detekce virů

1. **Signature-Based Detection**
    - Princip: Antivir porovnává kód souboru se svou databází známých digitálních "otisku" (signatur) škodlivého kódu.
    - Silné stránky: Velmi přesná detekce známých hrozeb.
    - Slabé stránky: Neúčinná proti novým hrozbám (tzv. "zero-day" útokům), pro které ještě nebyla vytvořena signatura.
2. **Heuristic-Based Detection**
   - Princip: Antivir analyzuje kód souboru, zda neobsahuje podezřelé nebo neobvyklé instrukce či vzorce, které jsou typické pro Malware. Netestuje shodu s konkrétní signaturou, ale s pravidly chování virů.
   - Silné stránky: Dokáže detekovat nové a neznámé hrozby.
3. **Behavioral-Based Detection**
   - Princip: Monitoruje chování spuštěného programu (procesu) v reálném čase. Pokud program začne provádět rizikové akce (např. hromadně šifrovat soubory, modifikovat systémové registry, pokoušet se o přístup k chráněným datům), je identifikován jako hrozba.
   - Silné stránky: Velmi účinná proti Ransomwaru a polymorfním virům (které neustále mění svůj kód).
4. **Sandboxing**
   - Princip: Podezřelé soubory se spustí v izolovaném virtuálním prostředí (sandboxu), kde nemohou poškodit skutečný systém. Monitoruje se, jaké akce v tomto bezpečném prostředí provádějí, a na základě toho se určí jejich škodlivost.