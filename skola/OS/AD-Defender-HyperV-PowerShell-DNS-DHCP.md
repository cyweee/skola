# Kompletní výuková prezentace: AD, Defender, Hyper-V, PowerShell, DNS, DHCP

## Vysvětlení klíčových zkratek

- **AD: Active Directory** - Adresářová služba pro správu uživatelů a zdrojů
- **DNS: Domain Name System** - Systém pro překlad doménových jmen na IP adresy
- **DHCP: Dynamic Host Configuration Protocol** - Protokol pro automatické přidělování IP adres
- **GPO: Group Policy Object** - Objekt pro správu politik v AD
- **OU: Organizational Unit** - Organizační jednotka v AD
- **FSMO: Flexible Single Master Operations** - Role pro správu AD
- **VM: Virtual Machine** - Virtuální stroj
- **ACL: Access Control List** - Seznam oprávnění pro objekty
- **Kerberos**: Protokol pro autentizaci v síti

## Active Directory (AD)

### Principy a Architektura

- AD je adresářová služba pro správu uživatelů, počítačů a zdrojů
- Hierarchická struktura zahrnující Doménu, OU (Organizační jednotku)
- Autentizace probíhá pomocí protokolu Kerberos, autorizace přes ACL (seznam oprávnění)
- Replikace mezi řadiči domény (Domain Controllers) zajišťuje konzistenci dat
- Klíčové komponenty architektury:
  - Řadiče domény
  - Globální katalog
  - FSMO
  - DNS + DHCP
- PowerShell příkazy pro AD

| Funkce                     | Příkaz |
|----------------------------|--------|
| Zobrazit uživatele         | `Get-ADUser -Filter *` |
| Vytvořit nového uživatele  | `New-ADUser -Name 'Jan Novak' -AccountPassword (ConvertTo-SecureString 'Heslo123!' -AsPlainText -Force) -Enabled $true` |
| Nastavit nové heslo        | `Set-ADAccountPassword -Identity 'Jan Novak' -NewPassword (ConvertTo-SecureString 'NovéHeslo123!' -AsPlainText -Force)` |
| Odblokovat účet            | `Unlock-ADAccount -Identity 'Jan Novak'` |
| Mini-lab – Vytvoření uživatele | `New-ADUser -Name 'TestUser' -AccountPassword (ConvertTo-SecureString 'Heslo123!' -AsPlainText -Force) -Enabled $true` |

---

## Microsoft Defender

### Funkce a Konfigurace

- Ochrana proti malwaru, ransomware a síťovým útokům
- S Windows Security Center a s Microsoft 365 Defender
- Možnost centrální správy přes Microsoft Endpoint Manager
- Zapnutí Real-Time Protection , nastavení politik přes Group Policy , automatické aktualizace definic
- PowerShell příkazy a Best Practices
  - PowerShell:
    - Získání stavu počítače (`Get-MpComputerStatus`) , spuštění plného skenu (`Start-MpScan -ScanType FullScan`) , povolení Real-Time Monitoring (`Set-MpPreference -DisableRealtimeMonitoring $false`)

---

## Hyper-V

### Architektura a Správa VM

- Hypervisor typu 1 pro virtualizaci na Windows Server
- Podpora pro Generation 1 a Generation 2 VM
- Možnosti síťování: Internal, External, Private
- Podpora pro dynamickou paměť a snapshoty
- PowerShell a Best Practices
  - PowerShell
    - Vytvoření nového VM (`New-VM -Name 'TestVM' -MemoryStartupBytes 2GB -Generation 2 -SwitchName 'Default Switch'`)

---

## PowerShell

- Je nástroj pro automatizaci správy systému. Používá objektový model a cmdlety (speciální příkazy) a umožňuje zpracování dat pomocí Pipeline
- Obsahuje moduly pro správu AD, DNS, DHCP a Hyper-V
- PowerShell se používá k efektivní, skriptované a vzdálené správě systémů Windows.

---

## DNS a DHCP

### DNS (Domain Name System)

- Překlad doménových jmen na IP adresy
- Typy záznamů:
  - A (IPv4),
  - AAAA (IPv6),
  - CNAME,
  - MX
- Primární a sekundární zóny, Integrace s Active Directory (AD-integrated zones)

### DHCP (Dynamic Host Configuration Protocol)

- Automatické přidělování IP adres klientům
- Komponenty: 
  - Scope 
  - rezervace
  - možnosti
- Integrace s Active Directory a Failover