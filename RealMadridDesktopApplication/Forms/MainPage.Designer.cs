namespace RealMadridDesktopApplication.Forms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            pictureBox1 = new PictureBox();
            buttonAddNewPlayer = new Button();
            buttonShowAllPlayers = new Button();
            buttonAddEmployee = new Button();
            buttonShowEmployees = new Button();
            labelRealMadridFoundation = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // buttonAddNewPlayer
            // 
            buttonAddNewPlayer.Location = new Point(223, 251);
            buttonAddNewPlayer.Name = "buttonAddNewPlayer";
            buttonAddNewPlayer.Size = new Size(200, 40);
            buttonAddNewPlayer.TabIndex = 2;
            buttonAddNewPlayer.Text = "Add player";
            buttonAddNewPlayer.UseVisualStyleBackColor = true;
            buttonAddNewPlayer.Click += buttonAddNewPlayer_Click;
            // 
            // buttonShowAllPlayers
            // 
            buttonShowAllPlayers.Location = new Point(508, 251);
            buttonShowAllPlayers.Name = "buttonShowAllPlayers";
            buttonShowAllPlayers.Size = new Size(200, 40);
            buttonShowAllPlayers.TabIndex = 3;
            buttonShowAllPlayers.Text = "Show players";
            buttonShowAllPlayers.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(223, 346);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(200, 40);
            buttonAddEmployee.TabIndex = 4;
            buttonAddEmployee.Text = "Add employee";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonShowEmployees
            // 
            buttonShowEmployees.Location = new Point(508, 346);
            buttonShowEmployees.Name = "buttonShowEmployees";
            buttonShowEmployees.Size = new Size(200, 40);
            buttonShowEmployees.TabIndex = 5;
            buttonShowEmployees.Text = "Show employees";
            buttonShowEmployees.UseVisualStyleBackColor = true;
            // 
            // labelRealMadridFoundation
            // 
            labelRealMadridFoundation.AutoSize = true;
            labelRealMadridFoundation.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelRealMadridFoundation.Location = new Point(223, 149);
            labelRealMadridFoundation.Name = "labelRealMadridFoundation";
            labelRealMadridFoundation.Size = new Size(485, 35);
            labelRealMadridFoundation.TabIndex = 8;
            labelRealMadridFoundation.Text = "Real Madrid Foundation Program";
            // 
            // MainPage
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
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainPage";
            Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonAddNewPlayer;
        private Button buttonShowAllPlayers;
        private Button buttonAddEmployee;
        private Button buttonShowEmployees;
        private Label labelRealMadridFoundation;
    }
}