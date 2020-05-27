using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal{
    public class StateValida : StateCajero{
        private string nip;
        public void InsertarTarjeta(){
            System.Console.WriteLine("*RANURA DE INSERCCIÓN BLOQUEADA*");
        }
        public void SacarTarjeta(){
            System.Console.WriteLine("Gracias por usar el cajero, vuelva pronto");
        }
        public void EntrarCajero(){
            System.Console.WriteLine("Inserta tu NIP");
            nip = System.Console.ReadLine();
            if (nip == "1234" || nip == "4321"){
                System.Console.WriteLine("Nip valido, bienvenido");
            } else {
                System.Console.WriteLine("Error al validar, hasta luego");
            }
        }
        public void SacarDinero(){
            System.Console.WriteLine("Introduce tu NIP para sacar dinero");
        }
    }
}