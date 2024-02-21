using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        int num = 0;
        int counter = 0;
        string prime = "A megadott szám prímszám";
        string notPrime = "A megadott szám nem prímszám";
        string notValid = "Nem megfelelõ érték. Csak pozitív egész szám adható meg!";
        string result = "";

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
             num = (int)numericUpDown.Value;

            if (num >= 0)
            {
                if (num == 0 || num == 1)
                {
                    result = notPrime;
                }

                else if (num != 0 || num != 1)
                {
                    for (global::System.Int32 i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            counter += 1;
                        }
                        else counter = 0;
                    }

                    if (counter > 2)
                    {
                        result = notPrime;

                    }
                    else result = prime;

                }
            }
            else result = notValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = result;
        }
    }
}
