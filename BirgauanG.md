1. GL.Ortho(1.0, -2.0, -1.0, 2.0, -2.0, 1.0); S-a translatat triunghiul în urma modificarilor
3. 1.Viewport este o secțiune din fereastră unde se desenează obiectele.  

2. FPS reprezintă numărul de cadre care sunt randate intr-o secundă, influențând fluiditatea aplicației. 

3.OnUpdateFrame() se execută înainte de fiecare cadru pentru a actualiza starea logică a aplicației, cum ar fi pozițiile obiectelor.

4.Modul imediat de randare: Un mod vechi în OpenGL, în care toate elementele grafice sunt desenate direct, fără stocare în GPU. 

5.Ultima versiune cu modul imediat: Modul imediat a fost deprecate în OpenGL 3.0 și eliminat în Core Profile de la versiunea 3.1.

6.OnRenderFrame(): Se execută după OnUpdateFrame(), pentru a desena efectiv obiectele pe ecran.

7.OnResize(): Este necesară pentru a ajusta viewport-ul și proiecția scenei atunci când fereastra este redimensionată.

8.CreatePerspectiveFieldOfView(): Creează matricea de proiecție. Parametri:

FOV: Unghiul de deschidere al camerei (30°-90°).
Aspect ratio: Raportul lățime/înălțime al ferestrei.
Near și Far plane: Definirea intervalului de distanțe vizibile.