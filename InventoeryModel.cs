using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class InventoeryModel
    {
        public TypesOfRice typesOfRice;
        public TypesOfPuslses typesOfPulses;
        public TypesOfWheat typesOfWheat;

    }

    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPuslses
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}
    

