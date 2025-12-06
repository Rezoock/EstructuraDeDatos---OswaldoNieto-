## Ejercicio 1: Sistema de Vuelos
Se modeló un sistema de rutas aéreas utilizando un **grafo dirigido y ponderado** compuesto por 5 vértices (ciudades) y 6 aristas (vuelos con costo).

**a) Dibuja el grafo:**
![Diagrama de Vuelos](ejercicio1.PNG)

**b) Clasificación del grafo:**
* **¿Es dirigido?** Sí, es dirigido porque los vuelos tienen un sentido específico ("solo ida").
* **¿Es ponderado?** Sí, es ponderado porque cada arista tiene un peso asociado que representa el precio del boleto.

**c) Grados de entrada y salida:**
* **México:** Entrada: 1 | Salida: 2
* **Cancún:** Entrada: 1 | Salida: 1
* **Monterrey:** Entrada: 1 | Salida: 1
* **Houston:** Entrada: 1 | Salida: 1
* **Miami:** Entrada: 2 | Salida: 1

**d) Ciudad con más vuelos salientes:**
* **México** (tiene 2 salidas: a Cancún y a Monterrey).

**e) Ruta más barata de México a Miami:**
* La ruta óptima es **México → Cancún → Miami**.
* **Costo total:** $1500 + $3500 = **$5000**.
*(La otra opción vía Monterrey costaba $5800)*.

**f) Identificación de ciclo:**
* Sí existe un ciclo que permite regresar al origen: **México → Cancún → Miami → México**.
