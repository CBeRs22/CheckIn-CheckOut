import datetime

# Funciones
registros = {}

def check_in():
    empleado = input("Ingrese su Nombre y Apellido: ")
    hora_actual = datetime.datetime.now()
    registros[empleado] = {"check-in": hora_actual, "check-out": None}
    print(f"{empleado} ha realizado el check-in a las {hora_actual}")

def check_out():
    empleado = input("Ingrese su Nombre y Apellido: ")
    hora_actual = datetime.datetime.now()
    if empleado in registros and registros[empleado]["check-out"] is None:
        registros[empleado]["check-out"] = hora_actual
        print(f"{empleado} ha realizado el check-out a las {hora_actual}")
    else:
        print(f"{empleado} no ha realizado el check-in o ya ha realizado el check-out")

# Programa Principal
while True:
    print("1. Check-in")
    print("2. Check-out")
    print("3. Salir")
    opcion = input("Seleccione una opción: ")

    if opcion == "1":
        check_in()
    elif opcion == "2":
        check_out()
    elif opcion == "3":
        break
    else:
        print("Opción inválida. Por favor, seleccione nuevamente.")
