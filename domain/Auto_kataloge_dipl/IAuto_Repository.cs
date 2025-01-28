using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public interface IAuto_Repository
    {
        Auto_search[] GetAllByMarka_auto (string marka);
    }
}
