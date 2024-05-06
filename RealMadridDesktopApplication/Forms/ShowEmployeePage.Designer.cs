namespace RealMadridDesktopApplication.Forms
{
    partial class ShowEmployeePage
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
            employeeViewer = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            buttonBack = new Button();
            textBoxID = new TextBox();
            textBoxFirstName = new TextBox();
            buttonDelete = new Button();
            labelID = new Label();
            labelFirstName = new Label();
            buttonRefresh = new Button();
            buttonClean = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeViewer).BeginInit();
            SuspendLayout();
            // 
            // employeeViewer
            // 
            employeeViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeViewer.BackgroundColor = Color.White;
            employeeViewer.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            employeeViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeViewer.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FirstName, Surname, Birthday, PhoneNumber, Login, Password });
            employeeViewer.GridColor = Color.White;
            employeeViewer.Location = new Point(0, 90);
            employeeViewer.Margin = new Padding(4);
            employeeViewer.MaximumSize = new Size(1920, 1080);
            employeeViewer.MinimumSize = new Size(500, 250);
            employeeViewer.Name = "employeeViewer";
            employeeViewer.ReadOnly = true;
            employeeViewer.RowHeadersWidth = 51;
            employeeViewer.RowTemplate.Height = 29;
            employeeViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeViewer.Size = new Size(1182, 515);
            employeeViewer.TabIndex = 0;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "employee_id";
            EmployeeID.HeaderText = "ID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "name";
            FirstName.HeaderText = "First Name";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // Surname
            // 
            Surname.DataPropertyName = "surname";
            Surname.HeaderText = "Surname";
            Surname.MinimumWidth = 6;
            Surname.Name = "Surname";
            Surname.ReadOnly = true;
            // 
            // Birthday
            // 
            Birthday.DataPropertyName = "birthday";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Birthday.DefaultCellStyle = dataGridViewCellStyle1;
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            Birthday.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "phone_number";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Login
            // 
            Login.DataPropertyName = "login";
            Login.HeaderText = "Login";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.ReadOnly = true;
            // 
            // Password
            // 
            Password.DataPropertyName = "password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // buttonBack
            // 
            buttonBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonBack.Location = new Point(13, 632);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(13, 32);
            textBoxID.MaximumSize = new Size(160, 30);
            textBoxID.MaxLength = 100;
            textBoxID.MinimumSize = new Size(160, 30);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(160, 30);
            textBoxID.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(223, 32);
            textBoxFirstName.MaximumSize = new Size(160, 30);
            textBoxFirstName.MaxLength = 15;
            textBoxFirstName.MinimumSize = new Size(160, 30);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(160, 30);
            textBoxFirstName.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Location = new Point(427, 30);
            buttonDelete.MaximumSize = new Size(120, 65);
            buttonDelete.MinimumSize = new Size(90, 35);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(90, 35);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(13, 13);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 16);
            labelID.TabIndex = 5;
            labelID.Text = "ID";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.Location = new Point(223, 13);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(75, 16);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "First Name";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRefresh.Location = new Point(1068, 30);
            buttonRefresh.MaximumSize = new Size(140, 70);
            buttonRefresh.MinimumSize = new Size(105, 35);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(105, 35);
            buttonRefresh.TabIndex = 7;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonClean
            // 
            buttonClean.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClean.Location = new Point(533, 30);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(90, 35);
            buttonClean.TabIndex = 8;
            buttonClean.Text = "Clean";
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // ShowEmployeePage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1182, 693);
            Controls.Add(buttonClean);
            Controls.Add(buttonRefresh);
            Controls.Add(labelFirstName);
            Controls.Add(labelID);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxID);
            Controls.Add(buttonBack);
            Controls.Add(employeeViewer);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1200, 740);
            Name = "ShowEmployeePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Employee Page";
            ((System.ComponentModel.ISupportInitialize)employeeViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeeViewer;
        private Button buttonBack;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Birthday;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Password;
        private TextBox textBoxID;
        private TextBox textBoxFirstName;
        private Button buttonDelete;
        private Label labelID;
        private Label labelFirstName;
        private Button buttonRefresh;
        private Button buttonClean;
    }
}