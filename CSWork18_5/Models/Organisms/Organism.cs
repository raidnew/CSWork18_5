using CSWork18_5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Models.Organisms;

public class Organism : BaseOrganism, ISerializable
{

    public Organism() {}
    public Organism(Types type, string name, string desc) : base(type, name, desc)
    { 
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        throw new NotImplementedException();
    }
}
