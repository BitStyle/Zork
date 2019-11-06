namespace Zork.Builder.WinForms
{
    partial class AddRoomForm
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
            this.addRoomNameLabel = new System.Windows.Forms.Label();
            this.addRoomTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addRoomNameLabel
            // 
            this.addRoomNameLabel.AutoSize = true;
            this.addRoomNameLabel.Location = new System.Drawing.Point(13, 13);
            this.addRoomNameLabel.Name = "addRoomNameLabel";
            this.addRoomNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addRoomNameLabel.TabIndex = 0;
            this.addRoomNameLabel.Text = "&Name:";
            // 
            // addRoomTextBox
            // 
            this.addRoomTextBox.Location = new System.Drawing.Point(16, 30);
            this.addRoomTextBox.Name = "addRoomTextBox";
            this.addRoomTextBox.Size = new System.Drawing.Size(231, 20);
            this.addRoomTextBox.TabIndex = 1;
            this.addRoomTextBox.TextChanged += new System.EventHandler(this.AddRoomTextBox_TextChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(79, 56);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(172, 56);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // AddRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 85);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.addRoomTextBox);
            this.Controls.Add(this.addRoomNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.ShowIcon = false;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addRoomNameLabel;
        private System.Windows.Forms.TextBox addRoomTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}