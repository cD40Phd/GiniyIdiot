using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace GeniyIdiotConsoleApp
{
    partial class Program : FileProvider
    {
        static bool isAnimationRunning = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте,\n\n" +
                           "Пожалуйста, придумайте никнейм.\n" +
                           "Обязательно должны быть буквы или цифры.\n" +
                           "Минимум два символа, максимум двенадцать.");

            string outNumber;
            string userName;
            string messagedError = "";
            do
            {
                Console.WriteLine(messagedError);
                userName = Console.ReadLine();
            }
            while (!User.GetNicName(userName, out outNumber, out messagedError));

            var user = new User(outNumber);

            do
            {

                Console.Clear();
                var game = new Game(user);

                do
                {
                    Stopwatch waitingAnswered = new Stopwatch();
                    waitingAnswered.Start();

                    var currentQuestion = game.GetNextQuestion();
                    Console.WriteLine("\t" + game.GetQuestionNumberText());
                    Console.Write("\t" + currentQuestion.Text);
                    var getUserAnswer = TimeQuiz();
                    var userAnswer = Convert.ToInt32(getUserAnswer);

                    waitingAnswered.Stop();

                    user.waitingUserAnswered = waitingAnswered.Elapsed.Seconds;
                    user.AllTimeAnswered(user.waitingUserAnswered);
                    game.AcceptAnswer(userAnswer);

                    Console.Clear();
                    Console.SetCursorPosition(0, 0);

                } while (!game.EndGame());

                var message = game.CalculateDiagnose();
                Console.WriteLine("\n\t" + message);

                var exitValue = false;
                do
                {
                    Console.WriteLine("\n\n\t1. Предыдущие результаты игры." +
                                        "\n\t2. Добавить новый вопрос." +
                                        "\n\t3. Удалить вопрос." +
                                        "\n\t4. Удалить пользователя." +
                                        "\n\t5. Удалить тест." +
                                        "\n\t6. Пройти тест повторно." +
                                        "\n\t7. Выход");
                    Console.Write("\tВаш выбор: ");
                    var userAnswerMenu = GetNumber();

                    switch (userAnswerMenu)
                    {
                        case 1: ShowUserResults(); break;
                        case 2:
                            var userChoice = GetUserChoice("\n\tХотите добавить новый вопрос?");
                            if (userChoice)
                            {
                                AddNewQuestion();
                                Console.WriteLine("\tВопрос удачно добавлен.");
                            }
                            break;
                        case 3:
                            userChoice = GetUserChoice("\n\tХотите удалить вопрос?");
                            if (userChoice)
                            {
                                RemoveQuestion();
                                Console.WriteLine("\tВопрос удачно удалён.");
                            }
                            break;
                        case 4:
                            Console.Write("\n\tВведите имя пользователя: ");
                            var userRemove = Console.ReadLine();
                            if (UsersStorage.SearchUser(userRemove))
                            {
                                userChoice = GetUserChoice($"\n\tХотите удалить пользователя {userRemove}?");

                                if (userChoice)
                                {
                                    UsersStorage.Remove(userRemove);
                                    Console.WriteLine($"\tПользователь{userRemove} удачно удалён.");
                                }
                            }
                            else Console.Write($"\n\tПользователя {userRemove} не существует");
                            break;
                        case 5:
                            Console.Write("\n\tВведите дату и время теста как в таблице: ");
                            var dataTestRemove = Console.ReadLine();
                            int resultUserRemote;
                            double allTimeUserRemote;
                            if (UsersStorage.SearchUserDataTest(dataTestRemove, out userRemove, out resultUserRemote, out allTimeUserRemote))
                            {
                                userChoice = GetUserChoice($"\n\tВы хотите удалить {userRemove} c результатом {resultUserRemote} и продолжительностью {allTimeUserRemote} сек.?");
                                if (userChoice)
                                {
                                    UsersStorage.RemoveUserDataTest(dataTestRemove);
                                    Console.WriteLine($"\tПользователь {userRemove} удачно удалён.");
                                }
                            }
                            else Console.Write($"\n\tПользователя с такими данными {userRemove}");
                            break;

                        case 6:
                            userChoice = GetUserChoice($"\n\t{user.UserName}, начать тест заново?");
                            if (userChoice)
                            {
                                exitValue = true;
                            }
                            break;
                        case 7:
                            userChoice = GetUserChoice($"\n\t{user.UserName}, закончить работу с программой.");
                            if (userChoice)
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            Console.WriteLine("\n\tСделайте свой выбор из списка от 1 до 6");
                            break;
                    }

                } while (!exitValue);

            } while (true);
        }

        static void RemoveQuestion()
        {
            var deletionConsent = false;
            do
            {
                Console.Clear();
                var questions = QuestionsStorage.GetAll();
                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + questions[i].Text);
                }
                Console.Write("\n\tВведите номер удаляемого вопроса " +
                    "\n\tили 0 для выхода в предыдущее меню: ");
                int removeQuestionNumber = GetNumber();
                if (removeQuestionNumber == 0) break;
                do
                {
                    if (removeQuestionNumber <= questions.Count && removeQuestionNumber > 0) break;
                    Console.Write("\tНомер удаляемого вопроса от 1 до " + questions.Count + ": ");
                    removeQuestionNumber = GetNumber();
                } while (true);
                var userChoice = GetUserChoice("\n\n\tВы уверенны?");
                if (userChoice)
                {
                    deletionConsent = true;
                }
                var removeQuestion = questions[removeQuestionNumber - 1];
                QuestionsStorage.Remove(removeQuestion);
            } while (!deletionConsent);
        }

        static void AddNewQuestion()
        {
            Console.Clear();
            Console.Write("\tВведите текст вопроса: ");
            var text = Console.ReadLine();
            Console.Write("\tВедите число ответ на вопрос: ");
            var answer = GetNumber();
            var newQuestion = new Question(text, answer);
            QuestionsStorage.Add(newQuestion);
        }

        private static void ShowUserResults()
        {
            var result = UsersStorage.GetUsersResults();
            // Отступы каждых столбцов (19_1 12_2, 25_3, 10_4, 16_5, 13_6) + 7 символа "|"
            Console.WriteLine(new string('-', 19 + 12 + 25 + 10 + 16 + 13 + 7));
            Console.WriteLine("|{0,19}|{1,12}|{2,25}|{3,10}|{4,16}|{5,13}|", "  Дата       ", "     Имя    ", "Кол-во правильных ответов", "Диагноз", "Продол-сть теста", "Среднее время");
            Console.WriteLine(new string('-', 19 + 12 + 25 + 10 + 16 + 13 + 7));

            var groupedUsers = result.GroupBy(user => user.UserName);

            foreach (var group in groupedUsers)
            {
                var averageAllWaitingUserAnswered = group.Average(user => user.allWaitingUserAnswered);
                foreach (var user in group) { Console.WriteLine($"|{user.DataTest.ToLocalTime(),19}|{user.UserName,12}|{user.CorrectCountAnswers,12}{" ",13}|{user.Diagnos,10}|{user.allWaitingUserAnswered,16}|{averageAllWaitingUserAnswered.ToString("F2"),13}|"); }
            }

            Console.WriteLine(new string('-', 19 + 12 + 25 + 10 + 16 + 13 + 7));
        }

        static bool GetUserChoice(string message)
        {
            while (true)
            {
                Console.Write(message + "\n\tВведите Да или Нет: ");
                var userInput = Console.ReadLine();

                if (userInput.ToLower() == "нет")
                {
                    return false;
                }
                if (userInput.ToLower() == "да")
                {
                    return true;
                }
            }
        }
        private static int GetNumber()
        {
            int outNumber;
            while (!ProgramHelpers.TryGetNumber(Console.ReadLine(), out outNumber, out string messageError))
            {
                Console.Write(messageError + ":");
            }
            return outNumber;
        }

        private static string TimeQuiz()
        {
            Console.SetCursorPosition(0, 2);
            Console.CursorVisible = false;
            var userInput = new List<string>();
            var resultAnsver = "0";
            isAnimationRunning = true;

            var animationThread = new Thread(() => Animate(userInput));
            animationThread.Start();

            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {

                    foreach (string entry in userInput)
                    {
                        resultAnsver = resultAnsver + entry;
                    };

                    userInput.Clear();
                    isAnimationRunning = false;
                    Console.CursorVisible = true;
                    animationThread.Join();
                    return resultAnsver;
                }
                else if (key.Key == ConsoleKey.Backspace && userInput.Count > 0)
                {
                    userInput.RemoveAt(userInput.Count - 1);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                }
                else
                {
                    if (Char.IsDigit(key.KeyChar))
                    {
                        userInput.Add(key.KeyChar.ToString());
                        Console.Write(key.KeyChar);
                    }
                }
            }
            animationThread.Abort();

        }
        static void Animate(List<string> userInput)
        {
            int counter = 0;
            int seconds = 10;
            while (isAnimationRunning)
            {
                counter++;
                if (counter % 4 == 0)
                {
                    Console.Write("/");
                }
                else if (counter % 4 == 1)
                {
                    Console.Write("-");
                }
                else if (counter % 4 == 2)
                {
                    Console.Write("\\");
                }
                else
                {
                    Console.Write("|");
                }

                Console.SetCursorPosition(0, Console.CursorTop);

                if (counter % 10 == 0)
                {
                    seconds--;

                    Console.SetCursorPosition(2, Console.CursorTop);
                    Console.Write($"Время: {seconds} сек.");
                    if (seconds <= 0)
                    {
                        seconds = 0; isAnimationRunning = false;
                        Console.SetCursorPosition(18, Console.CursorTop);
                        Console.Write("Ваш ответ:");
                        Console.Write("Ответ не засчитан. Для продолжения нажмите Enter.");
                    }
                }

                Console.SetCursorPosition(18, Console.CursorTop);
                Console.Write("Ваш ответ:");
                Console.Write(string.Join("", userInput));

                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.CursorTop);

            }
        }

    }
}

