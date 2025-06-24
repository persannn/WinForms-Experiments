namespace Calculator
{
    public partial class FormCalculator : Form
    {

        private Stack<char> stack = new Stack<char>();
        private char[] operators = { '*', '/', '+', '-' };
        public FormCalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method that is called whenever a button other than 'Enter' is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text == "Invalid expression!")
                labelDisplay.Text = string.Empty;
            char buttonText;
            if(stack.Count == 0)
            {
                int buttonNumber;
                if(Int32.TryParse(((Button)sender).Text, out buttonNumber))
                {
                    stack.Push((char)(buttonNumber + 48));
                    labelDisplay.Text += buttonNumber;
                }
            }
            else if(stack.Count < 20)
            {
                if (char.TryParse(((Button)sender).Text, out buttonText))
                {
                    stack.Push(buttonText);
                    labelDisplay.Text += buttonText;
                }
            }
        }

        /// <summary>
        /// A method that is called when the 'Enter' button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (stack.Count == 0)
                return;
            if (labelDisplay.Text == "Invalid expression!")
            {
                labelDisplay.Text = string.Empty;
                return;
            }
            if (operators.Contains(stack.Peek()) || stack.Peek() == '.')
            {
                labelDisplay.Text = "Invalid expression!";
                stack.Clear();
                return;
            }

            bool expressionIsValid = true;
            int indexOfNextNumber = 0;
            char[] charInput = stack.ToArray();
            Array.Reverse(charInput);
            List<char> operations = new List<char>();
            List<float> floats = new List<float>();

            // The purpose of this loop is to break down the string input into
            // floats and operations.
            for (int i = 0; i < charInput.Length; i++)
            {
                char char_I = charInput[i];
                string number = "";
                float asFloat;
                if (operators.Contains(char_I))
                {
                    for (int j = indexOfNextNumber; j < i; j++)
                        number += charInput[j];
                    if (!float.TryParse(number, out asFloat))
                    {
                        expressionIsValid = false;
                        break;
                    }
                    floats.Add(asFloat);
                    operations.Add(char_I);
                    indexOfNextNumber = i + 1;
                }
                else if (i == charInput.Length - 1)
                {
                    for (int j = indexOfNextNumber; j <= i; j++)
                        number += charInput[j];
                    if (!float.TryParse(number, out asFloat))
                    {
                        expressionIsValid = false;
                        break;
                    }
                    floats.Add(asFloat);
                }
            }

            // Multiplication and division
            if (labelDisplay.Text.Contains('*') || labelDisplay.Text.Contains('/'))
            {
                for (int i = 0; i < operations.Count; i++)
                {
                    if (floats.Count == 1 || !expressionIsValid)
                        break;
                    if (operations[i] == '*')
                    {
                        floats[i] = floats[i] * floats[i + 1];
                        floats.RemoveAt(i + 1);
                        operations.RemoveAt(i);
                        i--;
                    }
                    else if (operations[i] == '/')
                    {
                        if (floats[i + 1] == 0)
                        {
                            expressionIsValid = false;
                            break;
                        }
                        floats[i] = floats[i] / floats[i + 1];
                        floats.RemoveAt(i + 1);
                        operations.RemoveAt(i);
                        i--;
                    }
                }
            }

            // Addition and substraction
            for (int i = 0; i < operations.Count; i++)
            {
                if (floats.Count == 1 || !expressionIsValid)
                    break;
                if (operations[i] == '+')
                {
                    floats[i] = floats[i] + floats[i + 1];
                    floats.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    i--;
                }
                else if (operations[i] == '-')
                {
                    floats[i] = floats[i] - floats[i + 1];
                    floats.RemoveAt(i + 1);
                    operations.RemoveAt(i);
                    i--;
                }
            }

            if(!expressionIsValid)
            {
                labelDisplay.Text = "Invalid expression!";
                stack.Clear();
            }
            else
            {
                labelDisplay.Text = floats[0].ToString();
                stack.Clear();
                foreach (char c in labelDisplay.Text)
                    stack.Push(c);
            }
        }

        /// <summary>
        /// A method that is called when the 'Delete' button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(labelDisplay.Text == "Invalid expression!")
                labelDisplay.Text = string.Empty;
            else
            {
                if (stack.Count > 0)
                    stack.Pop();
                if (labelDisplay.Text.Length > 0)
                    labelDisplay.Text = labelDisplay.Text.Remove(labelDisplay.Text.Length - 1);
            }
        }
    }
}
