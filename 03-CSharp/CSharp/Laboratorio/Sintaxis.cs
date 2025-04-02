namespace Laboratorio
{
    public class Sintaxis
    {
      public void PrimerEjercicio()
        {
            // 1- Solicite el nombre de una persona, su edad y el nombre de una ciudad. Después de solicitar estos datos deberá mostrar por pantalla el siguiente mensaje: Te llamas <nombre> y tienes <años> años. Bienvenido a <ciudad>
            Console.WriteLine("Introduce tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el nombre de una ciudad:");
            string ciudad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años. Bienvenido a {ciudad}");
        }

        public void SegundoEjercicio()
        {
            // 2 - Solicite dos números y diga cual es el mayor.

            Console.WriteLine("Introduce el primer número:");
            int primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine($"{primerNumero} es mayor que {segundoNumero}");
            }
            else
            {
                Console.WriteLine($"{segundoNumero} es mayor que {primerNumero}");
            }
        }

        public void TercerEjercicio()
        {
            // 3. Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo.

            Console.WriteLine("Introduce un día de la semana:");
            string diaSemana = Console.ReadLine();

            switch (diaSemana)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es fin de semana :(");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Es fin de semana!!!!! :)");
                    break;
                default:
                    Console.WriteLine("Error: Introduce un día de la semana");
                    break;
            }
        }

        public void CuartoEjercicio()
        {
            // 4 - Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.

            var numerosPares = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void QuintoEjercicio()
        {
            // 5 – Solicitar un número al usuario y generar un Array con N números aleatorios. Por ejemplo, si el usuario introduce 4, el resultado por consola debería ser: 23, 34, 234, 11
            Console.WriteLine("Introduce un número: ");
            int posiciones = Convert.ToInt32(Console.ReadLine());
            int min = 1, max = posiciones;

            int[] numerosAleatorios = new int[posiciones];

            var random = new Random();

            for (int i = 0; i < posiciones; i++)
            {
                numerosAleatorios[i] = random.Next(min, max + 1);
            }

            Console.WriteLine(string.Join(",", numerosAleatorios));
        }

        public void SextoEjercicio()
        {
            // 6 – Solicitar un número al usuario y un carácter. Crear una pirámide con N filas y el carácter solicitado. Por ejemplo, si el usuario introduce 5 y * el resultado por consola debería ser:

            Console.WriteLine("Introduce un número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un carácter:");
            char caracter = Convert.ToChar(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(new string(' ', numero - i) + new string(caracter, 2 * i - 1));
            }
        }
    }
}
