# Základní konfigurace přepínače (switch)

## Co to vůbec je?
Switch je síťové zařízení, které propojuje počítače, tiskárny a další zařízení v jedné lokální síti (LAN). Funguje na 2. vrstvě modelu OSI a posílá data přímo konkrétnímu zařízení podle MAC adresy.

### K čemu slouží?
- Propojuje zařízení v jedné síti (např. v kanceláři, doma)
- Řídí síťový provoz, aby nebyl „chaos“
- Je chytřejší než hub – neposílá data všem, ale jen tomu, komu jsou určena

### Kde se používá?

- Firmy, kanceláře, datová centra
- Školy, univerzity
- Domácnosti s více zařízeními (např. chytrá domácnost)
- Všude tam, kde je potřeba rychlé a stabilní síťové spojení v rámci LAN

## Proč musí být nakonfigurován

Switch funguje i bez nastavení, ale základní konfigurace je důležitá:

- Nastavení IP adresy pro vzdálenou správu (Telnet/SSH)
- Zabezpečení přístupu pomocí hesel
- Nastavení VLAN (virtuálních sítí)
- Správa portů (zapnutí, vypnutí, ochrana)
- Nastavení uvítací zprávy při přihlášení (banner)

## Základní příkazy a jejich vysvětlení (Cisco PacketTracer)

### 1. `enable`
- Přechod z uživatelského režimu (`>`) do privilegovaného režimu (`#`)
> Bez toho nelze provádět žádné nastavení.

### 2. `configure terminal`
- Přechod do globálního konfiguračního režimu, kde začínáš nastavovat zařízení.

### 3. `no ip domain-lookup`
- Vypne pokus o hledání IP při překlepu v příkazu.
Jinak se switch může na několik sekund „zaseknout“, než pochopí, že to nebyl hostname.

### 4. `hostname <name>`
- Nastaví jméno zařízení, např. `hostname S1`
Pomáhá rozlišovat zařízení ve větší síti.

### 5. ` banner motd #...#`
- Zobrazí zprávu dne (**Message Of The Day**) při přihlášení
Např. varování před neoprávněným přístupem.
- můžete použít tyto značky, aby vaše sdělení vyniklo:
    - `#, $, %, @, !, *, /, +, =` atd
### 6. `enable secret <pass>`
- Nastaví **zašifrované heslo** pro přístup do `enable` režimu.
Lepší než `enable password`, protože je uloženo bezpečněji.

### 7. `line console 0`
- Nastavuje **konzolové připojení** – fyzicky přes kabel k zařízení.

### 8. `password <pass>`
- Nastaví heslo pro aktuální režim/rozhraní (např. konzole nebo VTY).

### 9. `login`
- Aktivuje ověření hesla – bez toho by zařízení pustilo uživatele i bez hesla.

### 10. `exit`
- Vrací o úroveň zpět (z rozhraní nebo konfigurace řádku).

### 11. `line vty 0 15`
- Nastavení virtuálních terminálových linek pro připojení přes Telnet/SSH.

### 12. `service password-encryption`
- Zašifruje všechna hesla zadaná pomocí `password`, aby nebyla čitelná v konfiguraci.

### 13. `interface vlan3`
- Přechod do konfigurace virtuálního rozhraní VLAN 3
(např. místo výchozí vlan 1)

### 14. `ip address <ip adresa> <maska>`
- Nastaví IP adresu pro rozhraní (např. VLAN), aby bylo možné spravovat switch přes síť.
```
ip address 192.168.1.2 255.255.255.0
```
- IP adresa musí být ve stejné síti jako počítače, jinak nebude spojení fungovat.

### 15. `no shutdown`
- Zapne rozhraní – bez toho zůstane vypnuté i s IP adresou.

### 16. `copy running-config startup-config`
- Uloží aktuální (běžící) konfiguraci do paměti (NVRAM)
  - `running-config` — aktuální konfigurace v RAM (běží právě teď)
  - `startup-config` — konfigurace, která se načte po restartu zařízení
-  Pokud po konfiguraci nevložíš tento příkaz, po restartu switche se vše ztratí a vrátí do továrního nastavení.

### 17. `show running-config`
- Zobrazí celou konfiguraci