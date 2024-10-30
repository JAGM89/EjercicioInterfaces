using EjercicioInterfaces;

Operaciones operaciones = new Operaciones();

Console.WriteLine("Ingrese primer numero");
operaciones.N1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese segundo numero");
operaciones.N2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese tercer numero");
operaciones.N3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese X1");
operaciones.x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese X2");
operaciones.x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese Y1");
operaciones.y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese Y2");
operaciones.y2 = Convert.ToDouble(Console.ReadLine());






operaciones.imprimir();