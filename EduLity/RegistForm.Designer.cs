namespace EduLity
{
    partial class RegistForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistForm));
            btnRegist = new Button();
            lblNewUser = new Label();
            lblNewPassword = new Label();
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegist
            // 
            btnRegist.BackColor = Color.MistyRose;
            btnRegist.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegist.Location = new Point(268, 296);
            btnRegist.Name = "btnRegist";
            btnRegist.Size = new Size(150, 57);
            btnRegist.TabIndex = 0;
            btnRegist.Text = "Regist";
            btnRegist.UseVisualStyleBackColor = false;
            btnRegist.Click += btnRegist_Click;
            // 
            // lblNewUser
            // 
            lblNewUser.AutoSize = true;
            lblNewUser.BackColor = SystemColors.ButtonHighlight;
            lblNewUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNewUser.Location = new Point(111, 178);
            lblNewUser.Name = "lblNewUser";
            lblNewUser.Size = new Size(94, 25);
            lblNewUser.TabIndex = 1;
            lblNewUser.Text = "Username";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.BackColor = SystemColors.ButtonHighlight;
            lblNewPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNewPassword.Location = new Point(110, 236);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(90, 25);
            lblNewPassword.TabIndex = 2;
            lblNewPassword.Text = "Password";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new Point(268, 178);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(150, 31);
            txtNewUsername.TabIndex = 3;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(268, 236);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(150, 31);
            txtNewPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 92);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 6;
            label1.Text = "You don't have an EduLity account yet?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(146, 119);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 7;
            label2.Text = "don't worry, register here!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bgFirstForm;
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 453);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RegistForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 453);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Controls.Add(lblNewPassword);
            Controls.Add(lblNewUser);
            Controls.Add(btnRegist);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnRegist;
        private Label lblNewUser;
        private Label lblNewPassword;
        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}