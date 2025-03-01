namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        static string lowerCaseList = "abcdefghijklmnopqrstuvwxyz";
        static string upperCaseList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string numberList = "0123456789";
        static string symbolList = "!#$%&/()[]{}¿¡?@";
        string List = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildCharList ()
        {
            List = string.Empty;
            if (chkLowerCase.Checked)
            {
                List += lowerCaseList;
            }

            if (chkUpperCase.Checked)
            {
                List += upperCaseList;
            }

            if (chkSymbols.Checked)
            {
                List += symbolList;
            }

            if (chkNumbers.Checked)
            {
                List += numberList;
            }

            if (!chkLowerCase.Checked && !chkUpperCase.Checked && !chkSymbols.Checked && !chkNumbers.Checked)
            List = string.Concat(symbolList, numberList, upperCaseList, lowerCaseList);

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            BuildCharList();
            string? generatedPassword = null;
            Random random = new Random();
            int index= 0;
            char newCharacter;
            for (int i = 0; i < numCharacters.Value; i++) 
            {
                index = random.Next(0, List.Length);
                newCharacter = List[index];
                generatedPassword += newCharacter;
               
            }

            txtGeneratedPwd.Text = generatedPassword;
        }

    }


}
