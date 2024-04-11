namespace RealMadridDesktopApplication.Forms
{
    partial class MainPageAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageAdmin));
            pictureBox = new PictureBox();
            buttonAddNewPlayer = new Button();
            buttonShowAllPlayers = new Button();
            buttonAddEmployee = new Button();
            buttonShowEmployees = new Button();
            labelRealMadridFoundation = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(4, 4);
            pictureBox.MaximumSize = new Size(186, 192);
            pictureBox.MinimumSize = new Size(166, 172);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(166, 192);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // buttonAddNewPlayer
            // 
            buttonAddNewPlayer.Anchor = AnchorStyles.None;
            buttonAddNewPlayer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddNewPlayer.Location = new Point(227, 255);
            buttonAddNewPlayer.MaximumSize = new Size(200, 55);
            buttonAddNewPlayer.MinimumSize = new Size(190, 45);
            buttonAddNewPlayer.Name = "buttonAddNewPlayer";
            buttonAddNewPlayer.Size = new Size(190, 45);
            buttonAddNewPlayer.TabIndex = 2;
            buttonAddNewPlayer.Text = "Add player";
            buttonAddNewPlayer.UseVisualStyleBackColor = true;
            buttonAddNewPlayer.Click += buttonAddNewPlayer_Click;
            // 
            // buttonShowAllPlayers
            // 
            buttonShowAllPlayers.Anchor = AnchorStyles.None;
            buttonShowAllPlayers.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonShowAllPlayers.Location = new Point(504, 255);
            buttonShowAllPlayers.MaximumSize = new Size(200, 55);
            buttonShowAllPlayers.MinimumSize = new Size(190, 45);
            buttonShowAllPlayers.Name = "buttonShowAllPlayers";
            buttonShowAllPlayers.Size = new Size(190, 45);
            buttonShowAllPlayers.TabIndex = 3;
            buttonShowAllPlayers.Text = "Show players";
            buttonShowAllPlayers.UseVisualStyleBackColor = true;
            buttonShowAllPlayers.Click += buttonShowAllPlayers_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Anchor = AnchorStyles.None;
            buttonAddEmployee.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAddEmployee.Location = new Point(227, 341);
            buttonAddEmployee.MaximumSize = new Size(200, 55);
            buttonAddEmployee.MinimumSize = new Size(190, 45);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(190, 45);
            buttonAddEmployee.TabIndex = 4;
            buttonAddEmployee.Text = "Add employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // buttonShowEmployees
            // 
            buttonShowEmployees.Anchor = AnchorStyles.None;
            buttonShowEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonShowEmployees.Location = new Point(504, 341);
            buttonShowEmployees.MaximumSize = new Size(200, 55);
            buttonShowEmployees.MinimumSize = new Size(190, 45);
            buttonShowEmployees.Name = "buttonShowEmployees";
            buttonShowEmployees.Size = new Size(190, 45);
            buttonShowEmployees.TabIndex = 5;
            buttonShowEmployees.Text = "Show employees";
            buttonShowEmployees.UseVisualStyleBackColor = true;
            buttonShowEmployees.Click += buttonShowEmployees_Click;
            // 
            // labelRealMadridFoundation
            // 
            labelRealMadridFoundation.Anchor = AnchorStyles.None;
            labelRealMadridFoundation.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelRealMadridFoundation.Location = new Point(227, 161);
            labelRealMadridFoundation.MaximumSize = new Size(600, 55);
            labelRealMadridFoundation.MinimumSize = new Size(485, 35);
            labelRealMadridFoundation.Name = "labelRealMadridFoundation";
            labelRealMadridFoundation.Size = new Size(485, 35);
            labelRealMadridFoundation.TabIndex = 8;
            labelRealMadridFoundation.Text = "Real Madrid Foundation Program";
            // 
            // MainPageAdmin
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(labelRealMadridFoundation);
            Controls.Add(buttonShowEmployees);
            Controls.Add(buttonAddEmployee);
            Controls.Add(buttonShowAllPlayers);
            Controls.Add(buttonAddNewPlayer);
            Controls.Add(pictureBox);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(900, 550);
            Name = "MainPageAdmin";
            Padding = new Padding(4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttonAddNewPlayer;
        private Button buttonShowAllPlayers;
        private Button buttonAddEmployee;
        private Button buttonShowEmployees;
        private Label labelRealMadridFoundation;
    }
}