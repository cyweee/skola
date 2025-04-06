# Kontrolní otázky – Počítačové sítě (1. ročník – 1. pololetí)

## 1. Rozdíl mezi přepínáním okruhů a paketů
- **Přepínání okruhů** – vytvoří se trvalé spojení (např. telefonní hovor).
- **Přepínání paketů** – data se rozdělí na pakety, které putují různými cestami (např. internet).

## 2. Analogová vs. digitální síť
- **Analogová** – přenáší spojitý signál (např. starý telefon).
- **Digitální** – přenáší data jako 0 a 1. Rychlejší, spolehlivější.

## 3. Klient-server vs. peer-to-peer
- **Klient-server** – klienti komunikují se serverem (např. webová stránka).
- **P2P** – počítače si data vyměňují přímo (např. torrenty).

## 4. Sběrnicová topologie
- Všechna zařízení jsou připojena na jeden kabel.
- **+** Jednoduchá a levná  
- **–** Porucha jednoho místa vyřadí celou síť

## 5. Hvězdicová topologie
- Všechna zařízení připojena ke switchi.
- **+** Porucha jednoho kabelu neovlivní ostatní  
- **–** Porucha switche = výpadek celé sítě

## 6. Rozdíl mezi hvězdou a stromem
- **Hvězda** – každé zařízení vede přímo do centra.
- **Strom** – hierarchická síť složená z více hvězd (např. switch + podsítě).

## 7. LAN, MAN, WAN
- **LAN** – místní síť (škola, dům)  
- **MAN** – městská síť  
- **WAN** – globální síť (internet)

## 8. Veřejná, privátní a VPN síť
- **Veřejná** – otevřená, např. kavárna  
- **Privátní** – uzavřená, např. domácí Wi-Fi  
- **VPN** – bezpečné propojení přes internet

## 9. OSI model
- 7 vrstev od fyziky po aplikaci:  
  1. Fyzická  
  2. Linková  
  3. Síťová  
  4. Transportní  
  5. Relační  
  6. Prezentační  
  7. Aplikační  

## 10. TCP/IP model
- 4 vrstvy:  
  1. Přístup k síti  
  2. Internetová  
  3. Transportní  
  4. Aplikační

## 11. Strukturovaná kabeláž (SKS)
- Organizace kabelů v budově: zásuvky, patch panely, racky.
- Snadná údržba a rozšiřitelnost.

## 12. Synchronní, asynchronní, arytmický přenos
- **Synchronní** – přesný čas  
- **Asynchronní** – start/stop bity  
- **Arytmický** – nepravidelné  
- **Manchester kódování** – zabudovaná synchronizace

## 13. Kolik vodičů je potřeba pro přenos?
- **Minimálně 2** – signál + zem. Např. Ethernet (4 vodiče = 2 páry).

## 14. Baseband vs. broadband + modulace
- **Baseband** – přímý přenos  
- **Broadband** – využívá modulaci  
- **Modulace:**  
  - AM – amplituda (nejméně odolná)  
  - FM – frekvence  
  - PM – fáze

## 15. UTP, STP, FTP, S-STP
- **UTP** – nechráněný  
- **STP** – stínění každé dvojice  
- **FTP** – stínění celkově  
- **S-STP** – dvojité stínění

## 16. Kategorie kabelů
- **Cat5e** – 100 MHz, 1 Gbit/s  
- **Cat6** – 250 MHz  
- **Cat6a** – 500 MHz  
- **Cat7/7a/8** – až 40 Gbit/s

## 17. RJ-45, pořadí vodičů, křížený kabel
- **RJ-45** – konektor Ethernet  
- **Standard T568B:**  
  1. Bílá/oranžová  
  2. Oranžová  
  3. Bílá/zelená  
  4. Modrá  
  5. Bílá/modrá  
  6. Zelená  
  7. Bílá/hnědá  
  8. Hnědá  
- **Křížený kabel** – pro propojení 2 PC bez switche  
- **Krimpovací kleště** – pro montáž

## 18. Impedance + schéma
- **Impedance** – odpor střídavému proudu  
- **Schéma** – R + C + L (rezistor, kondenzátor, cívka)

## 19. Maximální délka TP kabelu
- **100 m celkem:**  
  - 90 m ve zdi  
  - 10 m patch kabely  
- **Patch kabel** – ohebný spojovací

## 20. Odraz a lom světla (Snellius)
- **Odraz:** úhel dopadu = úhel odrazu  
- **Lom:** změna směru při přechodu mezi médii  
- **Kritický úhel:** úplný vnitřní odraz

## 21. Struktura optického vlákna
- **Jádro (n1)** + **plášť (n2)**, kde n1 > n2  
- Typy: skleněné, plastové  
- Využití: internet, medicína

## 22. Druhy vláken podle módu
- **Singlemode** – 8–10 µm jádro, pro dlouhé vzdálenosti  
- **Multimode** – 50/62.5 µm jádro, pro kratší vzdálenosti

## 23. Ztráty a spojování vláken
- **Ztráty:** útlum, ohyb, konektory  
- **Spoje:** sváření, konektory, lepení  
- **Výhody optiky:** rychlost, bezpečnost, vzdálenost

## 24. Co je media konvertor, SFP, GBIC, miniGBIC
- **Media konvertor** – převádí metaliku <-> optiku  
- **SFP** – malý modul pro optiku  
- **GBIC** – starší, větší  
- **miniGBIC = SFP**
****

# Kontrolní otázky – Počítačové sítě (1. ročník – 2. pololetí)

