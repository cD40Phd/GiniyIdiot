using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class RemoveQuestionForm : Form
    {

        public RemoveQuestionForm()
        {
            InitializeComponent();
            var question = QuestionsStorage.GetAll();
            for (int i = 0; i < question.Count; i++)
            {
                var questionList = $"{i + 1}. {question[i].Text}";
                ListQuestion_Questions_ListBox.Items.Insert(i, questionList);
            }
        }

        private void ListQuestion_Questions_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListQuestionsForms_questionDelete_button.Enabled = true;
            ListQuestionForm_clueText_label.Enabled = false;
        }

        private void ListQuestionsForms_questionDelete_button_Click(object sender, EventArgs e)
        {
            runRemoveListQuestion();
        }

        private void ListQuestion_Questions_ListBox_KeyDown_1(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        runRemoveListQuestion();
                    }
                }

        private void runRemoveListQuestion()
        {
            var indexSelectQuestion = ListQuestion_Questions_ListBox.SelectedIndex;
            if (indexSelectQuestion != -1)
            {
                var question = QuestionsStorage.GetAll();
                var removeQuestion = question[indexSelectQuestion];

                QuestionsStorage.Remove(removeQuestion);
                ListQuestion_Questions_ListBox.Items.RemoveAt(indexSelectQuestion);

                ListQuestionsForms_questionDelete_button.Enabled = false;
                ListQuestionForm_clueText_label.Enabled = true;
            }
            else MessageBox.Show("Выделите, пожалуйста, вопрос");
        }        
    }
}
