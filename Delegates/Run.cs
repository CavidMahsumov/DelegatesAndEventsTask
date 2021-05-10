using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Run
    {
        public void RunFunc(Func myFunc,string word)
        {
            myFunc.Invoke(word);
        }
    }
}
