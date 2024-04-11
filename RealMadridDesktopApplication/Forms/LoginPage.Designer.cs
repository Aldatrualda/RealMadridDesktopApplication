namespace RealMadridDesktopApplication
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            labelLogin = new Label();
            labelPassword = new Label();
            labelWelcoming = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonClear = new Button();
            pictureBoxLogo = new PictureBox();
            checkBoxShow = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(212, 254);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(70, 24);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login:";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.None;
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(212, 295);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(110, 24);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password:";
            // 
            // labelWelcoming
            // 
            labelWelcoming.Anchor = AnchorStyles.None;
            labelWelcoming.AutoSize = true;
            labelWelcoming.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcoming.Location = new Point(212, 149);
            labelWelcoming.Name = "labelWelcoming";
            labelWelcoming.Size = new Size(547, 35);
            labelWelcoming.TabIndex = 2;
            labelWelcoming.Text = "Welcome to Real Madrind Foundation";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Location = new Point(332, 248);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(229, 30);
            textBoxLogin.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(332, 289);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(229, 30);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Location = new Point(471, 347);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(90, 35);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.None;
            buttonClear.Location = new Point(332, 347);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(90, 35);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(12, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(166, 172);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 7;
            pictureBoxLogo.TabStop = false;
            // 
            // checkBoxShow
            // 
            checkBoxShow.Anchor = AnchorStyles.None;
            checkBoxShow.AutoSize = true;
            checkBoxShow.Font = new Font("Arial", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxShow.Location = new Point(567, 297);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(62, 20);
            checkBoxShow.TabIndex = 8;
            checkBoxShow.Text = "show";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(882, 503);
            Controls.Add(checkBoxShow);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonClear);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelWelcoming);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private Label labelPassword;
        private Label labelWelcoming;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonClear;
        private PictureBox pictureBoxLogo;
        private CheckBox checkBoxShow;
    }
}
