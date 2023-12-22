using System;
using System.Windows.Forms;

namespace EduLity
{
    public partial class RecapForm : Form
    {
        public RecapForm()
        {
            InitializeComponent();
        }

        public MainForm MainFormInstance { get; set; }

        public RecapForm(string userName, int userAge, string institution, int currentScore) : this()
        {
            UserAge = userAge;
            Institution = institution;
            CurrentScore = currentScore;
        }

        public int UserAge { get; }
        public string Institution { get; }
        public int CurrentScore { get; }

        private bool showScore = false;

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            // Pass the MainForm instance to ExplanationForm during creation
            ExplanationForm explanationForm = new ExplanationForm(MainFormInstance);

            // Subscribe to the FormClosing event of ExplanationForm
            explanationForm.FormClosing += (s, args) =>
            {
                // Check if the score should be shown
                if (explanationForm.ShowScoreOnClose)
                {
                    // Show the pop-up score only if btnScore was clicked in ExplanationForm
                    MessageBox.Show($"Yay! Quiz Finished! Your Score: {CurrentScore}", "Your Final Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset showScore for the next interaction
                showScore = false;

                // Show MainForm only if it was visible before
                if (MainFormInstance != null && MainFormInstance.Visible)
                {
                    MainFormInstance.Show();
                }
            };

            // Show ExplanationForm
            explanationForm.Show();

            // Hide the current RecapForm
            this.Hide();
        }


        private void btnScore_Click(object sender, EventArgs e)
        {
            // Set the flag to true when the user clicks btnScore
            ShowScoreOnClose = true;

            // Show the pop-up score without closing the RecapForm
            MessageBox.Show($"Yay! Quiz Finished! Your Score: {CurrentScore}", "Your Final Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RecapForm_Load(object sender, EventArgs e)
        {
            // RecapForm is loaded without showing the score
            showScore = false;
        }

        // This property is set to true when the quiz is completed and the score is ready to be shown
        public bool ShowScoreOnClose { get; private set; }
    }
}