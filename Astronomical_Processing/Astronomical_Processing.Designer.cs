namespace Astronomical_Processing
{
    partial class Astronomical_Processing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMu = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Mu = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.column_SensorA = new System.Windows.Forms.ColumnHeader();
            this.column_SensorB = new System.Windows.Forms.ColumnHeader();
            this.button_LoadSensorData = new System.Windows.Forms.Button();
            this.label_SensorA = new System.Windows.Forms.Label();
            this.label_SensorB = new System.Windows.Forms.Label();
            this.label_ASearchIterative = new System.Windows.Forms.Label();
            this.button_ASearchIterative = new System.Windows.Forms.Button();
            this.textBox_ASearchIterative = new System.Windows.Forms.TextBox();
            this.label_ASearchRecursive = new System.Windows.Forms.Label();
            this.button_ASearchRecursive = new System.Windows.Forms.Button();
            this.textBox_ASearchRecursive = new System.Windows.Forms.TextBox();
            this.label_ASelectionSort = new System.Windows.Forms.Label();
            this.button_ASelectionSort = new System.Windows.Forms.Button();
            this.textBox_ASelectionSort = new System.Windows.Forms.TextBox();
            this.label_AInsertionSort = new System.Windows.Forms.Label();
            this.button_AInsertionSort = new System.Windows.Forms.Button();
            this.textBox_AInsertionSort = new System.Windows.Forms.TextBox();
            this.label_ASearchTarget = new System.Windows.Forms.Label();
            this.textBox_ATarget = new System.Windows.Forms.TextBox();
            this.listBox_SensorA = new System.Windows.Forms.ListBox();
            this.label_BSearchIterative = new System.Windows.Forms.Label();
            this.label_BSearchTarget = new System.Windows.Forms.Label();
            this.label_BSearchRecursive = new System.Windows.Forms.Label();
            this.label_BSelectionSort = new System.Windows.Forms.Label();
            this.label_BInsertionSort = new System.Windows.Forms.Label();
            this.button_BSearchIterative = new System.Windows.Forms.Button();
            this.button_BSearchRecursive = new System.Windows.Forms.Button();
            this.button_BSelectionSort = new System.Windows.Forms.Button();
            this.button_BInsertionSort = new System.Windows.Forms.Button();
            this.textBox_BSearchIterative = new System.Windows.Forms.TextBox();
            this.textBox_BSearchRecursive = new System.Windows.Forms.TextBox();
            this.textBox_BTarget = new System.Windows.Forms.TextBox();
            this.textBox_BSelectionSort = new System.Windows.Forms.TextBox();
            this.textBox_BInsertionSort = new System.Windows.Forms.TextBox();
            this.listBox_SensorB = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.Location = new System.Drawing.Point(26, 35);
            this.numericUpDownSigma.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownSigma.TabIndex = 0;
            this.numericUpDownSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMu
            // 
            this.numericUpDownMu.Location = new System.Drawing.Point(126, 35);
            this.numericUpDownMu.Maximum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numericUpDownMu.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDownMu.Name = "numericUpDownMu";
            this.numericUpDownMu.Size = new System.Drawing.Size(56, 23);
            this.numericUpDownMu.TabIndex = 0;
            this.numericUpDownMu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMu.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sigma";
            // 
            // label_Mu
            // 
            this.label_Mu.AutoSize = true;
            this.label_Mu.Location = new System.Drawing.Point(126, 15);
            this.label_Mu.Name = "label_Mu";
            this.label_Mu.Size = new System.Drawing.Size(25, 15);
            this.label_Mu.TabIndex = 1;
            this.label_Mu.Text = "Mu";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_SensorA,
            this.column_SensorB});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(26, 104);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(156, 379);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column_SensorA
            // 
            this.column_SensorA.Text = "Sensor A";
            this.column_SensorA.Width = 70;
            // 
            // column_SensorB
            // 
            this.column_SensorB.Text = "Sensor B";
            this.column_SensorB.Width = 70;
            // 
            // button_LoadSensorData
            // 
            this.button_LoadSensorData.Location = new System.Drawing.Point(26, 70);
            this.button_LoadSensorData.Name = "button_LoadSensorData";
            this.button_LoadSensorData.Size = new System.Drawing.Size(156, 23);
            this.button_LoadSensorData.TabIndex = 3;
            this.button_LoadSensorData.Text = "Load Sensor Data";
            this.button_LoadSensorData.UseVisualStyleBackColor = true;
            this.button_LoadSensorData.Click += new System.EventHandler(this.button_LoadSensorData_Click);
            // 
            // label_SensorA
            // 
            this.label_SensorA.AutoSize = true;
            this.label_SensorA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SensorA.Location = new System.Drawing.Point(267, 9);
            this.label_SensorA.Name = "label_SensorA";
            this.label_SensorA.Size = new System.Drawing.Size(120, 37);
            this.label_SensorA.TabIndex = 1;
            this.label_SensorA.Text = "Sensor A";
            // 
            // label_SensorB
            // 
            this.label_SensorB.AutoSize = true;
            this.label_SensorB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SensorB.Location = new System.Drawing.Point(560, 9);
            this.label_SensorB.Name = "label_SensorB";
            this.label_SensorB.Size = new System.Drawing.Size(118, 37);
            this.label_SensorB.TabIndex = 1;
            this.label_SensorB.Text = "Sensor B";
            // 
            // label_ASearchIterative
            // 
            this.label_ASearchIterative.AutoSize = true;
            this.label_ASearchIterative.Location = new System.Drawing.Point(210, 57);
            this.label_ASearchIterative.Name = "label_ASearchIterative";
            this.label_ASearchIterative.Size = new System.Drawing.Size(123, 15);
            this.label_ASearchIterative.TabIndex = 1;
            this.label_ASearchIterative.Text = "Binary Search Iterative";
            // 
            // button_ASearchIterative
            // 
            this.button_ASearchIterative.Location = new System.Drawing.Point(210, 81);
            this.button_ASearchIterative.Name = "button_ASearchIterative";
            this.button_ASearchIterative.Size = new System.Drawing.Size(75, 23);
            this.button_ASearchIterative.TabIndex = 4;
            this.button_ASearchIterative.Text = "Search";
            this.button_ASearchIterative.UseVisualStyleBackColor = true;
            this.button_ASearchIterative.Click += new System.EventHandler(this.button_ASearchIterative_Click);
            // 
            // textBox_ASearchIterative
            // 
            this.textBox_ASearchIterative.Location = new System.Drawing.Point(210, 110);
            this.textBox_ASearchIterative.Name = "textBox_ASearchIterative";
            this.textBox_ASearchIterative.ReadOnly = true;
            this.textBox_ASearchIterative.Size = new System.Drawing.Size(100, 23);
            this.textBox_ASearchIterative.TabIndex = 5;
        
            // 
            // label_ASearchRecursive
            // 
            this.label_ASearchRecursive.AutoSize = true;
            this.label_ASearchRecursive.Location = new System.Drawing.Point(210, 144);
            this.label_ASearchRecursive.Name = "label_ASearchRecursive";
            this.label_ASearchRecursive.Size = new System.Drawing.Size(131, 15);
            this.label_ASearchRecursive.TabIndex = 1;
            this.label_ASearchRecursive.Text = "Binary Search Recursive";
            // 
            // button_ASearchRecursive
            // 
            this.button_ASearchRecursive.Location = new System.Drawing.Point(210, 168);
            this.button_ASearchRecursive.Name = "button_ASearchRecursive";
            this.button_ASearchRecursive.Size = new System.Drawing.Size(75, 23);
            this.button_ASearchRecursive.TabIndex = 4;
            this.button_ASearchRecursive.Text = "Search";
            this.button_ASearchRecursive.UseVisualStyleBackColor = true;
            this.button_ASearchRecursive.Click += new System.EventHandler(this.button_ASearchRecursive_Click);
            // 
            // textBox_ASearchRecursive
            // 
            this.textBox_ASearchRecursive.Location = new System.Drawing.Point(210, 197);
            this.textBox_ASearchRecursive.Name = "textBox_ASearchRecursive";
            this.textBox_ASearchRecursive.ReadOnly = true;
            this.textBox_ASearchRecursive.Size = new System.Drawing.Size(100, 23);
            this.textBox_ASearchRecursive.TabIndex = 5;
            // 
            // label_ASelectionSort
            // 
            this.label_ASelectionSort.AutoSize = true;
            this.label_ASelectionSort.Location = new System.Drawing.Point(210, 289);
            this.label_ASelectionSort.Name = "label_ASelectionSort";
            this.label_ASelectionSort.Size = new System.Drawing.Size(79, 15);
            this.label_ASelectionSort.TabIndex = 1;
            this.label_ASelectionSort.Text = "Selection Sort";
            // 
            // button_ASelectionSort
            // 
            this.button_ASelectionSort.Location = new System.Drawing.Point(210, 313);
            this.button_ASelectionSort.Name = "button_ASelectionSort";
            this.button_ASelectionSort.Size = new System.Drawing.Size(75, 23);
            this.button_ASelectionSort.TabIndex = 4;
            this.button_ASelectionSort.Text = "Sort";
            this.button_ASelectionSort.UseVisualStyleBackColor = true;
            this.button_ASelectionSort.Click += new System.EventHandler(this.button_ASelectionSort_Click);
            // 
            // textBox_ASelectionSort
            // 
            this.textBox_ASelectionSort.Location = new System.Drawing.Point(210, 342);
            this.textBox_ASelectionSort.Name = "textBox_ASelectionSort";
            this.textBox_ASelectionSort.ReadOnly = true;
            this.textBox_ASelectionSort.Size = new System.Drawing.Size(100, 23);
            this.textBox_ASelectionSort.TabIndex = 5;
            // 
            // label_AInsertionSort
            // 
            this.label_AInsertionSort.AutoSize = true;
            this.label_AInsertionSort.Location = new System.Drawing.Point(210, 378);
            this.label_AInsertionSort.Name = "label_AInsertionSort";
            this.label_AInsertionSort.Size = new System.Drawing.Size(77, 15);
            this.label_AInsertionSort.TabIndex = 1;
            this.label_AInsertionSort.Text = "Insertion Sort";
            // 
            // button_AInsertionSort
            // 
            this.button_AInsertionSort.Location = new System.Drawing.Point(210, 402);
            this.button_AInsertionSort.Name = "button_AInsertionSort";
            this.button_AInsertionSort.Size = new System.Drawing.Size(75, 23);
            this.button_AInsertionSort.TabIndex = 4;
            this.button_AInsertionSort.Text = "Sort";
            this.button_AInsertionSort.UseVisualStyleBackColor = true;
            this.button_AInsertionSort.Click += new System.EventHandler(this.button_AInsertionSort_Click);
            // 
            // textBox_AInsertionSort
            // 
            this.textBox_AInsertionSort.Location = new System.Drawing.Point(210, 431);
            this.textBox_AInsertionSort.Name = "textBox_AInsertionSort";
            this.textBox_AInsertionSort.ReadOnly = true;
            this.textBox_AInsertionSort.Size = new System.Drawing.Size(100, 23);
            this.textBox_AInsertionSort.TabIndex = 5;
            // 
            // label_ASearchTarget
            // 
            this.label_ASearchTarget.AutoSize = true;
            this.label_ASearchTarget.Location = new System.Drawing.Point(210, 246);
            this.label_ASearchTarget.Name = "label_ASearchTarget";
            this.label_ASearchTarget.Size = new System.Drawing.Size(80, 15);
            this.label_ASearchTarget.TabIndex = 1;
            this.label_ASearchTarget.Text = "Search Target:";
            // 
            // textBox_ATarget
            // 
            this.textBox_ATarget.Location = new System.Drawing.Point(293, 243);
            this.textBox_ATarget.Name = "textBox_ATarget";
            this.textBox_ATarget.Size = new System.Drawing.Size(40, 23);
            this.textBox_ATarget.TabIndex = 5;
            this.textBox_ATarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ATarget_TextChanged);
            // 
            // listBox_SensorA
            // 
            this.listBox_SensorA.FormattingEnabled = true;
            this.listBox_SensorA.ItemHeight = 15;
            this.listBox_SensorA.Location = new System.Drawing.Point(358, 61);
            this.listBox_SensorA.Name = "listBox_SensorA";
            this.listBox_SensorA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox_SensorA.Size = new System.Drawing.Size(107, 424);
            this.listBox_SensorA.TabIndex = 6;
            // 
            // label_BSearchIterative
            // 
            this.label_BSearchIterative.AutoSize = true;
            this.label_BSearchIterative.Location = new System.Drawing.Point(492, 57);
            this.label_BSearchIterative.Name = "label_BSearchIterative";
            this.label_BSearchIterative.Size = new System.Drawing.Size(123, 15);
            this.label_BSearchIterative.TabIndex = 1;
            this.label_BSearchIterative.Text = "Binary Search Iterative";
            // 
            // label_BSearchTarget
            // 
            this.label_BSearchTarget.AutoSize = true;
            this.label_BSearchTarget.Location = new System.Drawing.Point(492, 246);
            this.label_BSearchTarget.Name = "label_BSearchTarget";
            this.label_BSearchTarget.Size = new System.Drawing.Size(80, 15);
            this.label_BSearchTarget.TabIndex = 1;
            this.label_BSearchTarget.Text = "Search Target:";
            // 
            // label_BSearchRecursive
            // 
            this.label_BSearchRecursive.AutoSize = true;
            this.label_BSearchRecursive.Location = new System.Drawing.Point(492, 144);
            this.label_BSearchRecursive.Name = "label_BSearchRecursive";
            this.label_BSearchRecursive.Size = new System.Drawing.Size(131, 15);
            this.label_BSearchRecursive.TabIndex = 1;
            this.label_BSearchRecursive.Text = "Binary Search Recursive";
            // 
            // label_BSelectionSort
            // 
            this.label_BSelectionSort.AutoSize = true;
            this.label_BSelectionSort.Location = new System.Drawing.Point(492, 289);
            this.label_BSelectionSort.Name = "label_BSelectionSort";
            this.label_BSelectionSort.Size = new System.Drawing.Size(79, 15);
            this.label_BSelectionSort.TabIndex = 1;
            this.label_BSelectionSort.Text = "Selection Sort";
            // 
            // label_BInsertionSort
            // 
            this.label_BInsertionSort.AutoSize = true;
            this.label_BInsertionSort.Location = new System.Drawing.Point(492, 378);
            this.label_BInsertionSort.Name = "label_BInsertionSort";
            this.label_BInsertionSort.Size = new System.Drawing.Size(77, 15);
            this.label_BInsertionSort.TabIndex = 1;
            this.label_BInsertionSort.Text = "Insertion Sort";
            // 
            // button_BSearchIterative
            // 
            this.button_BSearchIterative.Location = new System.Drawing.Point(492, 81);
            this.button_BSearchIterative.Name = "button_BSearchIterative";
            this.button_BSearchIterative.Size = new System.Drawing.Size(75, 23);
            this.button_BSearchIterative.TabIndex = 4;
            this.button_BSearchIterative.Text = "Search";
            this.button_BSearchIterative.UseVisualStyleBackColor = true;
            this.button_BSearchIterative.Click += new System.EventHandler(this.button_BSearchIterative_Click);
            // 
            // button_BSearchRecursive
            // 
            this.button_BSearchRecursive.Location = new System.Drawing.Point(492, 168);
            this.button_BSearchRecursive.Name = "button_BSearchRecursive";
            this.button_BSearchRecursive.Size = new System.Drawing.Size(75, 23);
            this.button_BSearchRecursive.TabIndex = 4;
            this.button_BSearchRecursive.Text = "Search";
            this.button_BSearchRecursive.UseVisualStyleBackColor = true;
            this.button_BSearchRecursive.Click += new System.EventHandler(this.button_BSearchRecursive_Click);
            // 
            // button_BSelectionSort
            // 
            this.button_BSelectionSort.Location = new System.Drawing.Point(492, 313);
            this.button_BSelectionSort.Name = "button_BSelectionSort";
            this.button_BSelectionSort.Size = new System.Drawing.Size(75, 23);
            this.button_BSelectionSort.TabIndex = 4;
            this.button_BSelectionSort.Text = "Sort";
            this.button_BSelectionSort.UseVisualStyleBackColor = true;
            this.button_BSelectionSort.Click += new System.EventHandler(this.button_BSelectionSort_Click);
            // 
            // button_BInsertionSort
            // 
            this.button_BInsertionSort.Location = new System.Drawing.Point(492, 402);
            this.button_BInsertionSort.Name = "button_BInsertionSort";
            this.button_BInsertionSort.Size = new System.Drawing.Size(75, 23);
            this.button_BInsertionSort.TabIndex = 4;
            this.button_BInsertionSort.Text = "Sort";
            this.button_BInsertionSort.UseVisualStyleBackColor = true;
            this.button_BInsertionSort.Click += new System.EventHandler(this.button_BInsertionSort_Click);
            // 
            // textBox_BSearchIterative
            // 
            this.textBox_BSearchIterative.Location = new System.Drawing.Point(492, 110);
            this.textBox_BSearchIterative.Name = "textBox_BSearchIterative";
            this.textBox_BSearchIterative.ReadOnly = true;
            this.textBox_BSearchIterative.Size = new System.Drawing.Size(100, 23);
            this.textBox_BSearchIterative.TabIndex = 5;
            // 
            // textBox_BSearchRecursive
            // 
            this.textBox_BSearchRecursive.Location = new System.Drawing.Point(492, 197);
            this.textBox_BSearchRecursive.Name = "textBox_BSearchRecursive";
            this.textBox_BSearchRecursive.ReadOnly = true;
            this.textBox_BSearchRecursive.Size = new System.Drawing.Size(100, 23);
            this.textBox_BSearchRecursive.TabIndex = 5;
            // 
            // textBox_BTarget
            // 
            this.textBox_BTarget.Location = new System.Drawing.Point(575, 243);
            this.textBox_BTarget.Name = "textBox_BTarget";
            this.textBox_BTarget.Size = new System.Drawing.Size(40, 23);
            this.textBox_BTarget.TabIndex = 5;
            this.textBox_BTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_BTarget_TextChanged);
            // 
            // textBox_BSelectionSort
            // 
            this.textBox_BSelectionSort.Location = new System.Drawing.Point(492, 342);
            this.textBox_BSelectionSort.Name = "textBox_BSelectionSort";
            this.textBox_BSelectionSort.ReadOnly = true;
            this.textBox_BSelectionSort.Size = new System.Drawing.Size(100, 23);
            this.textBox_BSelectionSort.TabIndex = 5;
            // 
            // textBox_BInsertionSort
            // 
            this.textBox_BInsertionSort.Location = new System.Drawing.Point(492, 431);
            this.textBox_BInsertionSort.Name = "textBox_BInsertionSort";
            this.textBox_BInsertionSort.ReadOnly = true;
            this.textBox_BInsertionSort.Size = new System.Drawing.Size(100, 23);
            this.textBox_BInsertionSort.TabIndex = 5;
            // 
            // listBox_SensorB
            // 
            this.listBox_SensorB.FormattingEnabled = true;
            this.listBox_SensorB.ItemHeight = 15;
            this.listBox_SensorB.Location = new System.Drawing.Point(640, 61);
            this.listBox_SensorB.Name = "listBox_SensorB";
            this.listBox_SensorB.Size = new System.Drawing.Size(107, 424);
            this.listBox_SensorB.TabIndex = 6;
            // 
            // Astronomical_Processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 495);
            this.Controls.Add(this.listBox_SensorB);
            this.Controls.Add(this.listBox_SensorA);
            this.Controls.Add(this.textBox_BInsertionSort);
            this.Controls.Add(this.textBox_AInsertionSort);
            this.Controls.Add(this.textBox_BSelectionSort);
            this.Controls.Add(this.textBox_ASelectionSort);
            this.Controls.Add(this.textBox_BTarget);
            this.Controls.Add(this.textBox_ATarget);
            this.Controls.Add(this.textBox_BSearchRecursive);
            this.Controls.Add(this.textBox_ASearchRecursive);
            this.Controls.Add(this.textBox_BSearchIterative);
            this.Controls.Add(this.textBox_ASearchIterative);
            this.Controls.Add(this.button_BInsertionSort);
            this.Controls.Add(this.button_AInsertionSort);
            this.Controls.Add(this.button_BSelectionSort);
            this.Controls.Add(this.button_ASelectionSort);
            this.Controls.Add(this.button_BSearchRecursive);
            this.Controls.Add(this.button_ASearchRecursive);
            this.Controls.Add(this.button_BSearchIterative);
            this.Controls.Add(this.button_ASearchIterative);
            this.Controls.Add(this.button_LoadSensorData);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label_Mu);
            this.Controls.Add(this.label_SensorB);
            this.Controls.Add(this.label_BInsertionSort);
            this.Controls.Add(this.label_AInsertionSort);
            this.Controls.Add(this.label_BSelectionSort);
            this.Controls.Add(this.label_ASelectionSort);
            this.Controls.Add(this.label_BSearchRecursive);
            this.Controls.Add(this.label_ASearchRecursive);
            this.Controls.Add(this.label_SensorA);
            this.Controls.Add(this.label_BSearchTarget);
            this.Controls.Add(this.label_ASearchTarget);
            this.Controls.Add(this.label_BSearchIterative);
            this.Controls.Add(this.label_ASearchIterative);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMu);
            this.Controls.Add(this.numericUpDownSigma);
            this.Name = "Astronomical_Processing";
            this.Text = "Astronomical_Processing";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDownSigma;
        private NumericUpDown numericUpDownMu;
        private Label label1;
        private Label label_Mu;
        private ListView listView;
        private ColumnHeader column_SensorA;
        private ColumnHeader column_SensorB;
        private Button button_LoadSensorData;
        private Label label_SensorA;
        private Label label_SensorB;
        private Label label_ASearchIterative;
        private Button button_ASearchIterative;
        private TextBox textBox_ASearchIterative;
        private Label label_ASearchRecursive;
        private Button button_ASearchRecursive;
        private TextBox textBox_ASearchRecursive;
        private Label label_ASelectionSort;
        private Button button_ASelectionSort;
        private TextBox textBox_ASelectionSort;
        private Label label_AInsertionSort;
        private Button button_AInsertionSort;
        private TextBox textBox_AInsertionSort;
        private Label label_ASearchTarget;
        private TextBox textBox_ATarget;
        private ListBox listBox_SensorA;
        private Label label_BSearchIterative;
        private Label label_BSearchTarget;
        private Label label_BSearchRecursive;
        private Label label_BSelectionSort;
        private Label label_BInsertionSort;
        private Button button_BSearchIterative;
        private Button button_BSearchRecursive;
        private Button button_BSelectionSort;
        private Button button_BInsertionSort;
        private TextBox textBox_BSearchIterative;
        private TextBox textBox_BSearchRecursive;
        private TextBox textBox_BTarget;
        private TextBox textBox_BSelectionSort;
        private TextBox textBox_BInsertionSort;
        private ListBox listBox_SensorB;
    }
}