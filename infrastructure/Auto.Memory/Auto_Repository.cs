using System;
using System.Linq;

namespace Auto.Memory
{
    public class Auto_Repository : IAuto_Repository
    {
        private readonly Auto_search[] autos = new[]
        {
            new Auto_search(1, "Mersedes"),
            new Auto_search(2, "Lada"),
            new Auto_search(3, "Audi")

        };
        public Auto_search[] GetAllByMarka_auto(string marka)
        {
            return autos.Where(auto => auto.Marka_auto.Contains(marka)).ToArray();
        }
    }
}
