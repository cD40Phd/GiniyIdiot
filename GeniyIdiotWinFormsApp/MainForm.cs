using GeniyIdiotClassLibrary;
using User = GeniyIdiotClassLibrary.User;

namespace GeniyIdiotWinFormsApp
{
    public partial class mainForm : Form
    {
        User user;
        Game game;
        private int timeValue = 10;


        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

            var welcomedForm = new WelcomedForm();
            welcomedForm.ShowDialog();

            user = new User(welcomedForm.WelcomForm_UserName_TextBox.Text);
            game = new Game(user);

            limitTime_MainForm_timer.Start();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var cornetsQuestion = game.GetNextQuestion();
            MainForm_Question_Textlabel.Text = cornetsQuestion.Text;
            MainForm_NumberQuestion_label.Text = game.GetQuestionNumberText();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            bool getNumber = ProgramHelpers.TryGetNumber(MainForm_AnswerQuestion_TextBox.Text, out int userAnswer, out string errorMessage);
            if (!getNumber)
            {
                MessageBox.Show(errorMessage);
            }
            else nextQuestion(userAnswer);
        }

        private void nextQuestion(int userAnswer)
        {
            game.AcceptAnswer(userAnswer);
            if (game.EndGame())
            {   
                limitTime_MainForm_timer.Stop();
                var message = game.CalculateDiagnose();
                MainForm_NextQuestion_button.Enabled = false;
                
                MessageBox.Show(message);
                return;
            }

            MainForm_AnswerQuestion_TextBox.Clear();
            MainForm_NextQuestion_button.Enabled = true;
            timeValue = 10;
            ShowNextQuestion();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game(user);
            MainForm_AnswerQuestion_TextBox.Clear();
            MainForm_NextQuestion_button.Enabled = true;
            limitTime_MainForm_timer.Start();
            timeValue = 10;
            ShowNextQuestion();
        }

        private void результатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limitTime_MainForm_timer.Stop();
            MainForm_NextQuestion_button.Enabled = false;
            var resultForm = new ResultForm();
            resultForm.ShowDialog();
        }

        private void удалитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limitTime_MainForm_timer.Stop();
            MainForm_NextQuestion_button.Enabled = false;
            var questionListForm = new RemoveQuestionForm();
            questionListForm.ShowDialog();
        }

        private void добавитьВопосToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limitTime_MainForm_timer.Stop();
            MainForm_NextQuestion_button.Enabled = false;
            var addQuestionForm = new AddQuestionForm();
            addQuestionForm.ShowDialog();
        }

        private void limitTime_MainForm_timer_Tick(object sender, EventArgs e)
        {
            user.AllTimeAnswered(1);
            timeValue--;
            if (timeValue < 0) { timeValue = 0; }
                visualTimer_MainForm_label.Text = "Выделенное время: " + timeValue.ToString() + " сек.";

            if (timeValue == 0) 
            {
                
                limitTime_MainForm_timer.Stop();
                MainForm_NextQuestion_button.Enabled = false;
                MessageBox.Show("К сожалению, время выделенное для ответа кончилось. \nПереходим к следующему вопросу");
                
                timeValue = 10;
                limitTime_MainForm_timer.Start();
                nextQuestion(0);
            }
        }
    }
}