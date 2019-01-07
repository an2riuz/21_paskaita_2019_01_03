using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_paskaita_2019_01_03
{
    class Proxy : IStuffDoer
    {
        private readonly IStuffDoer _realObject;
        public Proxy(IStuffDoer realObject)
        {
            _realObject = realObject;
        }
        public void DoStuff()
        {
            _realObject.DoStuff();
        }
    }
}
