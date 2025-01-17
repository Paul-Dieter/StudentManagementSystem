namespace Prg282Project
{
    partial class AdminLoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            label1 = new Label();
            label2 = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            label3 = new Label();
            imageList1 = new ImageList(components);
            ExitButton = new Button();
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            AdminLoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(150, 30);
            label1.Name = "label1";
            label1.Size = new Size(268, 54);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(129, 437);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // UserName
            // 
            UserName.Cursor = Cursors.IBeam;
            UserName.Location = new Point(243, 406);
            UserName.Name = "UserName";
            UserName.Size = new Size(100, 23);
            UserName.TabIndex = 2;
            // 
            // Password
            // 
            Password.Cursor = Cursors.IBeam;
            Password.Location = new Point(243, 442);
            Password.Name = "Password";
            Password.Size = new Size(100, 23);
            Password.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(129, 398);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 4;
            label3.Text = "User Name";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.White;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Location = new Point(508, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(27, 25);
            ExitButton.TabIndex = 30;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // AdminLoginButton
            // 
            AdminLoginButton.Cursor = Cursors.Hand;
            AdminLoginButton.Location = new Point(367, 423);
            AdminLoginButton.Name = "AdminLoginButton";
            AdminLoginButton.Size = new Size(89, 22);
            AdminLoginButton.TabIndex = 32;
            AdminLoginButton.Text = "LOGIN";
            AdminLoginButton.UseVisualStyleBackColor = true;
            AdminLoginButton.Click += AdminLoginButton_Click;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(547, 534);
            Controls.Add(AdminLoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(ExitButton);
            Controls.Add(label3);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLoginForm";
            Text = "Admin Login";
            Load += AdminLoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserName;
        private TextBox Password;
        private Label label3;
        private ImageList imageList1;
        private Button ExitButton;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private Button AdminLoginButton;
    }
}