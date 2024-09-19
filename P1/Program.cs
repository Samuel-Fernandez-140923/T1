internal class Program
{
    private static void Main(string[] args)
    {
        Double v=0, ga,añ=0,sub,sut1,im=0,co=0,sut2;
        string no;
        Console.WriteLine("Nombre del trabajador:");
        no= Console.ReadLine();
        Console.WriteLine("Años en la empresa:");
        añ=double.Parse(Console.ReadLine());
        Console.WriteLine("Sueldo bruto:");
        sub= double.Parse(Console.ReadLine());
        Console.WriteLine("Ventas realizadas:");
        v= double.Parse(Console.ReadLine());
        if (v <= 600)
        {
            co = v * 0.05;
        }else if (v >600 && v <= 3000)
        {
            co = v * 0.07;
        }else if(v > 3000)
        {
            co = (v * 0.06)+300;
        }
        sut1=sub+co;
        if (añ<=3) 
        {
            im = sut1 * 0.065;
        }else if (añ >= 4) 
        {
            im = sut1 * 0.045;

        }
        sut2 = sut1-im;
        Console.WriteLine($"{no}");
        Console.WriteLine($"Comision de ventas es {co}");
        Console.WriteLine($"impuestos {im}");
        Console.WriteLine($"Sueldo total{sut2}");


    }
}