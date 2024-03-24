namespace Login_System
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtboxName = new Guna.UI2.WinForms.Guna2TextBox();
            txtboxPass = new Guna.UI2.WinForms.Guna2TextBox();
            loginbtn = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            showpass = new Guna.UI2.WinForms.Guna2CheckBox();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtboxName
            // 
            txtboxName.BackColor = Color.White;
            txtboxName.BorderColor = Color.White;
            txtboxName.CustomizableEdges = customizableEdges1;
            txtboxName.DefaultText = "";
            txtboxName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtboxName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtboxName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtboxName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtboxName.FillColor = Color.FromArgb(16, 18, 56);
            txtboxName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtboxName.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxName.ForeColor = Color.White;
            txtboxName.HoverState.BorderColor = Color.White;
            txtboxName.Location = new Point(44, 186);
            txtboxName.Name = "txtboxName";
            txtboxName.PasswordChar = '\0';
            txtboxName.PlaceholderForeColor = Color.White;
            txtboxName.PlaceholderText = "Username";
            txtboxName.SelectedText = "";
            txtboxName.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtboxName.Size = new Size(271, 43);
            txtboxName.TabIndex = 0;
            txtboxName.TextChanged += txtboxName_TextChanged;
            // 
            // txtboxPass
            // 
            txtboxPass.BackColor = Color.White;
            txtboxPass.BorderColor = Color.White;
            txtboxPass.CustomizableEdges = customizableEdges3;
            txtboxPass.DefaultText = "";
            txtboxPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtboxPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtboxPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtboxPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtboxPass.FillColor = Color.FromArgb(16, 18, 56);
            txtboxPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtboxPass.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxPass.ForeColor = Color.White;
            txtboxPass.HoverState.BorderColor = Color.White;
            txtboxPass.Location = new Point(44, 235);
            txtboxPass.Margin = new Padding(4, 3, 4, 3);
            txtboxPass.Name = "txtboxPass";
            txtboxPass.PasswordChar = '\0';
            txtboxPass.PlaceholderForeColor = Color.White;
            txtboxPass.PlaceholderText = "Password";
            txtboxPass.SelectedText = "";
            txtboxPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtboxPass.Size = new Size(271, 43);
            txtboxPass.TabIndex = 1;
            txtboxPass.TextChanged += txtboxPass_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.Animated = true;
            loginbtn.CustomizableEdges = customizableEdges5;
            loginbtn.DisabledState.BorderColor = Color.DarkGray;
            loginbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginbtn.FillColor = Color.Green;
            loginbtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(44, 311);
            loginbtn.Name = "loginbtn";
            loginbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            loginbtn.Size = new Size(271, 45);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "LOGIN";
            loginbtn.Tile = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(111, 30);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(130, 130);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 3;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // showpass
            // 
            showpass.AutoSize = true;
            showpass.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showpass.CheckedState.BorderRadius = 0;
            showpass.CheckedState.BorderThickness = 0;
            showpass.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showpass.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showpass.ForeColor = SystemColors.ButtonHighlight;
            showpass.Location = new Point(44, 286);
            showpass.Name = "showpass";
            showpass.Size = new Size(127, 18);
            showpass.TabIndex = 4;
            showpass.Text = "Show Password";
            showpass.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showpass.UncheckedState.BorderRadius = 0;
            showpass.UncheckedState.BorderThickness = 0;
            showpass.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showpass.CheckedChanged += showpass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 18, 56);
            ClientSize = new Size(363, 386);
            Controls.Add(showpass);
            Controls.Add(guna2CirclePictureBox1);
            Controls.Add(loginbtn);
            Controls.Add(txtboxPass);
            Controls.Add(txtboxName);
            ForeColor = Color.White;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtboxName;
        private Guna.UI2.WinForms.Guna2TextBox txtboxPass;
        private Guna.UI2.WinForms.Guna2Button loginbtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox showpass;
    }
}
