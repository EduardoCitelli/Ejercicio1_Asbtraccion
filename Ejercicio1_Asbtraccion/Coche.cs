namespace Ejercicio1_Asbtraccion
{
    public class Coche : MedioTransporte
    {
        //Constructor por defecto (todas las clases lo tienen pero no se ve)
        public Coche()
        {
        }

        //Constructor con 1 parametro de tipo entero para definir el año de fabricación
        public Coche(int anioFabricacion)
        {
            AnioFabricacion = anioFabricacion;
        }

        //Constructor con 2 parametros de tipo entero para definir el año de fabricación y capacidad
        public Coche(int anioFabricacion, int capacidad)
        {
            AnioFabricacion = anioFabricacion;
            Capacidad = capacidad;
        }

        public override string Arrancar()
        {
            return "Enciendo el motor y salgo";
        }

        public override string Detener()
        {
            return "Piso el freno";
        }
    }
}
