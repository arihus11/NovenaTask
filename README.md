# NovenaTask
Simple Windows 2D application made with Unity3D for Novena Task

1. 
__
Izvršna datoteka nalazi se unutar mape NovenaAppExe, a izvorni kod unutar NovenaAppSrc/NovenaApp.

2. 
__
Podaci se pohranjuju unutar JSON datoteke samo za elemente galerije i cijela galerija se učitava prilikom incijalizacije trećeg ekrana - svaki element galerije definiran je svojim nazivom i slikom. 
Za ostale tekstove i grafičke elemente podaci se ne pohranjuju nego su defaultno zadani. Ideja je bila da se isti način pohrane i učitavanja podataka koristi za sadržaj drugog ekrana jer pretpostavljam
da je bi u pravoj aplikaciji bilo moguće i tamo listati elemente no s obzirom na nedostatak podataka za taj ekran (tekstova i slika) sadržaj je hardcodiran (i interaktivni element tog ekrana je pohranjen u obliku prefaba).

3. 
__
Dvojezičnost je implementirana samo unutar drugog ekrana. Odabirom drugog jezika unutar bilo kojeg ekrana promijenit će se tekst samo na drugom ekranu. Navedeno je implementirano samo u svrhu testiranja
te bi u slučaju dostupnosti više podataka bilo moguće na isti način mijenjati tekstove unutar cijele aplikacije. Naravno, to bi podrazumijevalo i veću razinu strukturiranosti koda.

4. 
__
Elementi galerije su pretvoreni u prefabove, a galerija općenito je zamišljena kao ScriptableObject. S obzirom na jednostavnost ove verzije aplikacije daljnje funkcionalnosti koje se ostvaruju pomoću takvog 
načina spremanja galerije nisu implementirane pa galerija u smislu SO pohranjuje samo trenutno odabrani element galerije i listu elemenata galerije. Takva implementacija bi također značajno poboljšalja 
strukturu i funkcionalnost koda.

5. 
__
Nisu implementirane nikakve animacije za npr. prijelaze među scenama ili odabire elemenata s obzirom da nije specificirano. Implementirano je highlightanje interaktivnih tekstualnih 
elemenata, ali ne i drugih ikona koje predstavljaju gumbe.

6. 
__
Prilikom odabira elementa u galeriji, uvećana slika nije u formatu kojem bi trebala biti nego je zapravo samo isti Sprite korišten kao ikona tog elementa, ali uvećano. Razlog toga je što nisam mogao preuzeti 
originalne slike iz Figme u punoj veličini.

7. 
__
Odabirom elementa unutar galerije, kao što je pretpostavljeno, otvara se overlay preko tog elementa. Overlay je potrebno zatvoriti prije nego se može odabrati drugi element. Takva funkcionalnost 
implementirana je namjerno, a ukoliko je potrebno, moguće je staviti i da se odabirom drugog elementa automatski zatvara overlay dosad otvorenog. 

8. 
__
Jedan od fontova unutar Figme je custom pa ga nisam mogao koristiti nego je umjesto njega korišteni drugi dostupni preuzet sa DaFont.com
