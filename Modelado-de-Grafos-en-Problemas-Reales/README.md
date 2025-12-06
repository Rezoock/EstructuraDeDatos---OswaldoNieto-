# Tarea 1.2: Modelado de Grafos

## Información
- **Nombre:** [Luis Oswaldo Nieto Diaz]
- **Fecha:** [05/12/2025]

## Ejercicio 1: Sistema de Vuelos
Se modeló un sistema de rutas aéreas utilizando un **grafo dirigido y ponderado** compuesto por 5 vértices (ciudades) y 6 aristas (vuelos con costo).

**Resultados del análisis:**
* **Ruta óptima:** La conexión más barata de México a Miami es vía Cancún con un costo total de $5000.
* **Ciclos:** Se detectó un ciclo que permite el retorno (México → Cancún → Miami → México).
* **Conectividad:** La ciudad de México funge como el "hub" principal con mayor cantidad de salidas.
[Diagrama](ejercicio1.png)

## Ejercicio 2: Red de Computadoras
Se representó la infraestructura de red de una oficina mediante un **grafo no dirigido** con topología de árbol (estrella extendida), conectando 10 dispositivos.

**Resultados del análisis:**
* **Topología:** La red es conexa y acíclica, clasificando matemáticamente como un árbol ($n=10, m=9$).
* **Vulnerabilidad:** El **Router** es el nodo crítico (punto de articulación); su fallo dividiría la red en 3 componentes aisladas, dejando al servidor incomunicado.
![Diagrama](ejercicio2.png)

## Ejercicio 3: [GRAFO-PRE-REQUESITOS-MATERIAS]
Se diseñó un modelo de **Grafo Dirigido Acíclico (DAG)** para representar la dependencia de materias (pre requisitos) en la carrera de Ingeniería en Sistemas.

**Resultados del análisis:**
* **Estructura:** Los vértices representan asignaturas y las aristas la obligatoria de cursarlas en orden.
* **Ruta Crítica:** Se identificó el camino más largo (Progra 1 → Progra 2 → Estructura → Proyecto), determinando el tiempo mínimo necesario para graduarse.
* **Validación:** El grafo no contiene ciclos, lo cual es consistente con la lógica académica (no se puede cursar el futuro para aprobar el pasado).
![Diagrama](ejercicio3.png)
