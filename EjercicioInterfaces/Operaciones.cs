

namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double N1;
        public double N2;
        public double N3;
        public double x1 , y1 ; // Punto 1
        public double x2 , y2 ; // Punto 2
        public double Area()
        {
            return N1 * N2 * N3;
        }

        public double Longitud()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double Potencias()
        {
            return Math.Pow(N1,N2);
        }

        public double RaizCuadrada()
        {
            return Math.Sqrt(N1);
        }

        public double Volumen()
        {
            return Math.Pow(N1, 3);
        }

        public void imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Longitud: {Longitud()}");
            Console.WriteLine($"Potencia: {Potencias()}");
            Console.WriteLine($"Raiz Cuadrada: {RaizCuadrada()}");
            Console.WriteLine($"Volumen: {Volumen()}");
        }
    }
}
