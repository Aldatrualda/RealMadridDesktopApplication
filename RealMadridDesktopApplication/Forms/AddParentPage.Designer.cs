namespace RealMadridDesktopApplication.Forms
{
    partial class AddParentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParentPage));
            pictureBox1 = new PictureBox();
            labelAddParent = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelPhoneNumber = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhoneNumber = new TextBox();
            buttonNext = new Button();
            buttonBack = new Button();
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
            // labelAddParent
            // 
            labelAddParent.AutoSize = true;
            labelAddParent.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddParent.Location = new Point(191, 149);
            labelAddParent.Name = "labelAddParent";
            labelAddParent.Size = new Size(184, 35);
            labelAddParent.TabIndex = 1;
            labelAddParent.Text = "Add Parent:";
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
            // labelPhoneNumber
            // 
            labelPhoneNumber.AutoSize = true;
            labelPhoneNumber.Location = new Point(12, 325);
            labelPhoneNumber.Name = "labelPhoneNumber";
            labelPhoneNumber.Size = new Size(165, 24);
            labelPhoneNumber.TabIndex = 4;
            labelPhoneNumber.Text = "Phone Number:*";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(191, 225);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(237, 30);
            textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(191, 275);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(237, 30);
            textBoxSurname.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(191, 325);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(237, 30);
            textBoxPhoneNumber.TabIndex = 7;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(780, 456);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(90, 35);
            buttonNext.TabIndex = 8;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 456);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(90, 35);
            buttonBack.TabIndex = 9;
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
            labelRequired.TabIndex = 10;
            labelRequired.Text = "* is required fields";
            // 
            // AddParentPage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(labelRequired);
            Controls.Add(buttonBack);
            Controls.Add(buttonNext);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxName);
            Controls.Add(labelPhoneNumber);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(labelAddParent);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "AddParentPage";
            Text = "Add Parent Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAddParent;
        private Label labelName;
        private Label labelSurname;
        private Label labelPhoneNumber;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhoneNumber;
        private Button buttonNext;
        private Button buttonBack;
        private Label labelRequired;
    }
}