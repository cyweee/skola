# EtherChannel

## LACP

### 1. `interface range FastEthernet 0/1 - 2`

### 2. `channel-group 1 mode active`
- Zapne LACP a aktivně vyjednává spojení se sousedním zařízením
- Na druhé straně spojení musí být nastaven režim active nebo passive

### 3. `interface port-channel 1`
- Přechod do konfigurace rozhraní Port-Channel

### 4. `switchport trunk encapsulation dot1q`
### **(Vyžadováno pouze u starších L3 switchů, např. 3560) Nastaví 802.1Q zapouzdření pro Trunk.**

### 5. NASLEDUJE DALSI NASTAVENI TRUNKU

---

## PAGP

### 1. `interface range FastEthernet 0/1 - 2`

### 2. `channel-group 1 mode desirable`
- Zapne PAgP a aktivně vyjednává spojení
- Na druhé straně spojení musí být nastaven režim desirable nebo auto

### 3. `interface port-channel 1`
- Přechod do konfigurace rozhraní Port-Channel

### 4. `switchport trunk encapsulation dot1q`
### **(Vyžadováno pouze u starších L3 switchů, např. 3560) Nastaví 802.1Q zapouzdření pro Trunk.**


---

## pro kontrolu

1. `show etherchannel summary`

- Zobrazí přehled všech EtherChannel rozhraní a jejich stav.
- Klíčové značky ve výstupu:
  - SU: Layer 2 / In-use (správně fungující L2 EtherChannel)
  - P: Bundled in port-channel (fyzický port je úspěšně zapojen)
  - D: Down (rozhraní je nefunkční)

2. `show ether port-channel`