1. Model TCP/IP
   - Rozdělen do 4 vrstev:
     - **Aplikační** – protokoly jako HTTP, FTP, DNS, SMTP.
     - **Transportní** – zajišťuje komunikaci mezi aplikacemi, protokoly TCP (spolehlivý) a UDP (nespolehlivý, rychlejší).
     - **Internetová** – obsahuje IP adresy, směrování, ICMP pro diagnostiku.
     - **Síťového rozhraní** – odpovídá za fyzickou komunikaci v síti.
   - Oproti modelu ISO/OSI, který má 7 vrstev, je jednodušší.

2. Strukturovaná kabeláž
   - Systém kabelů, konektorů a panelů pro přenos dat a hlasu.
   - Dělí se na:
     - **Horizontální vedení** – propojuje koncová zařízení s rozvaděčem.
     - **Páteřní vedení** – propojuje patra a budovy.

3. Přenosy dat
   - **Synchronní** – přenos v pravidelných intervalech.
   - **Asynchronní** – přenos nepravidelný.
   - **Arytmický** – kombinace obou.
   - **Manchester kódování** – využívá změnu napětí pro přenos bitů (Ethernet).

4. Minimální počet vodičů pro přenos dat
   - Minimálně 2 vodiče – jeden pro signál, druhý pro referenci (zem).


5. Přenosová pásma
   - **Základní pásmo** – signál přenášen přímo.
   - **Modulované pásmo** – využívá nosnou vlnu.
   - Druhy modulace:
     - **AM (amplitudová)** – nejméně odolná.
     - **FM (frekvenční)** – odolnější vůči rušení.
     - **PM (fázová)** – využívá změnu fáze signálu.


6. Kroucená dvoulinka
   - Typy:
     - **UTP** – nestíněná.
     - **STP** – stíněná.
     - **S-STP** – dvojitě stíněná.
     - **FTP** – fóliově stíněná.

7. Kategorie TP kabelů
   - **Cat 5e** – 1 Gbit/s.
   - **Cat 6** – 1 Gbit/s, lepší odstínění.
   - **Cat 6a** – 10 Gbit/s.
   - **Cat 7** – 10 Gbit/s, lepší stínění.
   - **Cat 8** – až 40 Gbit/s.

8. RJ-45 konektor
   - Standardní konektor pro síťové kabely.
   - Pořadí vodičů v T568B.
   - Křížený kabel (crossover) pro propojení dvou zařízení.
   - Použití krimpovacích kleští.

9. Maximální délka TP kabelu
   - Celkem 100 m (90 m pevné rozvody + 10 m patch kabely).

10. Zákon odrazu a lomu
   - **Odraz** – úhel dopadu = úhel odrazu.
   - **Lom (Snellův zákon)** – závisí na indexu lomu materiálů.
   - **Kritický úhel** – při dosažení dochází k totálnímu odrazu.


11. Optické vlákno
   - Složení: jádro, plášť, ochranný obal.
   - Dělení: skleněné, plastové.
   - Použití: internet, lékařství, senzory.


12. Dělení optických vláken podle vidů
   - **Jednovidové (SM)** – malé jádro, delší dosah.
   - **Mnohovidové (MM)** – větší jádro, kratší dosah.

13. Ztráty v optice a spojování vláken
   - Ztráty: absorpční, rozptylové, spojovací.
   - Spojování: svary, konektory.
   - Výhody oproti metalickým kabelům: vyšší rychlost, odolnost proti rušení.

14. Mediakonvertor a SFP
   - Mediakonvertor převádí mezi metalickým a optickým signálem.
   - Moduly: SFP, GBIC, miniGBIC.

15. Síťové protokoly
   - **Aplikační**: HTTP, FTP.
   - **Transportní**: TCP, UDP.
   - **Internetová**: IP, ICMP.
   - **Síťová**: Ethernet.

16. Ethernet
   - Vrsty OSI: L2 (linková), L1 (fyzická).
   - Topologie: sběrnicová, hvězdicová.

17. MAC adresa
   - 48bitová adresa, 6 bloků hexadecimálně (např. 00:1A:2B:3C:4D:5E).

18. Dvojková a šestnáctková soustava
   - Převod 11001100 (binárně) → CC (hexadecimálně).

19. CSMA/CD
   - Metoda detekce kolizí při sdílení média.

20. Přenosy na linkové vrstvě
   - **Broadcast** – všem.
   - **Unicast** – jednomu.
   - **Multicast** – skupině.

21. Ethernetový rámec
   - Obsahuje hlavičku, data a kontrolní součet.

22. Zapouzdření a rozbalení dat
   - **Zapouzdření** – přidání hlaviček a směrovacích informací.
   - **Deencapsulace** – odstranění hlaviček při příjmu.

23. Rámec vs. paket
   - Rámec obsahuje paket, slouží k přenosu na linkové vrstvě.

24. Hub vs. Switch
   - **Hub** – přeposílá data všem.
   - **Switch** – přeposílá data cíleně podle MAC adres.
   - Switch pracuje v topologii hvězda.

25. Full duplex vs. Half duplex
   - **Full duplex** – současný přenos oběma směry.
   - **Half duplex** – přenos střídavě.
   - Full duplex se používá od 100 Mbit/s.

26. Rychlosti Ethernetu
   - **10BASE-T** – 10 Mbit/s.
   - **100BASE-TX** – 100 Mbit/s.
   - **1000BASE-T** – 1 Gbit/s.
   - **10GBASE-T** – 10 Gbit/s.

27. CAM tabulka
   - Switch ukládá MAC adresy pro rychlejší přepínání rámců.

28. Přepínání rámců
   - Switch čte MAC adresy a směruje data podle tabulky CAM.