using System.Diagnostics.Metrics;

namespace SectionALab
{
    public partial class Form1 : Form
    {
        const int ARRAYSIZE = 10;

        int[] myArray = new int[ARRAYSIZE];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0, 11);
            }

            int counter = 0;
            lstDisplay.Items.Clear();
            do
            {
                lstDisplay.Items.Add(myArray[counter]);
                counter++;
            } while (counter < myArray.Length);

        }

        private void btnSumArray_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in myArray)
            {
                sum += i;
            }

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add($"The sum of the array={sum}");
        }

        private void btnDisplayRange_Click(object sender, EventArgs e)
        {
            int howManyDisplay = 0;
            int start = 0;

            validationMethod(ref howManyDisplay, ref start);

        }

        private void validationMethod(ref int howManyDisplay, ref int start)
        {
            try
            {
                if (!int.TryParse(txtSubscript.Text, out start)) { MessageBox.Show("Entry must only contain number"); return; }
                if (start < 0 || start > ARRAYSIZE) { MessageBox.Show("Starting number is out of range"); return; }

                if (!int.TryParse(txtHowManyDisplay.Text, out howManyDisplay)) { MessageBox.Show("Entry must only contain number"); return; }
                if (howManyDisplay <= 0 || (start + howManyDisplay > ARRAYSIZE)) { MessageBox.Show("Range number is out of range"); return; }

                lstDisplay.Items.Clear();
                for (int i = start; i < start + howManyDisplay; i++)
                {
                    lstDisplay.Items.Add($"Subscript {i} = {myArray[i]}");
                }
            } catch(Exception e)
            {
                MessageBox.Show("ERROR: " + e.Message);
            }
            
        }
    }
}