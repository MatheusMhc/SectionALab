using System.Diagnostics.Metrics;

namespace SectionALab
{
    public partial class Form1 : Form
    {
        const int ARRAYSIZE = 30;

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
            
            for(int i=0; i< myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0,101);
            }

            int counter = 0;
            do
            {
                lstDisplay.Items.Add(myArray[counter]);
                counter++;
            } while (counter < myArray.Length);

        }
    }
}