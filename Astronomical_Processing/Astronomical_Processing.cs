//Poorav Sharma
//30045900
//This application is a Satellite Data Processing Project for an organisation called Malin Space Science Systems (MSSS)
using Galileo;
using System.Diagnostics;

namespace Astronomical_Processing
{
    public partial class Astronomical_Processing : Form
    {       
        public Astronomical_Processing()
        {
            InitializeComponent();

        }
        //4.1 Create two data structures using the LinkedList<T> class from the C# Systems.Collections.Generic namespace. The data must be of type “double”; you are not permitted to use any additional classes, nodes, pointers or data structures (array, list, etc) in the implementation of this application. The two LinkedLists of type double are to be declared as global within the “public partial class”.
        LinkedList<double> sensorA = new LinkedList<double>();
        LinkedList<double> sensorB = new LinkedList<double>();



        #region GUI connections

        //4.14 Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        private void textBox_ATarget_TextChanged(object sender, KeyPressEventArgs e)
        {
            FilterTarget(e);
        }

        //4.14 Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
        private void textBox_BTarget_TextChanged(object sender, KeyPressEventArgs e)
        {
            FilterTarget(e);
        }

        /*4.11	Create four button click methods that will search the LinkedList for a value entered into a textbox on the form. The four methods are:
        1.	Method for Sensor A and Binary Search Iterative
        2.	Method for Sensor A and Binary Search Recursive
        3.	Method for Sensor B and Binary Search Iterative
        4.	Method for Sensor B and Binary Search Recursive
        The search code must check to ensure the data is sorted, then start a stopwatch before calling the search method.Once the search is complete the stopwatch will stop and the number of ticks will be displayed in a read only textbox.Finally, the code will call the “DisplayListboxData” method and highlight the appropriate number (or the next closest number). 
        */
        #region Search Buttons
        private void button_ASearchIterative_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            InsertionSort(numAnord(), sensorA);
            DisplayListBoxData(sensorA, listBox_SensorA);
            if (!string.IsNullOrEmpty(textBox_ATarget.Text))
            {
                stopWatch.Start();
                BinarySearchIterative(numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
                stopWatch.Stop();
                textBox_ASearchIterative.Text = stopWatch.ElapsedTicks.ToString()+" ticks";
            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }

        private void button_BSearchIterative_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            InsertionSort(numBnord(), sensorB);
            DisplayListBoxData(sensorB, listBox_SensorB);
            if (!string.IsNullOrEmpty(textBox_BTarget.Text))
            {
                stopWatch.Start();
                BinarySearchIterative(numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
                stopWatch.Stop();
                textBox_BSearchIterative.Text = stopWatch.ElapsedTicks.ToString()+" ticks";
            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button_ASearchRecursive_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            SelectionSort(numAnord(), sensorA);
            DisplayListBoxData(sensorA, listBox_SensorA);
            if (!string.IsNullOrEmpty(textBox_ATarget.Text))
            {
                stopWatch.Start();
                BinarySearchRecursive(0, numAnord(), sensorA, Convert.ToDouble(textBox_ATarget.Text), listBox_SensorA, textBox_ATarget);
                stopWatch.Stop();
                textBox_ASearchRecursive.Text = stopWatch.ElapsedTicks.ToString()+" ticks";

            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void button_BSearchRecursive_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            SelectionSort(numBnord(), sensorB);
            DisplayListBoxData(sensorB, listBox_SensorB);
            if (!string.IsNullOrEmpty(textBox_BTarget.Text))
            {
                stopWatch.Start();
                BinarySearchRecursive(0, numBnord(), sensorB, Convert.ToDouble(textBox_BTarget.Text), listBox_SensorB, textBox_BTarget);
                stopWatch.Stop();
                textBox_BSearchRecursive.Text = stopWatch.ElapsedTicks.ToString()+" ticks";
            }
            else
            {
                MessageBox.Show("Search Box is Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        /* 4.12	Create four button click methods that will sort the LinkedList using the Selection and Insertion methods.The four methods are:
         1.	Method for Sensor A and Selection Sort
         2.	Method for Sensor A and Insertion Sort
         3.	Method for Sensor B and Selection Sort
         4.	Method for Sensor B and Insertion Sort
         The button method must start a stopwatch before calling the sort method.Once the sort is complete the stopwatch will stop and the number of milliseconds will be displayed in a read only textbox. Finally, the code will call the “ShowAllSensorData” method and “DisplayListboxData” for the appropriate sensor.
        */
        #region Sort Buttons
        private void button_ASelectionSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            SelectionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_ASelectionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorA, listBox_SensorA);

        }

        private void button_BSelectionSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            SelectionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BSelectionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorB, listBox_SensorB);
        }

        private void button_AInsertionSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(numAnord(), sensorA);
            stopWatch.Stop();
            textBox_AInsertionSort.Text = stopWatch.ElapsedMilliseconds.ToString()+"ms";
            DisplayListBoxData(sensorA, listBox_SensorA);

        }

        private void button_BInsertionSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort(numBnord(), sensorB);
            stopWatch.Stop();
            textBox_BInsertionSort.Text = stopWatch.ElapsedMilliseconds.ToString() +"ms";
            DisplayListBoxData(sensorB, listBox_SensorB);

        }
        #endregion

