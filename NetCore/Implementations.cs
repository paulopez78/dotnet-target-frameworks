
using System;
using NetStandard;

namespace NetCore
{
    public class NetCore10 : INetCore10
    {
        public int Add(int x, int y) => x + y;
        public int Substract(int x, int y) => x - y;

        public int Multiply(int x, int y) => x * y;
        public int Divide(int x, int y) => x/y;

        public double Power(int x, int y) => Math.Pow(x, y);

        public double SquareRoot(int x) => Math.Sqrt(x);

        public double Sin(int x) => Math.Sin(x);
        public double Cos(int x) => Math.Cos(x);
    }

    public class NetCore11 : NetCore10, INetCore11
    {
    }

    public class NetCore20 : NetCore11, INetCore20
    {
        public double Log(int x) => Math.Log(x);
        public double Log10(int x) => Math.Log10(x);
    }
}
