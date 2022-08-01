using Galileo;
using Galileo6;

namespace Astronomical_Processing
{
    public partial class Astronomical_Processing : Form
    {
        public Astronomical_Processing()
        {
            InitializeComponent();
        }
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();


        #region GUI connections
        //4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        private void textBox_ATarget_TextChanged(object sender, KeyPressEventArgs e)
        {
            FilterTarget(e);
        }
        //4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        private void textBox_BTarget_TextChanged(object sender, KeyPressEventArgs e)
        {
            FilterTarget(e);
        }
        private void button_ASearchIterative_Click(object sender, EventArgs e)
        {
            int minimum = 0;
            bool found = false;
            int middle = minimum + maximum / 2;
            while (minimum <= maximum - 1)
            {

                if (target == list.ElementAt(middle))
                {
                    found = true;
                    break;
                }

                else if (target < list.ElementAt(middle))
                {
                    maximum = middle - 1;
                }
                else
                {
                    minimum = middle + 1;
                }
            }
            if (found)
            {
                //listbox.SelectedIndex = middle;
                MessageBox.Show("The target was found at element[" + middle + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //DisplayBox(mid);


            }
            else if (found==false)
            {
                MessageBox.Show("The target was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // The program must generate an error message if the search is not successful. 
            }
            //textBoxSearch.Clear();


            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_BSearchIterative_Click(object sender, EventArgs e)
        {

        }


        #endregion





        #region Methods
        private void LoadData()
        {


           // Galileo.ReadData.SensorA(((double)numericUpDownSigma.Value), ((double)numericUpDownMu.Value));
            //Galileo.ReadData.SensorB(((double)numericUpDownSigma.Value), ((double)numericUpDownMu.Value));
        }

        //4.14	Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        private void FilterTarget(KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox_ATarget.Text.IndexOf('.') !=-1)
            {
                e.Handled =true;
                return;
            }
            if (!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void BinarySearchIterative(int maximum, LinkedList<double> list, double target)
        {
            int minimum = 0;
            bool found = false;
            int middle = minimum + maximum / 2;
            while (minimum <= maximum - 1) {
               
                if (target == list.ElementAt(middle))
                {
                    found = true;
                    break;
                }

                else if (target < list.ElementAt(middle))
                {
                    maximum = middle - 1;
                }
                else
                {
                    minimum = middle + 1;
                }
            }
            if (found)
            {
                //listbox.SelectedIndex = middle;
                MessageBox.Show("The target was found at element[" + middle + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //DisplayBox(mid);


            }
            else if(found==false)
            {
                MessageBox.Show("The target was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // The program must generate an error message if the search is not successful. 
            }
            //textBoxSearch.Clear();
      

            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                   

        }
        private void BinarySearchRecursive()
        {

        }
        private void SelectionSort()
        {

        }
        private void InsertionSort()
        {

        }

        #endregion

        
    }
}