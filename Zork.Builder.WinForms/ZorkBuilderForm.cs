using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zork.Builder.WinForms.ViewModels;

namespace Zork.Builder.WinForms
{
    public partial class ZorkBuilderForm : Form
    {
        public static string AssemblyTitle = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
        private WorldViewModel ViewModel
        {
            get => mViewModel;
            set
            {
                if (mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            }
        }

        private WorldViewModel mViewModel;
        private bool mIsWorldLoaded;

        private bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            set
            {
                mIsWorldLoaded = value;
                gameSettingsTabControl.Enabled = mIsWorldLoaded;
            }
        }

        public ZorkBuilderForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
            IsWorldLoaded = false;
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO
                    Room room = new Room { Name = addRoomForm.RoomName };
                    ViewModel.Rooms.Add(room);
                }
            }
        }

        private void BindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void DeleteRoomButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this room?", AssemblyTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ViewModel.Rooms.Remove((Room)roomslistBox.SelectedItem);
                roomslistBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
            }
        }

        private void RoomslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomslistBox.SelectedItem != null;
        }

        private void OpenGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
                ViewModel.World = ViewModel.Game.World;
                IsWorldLoaded = true;
            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }

        private void SaveGameAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.Filename = saveFileDialog.FileName;
                ViewModel.SaveWorld();
            }
        }
    }
}
