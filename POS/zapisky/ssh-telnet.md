# SSH & Telnet

#### Slouží ke správě, konfiguraci a monitorování zařízení (např. routery, switche, servery) na dálku, bez fyzické přítomnosti.

**Mezi běžné metody patří:**
- SSH (Secure Shell)
- Telnet
- RDP, VNC
- HTTPS / Web rozhraní
- SNMP, VPN
---

## TELNET
- Zkratka:
  - **TEL**ecommunication **NET**work
- Vznik:
  - 1969
- Port:
  - 23
- Funkce:
  - připojení ke vzdálenému zařízení skrze textový terminál.
- Pracuje bez šifrování:
  - všechny údaje (včetně hesla) posílá jako prostý text.
- Použití:
  - Laboratorní konfigurace síťových zařízení
  - Přístup k Linux serverům
  - Testování otevřených portů
  - `telnet google.com 80`
- Výhody:
  - `+` Jednoduchá implementace
  - `+` Nízká režie
  - `+` Rychlé spojení
- Nevýhody:
  - `-` Nešifrovaný přenos → vysoké bezpečnostní riziko (snadné odposlechnutí)
  - `-` Dnes se nepoužívá v praxi, jen ve výuce
---

## SSH – Secure Shell
- Bezpečná alternativa Telnetu
- Vznik:
  - 1995
- Port:
  - 22
- Plně šifrovaná komunikace
- Využívá se k:
  - Vzdálenému přístupu k serverům (Linux, síťová zařízení)
  - Bezpečné správě systému
  - Přenosu souborů přes SCP nebo SFTP
- Výhody:
  - `+` Šifrování (ochrana před odposlechem)
  - `+` Možnost přihlášení pomocí hesla nebo SSH klíče
  - `+` Dnešní standard pro administrátory
---

## SSH klíče – princip

- Asymetrická kryptografie – dvojice klíčů:
  - Privátní klíč – zůstává bezpečně u klienta
  - Veřejný klíč – lze sdílet (posílá se na server)
- Generují se např. pomocí:
`ssh-keygen` (pro Linux a UNIX)
---
## Generování SSH klíčů ve Windows (s Putty)
1. Otevři `WIN + R` → napiš `puttygen`
2. Klikni na „Generate“, pohybuj myší
3. Ulož:
   - `.ppk` (privátní)
   - `.pub` (veřejný) → posílá se správci serveru
4. Veřejný klíč správce nainstaluje na server