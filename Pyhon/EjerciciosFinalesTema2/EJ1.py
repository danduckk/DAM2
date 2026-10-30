seguir = "s"

while seguir == "s":
    try:
        num1 = float(input("Primer número: "))
        num2 = float(input("Segundo número: "))
        operacion = input("Operación (+, -, *, /): ")

        if operacion == "+":
            print("Resultado:", num1 + num2)
        elif operacion == "-":
            print("Resultado:", num1 - num2)
        elif operacion == "*":
            print("Resultado:", num1 * num2)
        elif operacion == "/":
            print("Resultado:", num1 / num2)
        else:
            print("Operación no válida")

    except ValueError:
        print("Error: tienes que escribir un número")
    except ZeroDivisionError:
        print("Error: no se puede dividir entre cero")

    seguir = input("¿Quieres hacer otra operación? (s/n): ")

print("Hasta luego")