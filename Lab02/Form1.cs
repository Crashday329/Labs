﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab01
{
    public partial class Form1 : Form
    {
        private double _a = 2;
        private double _b = 5;
        private int _numberOfElements;

        private readonly List<double> _multyConList = new List<double>();//набор данных в диапазоне от 0 до 1
        private readonly List<double> _ravnomernList = new List<double>();//набор хранения равномерных значений
        private readonly List<double> _fxDi = new List<double>();//набор Y для функции распределения
        private readonly List<double> _fxDe = new List<double>();//набор Y для функции  плотности 
        private readonly List<int> _ll = new List<int>();// данные Y для хранения частот 
        private readonly List<double> _num = new List<double>();//данные подписи Х на графике


        public Form1()
        {
            InitializeComponent();

        }

        //метод подсчета частот
        private void CalcFreq(List<double> li)
        {
            _num.Clear();
            _ll.Clear();

            _num.Add(_a);
            //for (int i = 0; i < 10; i++)
            //    _ll.Add(0);
            //получение сетки для графика частот
            for (int i = 1; i < 10; i++)
                _num.Add(_num[i - 1] + (_b - _a) / 10.0);
            double delta = (_b - _a) / 10;
            for (int i = 0; i < 10; i++)
            {
               _ll.Add( li.Select(d => d >= _a + delta * i && d < _a + delta * (i + 1)).Count());
            }



            //foreach (double d in li)
            //{
            //    double delta = (_b - _a) / 10;
            //    if (d < _a + delta) _ll[0]++;
            //    if (d >= _a + delta && d < _a + delta * 2) _ll[1]++;
            //    if (d >= _a + delta * 2 && d < _a + delta * 3) _ll[2]++;
            //    if (d >= _a + delta * 3 && d < _a + delta * 4) _ll[3]++;
            //    if (d >= _a + delta * 4 && d < _a + delta * 5) _ll[4]++;
            //    if (d >= _a + delta * 5 && d < _a + delta * 6) _ll[5]++;
            //    if (d >= _a + delta * 6 && d < _a + delta * 7) _ll[6]++;
            //    if (d >= _a + delta * 7 && d < _a + delta * 8) _ll[7]++;
            //    if (d >= _a + delta * 8 && d < _a + delta * 9) _ll[8]++;
            //    if (d >= _a + delta * 9 && d <= _b) _ll[9]++;
            //}

        }

        private double Mcorp()
        {
            
            double mcup = 0;
            mcup = (_b + _a) / 2;
            mcup = Math.Round(mcup, 4);
            return mcup;
        }

        private double Dcorp()
        {     
            double dcup;
            dcup = Math.Pow((_b - _a), 2) / 12;
            dcup = Math.Round(dcup, 4);
            return dcup;
        }


        // генерация случайных данных метод Мультипликат
        private void button1_Click(object sender, EventArgs e)
        { _a = Convert.ToInt16(AtextBox.Text);
            _b = Convert.ToInt16(BtextBox.Text);
            if (_a>=_b)
            {
                MessageBox.Show("Не правильный диапазон a b");
                return;
            }

            _multyConList.Clear();
            _ravnomernList.Clear();
            _fxDi.Clear();
            _fxDe.Clear();
            listViewMKM.Items.Clear();

           
            int localValue = Convert.ToInt32(textBoxStart_value.Text);
            _numberOfElements = Convert.ToInt32(textBoxNumber_of_elements.Text);
            double ai = localValue;
            double z = 0;
            int modulM = Convert.ToInt32(textBoxMValue.Text);
            int kValue = Convert.ToInt32(textBoxKValue.Text);


            if (localValue < 1000 || localValue > 9999)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;
            }

            //генерация случайных чисел в диапазоне от 0 до 1
            for (int j = 1; j <= _numberOfElements; j++)
            {
                ai = (kValue * ai) % modulM;
                z = ai / modulM;
                _multyConList.Add(z);
            }
            //преобразование в заданный диапазон от А до B X=A+(B-A)*R
           
            foreach (double v in _multyConList)
            {
                double temp = _a + (_b - _a) * v;
                _ravnomernList.Add(temp);
                listViewMKM.Items.Add(temp.ToString());
            }


            CalcFreq(_ravnomernList);//подcчет частот значений

          
            chart1.ChartAreas[0].AxisX.Minimum = _a - 1;
            chart1.ChartAreas[0].AxisX.Maximum = _b + 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = _numberOfElements / 8;
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.DataBindXY(_num, _ll);

            labelD.Text = Dcorp().ToString();
            labelM.Text = Mcorp().ToString();

            PaintDensityFunction();
            PaintDistributionFunction();

        }

        //построение графика распределения
        private void PaintDistributionFunction()
        {
            for (int i = 0; i < _numberOfElements; i++)
            {
                _fxDi.Add(Math.Abs((_ravnomernList[i] - _a)) / (_b - _a));
            }
            dChart.ChartAreas[0].AxisX.Minimum = _a - 1;
            dChart.ChartAreas[0].AxisX.Maximum = _b + 1;
            dChart.ChartAreas[0].AxisY.Minimum = 0;
            dChart.ChartAreas[0].AxisY.Maximum = 1;
            dChart.Series[0].ChartType = SeriesChartType.Point;
            dChart.Series[0].Points.DataBindXY(_ravnomernList, _fxDi);

        }
        //построение графика плотности
        private void PaintDensityFunction()
        {
            for (int i = 0; i < _numberOfElements; i++)
            {
                _fxDe.Add(1 / (_b - _a));
            }

            fChart.ChartAreas[0].AxisX.Minimum = _a - 1;
            fChart.ChartAreas[0].AxisX.Maximum = _b + 1;
            fChart.ChartAreas[0].AxisY.Minimum = 0;
            fChart.ChartAreas[0].AxisY.Maximum = 1;
            fChart.Series[0].ChartType = SeriesChartType.Point;
            fChart.Series[0].Points.DataBindXY(_ravnomernList, _fxDe);
        }


        
        private void listViewMKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(listViewMKM);
            }
        }

        private void CopyListBox(ListView list)
        {

            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in list.SelectedItems)
            {
                sb.AppendLine(item.Text);
            }

            Clipboard.SetDataObject(sb.ToString());

        }




    }
}
