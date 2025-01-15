Svensk Personnummerkontroll

En C#-baserad konsolapplikation för att verifiera svenska personnummer enligt svenska regler. Applikationen inkluderar enhetstester och distribueras som en Docker-container. Projektet använder GitHub Actions för kontinuerlig integration och publicering.

Funktionalitet
- Tar emot ett svenskt personnummer som indata.
- Verifierar om personnumret är korrekt baserat på svenska regler för personnummer.

Svenska regler för personnummer
Ett svenskt personnummer består av 10 siffror, ofta skrivet som `YYYYMMDD-XXXX`. Kontrollsiffran i det sista fältet beräknas med hjälp av Luhn-algoritmen. 

Luhn-algoritmen som krävs för att kontrollera kontrollsiffran görs genom att multiplicera de 9 första siffrorna om vartannat med 1 och 2. Siffersummorna adderas (exempelvis 16 blir 1+6=7). När kontrollsiffran adderas till summan ska talet vara jämnt delbart med 10 för att personnumret ska vara korrekt.

Komma igång

Krav
- .NET SDK (version 6.0 eller senare) //snarare version 9.0
- Docker (för att bygga och köra containern)

Klona projektet
```bash
git clone https://github.com/<ditt-användarnamn>/personnummer-kontroll.git
cd personnummer-kontroll

