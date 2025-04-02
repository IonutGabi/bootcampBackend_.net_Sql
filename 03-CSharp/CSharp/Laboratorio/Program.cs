namespace Laboratorio
{

    public class Patient
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Sintaxis sintaxis = new Sintaxis();
            sintaxis.PrimerEjercicio();

            Excepciones excepciones = new Excepciones();
            excepciones.AdivinarNumero();

            SlotMachine machine1 = new SlotMachine();
            machine1.Menu();

            Linq linq = new Linq();
            linq.PrimerEjercicio();


        }


    }
}
