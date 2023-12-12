using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldFabricCore.Core.ParameterCore
{
    public class Set<DataType>
    {
        private List<DataType> elements;
        public Set()
        {
            elements = new List<DataType>();
        }
        public Set(Set<DataType> set)
        {

        }
    }
    public class LimitedSet<DataType>
    {

    }
}
