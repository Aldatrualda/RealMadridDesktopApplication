namespace RealMadridDesktopApplication.Forms
{
    partial class AddEmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeePage));
            buttonNext = new Button();
            pictureBoxRealMadridLogo = new PictureBox();
            labelAddEmployee = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelAdditionalName = new Label();
            labelPhoneNumber = new Label();
            labelBirthday = new Label();
            labelRole = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxAdditionalName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            dateTimePickerBirthday = new DateTimePicker();
            comboBoxRole = new ComboBox();
            buttonBack = new Button();
            labelRequired = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRealMadridLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(780, 456);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(90, 35);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // pictureBoxRealMadridLogo
            // 
            pictureBoxRealMadridLogo.Image = (Image)resources.GetObject("pictureBoxRealMadridLogo.Image");
            pictureBoxRealMadridLogo.Location = new Point(12, 12);
            pictureBoxRealMadridLogo.Name = "pictureBoxRealMadridLogo";
            pictureBoxRealMadridLogo.Size = new Size(166, 172);
            pictureBoxRealMadridLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRealMadridLogo.TabIndex = 1;
            pictureBoxRealMadridLogo.TabStop = false;
            // 
            // labelAddEmployee
            // 
            labelAddEmployee.AutoSize = true;
            labelAddEmployee.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddEmployee.Location = new Point(191, 149);
            labelAddEmployee.Name = "labelAddEmployee";
            labelAddEmployee.Size = new Size(230, 35);
            labelAddEmployee.TabIndex = 2;
            labelAddEmployee.Text = "Add Employee:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 225);
            labelName.Name = "labelName";
            labelName.Size = new Size(78, 24);
            labelName.TabIndex = 3;
            labelName.Text = "Name:*";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 275);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(109, 24);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "Surname:*";
            // 
            // labelAdditionalName
            // 
            labelAdditionalName.AutoSize = true;
            labelAdditionalName.Location = new Point(12, 325);
            labelAdditionalName.Name = "labelAdditionalName";
            labelAdditionalName.Size = new Size(170, 24);
            labelAdditionalName.TabIndex = 5;
            labelAdditionalName.Text = "Additional Name:";
            // 
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(463, 225);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(165, 24);
            labelPhoneNumber.TabIndex = 6;
            labelPhoneNumber.Text = "Phone Number:*";
            // 
            // labelBirthday
            // 
            labelBirthday.AutoSize = true;
            labelBirthday.Location = new Point(12, 375);
            labelBirthday.Name = "labelBirthday";
            labelBirthday.Size = new Size(97, 24);
            labelBirthday.TabIndex = 7;
            labelBirthday.Text = "Birthday:";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(463, 275);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(67, 24);
            labelRole.TabIndex = 8;
            labelRole.Text = "Role:*";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(190, 222);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(237, 30);
            textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(190, 269);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(237, 30);
            textBoxSurname.TabIndex = 10;
            // 
            // textBoxAdditionalName
            // 
            textBoxAdditionalName.Location = new Point(191, 319);
            textBoxAdditionalName.Name = "textBoxAdditionalName";
            textBoxAdditionalName.Size = new Size(237, 30);
            textBoxAdditionalName.TabIndex = 11;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(633, 219);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(237, 30);
            textBoxPhoneNumber.TabIndex = 12;
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(191, 369);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(237, 30);
            dateTimePickerBirthday.TabIndex = 13;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Admin", "Coach" });
            comboBoxRole.Location = new Point(633, 267);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(237, 32);
            comboBoxRole.TabIndex = 14;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 456);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 15;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelRequired
            // 
            labelRequired.AutoSize = true;
            labelRequired.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelRequired.Location = new Point(12, 420);
            labelRequired.Name = "labelRequired";
            labelRequired.Size = new Size(122, 16);
            labelRequired.TabIndex = 16;
            labelRequired.Text = "* is required fields";
            // 
            // AddEmployeePage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(labelRequired);
            Controls.Add(buttonBack);
            Controls.Add(comboBoxRole);
            Controls.Add(dateTimePickerBirthday);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxAdditionalName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelRole);
            Controls.Add(labelBirthday);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelAdditionalName);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(labelAddEmployee);
            Controls.Add(pictureBoxRealMadridLogo);
            Controls.Add(buttonNext);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddEmployeePage";
            Text = "Add Employee Page";
            ((System.ComponentModel.ISupportInitialize)pictureBoxRealMadridLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private PictureBox pictureBoxRealMadridLogo;
        private Label labelAddEmployee;
        private Label labelName;
        private Label labelSurname;
        private Label labelAdditionalName;
        private Label labelPhoneNumber;
        private Label labelBirthday;
        private Label labelRole;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxAdditionalName;
        private TextBox textBoxPhoneNumber;
        private DateTimePicker dateTimePickerBirthday;
        private ComboBox comboBoxRole;
        private Button buttonBack;
        private Label labelRequired;
    }
}