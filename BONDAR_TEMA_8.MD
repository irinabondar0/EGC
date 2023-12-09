BONDAR IRINA
GRUPA 3121A
TEMA LABORATOR 8

1. Descrieți diferențele dintre iluminarea așa cum funcționează în lumea reală și modelul de iluminare utilizat de OpenGL.

	R : OpenGL abordează lumina și iluminarea ca și cum lumina ar putea fi împărțită în componente roșie, verde și albastră. Prin urmare, culoarea surselor de lumină este caracterizată de cantitatea de lumină roșie, verde și albastră pe care o emit, iar materialul de suprafață este caracterizat de procentul de componente roșii, verzi și albastre reflectate în direcțiile date.În lumea reală, atunci când lumina din diferite surse de lumină strălucește pe obiecte opace, o parte din lumină va fi absorbită de obiect, iar o parte va fi reflectată. Ochiul percepe lumina reflectată de obiecte pentru a interpreta forma obiectului, culoarea și alte detalii. 

2. Câte surse de lumină sunt suportate în implementarea curentă a OpenGL cu ajutorul framework-ului OpenTK?

	R : Trei surse de lumină sunt suportate în implementarea curentă, acestea fiind - lumină ambientală , lumină difuză și lumină speculară.

3. Definiți iluminarea de material și specificați unde și când este utilizată aceasta.

	R : Iluminare de material înseamnă simularea reflexiei și a transmisiei luminii ţinând cont de proprietăţile materialelor fiind utilizată pentru a creea o imagine a obiectului cât mai aproape de realitate. 

4. Care este efectul asupra diverselor obiecte la activarea unei surse de lumină secundare (per pct. 3), comparativ cu utilizarea unei singure surse de lumină?

	R : La activarea unei surse de lumină secundare, comparativ cu utilizarea unei singure surse de lumină are ca efect accentuarea unei porțiuni ale unui obiect.

