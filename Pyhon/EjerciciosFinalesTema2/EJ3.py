UMBRAL = 10000


def pedir_numero(mensaje):
    while True:
        try:
            numero = float(input(mensaje))
            if numero < 0:
                print("Error: no puede ser negativo")
            else:
                return numero
        except ValueError:
            print("Error: tienes que escribir un número")


saldo = pedir_numero("Saldo inicial: ")
ahorro = pedir_numero("Cantidad a ahorrar cada mes: ")

meta_mostrada = False

for mes in range(1, 13):
    saldo = saldo + ahorro
    print(f"Mes {mes}: {saldo:.2f} €")

    if saldo >= UMBRAL and not meta_mostrada:
        print("¡Meta alcanzada!")
        meta_mostrada = True