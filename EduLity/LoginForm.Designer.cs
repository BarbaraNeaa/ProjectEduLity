namespace EduLity
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblName = new Label();
            txtName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            txtInstitution = new TextBox();
            lblInstitution = new Label();
            btnSubmit = new Button();
            lblUser = new Label();
            lblNotes = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ButtonHighlight;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(484, 361);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(619, 355);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 31);
            txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = SystemColors.ButtonHighlight;
            lblAge.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAge.Location = new Point(484, 422);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(45, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(619, 416);
            txtAge.Margin = new Padding(4, 5, 4, 5);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(265, 31);
            txtAge.TabIndex = 4;
            // 
            // txtInstitution
            // 
            txtInstitution.Location = new Point(619, 486);
            txtInstitution.Margin = new Padding(4, 5, 4, 5);
            txtInstitution.Name = "txtInstitution";
            txtInstitution.Size = new Size(265, 31);
            txtInstitution.TabIndex = 5;
            // 
            // lblInstitution
            // 
            lblInstitution.AutoSize = true;
            lblInstitution.BackColor = SystemColors.ButtonHighlight;
            lblInstitution.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblInstitution.Location = new Point(484, 492);
            lblInstitution.Margin = new Padding(4, 0, 4, 0);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(100, 25);
            lblInstitution.TabIndex = 6;
            lblInstitution.Text = "Institution";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Salmon;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSubmit.Location = new Point(984, 390);
            btnSubmit.Margin = new Padding(4, 5, 4, 5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(153, 88);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = SystemColors.ButtonHighlight;
            lblUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(631, 255);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(170, 25);
            lblUser.TabIndex = 8;
            lblUser.Text = "Your Username is : ";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.BackColor = SystemColors.ButtonHighlight;
            lblNotes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotes.Location = new Point(602, 289);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(231, 25);
            lblNotes.TabIndex = 9;
            lblNotes.Text = "Please fill your data below";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LoginFormBg;
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1398, 612);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = Properties.Resources.giphy;
            pictureBox2.Location = new Point(1168, 416);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 204);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1397, 610);
            Controls.Add(pictureBox2);
            Controls.Add(lblNotes);
            Controls.Add(lblUser);
            Controls.Add(btnSubmit);
            Controls.Add(lblInstitution);
            Controls.Add(txtInstitution);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblAge;
        private TextBox txtAge;
        private TextBox txtInstitution;
        private Label lblInstitution;
        private Button btnSubmit;
        private Label lblUser;
        private Label lblNotes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}