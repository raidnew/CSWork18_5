using CSWork18_5.Interfaces;
using CSWork18_5.Models;
using CSWork18_5.Models.Organisms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CSWork18_5.Fabrics;

public class OrganismFabric
{
    public static IOrganism GetOranism(Types type, string name, string desc)
    {
        IOrganism organism;
        switch (type)
        {
            case Types.Animal:
                organism = new Mammal(type, name, desc);
                break;
            case Types.Bird:
                organism = new Bird(type, name, desc);
                break;
            case Types.Fish:
                organism = new Amhibia(type, name, desc);
                break;
            case Types.None:
            default:
                organism = new NullOrganism();
                break;
        }
        return organism;
    }
}
