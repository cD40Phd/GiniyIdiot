using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        public AddQuestionForm()
        {
            InitializeComponent();
            AddQuestionForm_questionAdd_button_button.Enabled = false;
        }

        private void AddQuestionForm_questionAdd_button_button_Click(object sender, EventArgs e)
        {
            int outNumber;
            var inNumber = AddQuestionForm_answerNumer_textBox.Text;
            var text = AddQuestionForm_questionTextNew_textBox.Text;

            bool getTrueNumberQuestions = ProgramHelpers.TryGetNumber(inNumber, out outNumber, out string messageError1);
                if (!getTrueNumberQuestions)
                {
                    MessageBox.Show(messageError1);
                    AddQuestionForm_answerNumer_textBox.Text = null;
                }
                else
                {                   
                    var newQuestion = new Question(text, outNumber);
                    QuestionsStorage.Add(newQuestion);
                    Close();
                }
            
        }

        private void AddQuestionForm_questionTextNew_textBox_TextChanged(object sender, EventArgs e)
        {
            if (AddQuestionForm_answerNumer_textBox.Text != "целое число" && AddQuestionForm_answerNumer_textBox.Text != "" && AddQuestionForm_answerNumer_textBox.Text != "0")
            {
                AddQuestionForm_questionAdd_button_button.Enabled = true;
            }
        }

        private void AddQuestionForm_answerNumer_textBox_TextChanged(object sender, EventArgs e)
        {
            if (AddQuestionForm_questionTextNew_textBox.Text != "Ваш вопрос" && AddQuestionForm_answerNumer_textBox.Text != "" && AddQuestionForm_answerNumer_textBox.Text != "0")
            {
                AddQuestionForm_questionAdd_button_button.Enabled = true;
            }
        }
    }
}
