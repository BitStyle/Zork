using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms.ViewModels
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string WelcomeMessage { get; set; }

        public World World { get; set; }

        public Game()
        {
            WelcomeMessage = "Welcome to Zork!";
            World = new World();
        }
    }
}
