# CAM tabulka a MAC adresy

## MAC ADRESA

1. MAC adresa = `Media Access Control` adresa.
1. Jedinečný identifikátor síťového rozhraní, používaný na 2 (DATALINK LAYER). vrstvě OSI.
1. Délka: 48 bitů (6 bajtů), formát např. 00:A1:B2:C3:D4:E5.
1. **První 3 bajty: identifikátor výrobce (OUI).**
1. **Poslední 3 bajty: jedinečné číslo zařízení.**

## Použití MAC adresy

- MAC adresy se používají v rámci místní sítě (LAN) k určení cílového zařízení.
- Switch pomocí MAC adres rozhoduje, na který port rámec přeposlat.
- Nezávisle na IP adrese nebo obsahu vyšších vrstev.
****

## CAM tabulka (MAC tabulka)

1. CAM = `Content Addressable Memory`
1. Používá se ve switchích na 2. vrstvě OSI modelu.
1. Obsahuje záznamy typu: MAC adresa → číslo portu, ke kterému je zařízení připojeno.
1. Slouží k efektivnímu směrování ethernetových rámců mezi zařízeními v síti.
1. Na rozdíl od HUBu neposílá rámec všem, ale jen cílovému zařízení (pokud zná jeho MAC adresu).

## Jak CAM tabulka funguje

1. Přijetí rámce

-  Switch přijme ethernetový rámec.
-  Z rámce přečte zdrojovou MAC adresu a číslo portu, ze kterého rámec přišel.

2. Zapsání do tabulky

-  Pokud zdrojová MAC adresa v tabulce není → uloží se spolu s číslem portu.
-  Pokud v tabulce již je, ale na jiném portu → aktualizuje záznam.

3. Vyhledání cílové MAC adresy

- Switch prohledá CAM tabulku.
- Pokud cíl existuje → rámec se odešle na odpovídající port.
- Pokud cíl neexistuje → provede se flooding (odeslání na všechny porty kromě příchozího).

4. Dynamická aktualizace

-  Záznamy mají časovou platnost (např. 5 minut).
-  Pokud dojde k nečinnosti, záznam se po vypršení této doby smaže.
-  Nové připojení nebo aktivita obnoví platnost záznamu.

## Směrování na základě MAC adres

- Switch rozhoduje pouze podle MAC adres (na rozdíl od routeru, který pracuje s IP).
- Pokud cílová MAC adresa je známá → rámec se pošle na konkrétní port.
- Pokud cílová MAC adresa není známá → provede se flooding.
- Po odpovědi cílového zařízení se jeho MAC adresa zapíše do tabulky.

## Filtrace rámců

- Switch podle MAC tabulky filtruje rámce a směruje je pouze na jeden port.
- Snižuje tím síťový provoz a zamezuje zbytečnému zatěžování ostatních zařízení.