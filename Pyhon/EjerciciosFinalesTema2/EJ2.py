try:
    n = 0

    while n < 1:
        try:
            n = int(input("Introduce un número entero positivo: "))
            if n < 1:
                print("Error: tiene que ser mayor o igual que 1")
        except ValueError:
            print("Error: tienes que escribir un número entero")

    for i in range(1, n + 1):
        print(i)

except KeyboardInterrupt:
    print("\nPrograma interrumpido. Hasta luego")