using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuanIgnacioRossiniEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double catetoA, catetoB;
            double superficie, hipotenusa, perimetro;

            Console.WriteLine("ingrese el primer cateto");
            catetoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el segundo cateto");
            catetoB = Convert.ToDouble(Console.ReadLine());

            superficie = catetoA * catetoB / 2;
            hipotenusa = Math.Sqrt(Math.Pow(catetoA,2)+Math.Pow(catetoB,2));
            perimetro = catetoA + catetoB + hipotenusa;

            Console.WriteLine($"la superficie del triangulo es {superficie}");
            Console.WriteLine($"el perimetro del triangulo es {perimetro}");
            Console.ReadLine();
        }
    }
}
