using CSWork18_5.Interfaces;
using CSWork18_5.Models;
using CSWork18_5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CSWork18_5.Presentations;

public class ListPresentation
{

    private IOrganismList _list;
    private IOrganismListView _view;
    public ListPresentation() 
    {
        _list = new OrganismsList();
        _list.InitList();

        _view = new WindowOrganismList();
        _view.Presentation = this;
        (_view as Window).Show();

        Show();
    }

    private void Show()
    {
        IOrganism organism = _list.GetCurrent();

        _view.ShowName(organism.Name);
        _view.ShowDesc(organism.Description);
        _view.ShowType(organism.Type);
        _view.ShowObject(organism);
    }

    public void Prev()
    {
        _list.Prev();
        Show();
    }

    public void Next()
    {
        _list.Next();
        Show();
    }

    public void AddNewAnimal(Types Type, string Name, string Desc)
    {
        _list.AddNewAnimal(Type, Name, Desc);
    }
}
