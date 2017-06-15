using TargetFramework;

namespace NetStandard
{
    public interface INetStandard10 : ITargetFramework
    {
        int Add(int x, int y);
        int Substract(int x, int y);
    }

    public interface INetStandard11 : INetStandard10
    {
        int Multiply(int x, int y);
        int Divide(int x, int y);
    }

    public interface INetStandard12 : INetStandard11
    {
        double Power(int x, int y);
    }

    public interface INetStandard13 : INetStandard12
    {
        double SquareRoot(int x);

    }

    public interface INetStandard14 : INetStandard13
    {
        double Sin(int x);
        double Cos(int x);
    }

    public interface INetStandard15 : INetStandard14
    {
    }

    public interface INetStandard16 : INetStandard15
    {
    }

    public interface INetStandard20 : INetStandard16
    {
        double Log(int x);
        double Log10(int x);
    }
}
