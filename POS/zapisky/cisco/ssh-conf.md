# Příkazy pro Packet Tracer (Cisco) - Konfigurace SSH na switch

### 1. `enable`
- Přechod z uživatelského režimu (`>`) do privilegovaného režimu (`#`)

### 2. `configure terminal`
- Přechod do globálního konfiguračního režimu, kde začínáš nastavovat zařízení.

### 3. `hostname SW1`
- Nastaví název zařízení (např. SW1)
- Nutné pro generování RSA klíče!

### 4. `ip domain-name sosasou.cz`
- Nastaví doménové jméno (může být vymyšlené).
- Taky je nutné pro generování klíče.

### 5. `username admin secret cisco123`
- Vytvoří uživatele jménem `admin` a heslem `cisco123` (může být jine)
- `secret` znamená, že heslo bude uloženo zašifrovaně.

### 6. `crypto key generate rsa`
- Vygeneruje RSA klíč pro SSH.
- Až se zeptá na počet bitů:
  - `How many bits in the modulus?` → napiš 1024 a potvrď Enter.
  - 1024 je minimální doporučená délka pro:
    - Pro zajištění kompatibility s SSH verze 2,
    - pro správnou funkci mnoha klientů SSH,
    - základní zabezpečení.
- V reálném životě se pro servery obvykle používá 2048 nebo 4096 bitů, ale:
  - v programu Packet Tracer, nejčastěji je maximum 1024 bitů, již nemusí být v simulaci podporován.

### 7. `line vty 0 15`
- Otevře konfiguraci VTY linek (virtuální terminály – dálkový přístup).

### 8. `transport input ssh`
- Povolit jen SSH přístup.
> Telnet bude tímto zakázán.

### 9. `login local`
- Určuje, že se má použít lokální přihlašování pomocí uživatele (`admin`).

### 10. `ip ssh version 2`
- Zapne verzi 2 SSH, která je bezpečnější než stará verze 1.

### 11. `ip ssh time-out 60`
- (Volitelné) Nastaví časový limit na přihlášení (60 sekund).

### 12. `ip ssh authentication-retries 2`
- (Volitelné) Nastaví maximální počet pokusů o přihlášení (v tomto případě 2).

### 13. `end`
-  Ukončí konfigurační režim.

### 14. `write memory`
- Uloží konfiguraci do paměti zařízení (NVRAM), aby zůstala po restartu.