namespace Zork.Builder.WinForms
{
    partial class ZorkBuilderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomDescriptionLabel = new System.Windows.Forms.Label();
            this.roomDetailsLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.eastNeighborLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.southNeightborLabel = new System.Windows.Forms.Label();
            this.northNeighborComboBox = new System.Windows.Forms.ComboBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.northNeighborLabel = new System.Windows.Forms.Label();
            this.neighborsLabel = new System.Windows.Forms.Label();
            this.roomNameLabel = new System.Windows.Forms.Label();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomslistBox = new System.Windows.Forms.ListBox();
            this.roomslistView = new System.Windows.Forms.ListView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gameSettingsTabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gameSettingsTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openGameToolStripMenuItem.Text = "&Open Game...";
            this.openGameToolStripMenuItem.Click += new System.EventHandler(this.OpenGameToolStripMenuItem_Click);
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameAsToolStripMenuItem.Text = "&Save Game &As...";
            this.saveGameAsToolStripMenuItem.Click += new System.EventHandler(this.SaveGameAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.closeToolStripMenuItem.Text = "E&xit";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomDescriptionTextBox);
            this.tabPage2.Controls.Add(this.roomDescriptionLabel);
            this.tabPage2.Controls.Add(this.roomDetailsLabel);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.eastNeighborLabel);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.southNeightborLabel);
            this.tabPage2.Controls.Add(this.northNeighborComboBox);
            this.tabPage2.Controls.Add(this.nameTextBox);
            this.tabPage2.Controls.Add(this.northNeighborLabel);
            this.tabPage2.Controls.Add(this.neighborsLabel);
            this.tabPage2.Controls.Add(this.roomNameLabel);
            this.tabPage2.Controls.Add(this.deleteRoomButton);
            this.tabPage2.Controls.Add(this.addRoomButton);
            this.tabPage2.Controls.Add(this.roomslistBox);
            this.tabPage2.Controls.Add(this.roomslistView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(228, 279);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(493, 109);
            this.roomDescriptionTextBox.TabIndex = 17;
            // 
            // roomDescriptionLabel
            // 
            this.roomDescriptionLabel.AutoSize = true;
            this.roomDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roomDescriptionLabel.Location = new System.Drawing.Point(224, 264);
            this.roomDescriptionLabel.Name = "roomDescriptionLabel";
            this.roomDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.roomDescriptionLabel.TabIndex = 16;
            this.roomDescriptionLabel.Text = "Description:";
            // 
            // roomDetailsLabel
            // 
            this.roomDetailsLabel.AutoSize = true;
            this.roomDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.roomDetailsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roomDetailsLabel.Location = new System.Drawing.Point(224, 234);
            this.roomDetailsLabel.Name = "roomDetailsLabel";
            this.roomDetailsLabel.Size = new System.Drawing.Size(58, 20);
            this.roomDetailsLabel.TabIndex = 15;
            this.roomDetailsLabel.Text = "Details";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.roomsBindingSource;
            this.comboBox3.DisplayMember = "Description";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(266, 200);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(213, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(224, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "West:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.roomsBindingSource;
            this.comboBox2.DisplayMember = "Description";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(266, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "Description";
            // 
            // eastNeighborLabel
            // 
            this.eastNeighborLabel.AutoSize = true;
            this.eastNeighborLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eastNeighborLabel.Location = new System.Drawing.Point(224, 165);
            this.eastNeighborLabel.Name = "eastNeighborLabel";
            this.eastNeighborLabel.Size = new System.Drawing.Size(31, 13);
            this.eastNeighborLabel.TabIndex = 11;
            this.eastNeighborLabel.Text = "East:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.roomsBindingSource;
            this.comboBox1.DisplayMember = "Description";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "Description";
            // 
            // southNeightborLabel
            // 
            this.southNeightborLabel.AutoSize = true;
            this.southNeightborLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.southNeightborLabel.Location = new System.Drawing.Point(224, 128);
            this.southNeightborLabel.Name = "southNeightborLabel";
            this.southNeightborLabel.Size = new System.Drawing.Size(38, 13);
            this.southNeightborLabel.TabIndex = 9;
            this.southNeightborLabel.Text = "South:";
            // 
            // northNeighborComboBox
            // 
            this.northNeighborComboBox.DataSource = this.roomsBindingSource;
            this.northNeighborComboBox.DisplayMember = "Description";
            this.northNeighborComboBox.FormattingEnabled = true;
            this.northNeighborComboBox.Location = new System.Drawing.Point(266, 89);
            this.northNeighborComboBox.Name = "northNeighborComboBox";
            this.northNeighborComboBox.Size = new System.Drawing.Size(213, 21);
            this.northNeighborComboBox.TabIndex = 8;
            this.northNeighborComboBox.ValueMember = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(228, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(251, 20);
            this.nameTextBox.TabIndex = 7;
            // 
            // northNeighborLabel
            // 
            this.northNeighborLabel.AutoSize = true;
            this.northNeighborLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.northNeighborLabel.Location = new System.Drawing.Point(224, 92);
            this.northNeighborLabel.Name = "northNeighborLabel";
            this.northNeighborLabel.Size = new System.Drawing.Size(36, 13);
            this.northNeighborLabel.TabIndex = 6;
            this.northNeighborLabel.Text = "North:";
            // 
            // neighborsLabel
            // 
            this.neighborsLabel.AutoSize = true;
            this.neighborsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.neighborsLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.neighborsLabel.Location = new System.Drawing.Point(223, 55);
            this.neighborsLabel.Name = "neighborsLabel";
            this.neighborsLabel.Size = new System.Drawing.Size(81, 20);
            this.neighborsLabel.TabIndex = 5;
            this.neighborsLabel.Text = "Neighbors";
            // 
            // roomNameLabel
            // 
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roomNameLabel.Location = new System.Drawing.Point(224, 7);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.roomNameLabel.TabIndex = 4;
            this.roomNameLabel.Text = "Name:";
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteRoomButton.Location = new System.Drawing.Point(130, 365);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 3;
            this.deleteRoomButton.Text = "&Delete...";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addRoomButton.Location = new System.Drawing.Point(8, 365);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // roomslistBox
            // 
            this.roomslistBox.DataSource = this.roomsBindingSource;
            this.roomslistBox.DisplayMember = "Description";
            this.roomslistBox.FormattingEnabled = true;
            this.roomslistBox.Location = new System.Drawing.Point(4, 4);
            this.roomslistBox.Name = "roomslistBox";
            this.roomslistBox.Size = new System.Drawing.Size(213, 355);
            this.roomslistBox.TabIndex = 1;
            this.roomslistBox.ValueMember = "Description";
            this.roomslistBox.SelectedIndexChanged += new System.EventHandler(this.RoomslistBox_SelectedIndexChanged);
            // 
            // roomslistView
            // 
            this.roomslistView.HideSelection = false;
            this.roomslistView.Location = new System.Drawing.Point(4, 4);
            this.roomslistView.Name = "roomslistView";
            this.roomslistView.Size = new System.Drawing.Size(213, 389);
            this.roomslistView.TabIndex = 0;
            this.roomslistView.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gameSettingsTabControl
            // 
            this.gameSettingsTabControl.Controls.Add(this.tabPage1);
            this.gameSettingsTabControl.Controls.Add(this.tabPage2);
            this.gameSettingsTabControl.Location = new System.Drawing.Point(0, 27);
            this.gameSettingsTabControl.Name = "gameSettingsTabControl";
            this.gameSettingsTabControl.SelectedIndex = 0;
            this.gameSettingsTabControl.Size = new System.Drawing.Size(800, 422);
            this.gameSettingsTabControl.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Game Files (*json)|*.json";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Game Files (*json)|*.json";
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.ViewModels.WorldViewModel);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // ZorkBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameSettingsTabControl);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZorkBuilderForm";
            this.Text = "Zork Builder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gameSettingsTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl gameSettingsTabControl;
        private System.Windows.Forms.ListBox roomslistBox;
        private System.Windows.Forms.ListView roomslistView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label northNeighborLabel;
        private System.Windows.Forms.Label neighborsLabel;
        private System.Windows.Forms.Label roomNameLabel;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.Label roomDescriptionLabel;
        private System.Windows.Forms.Label roomDetailsLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label eastNeighborLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label southNeightborLabel;
        private System.Windows.Forms.ComboBox northNeighborComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
    }
}

