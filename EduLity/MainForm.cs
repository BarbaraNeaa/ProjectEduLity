using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduLity
{
    public partial class MainForm : Form
    {
        private string userName;
        private int userAge;
        private string institution;
        private int currentScore = 0;
        private int questionIndex = 0;

        private (string Question, string[] Options, string CorrectAnswer)[] questions =
        {
        ("You may have heard about SDGs, but what do SDGs actually stand for?", new[] { "Sustainable Development Goals", "Socially Driven Global Solutions", "Strategic Development Guidelines for Sustainability", "Synergistic Development Goals for a Sustainable Future" }, "Sustainable Development Goals"),
        ("How many SDGs are included in the UN Resolution called the Agenda 2030?", new[] { "15", "10", "17", "8" }, "17"),
        ("What is the full title of SDG 4?", new[] { "Ensure access to affordable, reliable, sustainable, and modern energy for all", "Ensure inclusive and equitable quality education and promote lifelong learning opportunities for all", "Achieve gender equality and empower all women and girls", "Promote sustained, inclusive, and sustainable economic growth, full and productive employment, and decent work for all" }, "Ensure inclusive and equitable quality education and promote lifelong learning opportunities for all"),
        ("What is Education for Sustainable Development (ESD) considered to be?", new[] { "A driver for the achievements of all 17 SDGs", "A separate goal from the SDGs", "A tool for economic growth", "A means to combat climate change" }, "A driver for the achievements of all 17 SDGs"),
        ("Which of the following is NOT a target under SDG 4?", new[] { "Achieve universal primary education", "Ensure all learners acquire knowledge and skills needed for sustainable development", "Promote lifelong learning opportunities for all", "Reduce greenhouse gas emissions" }, "Reduce greenhouse gas emissions"),
        //("pertanyaan", new[] { "opsi1", "opsi2", "opsi3", "opsi4" }, "jawaban benar"),
    };

        public MainForm(string userName, int userAge, string institution)
        {
            InitializeComponent();
            this.userName = userName;
            this.userAge = userAge;
            this.institution = institution;
        }

        public MainForm()
        {
        }

        private void LoadNextQuestion()
        {
            if (questionIndex < questions.Length)
            {
                using (var questionForm = new QuestionForm(questions[questionIndex].Question,
                                                            questions[questionIndex].Options))
                {
                    if (questionForm.ShowDialog() == DialogResult.OK)
                    {
                        if (questionForm.SelectedAnswer == questions[questionIndex].CorrectAnswer)
                        {
                            currentScore++;
                            MessageBox.Show("Congratulations! you're Correct!");
                        }
                        else
                        {
                            MessageBox.Show("Sorry, you're Incorrect!");
                        }
                    }
                    questionIndex++;

                    if (questionIndex < questions.Length)
                    {
                        LoadNextQuestion();
                    }
                    else
                    {
                        OpenRecapForm();
                    }
                }
            }
        }


        private void OpenRecapForm()
        {
            // Create an instance of RecapForm
            var recapForm = new RecapForm(userName, userAge, institution, currentScore);

            // Set MainFormInstance in RecapForm
            recapForm.MainFormInstance = this;

            // Subscribe to the FormClosing event of RecapForm
            recapForm.FormClosing += (sender, args) =>
            {

                // Reset questionIndex and currentScore for the next interaction
                questionIndex = 0;
                currentScore = 0;
            };

            // Hide the MainForm
            this.Hide();

            // Show RecapForm
            recapForm.ShowDialog();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // Gaada yg diload ya gausah
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close(); // Nutup form.
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.Hide(); // Menyembunyikan MainForm
            LoadNextQuestion(); // Mulai quiz.

            // Setelah LoadNextQuestion selesai (setelah semua pertanyaan dijawab), tampilkan kembali MainForm
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLeave_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}