# ISO/OSI

Model ISO/OSI je standard, který popisuje, jak různé komponenty síťových systémů vzájemně komunikují. Model je rozdělen do 7 vrstev, z nichž každá má své funkce a odpovídá za specifické aspekty přenosu dat v síti.

Model OSI má **7 vrstev**:

| Pořadí | Název vrstvy (česky)           | Název vrstvy (anglicky)        |
|--------|--------------------------------|--------------------------------|
| 7      | Aplikační vrstva               | Application Layer              |
| 6      | Prezentační vrstva             | Presentation Layer             |
| 5      | Relační vrstva                 | Session Layer                  |
| 4      | Transportní vrstva             | Transport Layer                |
| 3      | Síťová vrstva                  | Network Layer                  |
| 2      | Linková vrstva                 | Data Link Layer                |
| 1      | Fyzická vrstva                 | Physical Layer                 |


### Jak model ISO/OSI funguje?

Model OSI funguje jako síťová architektura, kde data procházejí všemi 7 úrovněmi, počínaje aplikační úrovní a přecházejí až na fyzickou úroveň, která zajišťuje přenos dat po fyzickém komunikačním kanálu (například přes kabel nebo Wi-Fi). Model pomáhá standardizovat procesy a zlepšit interakci mezi různými síťovými systémy.

### Protokoly na každé úrovni

- **Fyzická vrstva (Physical Layer):**  
    Tato úroveň se stará o přenos bitů po fyzickém komunikačním kanálu. Protokoly: Ethernet, DSL, USB, Wi-Fi, Bluetooth.
    
- **Linková vrstva (Data Link Layer):**  
    Zajišťuje spolehlivý přenos dat mezi zařízeními a zpracování chyb. Protokoly: Ethernet, PPP, MAC, Frame Relay, ARP.
    
- **Síťová vrstva (Network Layer):**  
    Určuje cesty pro přenos dat a směrování mezi různými sítěmi. Protokoly: IP (IPv4, IPv6), ICMP, OSPF, RIP.
    
- **Transportní vrstva (Transport Layer):**  
    Zajišťuje spolehlivý přenos dat mezi koncovými zařízeními, včetně řízení toku a opravy chyb. Protokoly: TCP, UDP.
    
- **Relační vrstva (Session Layer):**  
    Udržuje, spravuje a ukončuje komunikační sezení mezi aplikacemi. Protokoly: RPC, NetBIOS, SMB.
    
- **Prezentačni vrstva (Presentation Layer):**  
    Zajišťuje převod dat do formátu, který je pro příjemce srozumitelný (například šifrování, komprese). Protokoly: SSL/TLS, JPEG, GIF, ASCII, EBCDIC.
    
- **Aplikační vrstva (Application Layer):**  
    Poskytuje uživatelský přístup k síťovým službám a aplikacím. Protokoly: HTTP, FTP, SMTP, DNS, IMAP, POP3.

### Krátký popis funkce každé vrstvě:

1. **Fyzická vrstva:**  
    Na této úrovni dochází k přenosu "syrových" bitů přes fyzické připojení, jako jsou elektrické signály, světelné impulzy nebo rádiové vlny. Příklady: Ethernet kabel nebo Wi-Fi.
    
    **Přenáší** - Fyzikální signál
    
2. **Linková vrstva:**  
    Tato úroveň zajišťuje rámcování dat, jejich adresaci a zajištění spolehlivosti přenosu přes fyzický kanál. Používá MAC adresy pro identifikaci zařízení a přidává kontrolní součty pro ověření integrity.
    
    **Přenáší** - Linkový rámec
    
3. **Síťová vrstva:**  
    Úkolem této úrovně je směrování dat mezi různými sítěmi a podsítěmi. Přidává logické adresy (IP adresy) a zajišťuje určení cesty pro doručení paketů.
    
    **Přenáší** - IP Datagram
    
4. **Transportní vrstva:**  
    Zajišťuje spolehlivý přenos dat mezi dvěma koncovými uzly, řízení toku dat a opravu chyb. Příklad: TCP zaručuje správné doručení dat v pořádí, zatímco UDP je rychlejší, ale nespolehlivý.
    
	**Přenáší** -   TCP segment
	
5. **Relační vrstva:**  
    Tato úroveň se stará o navázání, udržování a ukončení komunikačního sezení mezi aplikacemi, což umožňuje dlouhodobou komunikaci mezi zařízeními.
    
6. **Prezentačni vrstva:**  
    Tato úroveň převádí data do formátu, který je přijatelný pro aplikaci na druhém konci. Může také zahrnovat kompresi nebo šifrování dat, například převádí text do formátu ASCII nebo UTF-8.
    
7. **Aplikační vrstva:**  
    Na této úrovni se nacházejí samotné aplikace, které poskytují koncovému uživateli přístup k síti. Příklady: webové prohlížeče, e-mailové klienty a další aplikace využívající protokoly jako HTTP nebo SMTP.
