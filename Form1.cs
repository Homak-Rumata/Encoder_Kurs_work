namespace Тестовое_окно
{
    public partial class LoginForm : Form
    {

        MainForm mainform;

        private string _username; private string _password;


        public LoginForm(MainForm MainForm)
        {
            this.mainform = MainForm;

            InitializeComponent();
 //           this.Close();
        }


        private void LoginString_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputLoginForm_Click(object sender, EventArgs e)
        {
            mainform.Showing(this);
        //    this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainform.Hide();
            this.Close();
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}