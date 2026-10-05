# Konfigurace VLAN

### 1. `vlan {ID}`
- Vytvoří VLAN s daným ID nebo přejde do konfigurace existující VLAN
> ID v normálním rozsahu je od 1 do 1005 (použitelné běžně), rozšířený rozsah je od 1006 do 4094

### 2. `name {jméno}`
- Zadá nebo změní název VLAN (např. name studenti), který danou síť jednoznačně identifikuje

### 3. `interface {rozhraní}`
- Vstup do konfigurace konkrétního portu, např. interface fa0/1 pro FastEthernet nebo g0/1 pro GigabitEthernet

### 4. `switchport mode access`
- Nastaví port napevno do režimu access (přístupový port)
> Port v tomto režimu patří pouze do jedné datové VLAN, nepřenáší tagované rámce a typicky se k němu připojují koncová zařízení jako PC

### 5. `switchport access vlan {ID}`
- Přiřadí konkrétní port do vytvořené datové VLAN, např. `switchport access vlan 10`

### 6. `switchport voice vlan {ID}`
- Přiřadí na jeden access port druhou VLAN vyhrazenou speciálně pro hlasový provoz (typicky pro IP telefony)

### 7. `mls qos trust cos`
- Přikáže switchi, aby důvěřoval prioritě provozu (CoS – Class of Service), kterou odesílá a značí připojený IP telefon

### 8. `switchport mode trunk`
- Nastaví port do režimu trunk
- Trunk port slouží pro propojení switchů navzájem a umí přenášet provoz pro více VLAN současně po jednom fyzickém spoji

### 9. `switchport trunk native vlan {ID}`
- Určí, která VLAN bude fungovat jako tzv. native VLAN
> Nativní VLAN se přes trunk přenáší neoznačená (bez tagu)

### 10. `switchport trunk allowed vlan {seznam}`
- Omezí trunk tak, aby přenášel pouze specificky vyjmenované VLAN, např. `switchport trunk allowed vlan 10,20,30,99`

### 11. `switchport trunk encapsulation dot1q`
- Určí standard pro tagování (zapouzdření) rámců na trunku na 802.1Q
> U některých L3 switchů Cisco je tento příkaz nezbytný a musí se zadat dříve, než switch dovolí zadat příkaz `switchport mode trunk`

### 12. `no switchport access vlan`
- Vymaže přiřazení portu do dřívější VLAN a automaticky jej vrátí do výchozí VLAN 1

### 13. `no vlan {ID}`
- Smaže konkrétní VLAN z databáze switche
> Než VLAN smažete, je nutné její porty ručně přeřadit do jiné aktivní VLAN. Jinak ztratí schopnost komunikovat, dokud je nepřeřadíte

### 14. `no switchport trunk allowed vlan`
- Resetuje (vymaže) seznam povolených VLAN na trunkovém portu zpět do výchozího nastavení, čímž znovu povolí přenos všech VLAN

### 15. `no switchport trunk native vlan`
- Obnoví nastavení nativní VLAN na trunku zpět na výchozí hodnotu (což je standardně VLAN 1)

### 16. `show vlan brief`
- Zobrazí přehled vytvořených VLAN na switchi, jejich status (active) a porty, které do nich patří

### 17. `show interfaces trunk`
- Vypíše přehled všech trunk portů na zařízení, stav zapouzdření, nastavené nativní VLAN a seznamy VLAN povolených a aktivních na trunku

### 18. `show running-config | section interface {rozhraní}`
- Zobrazí konkrétní část běžící konfigurace – např. `show running-config | section interface Fa0/1` vypíše pouze ty řádky, které se týkají nastavení portu Fa0/1

### 19. `delete flash:vlan.dat` (nebo `delete vlan.dat`)
- Zcela smaže soubor s databází VLAN z paměti flash
> Provádí se v privilegovaném režimu EXEC a používá se pro resetování tabulky VLAN

### 20. `erase startup-config`
- Smaže startovací konfiguraci
> Tento příkaz se (spolu s `delete vlan.dat`) využívá k obnovení switche do továrního nastavení

---

# InterVLAN

## Router-on-a-Stick (ROAS)

### 1. `interface {rozhraní}`

- Vstup do konfigurace fyzického rozhraní routeru, např. `interface g0/0/1`
> Fyzické rozhraní slouží jako hlavní linka pro trunk, na které se vytvářejí logická podrozhraní

### 2. `no shutdown`
- Zapne (aktivuje) fyzické rozhraní routeru nebo virtuální SVI rozhraní na switchi

### 3. `interface {rozhraní}.{ID_podrozhraní}`
- Vytvoří a přejde do konfigurace logického podrozhraní (subinterface), např. `interface g0/0/1.10`
> Každá VLAN vyžaduje vlastní podrozhraní na fyzickém portu routeru

### 4. `encapsulation dot1Q {VLAN_ID}`
- Nastaví standard zapouzdření 802.1Q a přiřadí podrozhraní k určené VLAN
> Router díky tomu dokáže zpracovávat tagované rámce z trunku a odstraňovat z nich tagy při směrování paketů

### 5. `ip address {IP_adresa} {maska}`
- Nastaví IP adresu a masku podsítě na rozhraní či podrozhraní

## L3 Switch / SVI

### 6. `ip routing`
- Zapne funkce směrování (routování) přímo na L3 switchi
> Po zapnutí umožňuje switchi směrovat provoz přímo mezi rozhraními SVI (mezi různými VLAN) a využívat routovací protokoly

### 7. `interface vlan {VLAN_ID}`
- Vytvoří a vstoupí do konfigurace virtuálního rozhraní switche (SVI)

### 8. `ip address {IP_adresa} {maska}`
- Nastaví IP adresu a masku podsítě na rozhraní

### 9. `no switchport`
- Přepne fyzický port switche z přepínaného (L2) do směrovaného (L3) režimu (tzv. routed port)