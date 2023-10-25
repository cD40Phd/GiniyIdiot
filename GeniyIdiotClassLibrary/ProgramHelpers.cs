namespace GeniyIdiotClassLibrary
{

    public static class ProgramHelpers
    {

        public static bool IsNotValidNik(string userName)
        {
            if (userName.Length > 12 || userName.Length < 2)
            {
                return false;
            }

            foreach (char c in userName)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool TryGetNumber(string inNumber, out int outNumber, out string messageError)
        {
            try
            {
                outNumber = Convert.ToInt32(inNumber);
                messageError = null;
                return true;
            }
            catch (FormatException)
            {
                outNumber = 0;
                messageError = "\tВведите число";
                return false;
            }
            catch (OverflowException)
            {
                outNumber = 0;
                messageError = "\tВведите число от -2*10^9 до 2*10^9";
                return false;
            }
        }
    }
}