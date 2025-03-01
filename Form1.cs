namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        static string _lowerCaseList = "abcdefghijklmnopqrstuvwxyz";
        static string _upperCaseList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string _numberList = "0123456789";
        static string _symbolList = "!#$%&/()[]{}¿¡?@";
        string _characterList = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildCharList ()
        {
            _characterList = string.Empty;
            if (chkLowerCase.Checked)
            {
                _characterList += _lowerCaseList;
            }

            if (chkUpperCase.Checked)
            {
                _characterList += _upperCaseList;
            }

            if (chkSymbols.Checked)
            {
                _characterList += _symbolList;
            }

            if (chkNumbers.Checked)
            {
                _characterList += _numberList;
            }

            if (!chkLowerCase.Checked && !chkUpperCase.Checked && !chkSymbols.Checked && !chkNumbers.Checked)
                _characterList = string.Concat(_symbolList, _numberList, _upperCaseList, _lowerCaseList);

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                BuildCharList();
                string generatedPassword = string.Empty;
                Random random = new Random();
                int index = 0;
                char newCharacter;
                for (int i = 0; i < numCharacters.Value; i++)
                {
                    index = random.Next(0, _characterList.Length);
                    newCharacter = _characterList[index];
                    generatedPassword += newCharacter;
                }

                txtGeneratedPwd.Text = generatedPassword;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }


}
