# Linux (Ubuntu)

## 1. Síťová konfigurace a diagnostika

Moderní Linux využívá balíček iproute2

- `ip addr`: Správa IP adres; show pro zobrazení, add pro přiřazení adresy rozhraní
- `ip link`: Aktivace (up) nebo deaktivace síťových karet a kontrola stavu linky
- `ip route`: Správa směrovací tabulky a nastavení výchozí brány (gateway)
- `ss`: Moderní náhrada za netstat; zobrazuje naslouchající porty a aktivní spojení (např. ss -tulpn)
- `mtr`: Kombinuje ping a traceroute pro diagnostiku ztráty paketů v síti

## 2. Správa systému a služeb (systemd)

- `systemctl`: Hlavní nástroj pro kontrolu služeb (status, restart, enable po startu)
- `journalctl`: Centrální logovací systém; umožňuje sledování logů v reálném čase (-f) nebo filtrování chyb (-p err)

## 3. Uživatelé, Balíčky a Bezpečnost

- `Oprávnění`: sudo pro spouštění příkazů s právy roota
- `Uživatelé`: useradd -m pro vytvoření uživatele a usermod -aG sudo pro přidání práv správce
- `APT`: Správa balíčků pomocí update (seznamy), upgrade (aktualizace SW) a install
- `UFW`: "Uncomplicated Firewall" pro snadnou správu portů (např. sudo ufw allow 22/tcp)

## 4. Monitorování výkonu

`top / htop`: Interaktivní přehled procesů, CPU a RAM.
`df -h`: Zaplnění disků v čitelném formátu
`free -m`: Aktuální využití operační paměti v MB
`uptime`: Doba běhu serveru a průměrná zátěž


# Windows Server

## 1. Síťová správa (CMD & PowerShell)

`ipconfig /all`: Kompletní konfigurace adaptérů
`Test-NetConnection`: (PowerShell) Pokročilý nástroj pro testování ping i konkrétních TCP portů (např. RDP 3389)
`netstat -ano`: Zobrazení aktivních spojení včetně ID procesu (PID)
`nslookup`: Diagnostika DNS záznamů

## 2. Active Directory a uživatelé

Lokální správa: Příkazy `net user /add` a `net localgroup` pro rychlou správu účtů
AD PowerShell: Modul pro hloubkovou správu (např. `Get-ADUser`, `Unlock-ADAccount`, `Set-ADAccountPassword`)

## 3. Souborový systém a údržba

- diskpart: Interaktivní správa diskových oddílů a formátování
- Oprava systému: `chkdsk` pro chyby disku a `sfc /scannow` pro integritu systémových souborů
- robocopy: Robustní nástroj pro zrcadlení adresářů (`/mir`) se zachováním oprávnění
- Group Policy: `gpupdate /force` pro okamžitou aktualizaci a `gpresult /r` pro report politik
- DISM: Oprava poškozeného obrazu systému nebo instalace rolí
- Vzdálená správa: `qwinsta` pro přehled RDP uživatelů a `Enter-PSSession` pro vzdálený PowerShell