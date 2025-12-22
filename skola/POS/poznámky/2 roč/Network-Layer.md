# Síťová vrstva (Layer 3)

**Síťová vrstva neboli OSI vrstva L3, poskytuje služby, které umožňují koncovým
zařízením vyměňovat si data napříč sítěmi.**

![net layer](../../../img/l3.png)

## PDU na síťove vrstve

- Datagram - je konkrétní typ paketu používaný u nespojovaného přenosu. IPv4
pracuje s datagramy, a to je správný technický termín.
- Paket (packet) - je obecný výraz pro jednotku dat, která se přenáší po síti.
- "Paket“ může být:
  - datagram (v nespojované síti), paket (ve spojované síti),
  - frame (na linkové vrstvě),
  - segment (v TCP),nebo prostě „něco, co nese data“.
> V běžné praxi se slangově říká "paket" i tehdy, když jde technicky o datagram,
podobně jako říkáme „USBčko“, i když myslíme flash disk.

## Způsoby přenosu dat

1. Spojovaný přenos (connection-oriented)
- Před přenosem se vytvoří virtuální spojení.
- Všechny pakety jdou stejnou cestou.
- Výhody: kontrola pořadí, stabilita, méně chyb.
- Příklad: MPLS, TCP (vrstva 4).

2. Nespojovaný přenos (connectionless)
- Pakety jsou odesílány nezávisle, každý může jít jinudy.
- **Není zaručeno** doručení ani pořadí.
- Výhody: jednodušší, rychlejší, méně režie.
- Příklad: IP (IPv4/IPv6), UDP.

![prep_packetu](../../../img/propojovani-packetu.png)

### Možné způsoby fungování síťové vrstvy

1. Přepojování paketů (packet switching)
- Data jsou rozdělena na pakety (datagramy), které se posílají jednotlivě.
- Každý paket obsahuje:
  - **adresu odesílatele**
  - **adresu příjemce**
  - **číslo paketu**
  - případně další metadata
- Pakety mohou putovat různými cestami sítí (na rozdíl od spojového přenosu - okruhy).
- Na cílové straně se pakety znovu složí (nebo také nemusí – záleží na vyšší vrstvě).
- Možné kombinace přenosu:

![priklad](../../../img/example-prenosu.png)

## Hlavní úkoly síťové vrstvy

1. Směrování (routing)
- Určuje nejvhodnější cestu, kterou se data (datagramy) dostanou od zdroje k cíli přes různé sítě.
- Rozhodování probíhá na základě směrovacích tabulek, které obsahují známé sítě a cesty k nim.
- Router vybírá cestu podle směrovacích protokolů (např. RIP, OSPF, BGP).
- Směrování může být:
  - Statické – cesty nastaví administrátor ručně.
  - Dynamické – routery si cesty vyměňují automaticky pomocí protokolů.
- Cíl: najít nejrychlejší nebo nejefektivnější trasu.

2. Předávání (forwarding)
- Proces fyzického odeslání paketu na další síťové zařízení podle směrovací tabulky.
- Router:
  - Přečte cílovou IP adresu z hlavičky datagramu.
  - Vyhledá, kudy má paket poslat (další hop).
  - Pošle ho na odpovídající rozhraní.
- Forwarding se provádí na každém routeru po cestě.
> hop (skok) - Je to počet routerů, kterými paket musí projít, než dorazí do cíle.
- Cíl: zajistit, aby se každý paket posouval krok po kroku směrem ke svému cíli.

3. QoS (Quality of Service – kvalita služeb)
- Mechanismus, který určuje, jakou prioritu mají různé typy dat.
- Např. videohovor musí mít přednost před stahováním souboru, aby se nesekal.
- Používá se pole DS (Differentiated Services) v hlavičce IP.
- Router podle QoS:
  - Rozpozná typ provozu.
  - Přednostně zpracuje důležité pakety.
  - Omezuje méně důležité přenosy (např. zálohování).
- Cíl: zachovat plynulý přenos u citlivých dat (hlas, video).

4. Řízení zahlcení (congestion control)
- Řeší situace, kdy je síť přetížená (router nestíhá přenášet všechny pakety).
- Při zahlcení se mohou:
  - ztrácet pakety
  - zvyšovat zpoždění
  - vznikat fronty v routerech
