
using System;
using NetStandard;

namespace NetFramework
{
    public class NetFramework45 : INetFramework45
    {
        public int Add(int x, int y)
        {
            var acc = y;
            for (var i = 0; i < x; i++)
            {
                ++acc;
            }

            return acc;
        }

        public int Substract(int x, int y)
        {
            var acc = x;
            for (var i = 0; i < y; i++)
            {
                --acc;
            }

            return acc;
        }

        public int Divide(int x, int y)
        {
            int quotient = 0;
            while (x >= y)
            {
                x = Substract(x, y);
                quotient = Add(quotient,1);
            }
            return quotient;
        }

        public int Multiply(int x, int y)
        {
            var acc = 0;
            for (var i = 0; i < x; i++)
            {
                acc = acc + y;
            }

            return acc;
        }
    }

    public class NetFramework451 : NetFramework45, INetFramework451
    {
        public double Power(int x, int y)
        {
            var acc = y;
            for (var i = 0; i < x; i++)
            {
                acc = Multiply(acc, x);
            }

            return acc;
        }

        public double SquareRoot(int x) => Math.Sqrt(x);
    }

    public class NetFramework452 : NetFramework451, INetFramework452
    {
        public double Cos(int x) => Math.Cos(x);

        public double Sin(int x) => Math.Sin(x);
    }
    public class NetFramework46 : NetFramework452, INetFramework46
    {
    }

    public class NetFramework461 : NetFramework46, INetFramework461
    {
        public double Log(int x) => Math.Log(x);

        public double Log10(int x) => Math.Log10(x);

    }
}
