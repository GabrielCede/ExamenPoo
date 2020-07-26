using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenProyecto.clases
{
    public class Cuenta_Joven:Cuenta_Bancaria
    {
        public Cuenta_Joven()
        {
            
        }
        public void Calculo_Cjoven(decimal Resultado_Cjoven)
        {
            Resultado_Cjoven = this.Saldo_Cuenta + this.Porcentaje_Interes;
            
            
        }
       
    }
}
