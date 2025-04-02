namespace Laboratorio
{
    internal class POO
    {

    }
        public class SlotMachine
        {
            private int CountCoins { get; set; }
            private bool FirstSlot { get; set; }
            private bool SecondSlot { get; set; }
            private bool ThirdSlot { get; set; }
            private bool Exit {  get; set; }

            public SlotMachine()
            {
                CountCoins = 0;
                Exit = false;
            }

            private void Play()
            {
                CountCoins++;

                Random random = new Random();

                FirstSlot = random.NextDouble() < 0.5;
                SecondSlot = random.NextDouble() < 0.5;
                ThirdSlot = random.NextDouble() < 0.5;

                if (FirstSlot && SecondSlot && ThirdSlot)
                {
                    Console.WriteLine($"Congratulations!!! You won {CountCoins} coins!!");
                    CountCoins = 0;
                } else
                {
                    Console.WriteLine("Good luck next time!!");
                }
            }

            public void Menu()
            {
            while (!Exit)
            {
                Console.Clear();
                Console.WriteLine("=== Menú de la App ===");
                Console.WriteLine("1. Opción 1: Jugar");
                Console.WriteLine("2. Opción 2: Salir");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Play();
                        break;

                    case "2":
                        Console.WriteLine("Saliendo de la aplicación...");
                        Exit = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Prueba de nuevo.");
                        break;
                }

                if (!Exit)
                {
                    Console.WriteLine("Pulsa Enter para continuar...");
                    Console.ReadLine();

                }
            }
        }
        }
}
