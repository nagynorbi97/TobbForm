
# TobbForm
|||
|--|--|
|Leírás|Próbálkozás: C#|
|Sorszám|1. példa|
|Dátum|2020. 02. 22.|
|||

## Több form közöti váltás új ablak nélkül
### A program felépítése:
|Fájl|Leírás|
|--|--|
|ablak.cs|Itt jelenítjük meg a többi ablakot, ez a megjelenő ablakunk.|
|fooldal.cs|Ez egy al-ablak, ezt hívjuk meg az ablak.cs-ben.|
|teszt1.cs|Ez egy al-ablak, ezt hívjuk meg az ablak.cs-ben.|
|leiras.cs|Ez egy al-ablak, ezt hívjuk meg az ablak.cs-ben.|

A formok között nem lehet metódusokat használni, ezért felveszünk minden al-ablaknak egy paramétert.
Ez egy `ablak` típusú `parent` nevű változó.
Amikor meghívjuk a megjelenítést, megadjuk paraméternek, hogy `this` így tudni fogja honnan kell meghívni.

#### Megjegyzés:
A dizájnerben letiltottam az ablakok `ControlBox`-át, azaz a kicsinyítés nagyítás bezárást.
A keretet eltávolíthatjátok szintén a dizájnerben, így fejlesztéskor tudjátok, hogy ez nem főablak.
Érdemes az ablakkeretet így csinálni ahogy én azért, hogy normálisan látszódjon fejlesztéskor, az ablakcímet pedig beállíthatjátok az adott aloldal nevére, mint én.
