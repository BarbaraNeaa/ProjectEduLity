using System;
using System.Collections.Generic;
using System.Windows.Forms;

//Untuk merapikan struktur dan keterbacaan kode, kami menerapkan design patterns untuk QuestionForm ini.

namespace EduLity
{
    // Observer interface
    public interface IQuestionObserver
    {
        void UpdateSelectedAnswer(string selectedAnswer);
    }

    // Subject class
    public partial class QuestionForm : Form
    {
        private string selectedAnswer;
        private List<IQuestionObserver> observers = new List<IQuestionObserver>();

        public string SelectedAnswer
        {
            get { return selectedAnswer; }
            private set
            {
                if (selectedAnswer != value)
                {
                    selectedAnswer = value;
                    NotifyObservers();
                }
            }
        }

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(string question, string[] options) : this()
        {
            lblQuestion.Text = question;
            radioButton1.Text = options[0];
            radioButton2.Text = options[1];
            radioButton3.Text = options[2];
            radioButton4.Text = options[3];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) SelectedAnswer = radioButton1.Text;
            else if (radioButton2.Checked) SelectedAnswer = radioButton2.Text;
            else if (radioButton3.Checked) SelectedAnswer = radioButton3.Text;
            else if (radioButton4.Checked) SelectedAnswer = radioButton4.Text;

            if (SelectedAnswer != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select an answer before proceeding.", "Select an Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Observer registration and notification methods
        public void RegisterObserver(IQuestionObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IQuestionObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.UpdateSelectedAnswer(selectedAnswer);
            }
        }
    }

    // Example Observer implementation
    public class ExampleObserver : IQuestionObserver
    {
        public void UpdateSelectedAnswer(string selectedAnswer)
        {
            // Do something with the selected answer
            Console.WriteLine($"Selected Answer: {selectedAnswer}");
        }
    }
}
