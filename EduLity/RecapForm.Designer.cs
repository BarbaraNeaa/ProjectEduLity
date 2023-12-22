namespace EduLity
{
    partial class RecapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecapForm));
            btnExplanation = new Button();
            label2 = new Label();
            label1 = new Label();
            btnScore = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExplanation
            // 
            btnExplanation.BackColor = Color.FromArgb(255, 192, 192);
            btnExplanation.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExplanation.Location = new Point(363, 222);
            btnExplanation.Name = "btnExplanation";
            btnExplanation.Size = new Size(165, 45);
            btnExplanation.TabIndex = 9;
            btnExplanation.Text = "Explanation";
            btnExplanation.UseVisualStyleBackColor = false;
            btnExplanation.Click += btnExplanation_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(118, 133);
            label2.Name = "label2";
            label2.Size = new Size(456, 25);
            label2.TabIndex = 8;
            label2.Text = "Thank you for completing all of these SDGS quizzes!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(255, 75);
            label1.Name = "label1";
            label1.Size = new Size(179, 46);
            label1.TabIndex = 7;
            label1.Text = "Great job!";
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.FromArgb(255, 192, 192);
            btnScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnScore.Location = new Point(170, 222);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(165, 45);
            btnScore.TabIndex = 11;
            btnScore.Text = "View Score";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainFormBg2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(712, 337);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // RecapForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 336);
            Controls.Add(btnScore);
            Controls.Add(btnExplanation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RecapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recap Form";
            Load += RecapForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExplanation;
        private Label label2;
        private Label label1;
        private Button btnScore;
        private PictureBox pictureBox1;
    }
}