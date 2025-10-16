# Architektury OS

**Architektura operačního systému = jak je uspořádáno jádro + jak komunikuje s programy a zařízeními**

## Monolitická struktura

- Monolitická struktura je architektura operačního systému, ve které všechny základní části jádra pracují jako jeden celek
- U OS s monolitickým jádrem jsou všechny hlavní části součástí jednoho velkého bloku:
  - správa procesů (process management)
  - správa paměti (memory management)
  - souborový systém (file system)
  - ovladače zařízení (device drivers)
  - síťové protokoly (network stack)
- Tyto moduly spolu komunikují přímo, bez oddělení nebo mezivrstev.
- Výhody:
  - Vysoký výkon
  - Rychlá komunikace mezi částmi jádra.
  - Jednodušší správa prostředků
- Nevýhody:
  - Nižší spolehlivost
  - Obtížná údržba
  - Těžší rozšiřitelnost
- Příklad:
  - Typické monolitické systémy jsou Linux, MS-DOS, rané verze Unixu.   

---

## Mikrojádrová architektura

- Mikrojádro (microkernel) je typ architektury operačního systému, ve které jádro obsahuje pouze nejzákladnější funkce, zatímco ostatní části systému běží v uživatelském prostoru jako samostatné procesy (služby).
- Cílem mikrojádra je minimalizovat jádro a přesunout většinu funkcí mimo něj.
- Jádro tak zajišťuje pouze:
  - správu procesů (process management)
  - správu paměti (memory management)
  - komunikaci mezi procesy (interprocess communication – IPC)
- Naopak věci jako souborový systém, síťové protokoly nebo ovladače zařízení nejsou součástí jádra – běží jako samostatné služby v uživatelském prostoru.
- Výhody:
  - Vysoká spolehlivost
  - Lepší bezpečnost
  - Lepší ladění (debugging)
- Nevýhody:
  - Nižší výkon
  - Složitější návrh
  - Vyšší režie (overhead)
- Příklady:
  - Minix
  - GNU Hurd

---

## Modulární architektura

- Modulární architektura je typ struktury operačního systému, kde je jádro rozděleno na samostatné moduly, které lze načítat nebo odebírat během běhu systému (dynamicky).
- Jde o kombinaci výhod **monolitického a mikrojádrového přístupu**.
- Jádro obsahuje základní funkce (např. plánování procesů, správu paměti, komunikaci), zatímco další části systému – jako souborové systémy, síťové protokoly, nebo ovladače zařízení – jsou implementovány jako moduly (modules), které je možné:
  - nahrát do jádra (load), když jsou potřeba
  - odstranit z jádra (unload), když nejsou potřeba
- Moduly běží v jádrovém prostoru, ale jsou oddělené – tedy jádro je stále monolitické, jen flexibilnější.
- Výhody:
  - Flexibilita
  - Snazší údržba
  - Kombinuje rychlost monolitu a modularitu mikrojádra.
- Nevýhody:
  - Složitější správa kompatibility
  - Závislosti mezi moduly
- Příklady:
  - Solaris
  - Windows NT

---

## Hybridní architektura

- Hybridní jádro (hybrid kernel) je kombinace monolitického a mikrojádrového přístupu.
- Cílem je spojit výkon monolitického jádra s modularitou a stabilitou mikrojádra.
- Hybridní jádro se snaží zachovat rychlost monolitického systému, ale zároveň odděluje některé části, aby zlepšilo bezpečnost a stabilitu.
- V praxi to znamená, že:
  - Základní části systému (např. správa procesů, paměti, ovladače, souborové systémy) běží v jádrovém prostoru.
  - Ale některé služby (např. subsystémy pro bezpečnost, ovladače, serverové služby) mohou běžet v uživatelském prostoru jako samostatné procesy.
- Výhody:
  - Vyšší výkon než mikrojádro
  - Lepší stabilita než monolitické jádro
  - Kompromis mezi rychlostí a spolehlivostí.
- Nevýhody:
  - Složitost implementace
  - Některé komponenty stále běží v jádře
- Příklady:
  - iOS
  - macOS (XNU jádro – kombinace Mach + BSD)

---