using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_diseños.Factory
{
    public interface ConcretoProductA2 : IAbstractProductA
    {
        public string MetodoA() {
            return "Desde MetodoA en ConcretoProductoA2";
        }
    }
}
