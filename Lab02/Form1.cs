using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab01
{
    public partial class Form1 : Form
    {
        double a = 2;
        double b = 5;
        int number_of_elements;

        List<double> multy_con_list = new List<double>();//набор данных в диапазоне от 0 до 1
        List<double> ravnomern_list = new List<double>();//набор хранения равномерных значений
        List<double> fxDI = new List<double>();//набор Y для функции распределения
        List<double> fxDE = new List<double>();//набор Y для функции  плотности 
        List<int> ll = new List<int>();// данные Y для хранения частот 
        List<double> num = new List<double>();//данные подписи Х на графике


        public Form1()
        {
            InitializeComponent();

        }

        //метод подсчета частот
        void calcFreq(List<double> li)
        {
            num.Clear();
            ll.Clear();

            num.Add(a);
            for (int i = 0; i < 10; i++)
                ll.Add(0);
            //получение сетки для графика частот
            for (int i = 1; i < 10; i++)
                num.Add(num[i - 1] + (b - a) / 10.0);
            
            foreach (double d in li)
            {
                double delta = (b - a) / 10;
                if (d < a + delta) ll[0]++;
                if (d >= a + delta && d < a + delta * 2) ll[1]++;
                if (d >= a + delta * 2 && d < a + delta * 3) ll[2]++;
                if (d >= a + delta * 3 && d < a + delta * 4) ll[3]++;
                if (d >= a + delta * 4 && d < a + delta * 5) ll[4]++;
                if (d >= a + delta * 5 && d < a + delta * 6) ll[5]++;
                if (d >= a + delta * 6 && d < a + delta * 7) ll[6]++;
                if (d >= a + delta * 7 && d < a + delta * 8) ll[7]++;
                if (d >= a + delta * 8 && d < a + delta * 9) ll[8]++;
                if (d >= a + delta * 9 && d <= b) ll[9]++;
            }

        }
        double Mcorp()
        {
            
            double Mcup = 0;
            Mcup = (b + a) / 2;
            Mcup = Math.Round(Mcup, 4);
            return Mcup;
        }
        double Dcorp()
        {     
            double Dcup;
            Dcup = Math.Pow((b - a), 2) / 12;
            Dcup = Math.Round(Dcup, 4);
            return Dcup;
        }


        // генерация случайных данных метод Мультипликат
        private void button1_Click(object sender, EventArgs e)
        {
            multy_con_list.Clear();
            ravnomern_list.Clear();
            fxDI.Clear();
            fxDE.Clear();
            listViewMKM.Items.Clear();

            a = Convert.ToInt16(AtextBox.Text);
            b = Convert.ToInt16(BtextBox.Text);
            int local_value = Convert.ToInt32(textBoxStart_value.Text);
            number_of_elements = Convert.ToInt32(textBoxNumber_of_elements.Text);
            double Ai = local_value;
            double z = 0;
            int modul_m = Convert.ToInt32(textBoxMValue.Text);
            int k_value = Convert.ToInt32(textBoxKValue.Text);


            if (local_value < 1000 || local_value > 9999)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;
            }

            //генерация случайных чисел в диапазоне от 0 до 1
            for (int j = 1; j <= number_of_elements; j++)
            {
                Ai = (k_value * Ai) % modul_m;
                z = Ai / modul_m;
                multy_con_list.Add(z);
            }
            //преобразование в заданный диапазон от А до B X=A+(B-A)*R
           
            foreach (double v in multy_con_list)
            {
                double temp = a + (b - a) * v;
                ravnomern_list.Add(temp);
                listViewMKM.Items.Add(temp.ToString());
            }


            calcFreq(ravnomern_list);//подcчет частот значений

          
            chart1.ChartAreas[0].AxisX.Minimum = a - 1;
            chart1.ChartAreas[0].AxisX.Maximum = b + 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = number_of_elements / 8;
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[0].Points.DataBindXY(num, ll);

            labelD.Text = Dcorp().ToString();
            labelM.Text = Mcorp().ToString();

            PaintDensityFunction();
            PaintDistributionFunction();

        }

        //построение графика распределения
        private void PaintDistributionFunction()
        {
            for (int i = 0; i < number_of_elements; i++)
            {
                fxDI.Add(Math.Abs((ravnomern_list[i] - a)) / (b - a));
            }
            dChart.ChartAreas[0].AxisX.Minimum = a - 1;
            dChart.ChartAreas[0].AxisX.Maximum = b + 1;
            dChart.ChartAreas[0].AxisY.Minimum = 0;
            dChart.ChartAreas[0].AxisY.Maximum = 1;
            dChart.Series[0].ChartType = SeriesChartType.Point;
            dChart.Series[0].Points.DataBindXY(ravnomern_list, fxDI);

        }
        //построение графика плотности
        private void PaintDensityFunction()
        {
            for (int i = 0; i < number_of_elements; i++)
            {
                fxDE.Add(1 / (b - a));
            }

            fChart.ChartAreas[0].AxisX.Minimum = a - 1;
            fChart.ChartAreas[0].AxisX.Maximum = b + 1;
            fChart.ChartAreas[0].AxisY.Minimum = 0;
            fChart.ChartAreas[0].AxisY.Maximum = 1;
            fChart.Series[0].ChartType = SeriesChartType.Point;
            fChart.Series[0].Points.DataBindXY(ravnomern_list, fxDE);
        }


        
        private void listViewMKM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(listViewMKM);
            }
        }
        public void CopyListBox(ListView list)
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
