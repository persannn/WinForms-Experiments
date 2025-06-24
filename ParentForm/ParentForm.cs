using Calculator;
using Scramble;

namespace ParentForm
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            if(Calculator != null)
                Calculator.Close();
            Calculator = new FormCalculator();
            Calculator.Show();
        }

        private void buttonScramble_Click(object sender, EventArgs e)
        {
            if(Scramble != null)
                Scramble.Close();
            Scramble = new FormScramble();
            Scramble.Show();
        }
    }
}
