using System;
using MyLib;

namespace HelloWorld
{
    class Program
    {
        /**
         * Entry Point
         */
        static void Main(string[] args)
        {
            float x = 0;
            var rs = MyMath.PTBacNhat(20, 10, out x);

            if (rs == MyMath.KetQua.VoSoNghiem)
                Console.WriteLine("PT co vo so nghiem");
            else if (rs == MyMath.KetQua.VoNghiem)
                Console.WriteLine("PT vo nghiem");
            else
                Console.WriteLine($"PT co nghiem la {x}");

            Console.ReadKey();
        }

    }
}

