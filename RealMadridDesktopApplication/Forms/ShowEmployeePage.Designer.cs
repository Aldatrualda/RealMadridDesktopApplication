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
            employeeViewer.Dock = DockStyle.Top;
            employeeViewer.GridColor = Color.White;
            employeeViewer.Location = new Point(0, 0);
            employeeViewer.Margin = new Padding(4);
            employeeViewer.MaximumSize = new Size(1920, 1080);
            employeeViewer.MinimumSize = new Size(1141, 604);
            employeeViewer.Name = "employeeViewer";
            employeeViewer.RowHeadersWidth = 51;
            employeeViewer.RowTemplate.Height = 29;
            employeeViewer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeViewer.Size = new Size(1182, 604);
            employeeViewer.TabIndex = 0;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "employee_id";
            EmployeeID.HeaderText = "ID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "name";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Birthday.DefaultCellStyle = dataGridViewCellStyle1;
            Birthday.HeaderText = "Birthday";
            Birthday.MinimumWidth = 6;
            Birthday.Name = "Birthday";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "phone_number";
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Login
            // 
            Login.DataPropertyName = "login";
            Login.HeaderText = "Login";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            // 
            // Password
            // 
            Password.DataPropertyName = "password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(13, 632);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // ShowEmployeePage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(1182, 693);
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
    }
}