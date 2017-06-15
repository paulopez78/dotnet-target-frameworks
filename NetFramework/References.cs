
using NetStandard;
using TargetFramework;

namespace NetFramework
{
    public interface INetFramework45 : INetStandard10, INetStandard11, ITargetFramework
    {
    }

    public interface INetFramework451 : INetFramework45, INetStandard12
    {
    }

    public interface INetFramework452 : INetFramework451, INetStandard13
    {
    }

    public interface INetFramework46 : INetFramework452, INetStandard14
    {
    }

    public interface INetFramework461 : INetFramework46, INetStandard20
    {
    }
}
