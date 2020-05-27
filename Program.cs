using System;
using System.Collections.Generic;
using System.Text;
using ExamenFinal;

namespace ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Cajero cajeroAutomatico = new Cajero();
            System.Console.WriteLine("MENU DESARROLLO CAJERO AUTOMATICO\n1) INSERTAR TARJETA\n2) INTRODUCIR NIP\n3)SACAR DINERO\n4)SACAR TARJETA\n5)SALIR\n");
            opc = Convert.ToInt32(System.Console.ReadLine());
            while(opc != 5){
                switch(opc){
                    case 1:
                        cajeroAutomatico.InsertarTarjeta();
                    break;
                    case 2:
                        cajeroAutomatico.EntrarCajero();
                    break;
                    case 3: 
                        cajeroAutomatico.SacarDinero();
                    break;
                    case 4:
                        cajeroAutomatico.SacarTarjeta();
                    break;
                    default:
                        System.Console.WriteLine("Opcion no valida intenta de nuevo");
                    break;
                }
                System.Console.WriteLine("MENU DESARROLLO CAJERO AUTOMATICO\n1) INSERTAR TARJETA\n2) INTRODUCIR NIP\n3)SACAR DINERO\n4)SACAR TARJETA\n5)SALIR\n");
                opc = Convert.ToInt32(System.Console.ReadLine());
            }
        }
    }
}
