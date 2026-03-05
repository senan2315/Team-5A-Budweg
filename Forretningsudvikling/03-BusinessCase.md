# Business Case

## Ledelsesresumé
* Budweg har problemer med processen af deres kalibrer. Det hele foregår over papir og dette gør arbejdet langsommere og mindre organiseret i det man manuelt skal gå hen, og finde ID nummeret og navn på kaliberen, hvor man i stedet kunne tjekke dette i et digitalt program.

## Beskrivelse af problemområde
* Butikken mangler et digitalt system til at holde styr på deres kaliber og status på hvor langt kaliberen er kommet i processen. Alt foregår på papir, hvilket betyder at processen tager meget lang tid, da man selv manuelt skal opdatere og dobbelttjekke at alt er i orden. Der skal også manuelt tjekkes om kaliberen er helt færdig på dens nuværende station (brugt, rengjort eller lign.) og er klar til at blive videresendt til næste station. 

## Forretningsmæssig Baggrund
* Budweg er førende leverandør af renoverede bremse kaliber til det Europæiske reservedelsmarked. Budweg’s produktsortiment dækker mere end 95% af personbiler i Europa. Produktsortimentet omfatter mere end 4,400 kalibre og 1,900 reservedele. Budweg sælger til private labels og grossister indenfor reservedelsmarkedet. 

## Forretningsmæssig Problemstilling
* Budweg ønsker et it-system som kan holde overblik over processen samt opdaterer forløbet, når en kaliber går fra station til station og når kaliberen er færdig i systemet. Dette system skal kunne give overblik over firmaets produkter, så ledelsen og medarbejderne kan få et overblik over hvilke kaliber der er på bestemte stationer.

## Interessenter
* Medarbejdere i firmaet (skal bruge systemet)

* Ledelsen (skal kunne følge med i status og processen)

## Scenarier
* 0-Scenarie: Den nuværende løsning:

Alt laves på papir, dette gør arbejdet langsommere og mindre organiseret i det man manuelt skal gå hen og finde ID nummeret og navn på kaliberen, hvor man i stedet kunne tjekke dette i et digitalt program.

* 1-scenarie: Den foretrukne løsning:

Den foretrukne løsning er et system som skal kunne oprette og registrere nye kaliber ind i systemet, og opdatere processen omkring kalibrene, når de sendes fra station til station. Alle kalibre får et ID med en tilhørende stregkode, som bruges til at scanne kalibre når de sendes til næste station.

* 2-scenarie: Alternative løsninger:

Et løsningsforslag for firmaet, ville være at købe et program udefra og implementere i firmaets systemer, men som er sat op for det generelle arbejdsmarked for lagerpladser.

## Den foretrukne løsning (1-scenariet)
* 1-scenariet vil være den foretrukne løsning, da det færdige produkt ville være et system som er lavet specifikt til dem og deres problem for at gøre deres hverdag lettere og generelt gøre deres arbejdsproces hurtig og effektiv for alle i firmaet.

## Formål 
* At digitalisere arbejdsprocessen for at øge effektiviteten. Det minimerer fejl og sikrer bedre opfølgning.

## Forretningsmæssig løsningsbeskrivelse
* Et system, hvor der kan registreres kaliber, og man kan følge processen mellem de forskellige indregistrerede kaliber i systemet.

## IT-mæssig løsningsbeskrivelse
* Denne løsning udvikles i WPF-applikation ved brug af C# kode. Systemet skulle fremvise ID på de indregistrerede kalibre, og hvor den befinder sig henne i processen. systemet skal også kunne oprette nye kaliber ind i systemet, når lageret modtager de bestilte kalibre. 

## Forretningsmæssige effekter
* Økonomiske effekter:
  * Ingen udviklingsomkostninger
  * Potentielt fremtidige omkostninger, hvis virksomheden vil have udviklet videre på programmet.

* Gevinster:
  * Hurtigere arbejdsgang.
  * Færre fejl.
  * Øget medarbejdertilfredshed.

* Risici:
  * Tab af data kan forekomme hvis medarbejderen ikke bruger systemet rigtigt.

## Implementeringsstrategi
* Vi laver en prototype på en WPF-applikation, der kan gøre det nemmere og mere overskueligt for Budweg. For at mindske risikoen for tab af data, vil vi give medarbejderne i Budweg en introduktion til programmet og hjælpe, hvis der opstår problemer i fremtiden.

## Gevinstrealisering
* Vi har opstillet et forslag på en KPI hvis programmet engang kan blive implementeret.

| KPI | Hvor effektivt arbejdsprocessen er blevet for en kaliber fra modtaget/brugt til færdig/lager | 
| --- | --- |
| Hvorfor måles det? | Opfølgning på om systemet bliver brugt korrekt, og for at være sikker på at arbejdsprocessen bliver forbedret | 
| Hvordan måles det? | Ved at kigge på arbejdsprocessen efter at de har haft programmet og samme linje med arbejdsprocessen fra før de havde programmet | 
| Hvem er ansvarlig for måling? | Ledelsen | 
| Forventet værdiinterval for måling: | Der skal foretages en måling en gang hver 6.måned| 
| Handlingsplan ifald målingen ligger udenfor interval: | Der bliver holdt et møde for hele firmaet hvor der snakkes om hvad der skal forbedres | 
| Ansvarlig for handling: | Chefen i samarbejde med medarbejdere på stationerne  | 



