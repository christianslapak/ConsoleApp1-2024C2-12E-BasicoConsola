namespace ConsoleApp1_2024C2_12E_BasicoConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Persona p = new Persona();

            p.DNI = 12456889;
            p.Apellido = "Gonzales";
            p.Nombre = "Marcela";

            Console.WriteLine(p.MostrarDatos());

            Console.ReadKey();
        }
    }
}
