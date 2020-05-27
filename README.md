# ExamenFinalPatronesDeDisenio-State
Realizar una aplicación que simule la funcionalidad de un cajero automático

# El cajero automático debe considerar los siguientes Estados:
-SinTarjeta
-TarjetaValidada
-EntregadeDinero
-FueraDeServicio

# Consideraciones para el Cajero Automático:
-El cajero deberá inicializarse con una cantidad de dinero por default de 5000 pesos.
-Cada que un cliente retire dinero el programa deberá validar si aún existe saldo en cajero.
-Los únicos pines validos para efectos de prueba serán 1234, 4321.
-El estado inicial del cajero es sin tarjeta. En este estado el cajero deberá solicitar el pin del usuario, hasta que ingreso uno correcto. Cuando el pin sea correcto el cajero deberá pasar al estado de TarjetaValida.
-Cuando se encuentre en el estado TarjetaValida, el cajero deberá solicitar al usuario el monto a retirar, y deberá preguntarle hasta que el usuario ingreso un monto válido.
-Si es posible retirar el dinero, cambiará al estatus EntregadeDinero, y deberá indicarle al usuario el monto retirado, y Regresar al estado de SinTrajeta.
-En caso de que el cajero quede sin saldo, cambiara al estatus EntregadeDinero, y deberá indicarle al usuario el monto retirado, pero como ya no hay fondos suficientes el cajero pasara al estado de FueraDeServicio.
