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
            this.chartMSK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.freqClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewMSK = new System.Windows.Forms.ListView();
            this.buttonMSK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxKValue = new System.Windows.Forms.TextBox();
            this.textBoxMValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewMKM = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStart_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber_of_elements = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMSK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqClassBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMSK
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartMSK.ChartAreas.Add(chartArea1);
            this.chartMSK.DataSource = this.freqClassBindingSource;
            legend1.Name = "Legend1";
            this.chartMSK.Legends.Add(legend1);
            this.chartMSK.Location = new System.Drawing.Point(591, 113);
            this.chartMSK.Margin = new System.Windows.Forms.Padding(4);
            this.chartMSK.Name = "chartMSK";
            this.chartMSK.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Частоты";
            series1.XValueMember = "Xvalue";
            series1.YValueMembers = "Freq";
            this.chartMSK.Series.Add(series1);
            this.chartMSK.Size = new System.Drawing.Size(816, 283);
            this.chartMSK.TabIndex = 0;
            this.chartMSK.Text = "Таблица Частот";
            title1.Name = "Частоты";
            this.chartMSK.Titles.Add(title1);
            // 
            // freqClassBindingSource
            // 
            this.freqClassBindingSource.DataSource = typeof(Lab01.FreqClass);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(18, 159);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1452, 481);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewMSK);
            this.tabPage1.Controls.Add(this.buttonMSK);
            this.tabPage1.Controls.Add(this.chartMSK);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1444, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод середины квадрата";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewMSK
            // 
            this.listViewMSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMSK.Location = new System.Drawing.Point(40, 42);
            this.listViewMSK.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMSK.Name = "listViewMSK";
            this.listViewMSK.Size = new System.Drawing.Size(516, 354);
            this.listViewMSK.TabIndex = 2;
            this.listViewMSK.UseCompatibleStateImageBehavior = false;
            this.listViewMSK.View = System.Windows.Forms.View.List;
            this.listViewMSK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMSK_KeyDown);
            // 
            // buttonMSK
            // 
            this.buttonMSK.Location = new System.Drawing.Point(1131, 21);
            this.buttonMSK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMSK.Name = "buttonMSK";
            this.buttonMSK.Size = new System.Drawing.Size(300, 85);
            this.buttonMSK.TabIndex = 1;
            this.buttonMSK.Text = "Запустить процесс генерации";
            this.buttonMSK.UseVisualStyleBackColor = true;
            this.buttonMSK.Click += new System.EventHandler(this.buttonMSK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxKValue);
            this.tabPage2.Controls.Add(this.textBoxMValue);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listViewMKM);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1444, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Мультипликативный конгруэнтный метод";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxKValue
            // 
            this.textBoxKValue.Location = new System.Drawing.Point(665, 74);
            this.textBoxKValue.Name = "textBoxKValue";
            this.textBoxKValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxKValue.TabIndex = 9;
            this.textBoxKValue.Text = "2416";
            // 
            // textBoxMValue
            // 
            this.textBoxMValue.Location = new System.Drawing.Point(665, 36);
            this.textBoxMValue.Name = "textBoxMValue";
            this.textBoxMValue.Size = new System.Drawing.Size(100, 26);
            this.textBoxMValue.TabIndex = 8;
            this.textBoxMValue.Text = "1771875";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "k-Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "m-Value:";
            // 
            // listViewMKM
            // 
            this.listViewMKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewMKM.Location = new System.Drawing.Point(27, 58);
            this.listViewMKM.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMKM.Name = "listViewMKM";
            this.listViewMKM.Size = new System.Drawing.Size(516, 354);
            this.listViewMKM.TabIndex = 5;
            this.listViewMKM.UseCompatibleStateImageBehavior = false;
            this.listViewMKM.View = System.Windows.Forms.View.List;
            this.listViewMKM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewMKM_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1118, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "Запустить процесс генерации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart2
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea2.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.freqClassBindingSource;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(578, 129);
            this.chart2.Margin = new System.Windows.Forms.Padding(4);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Частоты";
            series2.XValueMember = "Xvalue";
            series2.YValueMembers = "Freq";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(816, 283);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "Таблица Частот";
            title2.Name = "Частоты";
            this.chart2.Titles.Add(title2);
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
            this.textBoxStart_value.Name = "textBoxStart_value";
            this.textBoxStart_value.Size = new System.Drawing.Size(48, 26);
            this.textBoxStart_value.TabIndex = 3;
            this.textBoxStart_value.Text = "1994";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Укажите количество генерируемых данных";
            // 
            // textBoxNumber_of_elements
            // 
            this.textBoxNumber_of_elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber_of_elements.Location = new System.Drawing.Point(532, 68);
            this.textBoxNumber_of_elements.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumber_of_elements.Name = "textBoxNumber_of_elements";
            this.textBoxNumber_of_elements.Size = new System.Drawing.Size(89, 26);
            this.textBoxNumber_of_elements.TabIndex = 5;
            this.textBoxNumber_of_elements.Text = "100";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1082, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "r=";
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
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(1125, 94);
            this.labelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(16, 16);
            this.labelR.TabIndex = 11;
            this.labelR.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 655);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumber_of_elements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxStart_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторная №1";
            ((System.ComponentModel.ISupportInitialize)(this.chartMSK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqClassBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMSK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonMSK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewMSK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStart_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber_of_elements;
        private System.Windows.Forms.BindingSource freqClassBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.TextBox textBoxKValue;
        private System.Windows.Forms.TextBox textBoxMValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewMKM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

