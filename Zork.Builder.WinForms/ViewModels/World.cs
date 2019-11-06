using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms.ViewModels
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string StartingLocation { get; set; }

        public List<Room> Rooms { get; set; }


        public World()
        {
            StartingLocation = "";
            Rooms = new List<Room>();
        }
    }
}
