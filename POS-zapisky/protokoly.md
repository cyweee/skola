# Komunikace v síti, síťové protokoly

## Síťové protokoly

Síťové protokoly jsou pravidla, která umožňují zařízením komunikovat mezi sebou. Každé zařízení v síti musí vědět, kde se nachází, jak odesílat data a jak zjistit, zda byla data úspěšně doručena. Tato pravidla zajišťují, že data budou doručena správně a bezpečně.
****

## Základy síťové komunikace

Aby si dva počítače mohly vyměňovat data, potřebují:

- Odesílatele (zdroj zprávy)
- Příjemce (cílové zařízení)
- Komunikační kanál (Wi-Fi, kabel, internet)

Příklad:
Pokud dva lidé mluví různými jazyky, nebudou si rozumět. Stejně tak počítače potřebují protokoly, aby si mohly vyměňovat informace.

➡ Protokoly určují pravidla pro komunikaci mezi počítači.
****
## Co musí obsahovat síťový protokol?

Protokol musí obsahovat několik důležitých částí:

1. Kódování dat – převod informací do formátu vhodného pro přenos.
2. Formátování a zapouzdření – přidání hlaviček s informacemi (adresy, typ zprávy).
3. Omezení velikosti zprávy – pokud je zpráva příliš velká, rozdělí se na menší části.
4. Načasování doručení – kontrola rychlosti přenosu a reakční doby.
5. Možnosti doručení – zpráva může být doručena jednomu nebo více zařízením.
****
## Kódování zpráv

Kódování je proces převodu dat do podoby, kterou mohou zařízení přenést.

Příklad:
- Představte si, že popisujete západ slunce kamarádovi. Použijete slova (kódování), kamarád je poslouchá a interpretuje (dekódování).

➡ V počítačích se používá dvojková soustava (0 a 1) pro kódování.
****
## Zapouzdření a formátování dat

Před odesláním se data zabalí do hlaviček, aby příjemce pochopil, o jaký typ zprávy se jedná.

Příklad:
- Posíláte dopis poštou:

1. Napíšete text (data).
1. Vložíte do obálky (zapouzdření).
1. Napíšete adresu odesílatele a příjemce (IP adresy).
1. Pošťák doručí dopis na správnou adresu.

➡ Na internetu se data rozdělí na pakety a odešlou se.
****
## Omezení velikosti zprávy

Pokud je zpráva příliš dlouhá, může se ztratit nebo zpomalit síť.

Řešení:
Data se rozdělí na menší části (pakety). Každý paket má pořadové číslo, což umožňuje je správně sestavit.

➡ Je to jako číslované stránky v knize, které usnadňují čtení a sestavení.
****
## Načasování doručení a odezvy

Pokud se neobjeví odpověď na vaši otázku, zopakujete ji nebo ukončíte konverzaci.

V síťové komunikaci to platí také:

- Flow Control (řízení toku) – omezuje rychlost přenosu, aby se zabránilo zahlcení sítě.
- Timeout (časový limit odezvy) – pokud odpověď nepřijde včas, zpráva se odešle znovu.
- Access Method (přístupová metoda) – určuje, kdo může v danou chvíli vysílat data.
*****
## Možnosti doručení zpráv

1. Unicast – zpráva se posílá jednomu příjemci.

    Příklad: Otevření webové stránky (server posílá data pouze vám).

2. Broadcast – zpráva se posílá všem zařízením v síti.

    Příklad: DHCP server přiřazuje IP adresy všem počítačům v síti.

3. Multicast – zpráva se posílá vybrané skupině zařízení.

    Příklad: Online streamování (IPTV).

4. Anycast – zpráva se posílá nejbližšímu dostupnému serveru.

    Příklad: DNS dotaz (připojíte se k nejbližšímu serveru).

➡ Výběr správného způsobu doručení závisí na typu komunikace.
****
## Nejdůležitější síťové protokoly
**Protokoly pro přenos souborů (Aplikační vrstva)**

- FTP (File Transfer Protocol) – pro přenos souborů mezi klientem a serverem. Používá TCP.
- SFTP (Secure File Transfer Protocol) – zabezpečená verze FTP, šifruje přenos přes SSH.
- TFTP (Trivial File Transfer Protocol) – zjednodušená verze FTP pro rychlý přenos v lokálních sítích.

**Protokoly pro e-mail (Aplikační vrstva)**

- SMTP (Simple Mail Transfer Protocol) – pro odesílání e-mailů.
- POP3 (Post Office Protocol v3) – pro stahování e-mailů (maže je po stažení ze serveru).
- IMAP (Internet Message Access Protocol) – pro synchronizaci e-mailů mezi zařízeními.

**Protokoly internetu a síťové služby (Síťová vrstva)**

- IPv4 – adresování a směrování paketů pomocí 32bitových IP adres.
- IPv6 – novější verze IPv4 s 128bitovými adresami.
- NAT (Network Address Translation) – překládá soukromé IP adresy na veřejné.

**Protokoly pro směrování (Síťová vrstva)**

- OSPF (Open Shortest Path First) – hledá nejkratší cestu mezi směrovači.
- BGP (Border Gateway Protocol) – používá se mezi ISP a velkými sítěmi k výběru nejlepší cesty.

**Protokoly pro zabezpečení (Aplikační vrstva)**

- SSH (Secure Shell) – šifrované připojení k serveru.
- SSL/TLS – šifruje webovou komunikaci (např. HTTPS).

**Síťová vrstva:**

- IPSec – šifruje a autentizuje IP komunikaci (používá se např. ve VPN).

**Protokoly transportní vrstvy**

- TCP (Transmission Control Protocol) – spolehlivý protokol pro doručení dat (web, e-mail).
- UDP (User Datagram Protocol) – nespolehlivý, rychlejší protokol (streamování videa, VoIP).

**Další důležité protokoly**

- ICMP (Internet Control Message Protocol) – odesílá chybové zprávy a provádí testy sítě (ping).
- ARP (Address Resolution Protocol) – překládá IP adresy na MAC adresy v lokálních sítích.
- HTTP/HTTPS – protokoly pro přenos webových stránek.

**Shrnutí**

1. Síťové protokoly – pravidla pro komunikaci mezi zařízeními.
1. Aplikační vrstva – HTTP, DNS, SMTP, FTP, SSH.
1. Transportní vrstva – TCP, UDP.
1. Síťová vrstva – IPv4, IPv6, OSPF, BGP, ICMP, ARP.
1. Zabezpečení – SSL, TLS, SSH.

➡ Síťové protokoly zajišťují spolehlivou a bezpečnou komunikaci v síti a na internetu.