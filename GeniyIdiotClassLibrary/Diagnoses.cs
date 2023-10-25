namespace GeniyIdiotClassLibrary
{

    public class Diagnoses
    {
        public static List<string> GetDiagnosis()
        {
            var diagnoses = new List<string>
            { "кретин", "идиот", "дурак", "нормальный", "талант", "гений" };
            return diagnoses;
        }

        public static int GetEvaluation(int totalCountQuestions, int correctCountAnswers, int countDiagnoses)
        {
            var stepEvaluation = (decimal)totalCountQuestions / (countDiagnoses - 1);
            var evaluation = (int)Math.Round(correctCountAnswers / stepEvaluation);
            return evaluation;
        }

        public static string Calculate(int CorrectCountAnswers, int totalCountQuestions)
        {
            var diagnos = GetDiagnosis();
            var countDiagnoses = diagnos.Count;
            var totalEvaluation = GetEvaluation(totalCountQuestions, CorrectCountAnswers, countDiagnoses);
            try
            {
                return diagnos[totalEvaluation];
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}

