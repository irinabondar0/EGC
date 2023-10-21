BONDAR IRINA 
GRUPA 3131A

LABORATOR 2 - TEMA 2

PROBLEME DE REZOLVAT 

1.Modificați valoarea constantei „MatrixMode.Projection”. Ce observați?
	R: Prin modificarea constantei „MatrixMode.Projection” nu am observat nicio modificare/schimbare.

2.Rezolvată în soluție.

3. Răspundeți la următoarele întrebări (utilizați ca referință și tutorialele OpenGL Nate Robbins încărcate în cadrul laboratorului 01):

⚫ Ce este un viewport?
	R : Un viewport reprezintă o zonă ce este exprimată în coordonate specifice, pixeli ce reprezintă coordonatele ecranului unde obiectele create de către utilizator vor fii redate.


⚫ Ce reprezintă conceptul de frames per seconds din punctul de vedere al bibliotecii OpenGL?
	R : Frames per seconds ( FPS ) este unitatea de măsură pentru rata de cadre(este frecvența la care imaginile consecutive numite cadre apar pe ecran).


⚫ Când este rulată metoda OnUpdateFrame()?
	R : Metoda OnUpdateFrame() este rulată automat pe ecran în pasul următor, când va fi realizată următoarea randare.


⚫ Ce este modul imediat de randare?
	R : Redarea modului imediat este un stil pentru interfețele de programare ale aplicațiilor din bibliotecile de grafică, în care utilizatorul apelează direct la afișarea obiectelor grafice pe afișaj sau în care datele care descriu primitivele de redare sunt  inserate frame by frame direct într-o listă de comenzi (în caz de redare imediată a modului primitiv), fără utilizarea unei indirecții extinse la resursele reținute.


⚫ Care este ultima versiune de OpenGL care acceptă modul imediat?
	R : Ultima versiune de OpenGL care accepta modul imediat este 4.6.


⚫ Când este rulată metoda OnRenderFrame()?
	R : Metoda OnRenderFrame() este rulata atunci când se dorește randarea scenei grafice.


⚫ De ce este nevoie ca metoda OnResize() să fie executată cel puțin o dată?
	R: Metoda OnResize() trebuie execută măcar odată pentru inițierea afișării și setarea viewport-ului grafic.


⚫ Ce reprezintă parametrii metodei CreatePerspectiveFieldOfView() și care este domeniul de valori pentru aceștia?
	R : Parametrii metodei CreatePerspectiveFieldOfView() reprezintă crearea unei perspective a proiectării unei matrici, dar și a raportului de aspecte și distanțe plane apropiate și de vedere. Domeniul de valori pentru această metodă fiind Single CreatePerspectiveFieldOfView (Single, Single, Single, Single).