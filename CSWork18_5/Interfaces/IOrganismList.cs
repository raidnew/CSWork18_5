using CSWork18_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Interfaces;

public interface IOrganismList
{
    public void Next();
    public void Prev();
    public IOrganism GetCurrent();
    public void InitList();
    public void AddNewAnimal(Types type, string name, string desc);
}
