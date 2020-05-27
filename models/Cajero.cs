using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinal{
    public class Cajero : StateCajero
    {
        public StateCajero stateCajero {get; set;}
        public Cajero(){
            stateCajero = new StateNoTarjeta();
        }
        public void InsertarTarjeta(){
            stateCajero.InsertarTarjeta();
            if (stateCajero is StateNoTarjeta){
                stateCajero = new StateValida();
            }
        }

        public void SacarTarjeta(){
            stateCajero.SacarTarjeta();
            if (stateCajero is StateValida || stateCajero is StateInsertada){
                stateCajero = new StateNoTarjeta();
            }
        }
        public void EntrarCajero(){
            stateCajero.EntrarCajero();
            if (stateCajero is StateValida){
                stateCajero = new StateInsertada();
            }
        }
        public void SacarDinero(){
            stateCajero.SacarDinero();
        }
    }
}