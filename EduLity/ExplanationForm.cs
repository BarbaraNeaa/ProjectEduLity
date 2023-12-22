using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EduLity
{
    public partial class ExplanationForm : Form
    {
        private readonly MainForm mainForm;

        public MainForm MainFormInstance { get; set; }

        // This property is set to true when the quiz is completed and the score is ready to be shown
        public bool ShowScoreOnClose { get; set; }

        public ExplanationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Subscribe to the FormClosed event
            this.FormClosed += ExplanationForm_FormClosed;
        }

        public ExplanationForm()
        {
        }

        private void ExplanationForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            // Reset showScore for the next interaction
            ShowScoreOnClose = false;

            // Show MainForm only if it was visible before
            if (MainFormInstance != null && MainFormInstance.Visible)
            {
                MainFormInstance.Show();
            }
        }


        private void panelHome_MouseClick(object sender, MouseEventArgs e)
        {
            lblTitle.Text = "HII! Welcome Again!";
            lblText.Text = "How's the Quiz? Is it finished well?";
            lblSubText.Text = "Unlocking the power of knowledge through quizzes, let's delve into the essence of SDG 4, \n paving the way to empower education for all. \n Together, let's be catalysts for positive change, prepared to take meaningful actions \n for a better and more equitable world!";
        }

        private void panelEduLity_MouseClick(object sender, MouseEventArgs e)
        {
            lblTitle.Text = "About EduLity";
            lblText.Text = "EduLity : Elevate Education, Embrace Quality";
            lblSubText.Text = "EduLity is an innovative global education app featuring interactive quizzes \n to engage students and enhance understanding of global issues and SDGs. \n It's more than an app – a comprehensive solution designed to positively impact \n education worldwide through structured development and rigorous testing. \n \n \n EduLity is an innovative application developed by the Asteria Group, \n composed of Barbara Neanake and Christella Jesslyn, who are both IT students at \n Gadjah Mada University, class of 2022.";
        }

        private void panelSDG4_MouseClick(object sender, MouseEventArgs e)
        {
            lblTitle.Text = "About SDG4";
            lblText.Text = "Sustainable Development Goal 4: Quality Education";
            lblSubText.Text = "Sustainable Development Goal 4 (SDG4) is one of the 17 United Nations goals \n established in 2015, focusing on quality education. \n Its full title is Ensure inclusive and equitable quality education \n and promote lifelong learning opportunities for all. \n SDG4 is a commitment to provide accessible and high-quality \n education, emphasizing its transformative role in creating a \n sustainable and equitable world.";
        }

        private void ExplanationForm_Load(object sender, EventArgs e)
        {

        }

        private void PanelQuit_MouseClick(object sender, MouseEventArgs e)
        {
            // Close the current ExplanationForm
            this.Close();

            // Show the MainForm
            if (MainFormInstance != null)
            {
                MainFormInstance.Show();
            }
        }


        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
