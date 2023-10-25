using System.Data;

namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        private User user;
        private List<Question> questions;
        private Question correctQuestion;
        public int totalCountQuestions;
        private int questionNumber;



        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetAll();
            totalCountQuestions = questions.Count;
            user.CorrectCountAnswers = 0;
            user.allWaitingUserAnswered = 0;
            user.DataTest = DateTime.Now;
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomIndex = random.Next(0, questions.Count);
            correctQuestion = questions[randomIndex];
            questionNumber++;
            return correctQuestion;
        }

        public void AcceptAnswer(int userAnswer)
        {
            var rightAnswer = correctQuestion.Answer;

            if (rightAnswer == userAnswer) { user.AcceptRightAnswers(); }
            questions.Remove(correctQuestion);
        }
        public string GetQuestionNumberText()
        {
            return "Вопрос номер " + questionNumber;
        }

        public bool EndGame()
        {
            return questions.Count == 0;
        }

        public string CalculateDiagnose()
        {
            user.Diagnos = Diagnoses.Calculate(user.CorrectCountAnswers, totalCountQuestions);
            UsersStorage.SaveUserResult(user);
            TimeSpan t = TimeSpan.FromSeconds(user.allWaitingUserAnswered);
            string timeValue = string.Format("{0}:{1:00} минут", (int)t.TotalMinutes, t.Seconds);
            return $"Уважаемый(-ая) {user.UserName}\n\nКоличество Ваших правильных ответов {user.CorrectCountAnswers}\nВремя прохождение теста {timeValue}\nТаким образом, по итогу игры, Ваш диагноз\n\n\t{user.Diagnos.ToUpper()}";
        }
    }
}
