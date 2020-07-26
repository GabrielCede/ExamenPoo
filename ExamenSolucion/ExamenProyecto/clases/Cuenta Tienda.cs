using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenProyecto.clases
{
    public class Cuenta_Tienda:Cuenta_Bancaria
    {
        public Cuenta_Tienda()
        {
            this.Nivel_Tienda =0;
                
        }
        public int Nivel_Tienda { get; set; }

        public void Calculo_Ctienda(int Porcentaje_Ganado)
        {
            switch (this.Nivel_Tienda)
            {
                case 1:
                    Porcentaje_Ganado = 5;
                    Console.WriteLine("El porcentaje ganado es de"+Porcentaje_Ganado+"%");
                    break;
                case 2:
                    Porcentaje_Ganado = 10;
                    Console.WriteLine("El porcentaje ganado es de" + Porcentaje_Ganado + "%");
                    break;
                case 3:
                    Porcentaje_Ganado = 15;
                    Console.WriteLine("El porcentaje ganado es de" + Porcentaje_Ganado + "%");
                    break;

                default:
                    Console.WriteLine("No está dentro del rango");
                    break;
            }
        }
    }
}
