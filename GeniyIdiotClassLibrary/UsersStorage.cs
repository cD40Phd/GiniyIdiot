using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GeniyIdiotClassLibrary
{

    public class UsersStorage
    {
        public static string FileName = "userResults.json";
        public static void SaveUserResult(User user)
        {
            var userResult = GetUsersResults();
            userResult.Add(user);
            Save(userResult);
        }

        public static List<User> GetUsersResults()
        {
            if (!FileProvider.Exists(FileName))
            {
                return new List<User>();
            }
            var value = FileProvider.GetValue(FileName);
            var userResult = JsonConvert.DeserializeObject<List<User>>(value);
            return userResult;
        }

        static void Save(List<User> userResult)
        {
            var jsonData = JsonConvert.SerializeObject(userResult, Formatting.Indented);
            FileProvider.Replace(FileName, jsonData);
        }

        public static void Remove(string? removeUser)
        {
            var users = GetUsersResults();
            do
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i] != null)
                    {
                        if (users[i].UserName == removeUser)
                        {
                            users.RemoveAt(i);
                        }
                    }
                }
                Save(users);
            } while (SearchUser(removeUser));
        }

        public static bool SearchUser(string? userRemove)
        {
            var users = GetUsersResults();
            if (userRemove != null)
            {
                foreach (var userResult in users)
                {
                    if (userResult.UserName == userRemove) { return true; }
                }
            }
            return false;
        }

        public static void RemoveUserDataTest(string dateTime)
        {
            var users = GetUsersResults();
            if (dateTime != null)
            {
                users.RemoveAll(user => user != null && user.DataTest.ToLocalTime().ToString() == dateTime);
            }
            Save(users);
        }

        public static bool SearchUserDataTest(string dateTime, out string userRemove, out int resultUserRemove, out double allTimeUserRemove)
        {
            var users = GetUsersResults();

            for (var i = 0; i < users.Count; i++)
            {
                if (users[i] != null && users[i].DataTest.ToLocalTime().ToString() == dateTime)
                {
                    userRemove = users[i].UserName;
                    resultUserRemove = users[i].CorrectCountAnswers;
                    allTimeUserRemove = users[i].allWaitingUserAnswered;
                    return true;
                }
            }
            userRemove = "не существует";
            resultUserRemove = 0;
            allTimeUserRemove = 0;
            return false;
        }

    }
}

