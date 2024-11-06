using CSWork18_5.Models;
using CSWork18_5.Presentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork18_5.Interfaces;

public interface IOrganismListView
{
    public ListPresentation Presentation { get; set; }
    public void ShowName(string name);
    public void ShowDesc(string desc);
    public void ShowType(Types type);
    public void ShowObject(IOrganism obj);
}
