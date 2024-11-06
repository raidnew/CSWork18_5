using CSWork18_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Interfaces;

public interface IOrganism
{
    public string Name { get; }

    public string Description { get; }

    public Types Type { get; }

}
