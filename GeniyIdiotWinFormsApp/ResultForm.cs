using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            var results = UsersStorage.GetUsersResults();
            var groupedUsers = results.GroupBy(user => user.UserName);

            foreach (var group in groupedUsers)
            {
                var averageAllWaitingUserAnswered = group.Average(user => user.allWaitingUserAnswered);

                foreach (var result in group)
                {
                    ResultForm_Result_DataGridView.Rows.Add(result.DataTest, result.UserName, result.CorrectCountAnswers, result.Diagnos, result.allWaitingUserAnswered, averageAllWaitingUserAnswered.ToString("F2"));
                }
            }
        }

        private void deleteUser_ResultForm_button_Click(object sender, EventArgs e)
        {
            showDialogYesNo();
        }
        private void ResultForm_Result_DataGridView_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Delete)
                {
                    showDialogYesNo();
                }
        }

        private void showDialogYesNo()
        {
            DialogResult dialogResult = MessageBox.Show("Удалить всех пользователей с таким именем?", "Внимание!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                runRemoveLinesUser();
            }
            else if (dialogResult == DialogResult.No)
            {
                runRemoveLineUser();
            }
        }

        private void runRemoveLinesUser()
        {
            var rows = ResultForm_Result_DataGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            var userName = rows[0].Cells[1].Value.ToString();
            if (userName != null)
            {
                UsersStorage.Remove(userName);
            }
            Close();
        }

        private void runRemoveLineUser()
        {
            var rows = ResultForm_Result_DataGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            var userData = rows[0].Cells[0].Value.ToString();
            if (userData != null)
            {
                UsersStorage.RemoveUserDataTest(userData);
            }
            Close();
        }

        
    }
}
