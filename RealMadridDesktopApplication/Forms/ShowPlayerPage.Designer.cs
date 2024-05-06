namespace RealMadridDesktopApplication.Forms
{
    partial class ShowPlayerPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            playerViewer = new DataGridView();
            PlayerID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            buttonBack = new Button();
            buttonFilter = new Button();
            comboBoxNationality = new ComboBox();
            comboBoxLocation = new ComboBox();
            comboBoxAge = new ComboBox();
            buttonClean = new Button();
            labelNationality = new Label();
            labelLocation = new Label();
            labelAgeGroup = new Label();
            ((System.ComponentModel.ISupportInitialize)playerViewer).BeginInit();
            SuspendLayout();
            // 
            // playerViewer
            // 
            playerViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            playerViewer.BackgroundColor = Color.White;
            playerViewer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            playerViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerViewer.Columns.AddRange(new DataGridViewColumn[] { PlayerID, FirstName, Surname, Birthday, Nationality, PhoneNumber, Address, Location });
            playerViewer.Cursor = Cursors.Hand;
            playerViewer.GridColor = Color.White;
            playerViewer.Location = new Point(0, 90);
            playerViewer.Margin = new Padding(4);
            playerViewer.MaximumSize = new Size(1920, 1080);
            playerViewer.MinimumSize = new Size(500, 250);
            playerViewer.Name = "playerViewer";
            playerViewer.RowHeadersWidth = 51;
            playerViewer.RowTemplate.Height = 29;
            playerViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playerViewer.Size = new Size(1183, 515);
            playerViewer.TabIndex = 0;
            // 
            // PlayerID
            // 
            PlayerID.DataPropertyName = "player_id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            PlayerID.DefaultCellStyle = dataGridViewCellStyle1;
            PlayerID.HeaderText = "ID";
            PlayerID.MinimumWidth = 6;
            PlayerID.Name = "PlayerID";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "name";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            FirstName.DefaultCellStyle = dataGridViewCellStyle2;
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            Surname.DataPropertyName = "surname";
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            // 
            // Birthday
            // 
            Birthday.DataPropertyName = "birthday";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Birthday.DefaultCellStyle = dataGridViewCellStyle3;
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            // 
            // Nationality
            // 
            Nationality.DataPropertyName = "nationality";
            Nationality.HeaderText = "Nationality";
            Nationality.MinimumWidth = 6;
            Nationality.Name = "Nationality";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "phone_number";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            Address.DataPropertyName = "address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // Location
            // 
            Location.DataPropertyName = "location";
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(13, 645);
            buttonBack.Margin = new Padding(4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonFilter
            // 
            buttonFilter.Location = new Point(969, 49);
            buttonFilter.Name = "buttonFilter";
            buttonFilter.Size = new Size(90, 35);
            buttonFilter.TabIndex = 2;
            buttonFilter.Text = "Search";
            buttonFilter.UseVisualStyleBackColor = true;
            buttonFilter.Click += buttonFilter_Click;
            // 
            // comboBoxNationality
            // 
            comboBoxNationality.FormattingEnabled = true;
            comboBoxNationality.Items.AddRange(new object[] { "", "Afghan", "Albanian", "Algerian", "American", "Andorran", "Angolan", "Antiguans", "Argentinean", "Armenian", "Australian", "Austrian", "Azerbaijani", "Bahamian", "Bahraini", "Bangladeshi", "Barbadian", "Barbudans", "Batswana", "Belarusian", "Belgian", "Belizean", "Beninese", "Bhutanese", "Bolivian", "Bosnian", "Brazilian", "British", "Bruneian", "Bulgarian", "Burkinabe", "Burmese", "Burundian", "Cambodian", "Cameroonian", "Canadian", "Cape Verdean", "Central African", "Chadian", "Chilean", "Chinese", "Colombian", "Comoran", "Congolese", "Costa Rican", "Croatian", "Cuban", "Cypriot", "Czech", "Danish", "Djibouti", "Dominican", "Dutch", "East Timorese", "Ecuadorean", "Egyptian", "Emirian", "Equatorial Guinean", "Eritrean", "Estonian", "Ethiopian", "Fijian", "Filipino", "Finnish", "French", "Gabonese", "Gambian", "Georgian", "German", "Ghanaian", "Greek", "Grenadian", "Guatemalan", "Guinea-Bissauan", "Guinean", "Guyanese", "Haitian", "Herzegovinian", "Honduran", "Hungarian", "I-Kiribati", "Icelander", "Indian", "Indonesian", "Iranian", "Iraqi", "Irish", "Israeli", "Italian", "Ivorian", "Jamaican", "Japanese", "Jordanian", "Kazakhstani", "Kenyan", "Kittian and Nevisian", "Kuwaiti", "Kyrgyz", "Laotian", "Latvian", "Lebanese", "Liberian", "Libyan", "Liechtensteiner", "Lithuanian", "Luxembourger", "Macedonian", "Malagasy", "Malawian", "Malaysian", "Maldivian", "Malian", "Maltese", "Marshallese", "Mauritanian", "Mauritian", "Mexican", "Micronesian", "Moldovan", "Monacan", "Mongolian", "Moroccan", "Mosotho", "Motswana", "Mozambican", "Namibian", "Nauruan", "Nepalese", "New Zealander", "Ni-Vanuatu", "Nicaraguan", "Nigerian", "Nigerien", "North Korean", "Northern Irish", "Norwegian", "Omani", "Pakistani", "Palauan", "Panamanian", "Papua New Guinean", "Paraguayan", "Peruvian", "Polish", "Portuguese", "Qatari", "Romanian", "Russian", "Rwandan", "Saint Lucian", "Salvadoran", "Samoan", "San Marinese", "Sao Tomean", "Saudi", "Scottish", "Senegalese", "Serbian", "Seychellois", "Sierra Leonean", "Singaporean", "Slovakian", "Slovenian", "Solomon Islander", "Somali", "South African", "South Korean", "Spanish", "Sri Lankan", "Sudanese", "Surinamer", "Swazi", "Swedish", "Swiss", "Syrian", "Taiwanese", "Tajik", "Tanzanian", "Thai", "Togolese", "Tongan", "Trinidadian or Tobagonian", "Tunisian", "Turkish", "Tuvaluan", "Ugandan", "Ukrainian", "Uruguayan", "Uzbekistani", "Venezuelan", "Vietnamese", "Welsh", "Yemenite", "Zambian", "Zimbabwean" });
            comboBoxNationality.Location = new Point(11, 49);
            comboBoxNationality.Name = "comboBoxNationality";
            comboBoxNationality.Size = new Size(240, 32);
            comboBoxNationality.TabIndex = 3;
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Items.AddRange(new object[] { "", "Keystone", "Pendik" });
            comboBoxLocation.Location = new Point(271, 49);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(240, 32);
            comboBoxLocation.TabIndex = 4;
            // 
            // comboBoxAge
            // 
            comboBoxAge.FormattingEnabled = true;
            comboBoxAge.Items.AddRange(new object[] { "", "U-7", "U-9", "U-11", "U-13", "U-15", "U-17" });
            comboBoxAge.Location = new Point(531, 49);
            comboBoxAge.Name = "comboBoxAge";
            comboBoxAge.Size = new Size(240, 32);
            comboBoxAge.TabIndex = 5;
            // 
            // buttonClean
            // 
            buttonClean.Location = new Point(1079, 49);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(90, 35);
            buttonClean.TabIndex = 6;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // labelNationality
            // 
            labelNationality.AutoSize = true;
            labelNationality.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelNationality.Location = new Point(12, 30);
            labelNationality.Name = "labelNationality";
            labelNationality.Size = new Size(75, 16);
            labelNationality.TabIndex = 7;
            labelNationality.Text = "Nationality";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelLocation.Location = new Point(271, 30);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(62, 16);
            labelLocation.TabIndex = 8;
            labelLocation.Text = "Location";
            // 
            // labelAgeGroup
            // 
            labelAgeGroup.AutoSize = true;
            labelAgeGroup.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelAgeGroup.Location = new Point(531, 30);
            labelAgeGroup.Name = "labelAgeGroup";
            labelAgeGroup.Size = new Size(73, 16);
            labelAgeGroup.TabIndex = 9;
            labelAgeGroup.Text = "Age group";
            // 
            // ShowPlayerPage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 693);
            Controls.Add(labelAgeGroup);
            Controls.Add(labelLocation);
            Controls.Add(labelNationality);
            Controls.Add(buttonClean);
            Controls.Add(comboBoxAge);
            Controls.Add(comboBoxLocation);
            Controls.Add(comboBoxNationality);
            Controls.Add(buttonFilter);
            Controls.Add(buttonBack);
            Controls.Add(playerViewer);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1200, 740);
            Name = "ShowPlayerPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Player Page";
            ((System.ComponentModel.ISupportInitialize)playerViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView playerViewer;
        private Button buttonBack;
        private DataGridViewTextBoxColumn PlayerID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn Nationality;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Location;
        private Button buttonFilter;
        private ComboBox comboBoxNationality;
        private ComboBox comboBoxLocation;
        private ComboBox comboBoxAge;
        private Button buttonClean;
        private Label labelNationality;
        private Label labelLocation;
        private Label labelAgeGroup;
    }
}