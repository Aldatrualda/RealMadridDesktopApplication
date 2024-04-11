namespace RealMadridDesktopApplication.Forms
{
    partial class MainPageCoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageCoach));
            pictureBox = new PictureBox();
            labelRealMadridFoundation = new Label();
            buttonShowPlayer = new Button();
            buttonShowEmployees = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(4, 4);
            pictureBox.MaximumSize = new Size(186, 192);
            pictureBox.MinimumSize = new Size(166, 192);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(166, 192);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
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
            labelRealMadridFoundation.TabIndex = 1;
            labelRealMadridFoundation.Text = "Real Madrid Foundation Program";
            // 
            // buttonShowPlayer
            // 
            buttonShowPlayer.Anchor = AnchorStyles.None;
            buttonShowPlayer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonShowPlayer.Location = new Point(227, 255);
            buttonShowPlayer.MaximumSize = new Size(200, 55);
            buttonShowPlayer.MinimumSize = new Size(190, 45);
            buttonShowPlayer.Name = "buttonShowPlayer";
            buttonShowPlayer.Size = new Size(190, 45);
            buttonShowPlayer.TabIndex = 2;
            buttonShowPlayer.Text = "Show Players";
            buttonShowPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonShowEmployees
            // 
            buttonShowEmployees.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonShowEmployees.Location = new Point(504, 255);
            buttonShowEmployees.MaximumSize = new Size(200, 55);
            buttonShowEmployees.MinimumSize = new Size(190, 45);
            buttonShowEmployees.Name = "buttonShowEmployees";
            buttonShowEmployees.Size = new Size(190, 45);
            buttonShowEmployees.TabIndex = 3;
            buttonShowEmployees.Text = "Show Employees";
            buttonShowEmployees.UseVisualStyleBackColor = true;
            // 
            // MainPageCoach
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(buttonShowEmployees);
            Controls.Add(buttonShowPlayer);
            Controls.Add(labelRealMadridFoundation);
            Controls.Add(pictureBox);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(900, 550);
            Name = "MainPageCoach";
            Padding = new Padding(4);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelRealMadridFoundation;
        private Button buttonShowPlayer;
        private Button buttonShowEmployees;
    }
}