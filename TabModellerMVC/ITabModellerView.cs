using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabModellerMVC
{
    public interface ITabModellerView
    {

        void update(List<Bar> bars);

    }
}