        //4.4 Create a button and associated click method that will call the LoadData and ShowAllSensorData methods. The input parameters are empty, and the return type is void.
        private void button_LoadSensorData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion


        #region Methods

        //4.2 Copy the Galileo.DLL file into the root directory of your solution folder and add the appropriate reference in the solution explorer. Create a method called “LoadData” which will populate both LinkedLists. Declare an instance of the Galileo library in the method and create the appropriate loop construct to populate the two LinkedList; the data from Sensor A will populate the first LinkedList, while the data from Sensor B will populate the second LinkedList. The LinkedList size will be hardcoded inside the method and must be equal to 400. The input parameters are empty, and the return type is void.
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

        //4.3Create a custom method called “ShowAllSensorData” which will display both LinkedLists in a ListView.Add column titles “Sensor A” and “Sensor B” to the ListView.The input parameters are empty, and the return type is void.
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

        // 4.6 Create a method called “DisplayListboxData” that will display the content of a LinkedList inside the appropriate ListBox.The method signature will have two input parameters; a LinkedList, and the ListBox name.The calling code argument is the linkedlist name and the listbox name.
        private void DisplayListBoxData(LinkedList<double> list, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in list)
            {
                listBox.Items.Add(item);
            }

        }

        //4.14 Add two textboxes for the search value; one for each sensor, ensure only numeric values can be entered.
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

        //4.9Create a method called “BinarySearchIterative” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value. The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list. The method code must follow the pseudo code supplied below in the Appendix.
        private void BinarySearchIterative(int maximum, LinkedList<double> list, double target, ListBox listBox, TextBox textBox)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("Data out of bound", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //4.10 Create a method called “BinarySearchRecursive” which has the following four parameters: LinkedList, SearchValue, Minimum and Maximum. This method will return an integer of the linkedlist element from a successful search or the nearest neighbour value. The calling code argument is the linkedlist name, search value, minimum list size and the number of nodes in the list. The method code must follow the pseudo code supplied below in the Appendix.
        private void BinarySearchRecursive(int minimum, int maximum, LinkedList<double> list, double target, ListBox listBox, TextBox textBox)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("Data out of bound", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //4.7 Create a method called “SelectionSort” which has a single input parameter of type LinkedList, while the calling code argument is the linkedlist name. The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
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

        //4.8 Create a method called “InsertionSort” which has a single parameter of type LinkedList, while the calling code argument is the linkedlist name. The method code must follow the pseudo code supplied below in the Appendix. The return type is Boolean.
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

        //4.5 Create a method called “NumberOfNodes” that will return an integer which is the number of nodes(elements) in a LinkedList. The method signature will have an input parameter of type LinkedList, and the calling code argument is the linkedlist name.
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