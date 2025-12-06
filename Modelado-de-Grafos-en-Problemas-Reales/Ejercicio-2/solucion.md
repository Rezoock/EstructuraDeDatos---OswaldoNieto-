## Ejercicio 2: Red de Computadoras
Se representó la infraestructura de red de una oficina mediante un **grafo no dirigido** con topología de árbol (estrella extendida), conectando 10 dispositivos.

### Solución a los incisos:

**a) Dibuja el grafo:**
![Topología de Red](ejercicio2.PNG)

**b) Conteo de elementos:**
* **Vértices (n):** 10 dispositivos.
* **Aristas (m):** 9 conexiones.

**c) Análisis de conexidad:**
* **¿Es conexo?** Sí.
* **Significado:** Existe un camino físico entre cualquier par de dispositivos, por lo que todos los equipos pueden comunicarse entre sí sin excepciones.

**d) ¿Es un árbol?**
* **Sí, es un árbol.**
* **Justificación:** Es un grafo conexo que no contiene ciclos (circuitos cerrados) y cumple la propiedad $aristas = vértices - 1$ ($9 = 10 - 1$).

**e) Componentes conexas sin el Router:**
* Si se desconecta el Router, la red se fragmenta en **3 componentes conexas** aisladas:
  1. El Servidor (solo).
  2. El segmento del Switch 1.
  3. El segmento del Switch 2.

**f) Dispositivo más crítico:**
* **El Router Principal.** Es el nodo de articulación; su falla aísla las subredes y desconecta el servidor del resto de la oficina.
