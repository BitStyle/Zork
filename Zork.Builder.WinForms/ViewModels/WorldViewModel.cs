using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }

        public string WelcomeMessage { get; set; }

        public string StartingLocation { get; set; }

        public BindingList<Room> Rooms { get; set; }
        public World World
        {
            set
            {
                if (mWorld != value)
                {
                    mWorld = value;
                    if (mWorld != null)
                    {
                        StartingLocation = mWorld.StartingLocation;
                        Rooms = new BindingList<Room>(mWorld.Rooms);
                    }
                    else
                    {
                        StartingLocation = "";
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        public Game Game
        {
            set
            {
                if (mGame != value)
                {
                    mGame = value;
                    if (mGame != null)
                    {
                        WelcomeMessage = mGame.WelcomeMessage;
                        World = mWorld;
                    }
                    else
                    {
                        WelcomeMessage = "Welcome to Zork!";
                        World = mWorld;
                    }
                }
            }
        }

        public WorldViewModel(World world = null, Game game = null)
        {
            Game = game;
            World = world;
        }

        public void SaveWorld()
        {
            if (string.IsNullOrEmpty(Filename))
            {
                throw new InvalidProgramException("Filename expected.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };

            Game saveGame = new Game
            {
                WelcomeMessage = "Welcome to Zork",
                World = (mWorld != null) ? mWorld : new World { StartingLocation = "", Rooms = new List<Room> { new Room { Name = "Test Room", Description = "Test"} } }
            };

            using (StreamWriter streamWriter = new StreamWriter(Filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, saveGame);
            }
        }

        private World mWorld;
        private Game mGame;
    }

}
