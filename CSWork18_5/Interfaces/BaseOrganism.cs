using CSWork18_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Interfaces;

public abstract class BaseOrganism : IOrganism
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Types Type { get; set; }

    protected BaseOrganism(Types type, string name, string desc) 
    {
        Type = type;
        Name = name;
        Description = desc;
    }

    protected BaseOrganism() {}

}
