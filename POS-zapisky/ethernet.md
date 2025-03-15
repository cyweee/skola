# Ethernet

**Ethernet je přenosovou technologií zajišťující skutečný přenos dat.**

Definován ve standardech IEEE 802.2 (LLC) a 802.3 (MAC).

Podporované přenosové rychlosti:
- 10 Mbps, 100 Mbps, 1 Gbps, 10 Gbps, 40 Gbps, 100 Gbps.

****

## 1. Struktura linkové vrstvy

Podvrstvy:

- `LLC (Logical Link Control)` – zprostředkovává komunikaci mezi vyššími síťovými protokoly (např. IPv4, IPv6) a spodními vrstvami. Vkládá do rámce informace, které určují, jaký síťový protokol je použit, což umožňuje více protokolům sdílet stejné fyzické médium.
- `MAC (Media Access Control)` – zajišťuje zapouzdření dat do ethernetových rámců a řízení přístupu k přenosovému médiu. Poskytuje fyzickou adresaci (MAC adresa) a definuje pravidla pro vysílání a příjem dat v rámci sítě.

****

## 2. Ethernetový rámec

#### Struktura Ethernetového rámce (IEEE 802.3)

| Pole                         | Velikost        | Popis |
|------------------------------|------------------|-------|
| **Preambule**                | 7 bajtů          | Sekvence pro synchronizaci přenosu mezi vysílajícím a přijímajícím zařízením (bitový vzor `10101010` opakovaný 7×). |
| **Start Frame Delimiter (SFD)** | 1 bajt       | Signalizuje začátek rámce, pevný vzor `10101011`. |
| **Cílová MAC adresa**        | 6 bajtů          | Fyzická adresa zařízení, kterému je rámec určen. |
| **Zdrojová MAC adresa**      | 6 bajtů          | Fyzická adresa zařízení, které rámec odesílá. |
| **Typ / Délka (EtherType)**  | 2 bajty          | Určuje, jaký protokol je zapouzdřen (např. IPv4 – `0x0800`) nebo délku dat. |
| **Data / Zatížení**          | 46–1500 bajtů    | Přenášená uživatelská data. Minimálně 46 bajtů kvůli požadavku na minimální délku rámce. |
| **FCS (Frame Check Sequence)** | 4 bajty       | Kontrolní součet (CRC – Cyclic Redundancy Check), slouží k detekci chyb při přenosu. |

> **Poznámka:** Preambule a SFD jsou součástí fyzické vrstvy a obvykle nejsou zobrazovány analyzátory paketů (např. Wireshark).


Struktura Ethernet II rámce (DIX Ethernet)

#### Struktura Ethernet II rámce (DIX Ethernet)

| Pole                         | Velikost        | Popis |
|------------------------------|------------------|-------|
| **Preambule**                | 7 bajtů          | Synchronizační sekvence `10101010` opakovaná 7×. |
| **Start Frame Delimiter (SFD)** | 1 bajt       | Označuje začátek rámce (`10101011`). |
| **Cílová MAC adresa**        | 6 bajtů          | MAC adresa příjemce. |
| **Zdrojová MAC adresa**      | 6 bajtů          | MAC adresa odesílatele. |
| **EtherType**                | 2 bajty          | Označuje protokol vyšší vrstvy (např. IPv4 – `0x0800`, ARP – `0x0806`). |
| **Data / Zatížení**          | 46–1500 bajtů    | Přenášená data. Pokud jsou kratší než 46 bajtů, doplní se paddingem. |
| **FCS (Frame Check Sequence)** | 4 bajty       | CRC kód pro detekci přenosových chyb. |

> **Poznámka:** Ethernet II se od IEEE 802.3 liší tím, že pole po MAC adresách **není délka**, ale **EtherType**, tedy identifikátor protokolu vyšší vrstvy.


1. Minimální velikost rámce je 64 bajtů, maximální 1518 bajtů.
2. Rámce menší než 64 bajtů jsou považovány za neplatné (runt frames) a jsou zahazovány.
3. Rámce větší než 1518 bajtů (jumbo frames) jsou platné pouze u zařízení, která je podporují.

- Ethernet II je v současnosti nejrozšířenější rámec v IP sítích. Je jednodušší, používá pole EtherType, které přímo říká, jaký protokol následuje (např. IPv4 – 0x0800).
- IEEE 802.3 vyžaduje navíc použití LLC (Logical Link Control) a případně SNAP záhlaví k určení protokolu, protože místo EtherType používá délku dat.
- Z hlediska kompatibility moderní zařízení obvykle podporují oba typy rámců, ale Ethernet II je preferovaný v TCP/IP sítích.

****

## 3. Přístup k médiím

- Starší sítě používaly poloduplexní režim a metodu CSMA/CD (detekce kolizí).
- Moderní přepínané sítě využívají **plně duplexní** komunikaci – CSMA/CD již není potřeba.

****

## 4. MAC adresa

- MAC adresa je jedinečný identifikátor síťového zařízení (48 bitů = 6 bajtů).
- Zapisuje se pomocí 12 hexadecimálních číslic.
- Tvořena dvěma částmi:
  - OUI (Organizačně jedinečný identifikátor) – první 3 bajty
  - Unikátní číslo zařízení – poslední 3 bajty
- MAC adresa je většinou trvale zapsána v paměti ROM síťové karty (tzv. BIA – Burned-In Address).

****

## 5. Zpracování rámce

- Po spuštění zařízení se MAC adresa načte z ROM do RAM.
- Při přijetí rámce zařízení kontroluje, zda cílová MAC adresa odpovídá jeho vlastní:

  -  Pokud ano, rámec je zpracován.
  -  Pokud ne, rámec je ignorován.

- Zařízení také přijímá rámce s broadcastovou a multicastovou adresou.

****

## 6. Typy MAC adres

**Unicast**

- Komunikace mezi jedním odesílatelem a jedním příjemcem.
- Jedinečná MAC adresa cílového zařízení.

**Broadcast**

- Komunikace ze zdroje ke všem zařízením v síti.
- Cílová MAC adresa: FF-FF-FF-FF-FF-FF
- Přepínač pošle rámec na všechny porty kromě příchozího.

**Multicast**

- Komunikace ze zdroje ke skupině zařízení.
- Používá se například pro streamování, aktualizace softwaru, protokoly IGMP, PIM.
- Příklady multicastových MAC adres:
  -  IPv4: začíná 01-00-5E
  -  IPv6: začíná 33-33
****

> **Shrnutí**
> 1. Ethernet pracuje na 1. a 2. vrstvě OSI.
> 1. Linková vrstva obsahuje podvrstvy LLC a MAC.
> 1. Ethernetové rámce mají pevně danou strukturu.
> 1. Moderní Ethernet sítě používají přepínače a plný duplex.
> 1. MAC adresa jednoznačně identifikuje síťové zařízení.
> 1. Rozlišujeme tři typy komunikace dle MAC adres: unicast, broadcast, multicast.