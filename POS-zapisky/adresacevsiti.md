# Adresace v síti

Každé zařízení v síti (počítač, telefon, server) musí mít jedinečnou adresu, aby mohlo posílat a přijímat data.

V počítačových sítích existují dva hlavní typy adres:

1. IP adresa (logická, vrstva L3 – síťová vrstva) → Určuje, kam mají data dorazit (podobně jako adresa domu).

2. MAC adresa (fyzická, vrstva L2 – linková vrstva) → Určuje, kterému zařízení v síti mají být data doručena (podobně jako číslo bytu).

### Typy IP adres

**IPv4 vs IPv6**

- IPv4 používá 32bitové adresy (např. 192.168.1.1), což omezuje počet dostupných adres.

- IPv6 používá 128bitové adresy (např. 2001:db8::1), což umožňuje větší adresní prostor, lepší směrování a bezpečnost.

**Veřejné vs soukromé IP adresy**

- Veřejné IP adresy jsou unikátní v celém internetu.

S- oukromé IP adresy (192.168.x.x, 10.x.x.x, 172.16.x.x–172.31.x.x) jsou používány v lokálních sítích a nejsou přímo dostupné z internetu.

**Statické vs dynamické IP adresy**

- Statické IP adresy jsou přidělovány ručně a zůstávají stejné.

- Dynamické IP adresy jsou přidělovány DHCP serverem a mohou se měnit.

### Typy MAC adres

MAC adresa je 48bitový identifikátor, který je přiřazen síťové kartě. Existují tři hlavní typy MAC adres:

- Unicast – adresa konkrétního zařízení v síti (např. 00:1A:2B:3C:4D:5E).

- Multicast – adresa pro skupinu zařízení (např. 01:00:5E:xx:xx:xx pro IPv4 multicast).

- Broadcast – adresa pro všechna zařízení v síti (FF:FF:FF:FF:FF:FF).

### Jak fungují IP adresy (L3 – síťová vrstva)?

IP adresa se skládá ze dvou částí:

1. Síťová část – určuje, do které sítě zařízení patří.

2. Část hostitele – určuje konkrétní zařízení v této síti.

Například u IP adresy 192.168.1.10:

192.168.1 → síťová část.

.10 → konkrétní zařízení (host).

Zařízení ve stejné síti mají stejnou síťovou část, ale různé hostitelské části.

#### Jak probíhá přenos dat ve stejné a v různých sítích?

1. **Pokud jsou zařízení ve stejné síti**

Příklad: Počítač PC1 (192.168.1.110) posílá soubor na FTP server (192.168.1.9).

Obě zařízení jsou ve stejné IP síti → paket je odeslán přímo na MAC adresu.

MAC adresy v Ethernetu (L2):

MAC adresa PC1: AA-AA-AA-AA-AA-AA

MAC adresa FTP serveru: CC-CC-CC-CC-CC-CC

Počítač PC1 odešle data přímo na MAC adresu serveru.

✅ Závěr: Pokud jsou dvě zařízení ve stejné síti, komunikují přímo pomocí MAC adres.

2. **Pokud jsou zařízení v různých sítích**

Příklad: Počítač PC1 (192.168.1.110) posílá požadavek na webový server (172.16.1.99).

Nacházejí se v různých sítích → paket nemůže být odeslán přímo.

Co se stane?

PC1 zjistí, že server je v jiné síti.

Pošle paket na směrovač (R1).

Změní se MAC adresy:

Zdrojová MAC = MAC adresa PC1 (AA-AA-AA-AA-AA-AA).

Cílová MAC = MAC adresa směrovače (11-11-11-11-11-11).

Směrovač přijme paket, změní cílovou MAC adresu a odešle jej dál.

✅ Závěr: Pokud jsou zařízení v různých sítích, paket nejprve putuje na směrovač (default gateway), který jej přeposílá dál.

### Jak se mění MAC adresy při směrování?

Když paket prochází sítí, jeho IP adresa zůstává stejná, ale MAC adresy se mění na každém směrovači!

| Fáze       | Zdrojová MAC          | Cílová MAC            | Zdrojová IP | Cílová IP   |
|------------|----------------------|----------------------|-------------|-------------|
| PC1 → R1   | AA-AA-AA-AA-AA-AA    | 11-11-11-11-11-11    | 192.168.1.110 | 172.16.1.99 |
| R1 → R2    | 22-22-22-22-22-22    | 33-33-33-33-33-33    | 192.168.1.110 | 172.16.1.99 |
| R2 → Server| 44-44-44-44-44-44    | CC-CC-CC-CC-CC-CC    | 192.168.1.110 | 172.16.1.99 |


✅ Závěr: MAC adresa je důležitá jen v lokální síti (LAN), zatímco IP adresa zůstává stejná po celé trase.

`ARP (Address Resolution Protocol)`

`ARP` se používá pro zjištění MAC adresy podle IP v lokální síti.

Pokud zařízení nezná MAC adresu, vyšle `ARP` dotaz.

Zařízení s odpovídající IP adresou odpoví svou MAC adresou.

MAC adresa se uloží do ARP tabulky.

### Subnetting a maska sítě

Maska sítě definuje rozsah IP adres v síti (např. 255.255.255.0 znamená, že 192.168.1.0–192.168.1.255 je jedna síť).

CIDR notace (/24 místo 255.255.255.0) usnadňuje zápis.

`NAT (Network Address Translation)`

`NAT` umožňuje zařízení v lokální síti (s privátní IP) přístup na internet přes jedinou veřejnou IP.

Typy `NAT`:

`SNAT (Source NAT)`: překládá zdrojovou IP adresu.

`DNAT (Destination NAT)`: překládá cílovou IP adresu.

### Jak se IP adresy přidělují?

`DHCP (Dynamic Host Configuration Protocol)` – automatické přidělování IP adres.

`RARP (Reverse ARP)` – zjišťuje IP adresu podle MAC (zastaralé).

### Rozšíření o směrování

Statické směrování – ruční nastavení tras.

Dynamické směrování – automatické směrování (protokoly: RIP, OSPF, BGP).

Default gateway – výchozí brána pro odchozí provoz do jiných sítí.

