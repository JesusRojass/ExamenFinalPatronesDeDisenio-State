using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal{
    public class StateNoTarjeta : StateCajero{
        public void InsertarTarjeta(){
            System.Console.WriteLine("Leyendo tarjeta...");
        }
        public void SacarTarjeta(){
            System.Console.WriteLine("No puedes sacar una tarjeta que no esta insertada");
        }
        public void EntrarCajero(){
            System.Console.WriteLine("Introduce una tarjeta para iniciar");
        }
        public void SacarDinero(){
            System.Console.WriteLine("Introduce una tarjeta para sacar dinero");
        }
    }
}