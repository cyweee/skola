# DHCPv4

### 1. `ip dhcp excluded-address [low] [high]` 
- vyloučí konkrétní adresy nebo rozsah z automatického přidělování (např. pro brány a servery)
### 2. `ip dhcp pool [name_of_the_pool]`
- vytvoří pool adres a vstoupí do konfiguračního režimu DHCP
### 3. `network [network-address] [mask]`
- definuje síť a masku adres, které se budou klientům přidělovat
### 4. `default-route [default_gateway address]`
- Adresa default gateway
### 5. `dns-server [address]`
- určí adresy DNS serverů pro překlad doménového jména na IP adresu
### 6. `domain-name [domain]`
- nastaví název domény pro klienty v daném poolu
### 7. `lease [days hours minutes]`
- nastaví dobu pronájmu IP adresy
> **!!! V packet traceru příkaz lease NEFUNGUJE !!!**
### 8. `ip helper-address [address]`
- aktivuje DHCP Relay; příkaz se **píše na rozhraní směrem ke klientům** a směřuje na IP adresu DHCP serveru (pro IPv4)
### 9. `show ip dhcp binding`
- zobrazí tabulku s aktuálně přidělenými adresami a MAC adresami klientů
> nepovinný příkaz

---

# IPv6

### 1. `ipv6 unicast-routing`
- **globální příkaz, který povolí směrování IPv6 a odesílání zpráv Router Advertisement (RA), nezbytné pro SLAAC a DHCPv6**


## SLAAC (Metoda 1)

### 1. `interface G0/0/0`
- vstup do rozhraní LAN (_toto rozhraní "interface G0/0/0" je uvedeno pouze jako příklad, tedy může být i jiné_)

### 2. `ipv6 address [GUA IPv6 address/prefix]`
- nastavení prefixu, který bude router inzerovat

### 3. `no shutdown`
- aktivace rozhraní

> Flagy: A=1, M=0, O=0


## SLAAC + Stateless DHCPv6 (Metoda 2)

### 1. `ipv6 dhcp pool [name_of_the_pool]`
- Vytvoření poolu pro doplňující info

### 2. `dns-server [DNS_address]`
- Adresa DNS serveru

### 3. `domain-name something.com`
- Název domény

### 4. `interface G0/0/0`
- vstup do rozhraní LAN

### 5. `ipv6 address [GUA IPv6 address/prefix]`
- Prefix pro **SLAAC**

### 6. `ipv6 nd other-config-flag`
- Klíčový příkaz: Nastaví O-flag=1, což klientovi řekne, aby hledal DNS v DHCP

### 7. `ipv6 dhcp pool [name_of_the_pool]`
- Propojení rozhraní s vytvořeným poolem

> Flagy: A=1, M=0, O=1

## Klient pro SLAAC (Metoda 1 a 2)

### 1. `interface G0/0/0`
- Vstoupíš na rozhraní, které je propojené s hlavním routerem

### 2. `ipv6 address autoconfig`
- Router si vezme prefix od serveru a zbytek adresy (Interface ID) si dopočítá sám (metodou EUI-64 nebo náhodně)

## Stateful DHCPv6 (Metoda 3)

### 1. `ipv6 dhcp pool [name_of_the_pool]`
- Vytvoření poolu pro adresy

### 2. `address prefix [GUA IPv6 address/prefix]`
- Rozsah adres k přidělování

### 3. `dns-server [DNS_address]`
- Adresa DNS serveru

### 4. `interface G0/0/0`
- vstup do rozhraní LAN

### 5. `ipv6 address [GUA IPv6 address/prefix]`
- Adresa brány

### 6. `ipv6 nd managed-config-flag`
- klíčový příkaz: nastaví M-flag=1, vše jde přes DHCP

### 8. `ipv6 dhcp server [name_of_the_pool]`
- Propojení s poolem

> Flagy: A=0, M=1, O=0

## Klient pro Stateful DHCPv6 (Metoda 3)

### 1. `interface G0/0/0`

### 2. `ipv6 address dhcp`
- Router se chová jako klasický DHCP klient a čeká, až mu server přidělí konkrétní adresu z poolu

