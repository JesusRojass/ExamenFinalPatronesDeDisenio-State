using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal{
    public class StateInsertada : StateCajero{
        private int dineroDisponible = 5000;
        private int cantidadARetirar;
        public void InsertarTarjeta(){
            System.Console.WriteLine("*RANURA DE INSERCCIÓN BLOQUEADA*");
        }
        public void SacarTarjeta(){
            System.Console.WriteLine("Gracias por usar el cajero, vuelva pronto");
        }
        public void EntrarCajero(){
            System.Console.WriteLine("Ya introdujiste tu NIP");
        }
        public void SacarDinero(){
            System.Console.WriteLine("Cuanto dinero deseas retirar?");
            cantidadARetirar = Convert.ToInt32(System.Console.ReadLine());
            if (cantidadARetirar < dineroDisponible){
                dineroDisponible -= cantidadARetirar;
                System.Console.WriteLine("Retiraste exitosamente: $" + cantidadARetirar + ", te queda un saldo de: $" + dineroDisponible);
            } else {
                System.Console.WriteLine("No tienes fondos suficientes");
            }
        }
    }
}