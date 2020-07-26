using ExamenProyecto.clases;
using System;
using System.Collections.Generic;


namespace ExamenProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de la clase padre
            //Cuenta_Bancaria cuentas = new Cuenta_Bancaria();
            //cuentas.ListaDeCuentas = new System.Collections.Generic.List<Cuenta_Bancaria>();


            //Se crean las cuentas de cada clase
            Cuenta_Joven cuenta_Joven = new Cuenta_Joven();
            Cuenta_Empresarial cuenta_Empresarial = new Cuenta_Empresarial();
            Cuenta_Tienda cuenta_Tienda = new Cuenta_Tienda();
            //menú de opciones

            Console.WriteLine("Eliga la cuenta a crear:\n"+
                "1-) Cuenta Joven\n" +
                "2.-) Cuenta Empresarial\n" +
                "3.-) Cuenta Tienda\n"
                );
            string opcion=Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("****CUENTA JOVEN****");

                    Console.WriteLine("Digite el Tipo de Cuenta a Crear");
                    cuenta_Joven.Tipo_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el nombre del titular de la cuenta");
                    cuenta_Joven.Titular_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el saldo");
                    cuenta_Joven.Saldo_Cuenta = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el porcentaje de interés");
                    cuenta_Joven.Porcentaje_Interes = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("DETALLES:\n");
                    Console.WriteLine("TIPO:"+cuenta_Joven.Tipo_Cuenta);
                    Console.WriteLine("TITULAR:" + cuenta_Joven.Titular_Cuenta);
                    Console.WriteLine("SALDO:" + cuenta_Joven.Saldo_Cuenta);
                    Console.WriteLine("PORCENTAJE DE INTERÉS:" + cuenta_Joven.Tipo_Cuenta+"%");

                    break;

                case "2":
                    Console.WriteLine("****CUENTA EMPRESARIAL****");

                    Console.WriteLine("Digite el Tipo de Cuenta a Crear");
                    cuenta_Empresarial.Tipo_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el nombre del titular de la cuenta");
                    cuenta_Empresarial.Titular_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el saldo");
                    cuenta_Empresarial.Saldo_Cuenta = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el porcentaje de interés");
                    cuenta_Empresarial.Porcentaje_Interes = int.Parse(Console.ReadLine());

                    Console.WriteLine("DETALLES:\n");
                    Console.WriteLine("TIPO:" + cuenta_Empresarial.Tipo_Cuenta);
                    Console.WriteLine("TITULAR:" + cuenta_Empresarial.Titular_Cuenta);
                    Console.WriteLine("SALDO:" + cuenta_Empresarial.Saldo_Cuenta);
                    Console.WriteLine("PORCENTAJE DE INTERÉS:" + cuenta_Empresarial.Porcentaje_Interes + "%");
                    break;

                case "3":
                    Console.WriteLine("****CUENTA TIENDA****");

                    Console.WriteLine("Digite el Tipo de Cuenta a Crear");
                    cuenta_Tienda.Tipo_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el nombre del titular de la cuenta");
                    cuenta_Tienda.Titular_Cuenta = Console.ReadLine();

                    Console.WriteLine("Digite el saldo");
                    cuenta_Tienda.Saldo_Cuenta = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Digite el nivel de la tienda");
                    cuenta_Tienda.Nivel_Tienda = int.Parse(Console.ReadLine());

                    Console.WriteLine("DETALLES:\n");
                    Console.WriteLine("TIPO:" + cuenta_Tienda.Tipo_Cuenta);
                    Console.WriteLine("TITULAR:" + cuenta_Tienda.Titular_Cuenta);
                    Console.WriteLine("SALDO:" + cuenta_Tienda.Saldo_Cuenta);
                    Console.WriteLine("Nivel:" + cuenta_Tienda.Nivel_Tienda);
                    break;
                default:
                    Console.WriteLine("Ha digitado un número fuera de las opciones dadas");
                    break;
            }

            //añadir cuentas a la lista
            //cuentas.ListaDeCuentas.Add(cuenta_Joven);
            

            //foreach (var Cuenta_Bancaria in cuentas.ListaDeCuentas)
            //{
                
            //    Console.WriteLine("Tipo de Cuenta:" + cuenta_Joven.Tipo_Cuenta +"\n"+ "Titular:"+ cuenta_Joven.Titular_Cuenta+"\n"+"Saldo:"+ cuenta_Joven.Saldo_Cuenta+ "\n"+"Porcentaje de Interès:"+ cuenta_Joven.Porcentaje_Interes);
            //}
            //Console.ReadKey();
            //cuentas.ListaDeCuentas.Add(cuenta_Empresarial);

            //foreach (var Cuenta_Bancaria in cuentas.ListaDeCuentas)
            //{
            //    Console.WriteLine("Tipo de Cuenta:" + cuenta_Empresarial.Tipo_Cuenta + "\n" + "Titular:" + cuenta_Empresarial.Titular_Cuenta + "\n" + "Saldo:" + cuenta_Empresarial.Saldo_Cuenta + "\n" + "Porcentaje de Interès:" + cuenta_Empresarial.Porcentaje_Interes);
            //}
            //Console.ReadKey();

            //cuentas.ListaDeCuentas.Add(cuenta_Tienda);

            //foreach (var Cuenta_Bancaria in cuentas.ListaDeCuentas)
            //{
            //    Console.WriteLine("Tipo de Cuenta:" + cuenta_Tienda.Tipo_Cuenta + "\n" + "Titular:" + cuenta_Tienda.Titular_Cuenta + "\n" + "Saldo:" + cuenta_Tienda.Saldo_Cuenta + "\n" + "Nivel de la Tienda:" + cuenta_Tienda.Nivel_Tienda);
            //}
            //Console.ReadKey();
        }
	
    }
}
