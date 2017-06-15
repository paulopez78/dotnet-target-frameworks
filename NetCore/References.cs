using NetStandard;
using TargetFramework;

namespace NetCore
{
    public interface INetCore10 : INetStandard16, ITargetFramework
    {
    }

    public interface INetCore11 : INetCore10
    {
    }

    public interface INetCore20 : INetStandard20
    {
    }
}