- Protokoly nebo zařízení mohou omezit rychlost odesílání dat, aby se síť uvolnila.
- Používá se například u TCP nebo ve směrovacích algoritmech.
- Cíl: zabránit „ucpání“ sítě a kolapsu přenosu.

## Operace protokolů síťové vrstvy

1. Adresování
   - každé zařízení má unikátní IP.

2. Zapouzdření (encapsulation)
   - přidání hlavičky IP k datům z transportní vrstvy.

3. Směrování
   - výběr trasy přes routery (každý přeskok = hop).

4. Rozpouzdření (De-encapsulation)
   - odstranění hlavičky na cíli.

## Protokoly síťové vrstvy (TCP/IP model)

- **IPv4** 
  - 32bitové adresy
  - Skládá se ze 4 oktetů (např. `192.168.1.1`)
- **IPv6** 
  -  128bitové adresy
  - Zapsáno v šestnáctkové soustavě (např. `2001:0db8:85a3:0000:0000:8a2e:0370:7334`)
  - Nabízí lepší zabezpečení (IPsec v základu) a automatickou konfiguraci zařízení bez nutnosti DHCP serveru
- **ICMP(Internet Control Message Protocol)** 
  - Slouží k hlášení chyb a diagnostice (`ping`,`traceroute`)
    - Ping: Testuje dostupnost zařízení (odešle echo a čeká na odpověď)
    - Traceroute: Ukazuje cestu (seznam routerů), přes které paket putuje k cíli
- **IGMP (IPv4) / MLD (IPv6)** 
  -  multicast správa
  - Používá se například pro IPTV (digitální televize) nebo videokonference. Protokol zajistí, aby router posílal stream jen těm zařízením, která o něj projevila zájem
- **ARP(Address Resolution Protocol)**
  - Používá se v IPv4
  - Funguje formou dotazu: "Kdo má IP 192.168.1.5? Pošli mi svou MAC adresu!"
- **NDP(Neighbor Discovery Protocol)**
  - Nástupce ARP pro IPv6
  - Je mnohem efektivnější – nepoužívá plošné vysílání (broadcast), které zbytečně zatěžuje všechna zařízení v síti, ale komunikuje cíleněji (multicast)
- Vnitřní protokoly (IGP) – uvnitř jedné sítě (např. firmy)
  - **RIP**:
    - Nejstarší a nejjednodušší. Rozhoduje se pouze podle počtu "skoků" (routerů) v cestě. Pokud je cesta delší než 15 skoků, považuje ji za nedosažitelnou
  - **OSPF**:
    - Moderní a velmi rychlý. Buduje si kompletní mapu sítě a vybírá cestu podle rychlosti (propustnosti) linek
  - **EIGRP**:
    - Pokročilý protokol od Cisco kombinuje výhody různých přístupů a bere v úvahu i latenci nebo spolehlivost linky
- Vnější protokoly (EGP) – propojení internetu
  - **BGP (Border Gateway Protocol)**:
    - Nejdůležitější protokol internetu
    - Propojuje velké sítě poskytovatelů (ISP)
    - BGP neřeší rychlost jednotlivých kabelů, ale politiku a nejkratší cestu mezi celými státy a kontinenty

## Protokol IP – vlastnosti

- **Nespojovaný** – žádné předem vytvořené spojení.
- **Best Effort(Nejlepší snaha)** – bez záruky doručení (nespolehlivý).
- **Nezávislý na médiu** – funguje přes měď, optiku i Wi-Fi.
- **Bez kontroly chyb** – to dělá TCP.

## MTU (Maximum Transmission Unit)

- Největší rámec, který může být přenesen přes médium.
- Ethernet ≈ 1500 B.
- Pokud je paket větší než MTU, musí dojít k **fragmentaci**.


## PMTUD (Path MTU Discovery)

- Je to proces pomocí kterého odesílatel zjišťuje nejmenší MTU na celé cestě k cíli
- Používá flag DF (Don’t Fragment) = 1 a zprávy ICMP, aby našel ideální velikost paketu, která projde všemi routery bez fragmentace
- Router, který nemůže přeposlat paket, pošle chybu “Packet too big”.

