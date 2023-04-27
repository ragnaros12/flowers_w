namespace Flowers
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			string loginText = Login.Text;
			string passwordText = Password.Text;

			if(string.IsNullOrWhiteSpace(loginText) || string.IsNullOrWhiteSpace(passwordText))
			{
				Errors.Text = "���� ��� ��������� ����� �� ���������";
				return;
			}
			if(loginText.Length < 5 || passwordText.Length < 5)
			{
				Errors.Text = "����� ������ ������ ���� ������ 5";
				return;
			}

			var user = Database.Instance.Users.Where(u => u.Login == loginText &&
			u.Password == passwordText);
			if (!user.Any())
			{
				Errors.Text = "������ ������������ �� ����������";
				return;
			}

			var userData = user.First();

			MessageBox.Show(userData.Login);

		}
	}
}