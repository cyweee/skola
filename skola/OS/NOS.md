# Network Operating System

## 1. Definice a role NOS

- **Definice**: Software umožňující komunikaci mezi více počítači a sdílení prostředků (soubory, tiskárny, aplikace) přes síť
- **Hlavní úloha**: Správa síťových služeb, uživatelů, zabezpečení a přístupu k prostředkům
- **Rozdíl oproti běžnému OS**: Zatímco běžný OS spravuje jeden lokální stroj, NOS se zaměřuje na správu celé sítě a jejích komponent

## 2. Klíčové funkce a architektura

- **Správa uživatelů**: Autentizace (ověření identity), autorizace (přidělení oprávnění) a správa skupin
- **Sdílení a komunikace**: Podpora protokolů (TCP/IP, SMB, NFS) pro sdílení disků a tiskáren
- **Síťové služby**: Zajištění chodu DNS, DHCP či e-mailových serverů
- **Architektura**: Skládá se z jádra OS (procesy, paměť), síťové vrstvy (protokoly), aplikační vrstvy (služby) a modulu správy uživatelů

## 3. Typy sítí a příklady systémů

- **Peer-to-Peer (P2P)**: Každý počítač je klientem i serverem zároveň
  - Vhodné pro malé sítě do 10 stanic (např. běžné Windows 10 se sdílením)

- **Klient-Server**: Centralizovaný model, kde dedikované servery poskytují služby klientům
  - Vhodné pro velké podniky (např. Windows Server, Ubuntu Server, Red Hat)

### Příklady konkrétních NOS:

- **Windows Server**: Využívá nástroje jako Active Directory a Group Policy
- **Linux**: Populární distribuce (Ubuntu Server, CentOS) využívající nástroje Apache nebo Samba
- **Historické/Ostatní**: Novell NetWare (průkopník) nebo stabilní Unixové systémy

## 4. Zabezpečení, Výhody a Trendy
- **Zabezpečení**: Zahrnuje autentizaci (hesla, biometrie), šifrování (SSL/TLS, VPN) a ochranu pomocí firewallů/IDS/IPS.
Bilance NOS:
    - **Výhody**: Centralizovaná správa, vyšší bezpečnost a snadné sdílení.
    - **Nevýhody**: Vyšší cena za HW/SW, potřeba experta na správu a závislost na funkčnosti serveru.
- **Budoucnost**: Přechod ke cloudu (Azure, AWS), virtualizaci (VMware, Hyper-V) a moderní kontejnerizaci (Docker, Kubernetes)