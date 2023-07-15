namespace Ejercicio1_Asbtraccion
{
    //Define una clase abstracta llamada "MedioTransporte" con métodos abstractos como
    //"Arrancar" y "Detener".
    //Luego, crea clases derivadas como "Coche", "Avión" y "Barco"
    //que hereden de "MedioTransporte" e implementen los métodos de acuerdo con las características
    //de cada medio de transporte.
    //Crear 1 instancia de cada medio de transporte,
    //Definir sus propiedades/atributos
    //Mostrar en pantallas los resultados de sus metodos

    internal class Program
    {
        static void Main(string[] args)
        {
            //inicializamos con el constructo dentro de la clase coche
            //donde recibe los 2 parametros para el anio de fabricacion y capacidad
            Coche coche = new Coche(1990, 5);

            Avion avion = new Avion()
            {
                AnioFabricacion = 2005,
                Capacidad = 200
            };

            Barco barco = new Barco()
            {
                AnioFabricacion = 2000,
                Capacidad = 500
            };

            var arrancarCoche = coche.Arrancar();
            var detenerCoche = coche.Detener();

            Console.WriteLine($"El coche arranca: {arrancarCoche}");
            Console.WriteLine($"El coche se detiene: {detenerCoche}");
        }
    }
}