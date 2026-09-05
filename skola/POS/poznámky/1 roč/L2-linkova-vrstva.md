# Linková vrstva a Ethernet (Network layer)
****
### 1. Linková vrstva v modelu OSI a koncept Ethernetu

- Je to druhá vrstva modelu OSI, která zajišťuje přenos dat mezi zařízeními v jedné síti
- V modelu TCP/IP patří do Network Access Layer (Vrstva síťového přístupu).
- Ethernet lze vnímat ve třech rovinách
  1. **Standard:** Definován IEEE jako 802.3 (definuje formát rámce, přístup k médiu, rychlosti a kabely)
  2. **Technologie:** Technologie pro lokální sítě LAN (kabeláž, switche, síťové karty)
  3. **Protokol:** Protokol linkové vrstvy, který řeší adresování pomocí MAC adres a zapouzdření (IPv4, IPv6)
- **Co Ethernet nedělá:** Neřeší IP adresy, routování ani internet

****
### 2. Podvrstvy linkové vrstvy (IEEE 802)

IEEE 802 definuje standardy pro LAN/MAN, přičemž Ethernet je **802.3**
Linková vrstva se dělí na dvě podvrstvy

1. **LLC (Logical Link Control) – IEEE 802.2**- Komunikuje se síťovými protokoly (L3).
- Umožňuje sdílení stejného média více protokoly.
2. **MAC (Media Access Control)**
- Řídí přístup k fyzickému médiu (kabel, optika)
- Používá MAC adresy pro identifikaci zařízení

****
### 3. Duplexní komunikace a řízení přístupu (CSMA/CD)

- **Poloduplexní (Half-Duplex):** Data se přenášejí jen jedním směrem v daný okamžik
  - Používá detekci kolizí **CSMA/CD**
  - Kolize může nastat jen během odesílání prvních 512 bitů (*časový slot*)
  - Proto musí být minimální velikost rámce **64 bajtů** (512 bitů). Rámce menší než 64 B (tzv. runt) se zahazují
- **Plně duplexní (Full-Duplex):** Obousměrná současná komunikace
  - Od rychlosti 1 Gb/s se používá výhradně plný duplex a CSMA/CD se již neřeší

****
### 4. Formát ethernetového rámce (Frame)

- **Mezera mezi rámci (IFG - Interframe Gap):** Čas na zpracování rámce, minimálně 96 bitových dob (12 bajtů)
- **Preambule (7 B) a SFD (1 B):** Slouží k synchronizaci a označení začátku, nejsou součástí samotného rámce

**Typy rámců:**
1. **Ethernet II (DIX Ethernet)** - Dnes dominantní, implicitní volba v OS
   - Obsahuje pole **EtherType (Typ)** o délce 2 B, které má hodnotu > 1500 a určuje nesený protokol (např. IPv4 je 0x0800)
   - Struktura: Cílová MAC (6 B) | Zdrojová MAC (6 B) | Typ (2 B) | Data (46-1500 B) | FCS (4 B)
   - Celková délka: 64 až 1518 bajtů
2. **IEEE 802.3** - Obsahuje pole **Length (Délka)** s hodnotou 1500 nebo menší
   - Typ protokolu se musí určovat vložením LLC hlavičky do datové části, což zmenšuje maximální užitečný náklad na 1492 bajtů

****
### 5. Kabeláž a zapojení RJ-45

Konektor RJ-45 (8P8C) se zapojuje podle standardů **T568A** a **T568B**
- **Přímý kabel (Straight-through):** Oba konce stejné (např. T568B - T568B). Propojení PC a switche
- **Křížený kabel (Crossover):** Jeden konec T568A, druhý T568B. Dříve pro PC-PC, dnes řeší Auto-MDI/MDIX automaticky
- **Konzolový kabel (Rollover):** Není pro Ethernet. Prohozený zelený a oranžový pár, slouží ke správě síťových prvků (router, switch)

****
### 6. Standardy rychlostí Ethernetu

- **10Base-T (10 Mb/s):** UTP Cat3, využívá 2 páry (piny 1-2 a 3-6), Half-duplex
- **100Base-TX (Fast Ethernet, 100 Mb/s):** UTP Cat5/5e, využívá 2 páry, Half i Full-duplex
- **1000Base-T (Gigabit Ethernet, 1 Gb/s):** UTP Cat5e/6, **využívá aktivně všechny 4 páry**, Full-duplex
- Max. délka segmentu u kroucené dvojlinky je vždy 100 metrů 

> Moderní sítě (Ethernet, Wi-Fi) využívají plně duplexní režim a pracují bez kolizí díky přepínačům.