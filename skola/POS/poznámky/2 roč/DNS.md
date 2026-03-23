# DNS (Domain Name Server)

## Co je to DNS a proč ho potřebujeme

- **DNS** slouží k překladu lidsky srozumitelných doménových jmen na číselné IP adresy
  - Funguje jako „telefonní seznam internetu“
- Výhody:
  - Uživatelé si nemusí pamatovat miliony složitých IP adres (např. 142.250.185.100)
  - Umožňuje rychlejší práci uživatelů i aplikací
  - Dovoluje změnit IP adresu serveru bez nutnosti měnit jeho jméno
- Pokud DNS nefunguje, weby se jeví jako neexistující, i když je síť fyzicky v pořádku


## Základní pojmy a hierarchie domén

**DNS je organizováno hierarchicky**

- Root (Kořen): Špička hierarchie, označovaná tečkou na konci
- TLD (Top-Level Domain): Domény nejvyšší úrovně (např. .cz, .com, .org, .edu)
- SLD (Second-Level Domain): Např. `example.com`
- Subdoména: Např. `www.example.com` nebo `mail.example.com`
- FQDN (Fully Qualified Domain Name): Plně kvalifikované jméno končící tečkou (např. `www.example.com.`)
---
- Zóna: Část jmenného prostoru spravovaná jedním správcem.
- Delegace: Předání odpovědnosti za podřízenou zónu pomocí NS záznamů

## Typy DNS serverů

- Autoritativní: Mají konečnou informaci („pravdu“) o své zóně, obsahují zdrojové záznamy.
- Rekurzivní (Resolver): Provádí dotazy jménem klienta a ukládá odpovědi do keše (cache).
- Kořenové a TLD servery: Zajišťují navigaci na samém vrcholu hierarchie.
  - Root servery: Existuje 13 logických (A-M), provozovaných v tisících instancí po světě pomocí anycastu.
  - TLD servery: Spravují konkrétní koncovky (např. CZ.NIC pro .cz)

## DNS dotaz

Klient zkontroluje svou DNS keš (prohlížeč/systém). Pokud záznam najde, proces končí.


1. Klient zkontroluje svou DNS keš (prohlížeč/systém). Pokud záznam najde, proces končí
2. Pokud není v keši, dotaz jde na rekurzivní resolver (např. u ISP)
3. Resolver se postupně ptá:
   - Kdo spravuje .com?
   - Kdo spravuje cisco.com?
   - Jaká je IP adresa pro `www.cisco.com`? 
4. Resolver si výsledek uloží na dobu určenou parametrem TTL a předá jej klientovi

## Parametr TTL (Time To Live)

- Udává dobu (v sekundách), po kterou může být odpověď uložena v keši
- Nízké TTL: Rychlejší propagace změn, ale vyšší zatížení serverů
- Vysoké TTL: Méně dotazů (rychlejší odezva pro opakované dotazy), ale pomalá aktualizace při změně IP

## Formát zprávy a typy záznamů

**Zpráva DNS má jednotný formát pro dotazy i odpovědi a skládá se z částí: Question, Answer, Authority, Additional**

Běžné typy záznamů:

- **A / AAAA**: Překlad jména na IPv4 / IPv6 adresu.
- **CNAME**: Alias (přezdívka) pro jiné jméno.
- **MX**: Určuje poštovní servery pro doménu a jejich priority.
- **NS**: Určuje autoritativní nameservery pro danou zónu.
- **TXT**: Libovolný text (využití pro SPF, DKIM, ověření služeb).
- **PTR**: Reverzní záznam (překlad IP na jméno).
- **SOA**: Informace o zóně (seriové číslo, správce, časovače).
- **SRV**: Specifikace služby a portu.

