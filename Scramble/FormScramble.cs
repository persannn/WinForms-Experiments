using System.Security.Cryptography;

namespace Scramble
{
    public partial class FormScramble : Form
    {
        public FormScramble()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that randomly scrambles the order of characters in label1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScramble_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] arr = text.ToCharArray();
            string scrambled = "";

            for (int i = text.Length; i > 0; i--)
            {
                int roll = RandomNumberGenerator.GetInt32(0, i);
                if (i == roll)
                    continue;
                // If the rolled number isn't the same as i, the two characters swap places.
                char charOriginal = arr[i - 1];
                char charRolled = arr[roll];
                arr[i - 1] = charRolled;
                arr[roll] = charOriginal;
            }

            for (int i = 0; i < text.Length; i++)
            {
                scrambled += arr[i];
            }
            textBox1.Text = scrambled;
        }
    }
}
