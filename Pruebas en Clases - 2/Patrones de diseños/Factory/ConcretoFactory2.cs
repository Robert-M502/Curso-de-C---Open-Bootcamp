using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseños.Factory
{
    public class ConcretoFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductoA()
        {
            return new ConcretoProductA2;
        }
        public IAbstractProductB CreateProductoB()
        {
            return new ConcretoProductB2;
        }
    }
}
