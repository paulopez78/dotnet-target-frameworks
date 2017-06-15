using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCore;
using NetFramework;
using NetStandard;
using TargetFramework;

namespace MyApp
{
    class MyLib
    {
        private readonly INetStandard11 _targetFramework;

        public MyLib(ITargetFramework targetFramework) =>
            _targetFramework = (INetStandard11)targetFramework;

        public int ComplexAwesomeCalculation()
        {
            var addResult = _targetFramework.Add(2,3);
            var subsResult = _targetFramework.Substract(addResult, 1);
            var mulResult = _targetFramework.Multiply(subsResult, 2);
            
            return _targetFramework.Divide(mulResult, 2);
        }
    }
}
