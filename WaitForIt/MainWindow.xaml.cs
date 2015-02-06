using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WaitForIt.Model;

namespace WaitForIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Event> Events;

        public MainWindow()
        {
            Events = new ObservableCollection<Event>();
            Events.Add(new Event("New Year's Eve", "12/31/2015"));
            InitializeComponent();
            CountdownList.DataContext = Events;
        }
    }
}
