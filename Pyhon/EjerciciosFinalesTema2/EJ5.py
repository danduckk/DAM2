expresion = input("Escribe una expresión matemática: ")

try:
    resultado = eval(expresion)
    print(resultado)
except SyntaxError:
    print("La expresión está mal escrita.")