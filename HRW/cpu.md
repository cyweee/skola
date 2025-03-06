# Mikroprocesory

## 1. Architektura a typy procesorů

- Rozdíl mezi CISC (Complex Instruction Set Computing) a RISC (Reduced Instruction Set Computing).
- EPIC (Explicitly Parallel Instruction Computing) – vlastnosti a důvody neúspěchu Itania.
- Jednojádrové a vícejádrové procesory (Single-core vs. Multi-core).
- Mikrokontroléry vs. procesory pro PC a servery vs. superpočítačové procesory.

****

## 2. Vnitřní struktura procesoru

- Jádro (CPU Core): co dělá a z čeho se skládá.
- ALU (Aritmeticko-logická jednotka) a její funkce.
- Registry:
     - Obecné registry (GPR) – uchovávají data během výpočtů.
     - Speciální registry:
         - PC (Program Counter) – sleduje adresu další instrukce.
         - IR (Instruction Register) – ukládá aktuálně vykonávanou instrukci.
         - SP (Stack Pointer) – ukazuje na vrchol zásobníku.
         - FR (Flags Register) – ukládá stav CPU (např. přetečení, nulový výsledek).
     -    Vektorové a SIMD registry (AVX, SSE) pro paralelní výpočty.
     -    Registry pro čísla s plovoucí desetinnou čárkou (FPU).
     -    Control Registers – řídicí registry pro ochranu paměti a režimy procesoru.
- Cache paměť CPU (L1, L2, L3): proč je důležitá a jak ovlivňuje výkon.
- Řadič instrukcí (Control Unit):
   - Dekódování instrukcí.
   - Řízení běhu programu.
- Paměťový řadič:
  -   Jak CPU přímo komunikuje s RAM.
  -   Rozdíl mezi DDR4 a DDR5   
****

## 3. Výkon procesoru

- Počet jader a vláken: Hyper-Threading (Intel) / SMT (AMD).
- Frekvence (GHz) a její vliv na výkon.
- Přetaktování (Overclocking):
  -  Turbo Boost (Intel) a Precision Boost (AMD).
  -  Rizika přetaktování (přehřívání, degradace).
- Spotřeba energie a chlazení (TDP).
- Vliv instrukční sady (x86-64, ARM, RISC-V).
****

## 4. Jak procesor pracuje

- Potrubí instrukcí (Pipeline processing) – fáze zpracování instrukcí.
- Přerušení (IRQ) a jejich obsluha.
- Přímý přístup k paměti (DMA) a jeho výhody.
- Systémová sběrnice (Bus):
  -    Adresová sběrnice (kam se ukládají data).
  -    Datová sběrnice (co se přenáší).
  -    Řídicí sběrnice (kdo řídí přenosy).
****

## 5. Komunikace s periferiemi

- PCI Express (PCIe 3.0, 4.0, 5.0) a jeho role.
- Memory-Mapped I/O (MMIO) – komunikace CPU s GPU, SSD a dalšími zařízeními.
- Infinity Fabric (AMD) – propojení jader a cache u procesorů Ryzen a EPYC.
- Řadiče periferií:
     -  USB, SATA, NVMe řadiče.
     -  Integrované grafické čipy: Intel Iris, AMD Radeon Graphics.
****

## 6. Moderní procesorové technologie

- Hardwarové akcelerátory:
     -   AVX (Advanced Vector Extensions) – zrychlení vědeckých výpočtů.
     -   AES-NI (hardwarové šifrování).
     -   Tensor Cores / AI akcelerátory.
- Virtualizace:
     -  Intel VT-x a AMD-V.
     -  Hyper-V, KVM, ESXi.
- Vliv výrobních procesů (7nm, 5nm, 3nm) na výkon a spotřebu.
****

## 7. Chlazení procesoru

- Vzduchové chlazení:
    - Rozdíl mezi věžovými chladiči a nízkoprofilovými modely.
 - Kapalinové chlazení (AIO / Custom Loop).
 - Důležitost teplovodivé pasty.
****

## 8. Budoucnost procesorů

- Hybridní procesory (big.LITTLE, Intel Alder Lake).
- Kvantové procesory a jejich význam.
- ARM procesory v osobních počítačích (Apple M1/M2, Qualcomm Oryon).