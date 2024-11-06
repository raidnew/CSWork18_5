using CSWork18_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Models.Organisms;

public class NullOrganism : Organism
{
    public NullOrganism() : base(Types.None, "Unknown", "Unknown")
    {
    }
}
