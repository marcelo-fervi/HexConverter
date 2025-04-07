namespace HexConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void valuesTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void userInputTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
        private void UpdateResult()
        {
            errorLabel.Visible = false;

            try
            {
                int optionIndex = valuesTypeListBox.SelectedIndex;

                string hexString = userInputTextBox.Text.Replace("0x", "");
                if (hexString.Length % 2 != 0)
                {
                    return;
                }

                byte[] values = StringToByteArray(hexString);

                byte[] newBytesArray = new byte[8];
                for (int i = 0; i < values.Length; i++)
                {
                    newBytesArray[i] = values[i];
                }

                switch (optionIndex)
                {
                    case 0: resultTextBox.Text = BitConverter.ToUInt32(newBytesArray, 0).ToString(); break;
                    case 1: resultTextBox.Text = BitConverter.ToSingle(newBytesArray, 0).ToString(); break;
                    case 2: resultTextBox.Text = BitConverter.ToUInt64(newBytesArray, 0).ToString(); break;
                    case 3: resultTextBox.Text = BitConverter.ToDouble(newBytesArray, 0).ToString(); break;
                    default: throw new NotImplementedException();
                }
            }
            catch (Exception)
            {
                errorLabel.Visible = true;
                //throw ex;
            }
        }
        //https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa
        private static byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            valuesTypeListBox.SelectedIndex = 0;
        }
    }
}