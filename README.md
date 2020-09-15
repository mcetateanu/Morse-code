#   Learning Morse-code
                    

## 1. Scurta descriere

    Codul Morse poartă numele lui Samuel Morse, unul dintre inventatorii telegrafului.
    Alfabetul Morse a devenit un standard mondial în 1865.
    A fost utilizat pe scară largă în lumea maritimă până la sfârșitul secolului al XX-lea.
    Alfabetul Morse este conceput astfel încât cele mai frecvente litere din alfabet să 
    aibă cele mai scurte coduri.
    Acest lucru face ca transmisia să fie mult mai rapidă decât dacă toate literele ar avea 
    coduri de lungime egală.
    Codul internațional Morse include literele engleze, câteva litere latine suplimentare, 
    cifrele arabe și un set mic de punctuații și semnale procedurale.

    Literele sunt separate printr-un spațiu de timp egal cu trei puncte.
    Cuvintele sunt separate printr-un spațiu de timp egal cu șapte puncte.
    
    Există, de asemenea, alfabete Morse speciale pentru alte limbi decât engleza.
    Codul Morse poate fi transmis folosind sunete  sau lumină, făcându-l util pe mare.
    Este o metodă de comunicații extrem de fiabilă, chiar și în medii dificile și zgomotoase. 
    Alfabetul Morse a devenit un standard mondial în 1865.  ***
    
   
  ( Text preluat integral si tradus in limba romana din: [***  Ref.1](https://www.boxentriq.com/code-breaking/morse-code/))
    
   #### Programul isi propune sa invete utilizatorul sa recunoasca si sa transcrie mesaje codate in Cod Morse.

>
>
>
>


## 2. User-Interface Design


```bash
Codul Morse se bazeaza pe urmatorul alfabet:
```
![Image](https://www.boxentriq.com/img/morse-code/morse-code-overview.png)

### 2.1. Procedeul clasic de invatare.
```
Invatarea Codului Morse se bazeaza pe retinerea "melodiei" fiecarui semn din alfabet. 
Va fi necesar sa putem varia viteza de transmisie a codurilor, nu foarte mica fiindca 
nu va mai putea fi recunoscuta usor "melodia" codurilor si nu foarte mare fiindca nu va 
mai fi suficient timp de transcris caracterele.
```
```
Evident, invatarea codurilor se face pe rand, si nu tot alfabetul dintr-o data.
Similar cu invatarea scrierii literelor in clasele primare, semnalele Codului Morse se 
invata treptat , grupate doua cate doua si alese cu melodii suficient de diferite 
astfel incat sa fie cat mai usoara si rapida retinerea lor.
```
```
Semnalele Codului Morse se transmit in grupe de cate cinci semne, precedate de unul 
sau mai multe caractere V (Atentie, urmeza transmitere)

```
```
Fiecare lectie, numerotata de la 1 pana la 20, va introduce cate doua semnale noi. 
Pentru inceput se vor exersa doar caracterele noi, urmand ca imediat ce acestea au fost asimilate 
sa fie intercalate cu semnalele lectiilor deja parcurse.
In acest fel dificultatea recunoasterii semnelor creste progresiv, lasind timp suficient pentru 
o invatare continua, fara metode abrupte. 

```



### 2.2. Interfata Utilizatorului
```
Interfata va deschide direct form-ul principal si va avea urmatoarele functiuni:
```
- Form principal cu

>- buton  < numeric up/doun >  pentru alegerea numarului lectiei
>- buton  <radio>              pentru (start / stop)  transmitere coduri
>- buton  <radio>              pentru mod de (afisare/ascundere) = [incepator/avansat] al caracterelor transmise 
>- buton  <radio>              pentu mod exersare doar grupul nou de caractere  

- Meniu "Options"  >> deschide New Form cu:

>- buton  < numeric up/doun >  pentru viteza de transmitere caractere ( implementat din Release 2.0_ daca totul este functional in  Alpha)
>- buton pentru  Form Help
>- buton pentru  Form About
>- buton pentru  Form License


## 3. Code desing.

### Clasele folosite:
  Preexistente:

- Beep (int frequency, int duration)     // genereaza ton de frecventa (int frequency) Hz si durata (duration) msec.
- Random (int32_Min,int32_Max)           // genereaza valoare int32 aleatorie in intervalul (Min,Max)

 construite:

- Morse_Code                            // generaza "melodia" corespunzatoare caracterului atribut.

### Structura programului:
          




             
             if  START_TX ==   true > generez caracter conf conditii lectie
                                      generez morse_code aferent caracter prin apelare obiect nou
 ``` c#                                    
                                       Morse_Code Play = new Morse_Code(CaracterRandomRezultat);
 ```
            if RadioButton_CodLaVedere == true 
                                    > afisez caracter in > caracter_curent_Box 
                                    > si apoi in grupa_x  Box
           else                     > afisez toate grupele de litere doar la sfrsitul transmisiei

### Interfata grafica:


## 4. Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## 5. License
[MIT](https://choosealicense.com/licenses/mit/)

### 6. Project Status
>  Coordonator proiect : *Stefana Berenghia*
>
>  Started   Today 04 sept 2020   :      *by Mihail Cetateanu - YO3FVV*

