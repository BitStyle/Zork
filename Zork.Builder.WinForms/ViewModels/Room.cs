using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zork.Builder.WinForms.ViewModels
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Direction Neighbors { get; set; }

        public Room()
        {
            Neighbors = new Direction();
        }
    }
}
