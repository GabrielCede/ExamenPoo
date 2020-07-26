using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenProyecto.clases
{
    public class Cuenta_Bancaria
    {
        public Cuenta_Bancaria()
        {

        }
        public string Numero_Cuenta { get; set; }

        //Tipo de Cuenta (Ahorro o Corriente)
        public string Tipo_Cuenta { get; set; }

        public string Titular_Cuenta { get; set; }

        public decimal Saldo_Cuenta { get; set; }

        public int Porcentaje_Interes { get; set; }

        //Lista

        public List<Cuenta_Bancaria> ListaDeCuentas = new List<Cuenta_Bancaria>();
    }
}
