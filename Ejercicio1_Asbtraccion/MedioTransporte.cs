namespace Ejercicio1_Asbtraccion
{
    //clase
    public abstract class MedioTransporte
    {
        //atributos
        public int AnioFabricacion { get; set; }

        public int Capacidad { get; set; }

        //metodos
        public abstract string Arrancar();

        public abstract string Detener();
    }
}
