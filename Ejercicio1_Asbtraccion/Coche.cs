namespace Ejercicio1_Asbtraccion
{
    public class Coche : MedioTransporte
    {
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
