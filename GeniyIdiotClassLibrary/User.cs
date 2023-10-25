namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string UserName;
        public string Diagnos;
        public int CorrectCountAnswers;
        public double allWaitingUserAnswered;
        public DateTime DataTest;


        public int waitingUserAnswered { get; set; }

        public User(string userName)
        {
            UserName = userName;
        }

        public void AcceptRightAnswers()
        {
            CorrectCountAnswers++;
        }
        public static bool GetNicName(string userName, out string? outUserName, out string? messagedError)
        {
            if (userName != null && ProgramHelpers.IsNotValidNik(userName))
            {
                outUserName = userName;
                messagedError = null;
                return true;
            }
            else
            {
                outUserName = null;
                messagedError = "\nВнимание!\n" +
                "Веденные данные не выполняют условий\nПопробуйте ввести заново";
                return false;
            }
        }

        public void AllTimeAnswered(int time)
        {
            allWaitingUserAnswered = allWaitingUserAnswered + time;
        }
    }
}


