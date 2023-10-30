BONDAR IRINA 
GRUPA 3131A

LABORATOR 3 - TEMA 3

PROBLEME DE REZOLVAT

1. Care este ordinea de desenare a vertexurilor pentru aceste metode (orar sau anti-orar)? Desenați axele de coordonate din aplicația- template folosind un singur apel GL.Begin().
	R : Ordinea de desenare a vertex-urilor este cel anti - orar.

2. Ce este anti-aliasing? Prezentați această tehnică pe scurt.
	R : Anti-aliasing-ul utilizează tehnici de netezire a marginilor.Această tehnică este folosită pentru a scăpa de marginile zimțate de pe ecran ce apar ca urmare a desenării unei drepte oblice pe ecran atunci când poziționarea naturală a pixelilor pe ecran este cea perpendiculară.

3. Care este efectul rulării comenzii GL.LineWidth(float)? Dar pentru GL.PointSize(float)? Funcționează în interiorul unei zone GL.Begin()?
	R : Comanda GL.LineWidth(float) mărește diametrul liniei
	    Comanda GL.PointSize(float) precizează diametrul punctului
	    Cele două comenzi funcționează doar în interiorul unei zone GL.Begin().

4. Răspundeți la următoarele întrebări (utilizați ca referință eventual și tutorii OpenGL Nate Robbins):
	• Care este efectul utilizării directivei LineLoop atunci când desenate segmente de dreaptă multiple în OpenGL?
	R : Efectul utilizării directivei LineLoop - creează o legătură între liniile desenate pe ecran, ultimul vertex desenat fiind conectat la primul vertex.

	• Care este efectul utilizării directivei LineStrip atunci când desenate segmente de dreaptă multiple în OpenGL?
	R : Efectul utilizării directivei LineStrip - creează legături între segmentele desenate pe ecran, după fiecare două segmente desenate se specifică un vertex de legătură.

	• Care este efectul utilizării directivei TriangleFan atunci când desenate segmente de dreaptă multiple în OpenGL?
	R : Efectul utilizării directivei TriangleFan - se desenează triunghiuri multiple precum TringleStrip, cu excepția că aceste triunghiuri sunt așezate circular.

	• Care este efectul utilizării directivei TriangleStrip atunci când desenate segmente de dreaptă multiple în OpenGL?
	R : Efectul utilizării directivei TriangleStrip - se desenează triunghiuri conectate pe ecran, fiecare vertex este specificat după ce s-au dat 3 vertex-uri pentru crearea unui triunghi.

5. Creați un proiect elementar. Urmăriți exemplul furnizat cu titlu de
demonstrație - OpenGL_conn_ImmediateMode. Atenție la setarea
viewport-ului.
	R: Prezentat în proiect.

6. Urmăriți aplicația „shapes.exe” din tutorii OpenGL Nate Robbins. De ce este importantă utilizarea de culori diferite (în gradient sau culori selectate per suprafață) în desenarea obiectelor 3D? Care este avantajul?
	R : Este importantă utilizarea de culori diferite (în gradient sau culori selectate per suprafață)deoarece se pot scoate în evidență atât formele obiectelor cât și o pronunțare a efectului 3D. Avantajul mare este dat de faptul că efectul 3D este foarte pronunțat, ieșind în evidență.

7. Ce reprezintă un gradient de culoare? Cum se obține acesta în OpenGL?
	R : Gradientul de culoare reprezintă o paletă de culori care evidențiază trecerea de la o culoare la alta. În OpenGL acest lucru se realizează prin specificarea culorii vertex-urilor ce compun o anumită figură. Astfel se va realiza gradient de la un vertex la altul.

8. Creați o aplicație care la apăsarea unui set de taste va modificaculoarea unui triunghi (coordonatele acestuia vor fi încărcate dintr-un fișier text) între valorile minime și maxime, pentru fiecare canal de culoare. Ce efect va apare la utilizarea canalului de transparență? Aplicația va permite modificarea unghiului camerei cu ajutorul mouse-ului. Folosiți documentația disponibila la https://opentk.net/api/OpenTK.Input.Mouse.html

9. Modificați aplicația pentru a manipula valorile RGB pentru fiecare vertex ce definește un triunghi. Afișați valorile RGB în consolă.

10. Ce efect are utilizarea unei culori diferite pentru fiecare vertex atunci când desenați o linie sau un triunghi în modul strip?
	R : Efectul este acela de gradient de la un vertex la alt vertex învecinat, adică se creează un gradient pe acea dreaptă.