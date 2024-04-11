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
            buttonBack = new Button();
            PlayerID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            Nationality = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
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
            playerViewer.Dock = DockStyle.Top;
            playerViewer.GridColor = Color.White;
            playerViewer.Location = new Point(0, 0);
            playerViewer.Margin = new Padding(4);
            playerViewer.MaximumSize = new Size(1920, 1080);
            playerViewer.MinimumSize = new Size(1141, 604);
            playerViewer.Name = "playerViewer";
            playerViewer.RowHeadersWidth = 51;
            playerViewer.RowTemplate.Height = 29;
            playerViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            playerViewer.Size = new Size(1182, 604);
            playerViewer.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(13, 632);
            buttonBack.Margin = new Padding(4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
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
            // ShowPlayerPage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 693);
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
    }
}