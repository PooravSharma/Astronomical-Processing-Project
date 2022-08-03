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
            textBox_ASearchIterative.Enabled = false;
            textBox_BSearchIterative.Enabled = false;
            textBox_ASearchRecursive.Enabled = false;
            textBox_BSearchRecursive.Enabled = false;
            textBox_ASelectionSort.Enabled = false;
            textBox_BSelectionSort.Enabled = false;
            textBox_AInsertionSort.Enabled = false;
            textBox_BInsertionSort.Enabled = false;
        }
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();
        // textBox_ASearchIterative.Enabled = false;
        
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
            stopWatch.Start();
            BinarySearchIterative(numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
            stopWatch.Stop();
            textBox_ASearchIterative.Text = stopWatch.Elapsed.ToString();
        }

        private void button_BSearchIterative_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            BinarySearchIterative(numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
            stopWatch.Stop();
            textBox_BSearchIterative.Text = stopWatch.Elapsed.ToString();
        }

        private void button_ASearchRecursive_Click(object sender, EventArgs e)
        {   stopWatch.Start();
            BinarySearchRecursive(0, numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
            stopWatch.Stop();
            textBox_ASearchRecursive.Text = stopWatch.Elapsed.ToString();
        }

        private void button_BSearchRecursive_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            BinarySearchRecursive(0, numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
            stopWatch.Stop();
            textBox_BSearchRecursive.Text = stopWatch.Elapsed.ToString();
        }

        private void button_ASelectionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            SelectionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_ASelectionSort.Text = stopWatch.Elapsed.ToString();
            ShowAllSensorData();
        }

        private void button_BSelectionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            SelectionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BSelectionSort.Text = stopWatch.Elapsed.ToString();
            ShowAllSensorData();
        }
        private void button_AInsertionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            InsertionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_AInsertionSort.Text = stopWatch.Elapsed.ToString();
            ShowAllSensorData();
        }

        private void button_BInsertionSort_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            InsertionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BInsertionSort.Text = stopWatch.Elapsed.ToString();
            ShowAllSensorData();
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
         
            ShowAllSensorData();
        }

        private void ShowAllSensorData()
        {
            DisplayListBoxData(sensorA, listBox_SensorA);
            DisplayListBoxData(sensorB, listBox_SensorB);
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
            listBox.Items.Clear() ;
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
            if (!string.IsNullOrEmpty(textBox.Text))
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
                    listBox.SelectedIndex = middle;
                    MessageBox.Show("The target was found at element[" + middle + "]", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("The target was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void BinarySearchRecursive(int minimum, int maximum, LinkedList<double> list, double target, ListBox listBox, TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                if (minimum <= maximum - 1)
                {
                    int middle = minimum + maximum / 2;
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
                        BinarySearchRecursive(middle - 1, maximum, list, target, listBox, textBox);
                    }
                }
                else
                {
                    MessageBox.Show("The target was Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelectionSort(int max, LinkedList<double> list)
        {
            int min = 0;

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

        }

        private void InsertionSort(int max, LinkedList<double> list)
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