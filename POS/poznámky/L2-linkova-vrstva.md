# Linkova vrstva (Network layer)
****
### Linková vrstva v modelu OSI

- Je to druhá vrstva modelu OSI, která zajišťuje přenos dat mezi zařízeními v jedné síti.
- V modelu TCP/IP patří linková vrstva do Network Access Layer (Vrstva síťového přístupu).
- Hlavní úkol: zapouzdření dat do rámců (frames) a řízení přístupu k síti.

****

### Funkce linkové vrstvy

Linková vrstva plní několik klíčových funkcí:

1. Přenos dat mezi zařízeními v rámci jedné sítě (např. LAN).
1. Řízení přístupu k přenosovému médiu (MAC – Media Access Control).
1. Zapouzdření paketů síťové vrstvy (L3, IPv4, IPv6) do rámců (L2).
1. Určení logické a fyzické topologie sítě (jak jsou zařízení propojena).
1. Detekce a oprava chyb (např. kontrolní součet CRC).
1. Adresování na úrovni datového spoje (MAC adresy).

> Poznámka: Bez linkové vrstvy by musel protokol IP pracovat přímo s různými typy fyzických médií, což by síťovou komunikaci značně komplikovalo.

****

### Podvrstvy linkové vrstvy (IEEE 802)

IEEE definuje dvě podvrstvy linkové vrstvy:

1. LLC (Logical Link Control – Řízení logického spoje)
- Komunikuje mezi síťovými protokoly (L3) a linkovou vrstvou.
- Umožňuje, aby více protokolů (IPv4, IPv6) používalo stejné síťové médium.

2. MAC (Media Access Control – Řízení přístupu k médiu)
- Spravuje přenos dat v síťovém médiu (Ethernet, Wi-Fi atd.).
- Definuje metody přístupu k síti (CSMA/CD, CSMA/CA).
- Používá MAC adresy pro identifikaci zařízení v síti.
****

### Topologie sítí

Logická a fyzická topologie určují, jak jsou zařízení v síti propojena.

1. Topologie WAN

Používané v globálních sítích:

- Point-to-Point (P2P) – přímé spojení dvou uzlů, spolehlivé a bezpečné.
- Hub-and-Spoke – jedno centrální zařízení (hub) propojuje ostatní uzly.
- Mesh – všechna zařízení jsou propojena přímo (vysoká spolehlivost).
- Hybridní topologie – kombinace několika typů.

2. Topologie LAN

Používané v lokálních sítích:

1. Sběrnicová (Bus) – všechna zařízení jsou připojena na jednu přenosovou linku.
- Výhody: jednoduchost, nízká cena.
- Nevýhody: vysoká pravděpodobnost kolizí, selhání jednoho uzlu ovlivňuje celou síť.

2. Hvězdicová (Star) – všechna zařízení jsou připojena k centrálnímu přepínači (switch).
- Výhody: snadná správa, vysoký výkon.
- Nevýhody: porucha centrálního uzlu způsobí výpadek celé sítě.

3. Kruhová (Ring) – zařízení jsou propojena do kruhu, data se přenášejí dokola.
- Výhody: žádné kolize.
- Nevýhody: pokud selže jedno zařízení, síť přestane fungovat.

4. Stromová (Tree) – hierarchická struktura s více úrovněmi propojení.
- Používá se ve velkých organizacích.
****
### Duplexní a poloduplexní komunikace

- Poloduplexní (Half-Duplex) – data lze přenášet pouze jedním směrem v daném okamžiku.
    - Používá se ve starších sítích a Wi-Fi (CSMA/CA).

- Plně duplexní (Full-Duplex) – data mohou být odesílána i přijímána současně.
  - Moderní přepínače (switch) pracují v plném duplexu.
****
### Metody řízení přístupu k síti

V sítích s více zařízeními (např. Ethernet, Wi-Fi) je nutné koordinovat přenos dat.

1. CSMA/CD (Collision Detection) – detekce kolizí

- Používá se v kabelových sítích Ethernet (starší verze).
- Zařízení před odesláním dat „naslouchá“, zda je médium volné.
- Pokud dojde ke kolizi (dvě zařízení vysílají zároveň), data se odešlou znovu.

2. CSMA/CA (Collision Avoidance) – předcházení kolizím

- Používá se v bezdrátových sítích Wi-Fi (802.11).
- Zařízení čeká náhodně dlouhou dobu, aby snížilo pravděpodobnost kolize.
****
### Formát rámce (Frame)

Rámce jsou struktura dat, kterou linková vrstva používá k přenosu informací.

1. Struktura rámce

Každý rámec obsahuje:

- Hlavičku (Header) – obsahuje MAC adresy odesílatele a příjemce.
- Data (Payload) – přenášená informace.
- Závěr (Trailer) – kontrolní součet (CRC) pro detekci chyb.

2. Adresování

- Linková vrstva používá MAC adresy (48bitové), které jsou unikátní pro každé zařízení.
****

### Protokoly linkové vrstvy

Různé sítě používají různé protokoly linkové vrstvy:
1. Lokální sítě (LAN)

-  `Ethernet (IEEE 802.3)` – standard kabelových sítí.
-  `Wi-Fi (IEEE 802.11)` – standard bezdrátových sítí.

2. Globální sítě (WAN)

- `PPP (Point-to-Point Protocol)` – pro spojení mezi dvěma uzly.
- `HDLC (High-Level Data Link Control)` – starší, ale spolehlivý.
- `Frame Relay, ATM, X.25` – používané ve starých WAN sítích.
****
## Shrnutí

Linková vrstva usnadňuje přenos dat tím, že zajišťuje:

- Tvorbu a zpracování rámců.
- Řízení přístupu k přenosovému médiu.
- Opravu chyb při přenosu dat.
- Adresování a síťovou topologii.

> Moderní sítě (Ethernet, Wi-Fi) využívají plně duplexní režim a pracují bez kolizí díky přepínačům.