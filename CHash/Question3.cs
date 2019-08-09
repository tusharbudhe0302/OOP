using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopcsharp
{
    class Question3
    {
        public int MethofF(int a,int b)
        {
            if (b == 0)
                return 0;
            if (b == 1)
                return a;
            return a+  MethofF(a, b - 1);
        }
    }
}
