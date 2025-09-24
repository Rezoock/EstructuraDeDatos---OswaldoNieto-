import time
import random

# ==============================================================================
# EJERCICIO 1: COMPARACIÓN DE BÚSQUEDAS (LINEAL VS BINARIA)
# ==============================================================================

def busqueda_lineal(lista, objetivo):
    """
    Implementa búsqueda lineal O(n).
    Recorre la lista uno por uno hasta encontrar el objetivo.
    """
    for i in range(len(lista)):
        if lista[i] == objetivo:
            return i  # Retorna la posición si lo encuentra
    return -1  # Retorna -1 si no lo encuentra

def busqueda_binaria(lista, objetivo):
    """
    Implementa búsqueda binaria O(log n).
    PRECONDICIÓN: La lista debe estar ordenada.
    """
    izquierda, derecha = 0, len(lista) - 1
    while izquierda <= derecha:
        medio = (izquierda + derecha) // 2
        if lista[medio] == objetivo:
            return medio
        elif lista[medio] < objetivo:
            izquierda = medio + 1
        else:
            derecha = medio - 1
    return -1

def experimento_busquedas():
    print("--- EJERCICIO 1: BÚSQUEDA LINEAL VS BINARIA ---")
    tamanos = [1000, 10000, 50000, 100000]
    
    print(f"{'Tamaño':>10} | {'B. Lineal (s)':>15} | {'B. Binaria (s)':>16} | {'Ratio (L/B)':>15}")
    print("-" * 65)

    for tamano in tamanos:
        # 1. Generar lista ordenada
        lista_ordenada = list(range(tamano))
        
        # 2. Generar 10 objetivos (5 existen, 5 no)
        objetivos = random.sample(lista_ordenada, 5) + [tamano + i for i in range(5)]
        
        # 3. Medir tiempo de búsqueda lineal
        inicio_lineal = time.time()
        for obj in objetivos:
            busqueda_lineal(lista_ordenada, obj)
        fin_lineal = time.time()
        tiempo_lineal = fin_lineal - inicio_lineal
        
        # 4. Medir tiempo de búsqueda binaria
        inicio_binaria = time.time()
        for obj in objetivos:
            busqueda_binaria(lista_ordenada, obj)
        fin_binaria = time.time()
        tiempo_binaria = fin_binaria - inicio_binaria
        
        # 5. Calcular ratio y mostrar resultados
        ratio = tiempo_lineal / tiempo_binaria if tiempo_binaria > 0 else float('inf')
        print(f"{tamano:>10} | {tiempo_lineal:>15.6f} | {tiempo_binaria:>16.6f} | {ratio:>15.2f}x")
    print("\n")


# ==============================================================================
# EJERCICIO 2: COMPARACIÓN DE ORDENAMIENTOS (BUBBLE SORT VS SORTED)
# ==============================================================================

def bubble_sort(lista):
    """Implementa Bubble Sort O(n^2)."""
    n = len(lista)
    # Copiamos la lista para no modificar la original
    lista_copia = lista[:]
    for i in range(n):
        hubo_intercambio = False
        for j in range(0, n - i - 1):
            if lista_copia[j] > lista_copia[j+1]:
                lista_copia[j], lista_copia[j+1] = lista_copia[j+1], lista_copia[j]
                hubo_intercambio = True
        if not hubo_intercambio:
            break # Optimización: si no hay intercambios, la lista ya está ordenada
    return lista_copia

def experimento_ordenamientos_rendimiento():
    print("--- EJERCICIO 2.1: RENDIMIENTO DE ORDENAMIENTOS ---")
    dimensiones = [100, 500, 1000, 5000] # Para 10,000 Bubble Sort puede ser MUY lento
    
    print(f"{'Dimensión':>10} | {'Bubble Sort (s)':>16} | {'Python sorted() (s)':>20} | {'Ratio (BS/Sorted)':>20}")
    print("-" * 75)
    
    for dim in dimensiones:
        # 1. Generar secuencia aleatoria
        secuencia = random.sample(range(dim * 10), dim)
        
        # 2. Medir Bubble Sort
        inicio_bs = time.time()
        resultado_bs = bubble_sort(secuencia)
        fin_bs = time.time()
        tiempo_bs = fin_bs - inicio_bs
        
        # 3. Medir Python sorted()
        inicio_sorted = time.time()
        resultado_sorted = sorted(secuencia)
        fin_sorted = time.time()
        tiempo_sorted = fin_sorted - inicio_sorted

        # Verificar que ambos ordenaron correctamente
        assert resultado_bs == resultado_sorted
        
        # 4. Calcular ratio y mostrar resultados
        ratio = tiempo_bs / tiempo_sorted if tiempo_sorted > 0 else float('inf')
        print(f"{dim:>10} | {tiempo_bs:>16.6f} | {tiempo_sorted:>20.6f} | {ratio:>20.2f}x")
    print("\n")

