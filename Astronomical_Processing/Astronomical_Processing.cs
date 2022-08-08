using Galileo;
using System.Diagnostics;

namespace Astronomical_Processing
{
    public partial class Astronomical_Processing : Form
    {
        Stopwatch stopWatch = new Stopwatch();
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
            if (SelectionSort(numAnord(), sensorA)||InsertionSort(numAnord(), sensorA))
            {
                if (!string.IsNullOrEmpty(textBox_ATarget.Text))
                {
                    stopWatch.Start();
                    BinarySearchIterative(numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
                    stopWatch.Stop();
                    textBox_ASearchIterative.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
                }
                else
                {
                    MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sort the list before you search", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_BSearchIterative_Click(object sender, EventArgs e)
        {
            if (SelectionSort(numBnord(), sensorB)||InsertionSort(numBnord(), sensorB))
            {
                if (!string.IsNullOrEmpty(textBox_BTarget.Text))
                {
                    stopWatch.Start();
                    BinarySearchIterative(numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
                    stopWatch.Stop();
                    textBox_BSearchIterative.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
                }
                else
                {
                    MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sort the list before you search", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_ASearchRecursive_Click(object sender, EventArgs e)
        {
            if (SelectionSort(numAnord(), sensorA)||InsertionSort(numAnord(), sensorA))
            {
                if (!string.IsNullOrEmpty(textBox_ATarget.Text))
                {
                    stopWatch.Start();
                    BinarySearchRecursive(0, numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
                    stopWatch.Stop();
                    textBox_ASearchRecursive.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
                    
                }
                else
                {
                    MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sort the list before you search", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_BSearchRecursive_Click(object sender, EventArgs e)
        {
            if (SelectionSort(numBnord(), sensorB)||InsertionSort(numBnord(), sensorB))
            {
                if (!string.IsNullOrEmpty(textBox_BTarget.Text))
                {
                    stopWatch.Start();
                    BinarySearchRecursive(0, numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
                    stopWatch.Stop();
                    textBox_BSearchRecursive.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
                }
                else
                {
                    MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sort the list before you search", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_ASelectionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            SelectionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_ASelectionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorA, listBox_SensorA);
           
        }

        private void button_BSelectionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            SelectionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BSelectionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorB, listBox_SensorB);
        }
        private void button_AInsertionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            InsertionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_AInsertionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorA, listBox_SensorA);
       
        }

        private void button_BInsertionSort_Click(object sender, EventArgs e)
        {

            stopWatch.Start();
            InsertionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BInsertionSort.Text = stopWatch.ElapsedMilliseconds.ToString() +"ms";
            DisplayListBoxData(sensorB, listBox_SensorB);

        }
        private void button_LoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void textBox_ASearchIterative_TextChanged(object sender, EventArgs e)
        {


            textBox_ASearchIterative.Enabled = false;
        }

        #endregion


        #region Methods
        private void LoadData()
        {

            sensorA.Clear();
            sensorB.Clear();
            ReadData readData = new ReadData();
            double max = 400;
            double sigma = (double)numericUpDownSigma.Value;
            double mu = (double)numericUpDownMu.Value;
            for (int i = 0; i < max; i++)
            {
                sensorA.AddLast((double)readData.SensorA(mu, sigma));
                sensorB.AddLast((double)readData.SensorB(mu, sigma));
            }
            DisplayListBoxData(sensorA, listBox_SensorA);
            DisplayListBoxData(sensorB, listBox_SensorB);
            ShowAllSensorData();
        }

        private void ShowAllSensorData()
        {
            
            listView.Items.Clear();

            for (int i = 0; i < listBox_SensorA.Items.Count; i++)
            {
                ListViewItem item = new ListViewItem(listBox_SensorA.Items[i].ToString());
                item.SubItems.Add(listBox_SensorB.Items[i].ToString());
                listView.Items.Add(item);

            }

        }
        private void DisplayListBoxData(LinkedList<double> list, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in list)
            {
                listBox.Items.Add(item);
            }

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

        private void BinarySearchIterative(int maximum, LinkedList<double> list, double target, ListBox listBox, TextBox textBox)
        {
            listBox.SelectedIndices.Clear();
            int minimum = 0;
            bool found = false;
            int middle = 0;
            while (minimum <= maximum - 1)
            {
                middle = (minimum + maximum) / 2;
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
                listBox.SelectedIndex = middle;       
                MessageBox.Show("The target was found at element[" + middle + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            { 
                listBox.SelectedIndices.Add(minimum-1);
                listBox.SelectedIndices.Add(minimum);                
                listBox.SelectedIndices.Add(minimum+1);
                listBox.SelectedIndices.Add(minimum+2);
                listBox.SelectedIndices.Add(minimum+3);
            }
            textBox.Clear();

        }

        private void BinarySearchRecursive(int minimum, int maximum, LinkedList<double> list, double target, ListBox listBox, TextBox textBox)
        {
            listBox.SelectedIndices.Clear();

            if (minimum <= maximum)
            {
                int middle = (minimum + maximum) / 2;
                if (target == list.ElementAt(middle))
                {
                    listBox.SelectedIndex = middle;
                    MessageBox.Show("The target was found at element[" + middle + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (target < list.ElementAt(middle))
                {
                    BinarySearchRecursive(minimum, middle - 1, list, target, listBox, textBox);
                }
                else
                {
                    BinarySearchRecursive(middle +1, maximum, list, target, listBox, textBox);
                }
            }
            else
            {
                listBox.SelectedIndices.Add(minimum-1);
                listBox.SelectedIndices.Add(minimum);
                listBox.SelectedIndices.Add(minimum+1);
                listBox.SelectedIndices.Add(minimum+2);
                listBox.SelectedIndices.Add(minimum+3);
            }
            textBox.Clear();
        }

        private bool SelectionSort(int max, LinkedList<double> list)
        {
            int min;

            for (int i = 0; i < max; i++)
            {
                min = i;
                for (int j = i + 1; j < max; j++)
                {

                    if (list.ElementAt(j) < list.ElementAt(min))
                    {
                        min = j;
                    }

                }

                LinkedListNode<double> currentMin = list.Find(list.ElementAt(min));
                LinkedListNode<double> currentI = list.Find(list.ElementAt(i));

                var temp = currentMin.Value;
                currentMin.Value = currentI.Value;
                currentI.Value = temp;
            }
            return true;
        }

        private bool InsertionSort(int max, LinkedList<double> list)
        {
            for (int i = 0; i < max - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (list.ElementAt(j - 1) > list.ElementAt(j))
                    {

                        LinkedListNode<double> current = list.Find(list.ElementAt(j));
                        LinkedListNode<double> currentPre = list.Find(list.ElementAt(j-1));

                        var temp = current.Value;
                        current.Value = currentPre.Value;
                        currentPre.Value = temp;

                    }
                }
            }
            return true;
        }

        private int numAnord()
        {

            return sensorA.Count();

        }

        private int numBnord()
        {

            return sensorB.Count();
        }





        #endregion


    }

}