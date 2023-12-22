using System;
using System.Windows.Forms;

//Kami menggunakan Teknik Refactoring untuk merapikan code ini :D

namespace EduLity
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Show the FirstForm first
            using (var firstForm = new FirstForm())
            {
                if (ShowFormAndCheckResult(firstForm) == DialogResult.OK)
                {
                    // Proceed to the next form (LoginForm)
                    using (var loginForm = new LoginForm())
                    {
                        if (ShowFormAndCheckResult(loginForm) == DialogResult.OK)
                        {
                            // Proceed to the next form (MainForm)
                            using (var mainForm = new MainForm(loginForm.UserName, loginForm.UserAge, loginForm.Institution))
                            {
                                if (ShowFormAndCheckResult(mainForm) == DialogResult.OK)
                                {
                                    // Proceed to the next form (QuestionForm)
                                    using (var questionForm = new QuestionForm())
                                    {
                                        if (ShowFormAndCheckResult(questionForm) == DialogResult.OK)
                                        {
                                            // Proceed to the next form (RecapForm)
                                            using (var recapForm = new RecapForm())
                                            {
                                                ShowForm(recapForm);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static DialogResult ShowFormAndCheckResult(Form form)
        {
            ShowForm(form);
            return form.DialogResult;
        }

        private static void ShowForm(Form form)
        {
            form.ShowDialog();
        }
    }
}
