# Use Cases
### **UC1**: Scan og flyt kaliber til næste station

**Primær aktør**: Medarbejder.

**Formål**: Kaliberen er oprettet i systemet og har en stregkode.

**Scope**: Oprettede, scannede og registrerede kalibre i lageret.


**Level**: User-goal.

**Interessenter og interesser**:
* **Medarbejder**: Givet et overblik og hvilke kalibre som er ved deres station.

* **Chefer**: Effektivisere arbejdsproces og mindske fejl.

* **Afdelingsleder**: Kan se hvilke stationer der skulle kigges nærmere på, for at effektivisere arbejdet i hverdagen.

* **Kontor**: Skabe et bedre overblik over inventar og renoveringsproces.

**Pre-conditions:**
1.  Budweg har modtaget brugte bremsekalibre

2.  Bremsekaliber modtaget med de relevante kriterier fra leverandører  

3.  Bremsekaliber er sorteret efter modtagelse (antagelse)

**Succesgaranti**:
1. Medarbejderen har scannet kaliberens stregkode

2. Kaliberen er oprettet i systemet

3. Kaliber scannes ved hver station

4. Kaliber er klar til pakning

5. System melder kaliberen klar til distribution

**Hovedscenarie**: 
1. Medarbejderen scanner kaliberens stregkode

2. Systemet finder kaliberens ID

3. Systemet viser nuværende status og station

4. Medarbejderen vælger "Send til næste station"

5. Systemet opdaterer status

6. Systemet gemmer ændringen

**Alternativt scenarie**: 
- Hvis systemet ikke kan registrere stregkoden på kaliberen

1. Scanneren registrerer ikke stregkoden, så medarbejderen registrerer stregkoden manuelt.

2. Systemet finder kaliberens ID

3. Systemet viser nuværende status og station

4. Medarbejderen vælger “send til næste station”

5. Systemet opdaterer status

6. Systemet gemmer ændringen

### **UC2**: Opret og registrér nye bremsekalibre

**Primær aktør**: Medarbejder

**Formål**:
Medarbejdere åbner programmet og vælger at oprette en ny bremsekaliber. Så bliver medarbejderen bedt om at udfylde informationer, og kan så registrere en bremsekaliber.

**Hovedscenarie**:
1. Medarbejder åbner program

2. System viser menuen

3. Medarbejder vælger opret bremsekaliber

4. System viser vindue med registrering af bremsekaliber

5. Medarbejder scanner bremsekaliber

6. System registrerer den scannede bremsekaliber

7. Medarbejder trykker gem

### **UC3**: Pak bremsekaliber til lager

**Primær aktør**: Medarbejder

**Formål**: Medarbejder modtager kalibre, pakkes ind og derefter sendes til lageret.

**Hovedscenarie**:
1. Kalibre modtages ved station 10

2. Medarbejder skanner kalibre

3. Kalibre pakkes i kasser

4. Der lægges nye stregkoder på kassen

5. Kassen videresendes til lageret





