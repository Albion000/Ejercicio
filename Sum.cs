namespace Ejercicio.total
{
    public class Sum
    {
        public void total()
        {
            // declarar las variables
            int num1 = 0;
            int num2 = 0;   
            int Resultado = 0;

            //Solicitar el primer numero
            Console.Write("Ingrese el primer numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
            // solicitar el segundo numero
            Console.Write("Ingrese el segundo numero: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            // sumar los numeros
            Resultado = num1 + num2;

            //mostrar los resultados
            Console.WriteLine($" EL Resultado es: {Resultado:c}");

        }

    }
   
}
