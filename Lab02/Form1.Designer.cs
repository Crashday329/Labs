namespace Lab01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStart_value = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber_of_elements = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.fChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxKValue = new System.Windows.Forms.NumericUpDown();
            this.textBoxMValue = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewMKM = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AtextBox = new System.Windows.Forms.NumericUpDown();
            this.BtextBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LineDistr = new System.Windows.Forms.RadioButton();
            this.NormalDistr = new System.Windows.Forms.RadioButton();
            this.ExpoDistr = new System.Windows.Forms.RadioButton();
            this.freqClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxStart_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumber_of_elements)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMValue)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AtextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtextBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите четырехзначное число для начала генерации данных";
            // 
            // textBoxStart_value
            // 
            this.textBoxStart_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStart_value.Location = new System.Drawing.Point(532, 19);
            this.textBoxStart_value.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStart_value.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.textBoxStart_value.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxStart_value.Name = "textBoxStart_value";
            this.textBoxStart_value.Size = new System.Drawing.Size(89, 26);
            this.textBoxStart_value.TabIndex = 3;
            this.textBoxStart_value.Value = new decimal(new int[] {
            1994,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите количество генерируемых данных";
            // 
            // textBoxNumber_of_elements
            // 
            this.textBoxNumber_of_elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber_of_elements.Location = new System.Drawing.Point(382, 51);
            this.textBoxNumber_of_elements.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber_of_elements.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.textBoxNumber_of_elements.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textBoxNumber_of_elements.Name = "textBoxNumber_of_elements";
            this.textBoxNumber_of_elements.Size = new System.Drawing.Size(89, 26);
            this.textBoxNumber_of_elements.TabIndex = 5;
            this.textBoxNumber_of_elements.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1082, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "M^=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1082, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "D^=";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(1125, 29);
            this.labelM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(16, 16);
            this.labelM.TabIndex = 9;
            this.labelM.Text = "0";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelD.Location = new System.Drawing.Point(1125, 61);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(16, 16);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "0";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.dChart);
            this.tabPage2.Controls.Add(this.fChart);
            this.tabPage2.Controls.Add(this.textBoxKValue);
            this.tabPage2.Controls.Add(this.textBoxMValue);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listViewMKM);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1444, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мультипликативный конгруэнтный метод";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.freqClassBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(435, 26);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Частоты значений";
            series1.XValueMember = "Xvalue";
            series1.YValueMembers = "Freq";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(684, 149);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "Частоты значений";
            title1.Name = "Частоты";
            this.chart1.Titles.Add(title1);
            // 
            // dChart
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.dChart.ChartAreas.Add(chartArea2);
            this.dChart.DataSource = this.freqClassBindingSource;
            legend2.Name = "Legend1";
            this.dChart.Legends.Add(legend2);
            this.dChart.Location = new System.Drawing.Point(435, 309);
            this.dChart.Margin = new System.Windows.Forms.Padding(4);
            this.dChart.Name = "dChart";
            this.dChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Функция распределения";
            series2.XValueMember = "Xvalue";
            series2.YValueMembers = "Freq";
            this.dChart.Series.Add(series2);
            this.dChart.Size = new System.Drawing.Size(698, 153);
            this.dChart.TabIndex = 11;
            this.dChart.Text = "Таблица Частот";
            title2.Name = "Частоты";
            this.dChart.Titles.Add(title2);
            // 
            // fChart
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.fChart.ChartAreas.Add(chartArea3);
            this.fChart.DataSource = this.freqClassBindingSource;
            legend3.Name = "Legend1";
            this.fChart.Legends.Add(legend3);
            this.fChart.Location = new System.Drawing.Point(435, 163);
            this.fChart.Margin = new System.Windows.Forms.Padding(4);
            this.fChart.Name = "fChart";
            this.fChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Плотность распределения";
            series3.XValueMember = "Xvalue";
            series3.YValueMembers = "Freq";
            this.fChart.Series.Add(series3);
            this.fChart.Size = new System.Drawing.Size(684, 149);
            this.fChart.TabIndex = 10;
            this.fChart.Text = "Плотность распределения";
            title3.Name = "Частоты";
            this.fChart.Titles.Add(title3);
            // 
            // textBoxKValue
            // 
            this.textBoxKValue.Location = new System.Drawing.Point(304, 8);
            this.textBoxKValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxKValue.Name = "textBoxKValue";
            this.textBoxKValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxKValue.TabIndex = 9;
            this.textBoxKValue.Value = new decimal(new int[] {
            2416,
            0,
            0,
            0});
            // 
            // textBoxMValue
            // 
            this.textBoxMValue.Location = new System.Drawing.Point(102, 7);
            this.textBoxMValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.textBoxMValue.Name = "textBoxMValue";
            this.textBoxMValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxMValue.TabIndex = 8;
            this.textBoxMValue.Value = new decimal(new int[] {
            1771875,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "k-Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "m-Value:";
            // 
            // listViewMKM
            // 
            this.listViewMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMKM.Location = new System.Drawing.Point(8, 64);
            this.listViewMKM.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMKM.Name = "listViewMKM";
            this.listViewMKM.Size = new System.Drawing.Size(419, 357);
            this.listViewMKM.TabIndex = 5;
            this.listViewMKM.UseCompatibleStateImageBehavior = false;
            this.listViewMKM.View = System.Windows.Forms.View.List;
            this.listViewMKM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMKM_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запустить процесс генерации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(18, 94);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1452, 546);
            this.tabControl1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(543, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "a:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "b:";
            // 
            // AtextBox
            // 
            this.AtextBox.Location = new System.Drawing.Point(566, 51);
            this.AtextBox.Name = "AtextBox";
            this.AtextBox.Size = new System.Drawing.Size(55, 22);
            this.AtextBox.TabIndex = 14;
            this.AtextBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BtextBox
            // 
            this.BtextBox.Location = new System.Drawing.Point(566, 77);
            this.BtextBox.Name = "BtextBox";
            this.BtextBox.Size = new System.Drawing.Size(55, 22);
            this.BtextBox.TabIndex = 15;
            this.BtextBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpoDistr);
            this.groupBox1.Controls.Add(this.NormalDistr);
            this.groupBox1.Controls.Add(this.LineDistr);
            this.groupBox1.Location = new System.Drawing.Point(628, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Распределение";
            // 
            // LineDistr
            // 
            this.LineDistr.AutoSize = true;
            this.LineDistr.Checked = true;
            this.LineDistr.Location = new System.Drawing.Point(7, 22);
            this.LineDistr.Name = "LineDistr";
            this.LineDistr.Size = new System.Drawing.Size(127, 20);
            this.LineDistr.TabIndex = 0;
            this.LineDistr.TabStop = true;
            this.LineDistr.Text = "Равномерное";
            this.LineDistr.UseVisualStyleBackColor = true;
            // 
            // NormalDistr
            // 
            this.NormalDistr.AutoSize = true;
            this.NormalDistr.Location = new System.Drawing.Point(7, 45);
            this.NormalDistr.Name = "NormalDistr";
            this.NormalDistr.Size = new System.Drawing.Size(118, 20);
            this.NormalDistr.TabIndex = 0;
            this.NormalDistr.Text = "Нормальное";
            this.NormalDistr.UseVisualStyleBackColor = true;
            // 
            // ExpoDistr
            // 
            this.ExpoDistr.AutoSize = true;
            this.ExpoDistr.Location = new System.Drawing.Point(6, 68);
            this.ExpoDistr.Name = "ExpoDistr";
            this.ExpoDistr.Size = new System.Drawing.Size(115, 20);
            this.ExpoDistr.TabIndex = 0;
            this.ExpoDistr.Text = "Экспонента";
            this.ExpoDistr.UseVisualStyleBackColor = true;
            // 
            // freqClassBindingSource
            // 
            this.freqClassBindingSource.DataSource = typeof(Lab01.FreqClass);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 598);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtextBox);
            this.Controls.Add(this.AtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber_of_elements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStart_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная №2";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxStart_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumber_of_elements)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxKValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxMValue)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AtextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtextBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.freqClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown textBoxStart_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textBoxNumber_of_elements;
        private System.Windows.Forms.BindingSource freqClassBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown textBoxKValue;
        private System.Windows.Forms.NumericUpDown textBoxMValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewMKM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart fChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown AtextBox;
        private System.Windows.Forms.NumericUpDown BtextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ExpoDistr;
        private System.Windows.Forms.RadioButton NormalDistr;
        private System.Windows.Forms.RadioButton LineDistr;
    }
}

