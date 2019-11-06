using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    public partial class AddRoomForm : Form
    {
        public string RoomName
        {
            get => addRoomTextBox.Text;
            set => addRoomTextBox.Text = value;
        }
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void AddRoomTextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(RoomName);
        }
    }
}
