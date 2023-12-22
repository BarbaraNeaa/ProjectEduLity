using EduLity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EduLityTests
{
    [TestClass]
    public class QuestionFormTests
    {
        [TestMethod]
        public void QuestionForm_SelectedAnswer_ShouldBeCorrect()
        {
            // Arrange
            string question = "Sample Question";
            string[] options = { "Option A", "Option B", "Option C", "Option D" };

            // Act
            using (var questionForm = new QuestionForm(question, options))
            {
                questionForm.ShowDialog();
                questionForm.Controls["radioButton1"].PerformClick(); // Simulate selecting Option A
                questionForm.Controls["btnOK"].PerformClick(); // Simulate clicking OK button

                // Assert
                Assert.AreEqual("Option A", questionForm.SelectedAnswer);
            }
        }

        [TestMethod]
        public void QuestionForm_SelectedAnswer_ShouldBeNullIfNoneSelected()
        {
            // Arrange
            string question = "Sample Question";
            string[] options = { "Option A", "Option B", "Option C", "Option D" };

            // Act
            using (var questionForm = new QuestionForm(question, options))
            {
                questionForm.ShowDialog();
                questionForm.Controls["btnOK"].PerformClick(); // Simulate clicking OK button without selecting any option

                // Assert
                Assert.IsNull(questionForm.SelectedAnswer);
            }
        }
    }
}
