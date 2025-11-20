# TCP/IP

### TCP/IP (Transmission Control Protocol / Internet Protocol) 

- je síťový model a sada protokolů, které zajišťují přenos dat na internetu a v lokálních sítích.


### Vrstvový model TCP/IP 
 skládá ze 4 vrstev:

- Aplikační vrstva (Application Layer) — interakce s uživatelem a aplikacemi (HTTP, FTP, SMTP, DNS atd.).

- Transportní vrstva (Transport Layer) — správa přenosu dat mezi zařízeními (TCP, UDP).

- Síťová vrstva (Internet Layer) — směrování a adresování paketů (IP, ICMP, ARP).

- Linková vrstva (Link Layer) — fyzický přenos dat (Ethernet, Wi-Fi, PPP).

| Vrstva | Funkce | Příklady protokolů |
|--------|--------|------------------|
| Aplikační | Interakce s uživatelem a aplikacemi | HTTP, FTP, SMTP, DNS |
| Transportní | Přenos dat mezi zařízeními | TCP, UDP |
| Síťová | Směrování a adresování paketů | IP, ICMP, ARP |
| Síťové rozhraní | Fyzický přenos dat | Ethernet, Wi-Fi, PPP |

### Hlavní protokoly TCP/IP

1. IP (Internet Protocol) — zajišťuje směrování a doručování paketů.

2. TCP (Transmission Control Protocol) — zajišťuje spolehlivý přenos dat s navázáním spojení.

3. UDP (User Datagram Protocol) — lehký protokol pro přenos dat bez navázání spojení.

4. ICMP (Internet Control Message Protocol) — servisní protokol pro diagnostiku síťových připojení (ping, traceroute).

5. ARP (Address Resolution Protocol) — mapuje IP adresy na MAC adresy v lokální síti.

### Principy fungování TCP/IP

- Směrování — proces výběru cesty přenosu paketů mezi uzly sítě.

- Číslování portů — umožňuje aplikacím rozlišovat datové toky (například 80 — HTTP, 443 — HTTPS). 

- Dělení dat na pakety — velké zprávy se rozdělí na menší pakety a přenášejí se nezávisle na sobě.

- Kontrola chyb a potvrzení doručení — používá se v TCP, ale chybí v UDP.

### Rozdíly mezi TCP a UDP

| Charakteristika | TCP | UDP |
|---------------|-----|-----|
| Spolehlivost | Vysoká, s kontrolou chyb a potvrzením | Nízká, bez potvrzení |
| Rychlost | Pomalejší kvůli kontrolám | Rychlejší, ale mohou nastat ztráty |
| Použití | Webové stránky, e-maily, sdílení souborů | Online hry, VoIP, streamování |

### IP adresace a podsítě

- IPv4 — 32bitová adresa (příklad: 192.168.1.1), používá se ve většině sítí.

- IPv6 — 128bitová adresa (příklad: 2001:db8::ff00:42:8329), vytvořená pro rozšíření adresního prostoru.

- Podsítě — umožňují rozdělení sítí a snižují počet broadcastových zpráv.

### DHCP a DNS

- DHCP (Dynamic Host Configuration Protocol) — automaticky přiděluje IP adresy zařízením v síti.

- DNS (Domain Name System) — převádí doménová jména (například google.com) na IP adresy.

### Bezpečnost v TCP/IP

- Použití VPN, SSH, TLS/SSL pro ochranu přenášených dat.

- Firewally a NAT pro kontrolu přístupu.

- Šifrování dat a autentizace uživatelů.

## Závěr:

- TCP/IP je základem internetu a většiny moderních sítí. Díky své flexibilitě, škálovatelnosti a spolehlivosti zůstává standardem pro přenos dat.

