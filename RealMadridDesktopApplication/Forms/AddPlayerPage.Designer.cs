namespace RealMadridDesktopApplication.Forms
{
    partial class AddPlayerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayerPage));
            pictureBox1 = new PictureBox();
            labelAddPlayer = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelAdditionalName = new Label();
            labelBirthday = new Label();
            labelPhoneNumber = new Label();
            labelNationality = new Label();
            labelAddress = new Label();
            labelLocation = new Label();
            textBoxName = new TextBox();
            dateBirthday = new DateTimePicker();
            textBoxSurname = new TextBox();
            textBoxAdditionalName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxAddress = new TextBox();
            buttonNext = new Button();
            buttonBack = new Button();
            comboBoxLocation = new ComboBox();
            comboBoxNationality = new ComboBox();
            labelRequired = new Label();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelAddPlayer
            // 
            labelAddPlayer.AutoSize = true;
            labelAddPlayer.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddPlayer.Location = new Point(191, 149);
            labelAddPlayer.Name = "labelAddPlayer";
            labelAddPlayer.Size = new Size(252, 35);
            labelAddPlayer.TabIndex = 1;
            labelAddPlayer.Text = "Add New Player:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 225);
            labelName.Name = "labelName";
            labelName.Size = new Size(78, 24);
            labelName.TabIndex = 2;
            labelName.Text = "Name:*";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 275);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(109, 24);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Surname:*";
            // 
            // labelAdditionalName
            // 
            labelAdditionalName.AutoSize = true;
            labelAdditionalName.Location = new Point(12, 325);
            labelAdditionalName.Name = "labelAdditionalName";
            labelAdditionalName.Size = new Size(170, 24);
            labelAdditionalName.TabIndex = 4;
            labelAdditionalName.Text = "Additional Name:";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(12, 375);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(97, 24);
            labelBirthday.TabIndex = 5;
            labelBirthday.Text = "Birthday:";
            labelBirthday.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(463, 225);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(157, 24);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Location = new Point(463, 275);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(117, 24);
            labelNationality.TabIndex = 7;
            labelNationality.Text = "Nationality:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(463, 325);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(95, 24);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Address:";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Location = new Point(463, 375);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(107, 24);
            labelLocation.TabIndex = 9;
            labelLocation.Text = "Location:*";
            // 
            // textBoxName
            // 
            textBoxName.ForeColor = SystemColors.WindowText;
            textBoxName.Location = new Point(190, 222);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(237, 30);
            textBoxName.TabIndex = 10;
            // 
            // dateBirthday
            // 
            dateBirthday.Location = new Point(191, 369);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(237, 30);
            dateBirthday.TabIndex = 11;
            dateBirthday.Value = new DateTime(2024, 3, 22, 0, 0, 0, 0);
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(190, 269);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(237, 30);
            textBoxSurname.TabIndex = 12;
            // 
            // textBoxAdditionalName
            // 
            textBoxAdditionalName.Location = new Point(191, 319);
            textBoxAdditionalName.Name = "textBoxAdditionalName";
            textBoxAdditionalName.Size = new Size(237, 30);
            textBoxAdditionalName.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(624, 222);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(237, 30);
            textBoxPhoneNumber.TabIndex = 14;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(624, 319);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(237, 30);
            textBoxAddress.TabIndex = 16;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(771, 456);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(90, 35);
            buttonNext.TabIndex = 19;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 456);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "Keystone", "Pendik" });
            comboBoxLocation.Location = new Point(624, 367);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(237, 32);
            comboBoxLocation.TabIndex = 21;
            // 
            // comboBoxNationality
            // 
            comboBoxNationality.FormattingEnabled = true;
            comboBoxNationality.Items.AddRange(new object[] { "Russian", "Turkish", "American" });
            comboBoxNationality.Location = new Point(624, 267);
            comboBoxNationality.Name = "comboBoxNationality";
            comboBoxNationality.Size = new Size(237, 32);
            comboBoxNationality.TabIndex = 22;
            // 
            // labelRequired
            // 
            labelRequired.AutoSize = true;
            labelRequired.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelRequired.Location = new Point(12, 420);
            labelRequired.Name = "labelRequired";
            labelRequired.Size = new Size(122, 16);
            labelRequired.TabIndex = 23;
            labelRequired.Text = "* is required fields";
            // 
            // AddPlayerPage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(labelRequired);
            Controls.Add(comboBoxNationality);
            Controls.Add(comboBoxLocation);
            Controls.Add(buttonBack);
            Controls.Add(buttonNext);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAdditionalName);
            Controls.Add(textBoxSurname);
            Controls.Add(dateBirthday);
            Controls.Add(textBoxName);
            Controls.Add(labelLocation);
            Controls.Add(labelAddress);
            Controls.Add(labelNationality);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelBirthday);
            Controls.Add(labelAdditionalName);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(labelAddPlayer);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddPlayerPage";
            Text = "Add Player Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAddPlayer;
        private Label labelName;
        private Label labelSurname;
        private Label labelAdditionalName;
        private Label labelBirthday;
        private Label labelPhoneNumber;
        private Label labelNationality;
        private Label labelAddress;
        private Label labelLocation;
        private TextBox textBoxName;
        private DateTimePicker dateBirthday;
        private TextBox textBoxSurname;
        private TextBox textBoxAdditionalName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxAddress;
        private Button buttonNext;
        private Button buttonBack;
        private ComboBox comboBoxLocation;
        private ComboBox comboBoxNationality;
        private Label labelRequired;
    }
}