> MTU je pevně daný limit velikosti paketu pro konkrétní rozhraní, zatímco PMTUD je proces hledání nejnižšího z těchto limitů na celé trase mezi odesílatelem a cílem


## Fragmentace (IPv4)

- Rozdělení velkého paketu na menší části
- Každý fragment má vlastní hlavičku (20 B)
- Používá 3 pole v IP datagramu, konkrétně:
  - **Identification (Identifikace)**;16b
    - Slouží jako "ID číslo" paketu
    - Pokud router paket rozdělí na 5 kousků (fragmentů), všechny tyto kousky budou mít stejné ID
    - Podle toho cílový počítač pozná, že tyto útržky patří k sobě a má je složit do jednoho původního obrazu
  - **Flags (Příznaky)**;3b
    - **DF (Don’t Fragment):**
      - Pokud je DF = 1, router nesmí paket rozdělit. Pokud se nevejde do MTU, router ho zahodí a pošle ICMP chybu
      - Pokud je DF = 0, router může paket v případě potřeby rozsekat
    - **MF (More Fragments):**
      - MF = 1 znamená: „Pozor, tohle není konec, za mnou jdou další kusy.“
      - MF = 0 znamená: „Tohle je poslední kus (nebo nebyl paket vůbec fragmentován).“
    - **Fragment Offset**;13b
      - Určuje "pořadí" nebo "pozici" útržku v původním paketu
      - Udává se v osmibitových blocích (tzv. offset units)
- IPv6 neumožňuje fragmentaci routery
- Zpomaluje přenos → proto se jí dnes vyhýbáme

## IPv4 datagram (header)

![ip-header](../../../img/dataram.png)

- **Verze** – obsahuje 4bitovou binární hodnotu nastavenou na 0100, která identifikuje tento paket jako paket IPv4
- **IHL** – délka hlavičky, dnes max. 20 byte (dříve to mohlo být jinak)
- **Differentiated Services (DS)** – je 8bitové pole používané k určení priority každého paketu, dnes známe spíše
jako QoS (Quality of Service)
- **Total Lenght** – délka datagramu v bytech
- **Identification** - pokud byl datagram při přepravě fragmentován, pozná se, které fragmenty patří k sobě (mají
stejný identifikátor)
- **Flag (příznaky)** – slouží pro řízení fragmentace, máme DF=1 (nesmí fragmentovat a MF=1 (fragment není
poslední)
- **Fragment offset** - udává, na jaké pozici v původním datagramu začíná tento fragment. Důležité k sestavení
paketu!
- **Time to Live (TTL)** – obsahuje 8bitovou binární hodnotu, která se používá k omezení životnosti paketu.
- **Protokol** – toto pole se používá k identifikaci protokolu další úrovně. Mezi běžné hodnoty patří ICMP (1), TCP (6)
a UDP (17).
- **Header Checksum (kontrolní součet záhlaví)** – slouží ke zjištění poškození v hlavičce protokolu IPv4
- **Zdrojová IPv4 adresa** – obsahuje 32bitovou binární hodnotu, která představuje zdrojovou IPv4 adresu paketu.
Zdrojová adresa IPv4 je vždy adresa unicastového vysílání.
- **Cílová IPv4 adresa** – obsahuje 32bitovou binární hodnotu, která představuje cílovou IPv4 adresu paketu

## TTL – Time To Live

- Počítadlo "skoků" v IP hlavičce
- Zabraňuje tomu, aby pakety v síti kroužily nekonečně dlouho (např. při chybě v cestě)
- Každý router, přes který paket projde, odečte 1 (TTL−1)
  - Když TTL = 0, router paket zahodí
  - Router pošle odesílateli zprávu ICMP Time Exceeded
- Použití: traceroute – zjištění cesty paketů přes síť.

> ## Omezení IPv4
> - Vyčerpání adres (pouze ≈ 4 miliardy).
> - Nedostatek end-to-end konektivity kvůli NAT.
> - Větší složitost sítí → NAT způsobuje zpoždění a komplikace.