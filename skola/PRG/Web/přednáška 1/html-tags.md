# HTML tags

- `<p></p>` — vytváří odstavec. Automaticky přidává mezery nahoře a dole.
- `<b></b>` — text se zobrazí tučně.
- `<i></i>` — text se zobrazí kurzívou.
- `<br>` — nový řádek, bez vytvoření odstavec.
- `<h1>`— nejdůležitější a největší nadpis na stránce.
- `<h2> – <h6>` — postupně menší a méně významné.

---

### Starý způsob:

```html
<font color="green" face="Arial, Helvetica" size="2">
  zxcursed in matrix
</font>
```

### Nový způsob:

```html
<span style="color: green; font-family: Arial, Helvetica, sans-serif; font-size: 14px;">
  zxcursed in matrix
</span>
```

- zastaralá varianta psaní programu přes `<font color="green" face="Arial, Helvetica" size="2"> zxcursed in matrix</font>`

```html
<!DOCTYPE html>
<html lang="cs">
  <head>
    <title>pozvanka</title>
    <meta charset='utf-8'> 
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="style.css">
  </head>
  <body>
    <div>

<font color = "blue" face="Arial, Helvetice" size = "6"> Pozvanka na narozeniny!!!!!!! </font>
<br>
<br>

<font color = "red" size = "3"> Konečně mám tolik let, kolik jsem si vždycky přál(a)! </font>
<br>
<font color = "green" size = "3"> Přijďte to se mnou oslavit a pomoct mi zapomenout, že už nejsem nejmladší. </font> 
<br>
<font color = "purple" size = "3"> Ujistěte se, že vás čeká večer plný skvělého jídla, pití a nezapomenutelných zážitků. </font
<br>
<br>
<font color = "pink" size = "3"> Kdo nepřijde, dostane 100 nových vrásek na tváři! 21.08.21 v 18:00 v Neratovicich </font



<br>

<b><p> S pozdravem </p></b>
<b><p> Someone </p></b>

  </body>
</html>
```

- moderní varianta se nachází v souboru `goofy_pozvanka.html`

TODO: `<span>` tag