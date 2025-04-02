namespace Laboratorio
{
    internal class Excepciones
    {

        public class NumeroMayorOMenorException: Exception
        {
            public NumeroMayorOMenorException(string message) : base(message) 
            {

            }
        }

        public void AdivinarNumero()
        {
                int intentos = 10;
                var numeroAAdivinar = new Random().Next(1, 10);
                Console.WriteLine($"Intentos restantes: {intentos}");
                Console.WriteLine("Introduce un número:");
                int numero = Convert.ToInt32(Console.ReadLine());

            while (numero != numeroAAdivinar && intentos != 0)
            {
                try
                {
                    if (numero <= 0)
                    {
                        throw new ArgumentOutOfRangeException("numero", "El número no puede ser negativo o igual a 0");
                    }

                    if (numero > numeroAAdivinar)
                    {
                        intentos--;
                        throw new NumeroMayorOMenorException("El número es menor");

                    } else if (numero < numeroAAdivinar)
                    {
                        intentos--;
                        throw new NumeroMayorOMenorException("El número es mayor");
                    }
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Por favor, ingrese un número");
                }
                catch (ArgumentOutOfRangeException ae)
                {
                    Console.WriteLine("Mensaje de error: `{0}`", ae.Message);
                }
                catch (NumeroMayorOMenorException ne)
                {
                    Console.WriteLine(ne.Message);
                }
                        
                Console.WriteLine($"Intentos restantes: {intentos}");
                Console.WriteLine("Introduce un número:");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            if (numero == numeroAAdivinar && intentos != 0)
            {
               Console.WriteLine($"Enhorabuena!! has adivinado el número");
            } else if (intentos == 0)
            {
                Console.WriteLine($"Lo siento, se te han acabado los intentos, el número era: {numeroAAdivinar}");
            }
        }
    }
}
