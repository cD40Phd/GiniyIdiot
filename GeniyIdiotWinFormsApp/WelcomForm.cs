using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class WelcomedForm : Form
    {
        public WelcomedForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool getUser = User.GetNicName(WelcomForm_UserName_TextBox.Text, out string outUser, out string errorMessage);

            if (!getUser)
            {
                MessageBox.Show(errorMessage);
                WelcomForm_UserName_TextBox.Text = "";
            }
            else
            {
                Close();
            }
        }
    }
}
