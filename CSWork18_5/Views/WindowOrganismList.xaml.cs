using CSWork18_5.Interfaces;
using CSWork18_5.Models;
using CSWork18_5.Presentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CSWork18_5.Views
{
    /// <summary>
    /// Interaction logic for OrganismList.xaml
    /// </summary>
    public partial class WindowOrganismList : Window, IOrganismListView
    {
        public ListPresentation Presentation { get; set; }

        public WindowOrganismList()
        {
            InitializeComponent();
            AddTypes();
        }

        public void ShowDesc(string desc)
        {
            BioDesc.Text = desc;
        }

        public void ShowType(Types type)
        {
            BioType.Text = type.ToString();
        }

        public void ShowObject(IOrganism obj)
        {
            Object.Text = obj.ToString();
        }

        private void ButtonPrev_Click(object sender, RoutedEventArgs e)
        {
            Presentation.Prev();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            Presentation.Next();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Presentation.AddNewAnimal((Types)NewType.SelectedItem, NewName.Text, NewDesc.Text);
        }

        private void AddTypes()
        {
            NewType.Items.Add(Types.None);
            NewType.Items.Add(Types.Animal);
            NewType.Items.Add(Types.Fish);
            NewType.Items.Add(Types.Bird);

            NewType.SelectedItem = Types.None;
        }

    }
}
