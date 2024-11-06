using CSWork18_5.Fabrics;
using CSWork18_5.Interfaces;
using CSWork18_5.Models.Organisms;
using System.Collections.Generic;
using System.Text.Json;

namespace CSWork18_5.Models;

public class OrganismsList : IOrganismList
{
    private List<IOrganism> _organismsList;
    private int _index;
    private FileStorage _fileStorage;

    internal class SavesOrganism
    {
        public Types Type { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public SavesOrganism()
        {

        }
        public SavesOrganism(Types type, string name, string desc)
        {
            Type = type;
            Name = name;
            Desc = desc;
        }
    }

    public OrganismsList() 
    {
    }

    public IOrganism GetCurrent()
    {
        if(_index < 0 || _index >= _organismsList.Count) return new NullOrganism();
        return _organismsList[_index];
    }

    public void InitList()
    {
        _index = 0;
        _organismsList = new List<IOrganism>();
        _fileStorage = new FileStorage("organizmes.dat");
        _fileStorage.OnFileLoaded += FileLoaded;
        _fileStorage.LoadFile();
    }

    public void Prev()
    {
        if (_organismsList.Count == 0) _index = 0;
        else  _index = (_index - 1 + _organismsList.Count) % _organismsList.Count;
    }

    public void Next()
    {
        if (_organismsList.Count == 0) _index = 0;
        else _index = (_index + 1) % _organismsList.Count;
    }

    public void AddNewAnimal(Types type, string name, string desc)
    {
        IOrganism newOrganism = OrganismFabric.GetOranism(type, name, desc);
        _fileStorage.AddString(JsonSerializer.Serialize(newOrganism));
        AddOrganismToList(newOrganism);
    }

    private void FileLoaded(List<string> typesString)
    {
        foreach (string str in typesString) 
        {
            SavesOrganism data = JsonSerializer.Deserialize<SavesOrganism>(str);
            AddOrganismToList(OrganismFabric.GetOranism(data.Type, data.Name, data.Desc));
        }
    }

    private void AddOrganismToList(IOrganism organism)
    {
        _organismsList.Add(organism);
    }

}