def experimento_ordenamientos_casos_especificos():
    print("--- EJERCICIO 2.2: CASOS ESPECÍFICOS (n=1000) ---")
    n = 1000
    secuencia_ordenada = list(range(n))
    secuencia_inversa = list(range(n, 0, -1))
    secuencia_casi_ordenada = [x if x % 100 != 0 else x + 500 for x in range(n)]

    escenarios = {
        "Ordenado (Mejor Caso)": secuencia_ordenada,
        "Inverso (Peor Caso)": secuencia_inversa,
        "Casi Ordenado": secuencia_casi_ordenada
    }
    
    print(f"{'Escenario':>25} | {'Bubble Sort (s)':>16} | {'Python sorted() (s)':>20}")
    print("-" * 70)

    for nombre, secuencia in escenarios.items():
        # Medir Bubble Sort
        inicio_bs = time.time()
        bubble_sort(secuencia)
        fin_bs = time.time()
        tiempo_bs = fin_bs - inicio_bs
        
        # Medir Python sorted()
        inicio_sorted = time.time()
        sorted(secuencia)
        fin_sorted = time.time()
        tiempo_sorted = fin_sorted - inicio_sorted
        
        print(f"{nombre:>25} | {tiempo_bs:>16.6f} | {tiempo_sorted:>20.6f}")
    print("\n")


# ==============================================================================
# EJERCICIO 3: FIBONACCI (RECURSIVO VS ITERATIVO)
# ==============================================================================

def fib_recursivo(n):
    """Implementación recursiva O(2^n). MUY LENTA."""
    if n <= 1:
        return n
    return fib_recursivo(n-1) + fib_recursivo(n-2)

def fib_iterativo(n):
    """Implementación iterativa O(n). EFICIENTE."""
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(n - 1):
        a, b = b, a + b
    return b
    
memo_fib = {}
def fib_memoization(n):
    """BONUS: Implementación con memoization O(n)."""
    if n in memo_fib:
        return memo_fib[n]
    if n <= 1:
        return n
    resultado = fib_memoization(n-1) + fib_memoization(n-2)
    memo_fib[n] = resultado
    return resultado

def experimento_fibonacci():
    print("--- EJERCICIO 3.1: TIEMPOS DE CÁLCULO FIBONACCI ---")
    valores_n = [5, 10, 20, 30, 35]
    
    print(f"{'n':>5} | {'Resultado':>10} | {'Recursivo (s)':>15} | {'Iterativo (s)':>15}")
    print("-" * 55)

    for n in valores_n:
        # Medir versión recursiva
        inicio_rec = time.time()
        resultado_rec = fib_recursivo(n)
        fin_rec = time.time()
        tiempo_rec = fin_rec - inicio_rec

        # Medir versión iterativa
        inicio_ite = time.time()
        resultado_ite = fib_iterativo(n)
        fin_ite = time.time()
        tiempo_ite = fin_ite - inicio_ite
        
        # Verificar que ambos dan el mismo resultado
        assert resultado_rec == resultado_ite
        
        print(f"{n:>5} | {resultado_ite:>10} | {tiempo_rec:>15.6f} | {tiempo_ite:>15.6f}")
    print("\n")


# ==============================================================================
# FUNCIÓN PRINCIPAL PARA EJECUTAR TODO
# ==============================================================================

def main():
    """Ejecuta todos los experimentos."""
    experimento_busquedas()
    experimento_ordenamientos_rendimiento()
    experimento_ordenamientos_casos_especificos()
    experimento_fibonacci()

# Esto asegura que el código dentro del if solo se ejecute cuando corres el archivo directamente
if __name__ == "__main__":
    main()