using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenProyecto.clases
{
    public class Cuenta_Empresarial:Cuenta_Bancaria
    {
        public Cuenta_Empresarial()
        {

        }
        
        public void Calculo_Cempresarial(int Porcentaje)
        {
            if (this.Saldo_Cuenta > 1000)
            {
                Porcentaje = 10;
                Console.WriteLine("El porcentaje es:"+Porcentaje+"%");

            }
            else
            {
                Porcentaje = 5;
                Console.WriteLine("El porcentaje es:" + Porcentaje + "%");
            }
        }

	}
    
}
