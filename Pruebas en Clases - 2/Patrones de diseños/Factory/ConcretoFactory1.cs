using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseños.Factory
{
    public class ConcretoFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductoA() {
            return new ConcretoProductA1;
        }
        public IAbstractProductB CreateProductoB() {
            return new ConcretoProductB1;
        }
    }
}
