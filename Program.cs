using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Crear un programa que simule una cuenta bancaria, con las siguientes características:

 * Crear una clase "CuentaBancaria" con los campos y métodos correspondientes *ver diagrama UML adjunto en la imagen*

 * El primer método que vemos en el diagrama es el constructor de la clase, que recibirá los argumentos que ahí se indican e inicializará a los campos de la clase.

 * El método "Deposito" se encarga de recibir una suma de dinero desde el exterior y la agregará al campo "saldo".

 * El método "Retiro" se encarga de extraer una suma de dinero del campo "saldo" dada desde el exterior (verificar que sea posible retirar la cantidad de dinero a partir del saldo que ya se encuentra en la cuenta.

 * El método "ConsultaSaldo" se encarga simplemente de mostrarnos el dinero que tenemos en nuestra cuenta bancaria.

 * El método "ToString" se encarga de mostrarnos la información del cliente (objeto).

 * En Main nos encargaremos de pedir los siguientes datos:
 * nombre, 
 * apellidos, 
 * dirección, 
 * rfc(en México el RFC es una clave que nos permite cumplir con nuestras obligaciones fiscales, ustedes pueden usar el similar de su país).
 * saldo inicial para depositar a la cuenta bancaria.

 * Todos esos datos serán enviados al constructor de la clase "CuentaBancaria" en el momento de instanciarla.

 * Después crearemos un menú que aparecerá mientras el usuario no decida salir (apoyarse de un Do-While), y contendrá las siguiente opciones:
 * Deposito
 * Retiro
 * Consultar Saldo
 * Mostrar información de la cuenta
 * Salir

 * Dependiendo de la opción que se escoja, mandar a llamar al método correspondiente de la clase y crear su lógica para que se pueda depositar o retirar dinero.

 * *NOTA* Es una tarea algo amplia en la que puede que surjan algunos problemas y preguntas, intenten resolverlo antes de ver mi vídeo de resolución, les deseo mucha suerte. Les dejo también el diagrama del método "Deposito" para que no estén tan perdidos.

 */
namespace TAREA_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string nombreAr, apellidoAr, direccionAr, rfcAr, saldoAr;
            int opc;
            bool repetir = true;

            //saludo
            Console.WriteLine("Bienvenidos al cajero automático!!");

            //solicitud de datos
            Console.Write("\nIngrese su nombre: ");
            nombreAr = Console.ReadLine();
            Console.Write("\nIngrese su apellido: ");
            apellidoAr = Console.ReadLine();
            Console.Write("\nIngrese su dirección (Pais, Provincia, Distrito, Corregimiento):\n");
            direccionAr = Console.ReadLine();
            Console.Write("\nIngrese su RFC: ");
            rfcAr = Console.ReadLine();
            Console.Write("\nIngrese su saldo: ");
            saldoAr =(Console.ReadLine());

            CuentaBancaria persona1 = new CuentaBancaria(nombreAr, apellidoAr, saldoAr, direccionAr, rfcAr);


            Console.Clear();

            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Menú!!\nSeleccione la opción que desee:");

                Console.WriteLine("1. Depósito\n2. Retiro\n3. Consultar Saldo\n4. Mostrar Información de la cuenta\n5. Salir");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad a depositar: ");
                        double montoAr = Convert.ToDouble(Console.ReadLine());
                        persona1.Deposito(montoAr);
                        break;
                    case 2:
                        //persona1.Retiro();
                        break;
                    case 3:
                        persona1.ConsultaSaldo();
                        break;
                    case 4:
                        persona1.ToString();
                        break;
                    case 5:
                        repetir = false;
                        break;
                }
            } while(repetir == true);

            Console.WriteLine("Gracias por participar");

        }
    }

    class CuentaBancaria
    {
        //Campos
        private string nombre, apellido, direccion, rfc;
        private double saldo;

        //Propiedades

        //Constructor
        public CuentaBancaria(string nombrePa, string apellidoPa, string saldoPa, string direccionPa, string rfcPa)
        {
            nombre = nombrePa;
            apellido = apellidoPa;
            direccion = direccionPa;
            rfc = rfcPa;
            saldo = Convert.ToDouble(saldoPa);
        }

        //Métodos
        public void Deposito(double montoPa)
        {
            saldo += montoPa;
            Console.WriteLine("Registro exitoso, nuevo saldo de: " + saldo);
        }

        public void Retiro(double montoPa)
        {

        }

        public void ConsultaSaldo()
        {
            
        }

        public override string ToString()
        {
            string mensaje = "";

            mensaje = "";

            return mensaje;
        }
    }
}
