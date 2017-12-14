using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr03
{
    public partial class Form1 : Form
    {   
        List<double> _xsegments=new List<double>();//диапазоны  для x 
        List<double> _ysegments=new List<double>();//диапазоны для у
        List<int> _countx=new List<int>();//количество конкретных значений по Х
        List<int> _county=new List<int>();//количество конкретных значений по У
        List<XyData> _countxy = new List<XyData>();//количество конкретных значений по комбинации  Х/У

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            _county = new List<int>(Convert.ToInt16(textBox2.Text));
            _countx = new List<int>(Convert.ToInt16(textBox1.Text));
            _countxy= new List<XyData>();

            Clearfreq();
         

            //указываем сколько строк в таблице с учетом значений, вероятностей и сумм вероятностей
            dataGridView1.RowCount = Convert.ToInt16(textBox1.Text)+3;
            dataGridView1.ColumnCount = Convert.ToInt16(textBox2.Text)+3;

            //расскраска ячеек
            for (int i = 0; i < dataGridView1.ColumnCount-1 ; i++)
            {
                dataGridView1.Rows[1].Cells[i].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1.Rows[1].Cells[i].Style.ForeColor = System.Drawing.Color.White;
                dataGridView1.Rows[1].Cells[i].ValueType = typeof(double);
                dataGridView1.Rows[0].Cells[i].ValueType = typeof(int);
            }

            for (int i = 2; i < dataGridView1.RowCount-1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.IndianRed;
                dataGridView1.Rows[i].Cells[1].Style.ForeColor = System.Drawing.Color.White;
                dataGridView1.Rows[i].Cells[1].ValueType = typeof(double);
                dataGridView1.Rows[i].Cells[0].ValueType = typeof(int);
            }

            dataGridView1.Rows[0].Cells[0].Value = "X/Y";

            dataGridView1.Rows[0].Cells[1].ReadOnly = true;
            dataGridView1.Rows[0].Cells[1].Style.BackColor = System.Drawing.Color.Gray;
            dataGridView1.Rows[1].Cells[1].ReadOnly = true;
            dataGridView1.Rows[1].Cells[1].Style.BackColor = System.Drawing.Color.Gray;
            dataGridView1.Rows[1].Cells[0].ReadOnly = true;
            dataGridView1.Rows[1].Cells[0].Style.BackColor = System.Drawing.Color.Gray;

            for (int i = 2; i < dataGridView1.ColumnCount-1; i++)
            {
                for (int j = 2; j < dataGridView1.RowCount-1; j++)
                {
                    dataGridView1.Rows[j].Cells[i].ReadOnly = true;
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = System.Drawing.Color.Gray;

                }
            }

            
            /////данные для теста
            dataGridView1.Rows[0].Cells[2].Value = 2;
            dataGridView1.Rows[0].Cells[3].Value = 5;
            dataGridView1.Rows[0].Cells[4].Value = 9;
            dataGridView1.Rows[1].Cells[2].Value = 0.2;
            dataGridView1.Rows[1].Cells[3].Value = 0.2;
            dataGridView1.Rows[1].Cells[4].Value = 0.6;

            dataGridView1.Rows[2].Cells[0].Value =3;
            dataGridView1.Rows[3].Cells[0].Value = 5;
            dataGridView1.Rows[4].Cells[0].Value = 7;
            dataGridView1.Rows[5].Cells[0].Value = 9;
            dataGridView1.Rows[6].Cells[0].Value = 12;

            dataGridView1.Rows[2].Cells[1].Value = 0.05;
            dataGridView1.Rows[3].Cells[1].Value = 0.3;
            dataGridView1.Rows[4].Cells[1].Value = 0.05;
            dataGridView1.Rows[5].Cells[1].Value = 0.2;
            dataGridView1.Rows[6].Cells[1].Value = 0.4;

        }

        //заполнение середины таблицы через перемножение вероятностей
        public void FillProbability() {
         
            for (int i = 2; i < dataGridView1.ColumnCount-1; i++) {
                for (int j = 2; j < dataGridView1.RowCount-1; j++)
                {
                    double d = Convert.ToDouble(dataGridView1.Rows[1].Cells[i].Value) 
                        * Convert.ToDouble(dataGridView1.Rows[j].Cells[1].Value);
                    dataGridView1.Rows[j].Cells[i].Value = d;
               
                }
                }


        }
        //подсчет суммы вероятностей по Xi
        private void DistributionRowX() {

            int j;

            double sumXi = 0;
          
          for (int i = 2; i < dataGridView1.ColumnCount-1; i++)
            {
                for ( j = 2; j < dataGridView1.RowCount-1; j++)
                {
                    sumXi += Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value);
                      }

                if (j == dataGridView1.RowCount - 1)
                {
                   //запись результата в ячейку нижней строчки
                    dataGridView1.Rows[j ].Cells[i ].Value = sumXi;
                  }
                sumXi = 0;
            }

            }
        //подсчет суммы вероятностей по Уi
        private void DistributionColY()
        {

            int j; int i;

            double sumYi = 0;

            for (j = 2; j < dataGridView1.RowCount - 1; j++)
            {
                for (i = 2; i < dataGridView1.ColumnCount - 1; i++)
                {
                    sumYi += Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value);
                }

                if (i == dataGridView1.ColumnCount - 1)
                {
                    //запись результата в ячейку самого правого столбца
                    dataGridView1.Rows[j].Cells[i].Value = sumYi;
                }
                sumYi = 0;
            }

        }
        //расчет матожидания Х
        void CalcMx() {
            double sumMx = 0;
            for (int j = 2; j < dataGridView1.ColumnCount - 1; j++)
            {
                sumMx += Convert.ToDouble(dataGridView1.Rows[0].Cells[j].Value)
                * Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value);
            }
            mxLabel.Text = sumMx.ToString();

        }

        //расчет матожидания У
                void CalcMy() {

            double sumMy = 0;
            for (int j = 2; j < dataGridView1.RowCount - 1; j++)
            {
                sumMy += Convert.ToDouble(dataGridView1.Rows[j].Cells[0].Value)
                * Convert.ToDouble(dataGridView1.Rows[j].Cells[dataGridView1.ColumnCount - 1].Value);
            }
            myLabel.Text = sumMy.ToString();

        }
        //расчет дисперсии Х
        void CalcDx() {
            double sumDx = 0;
            for (int j = 2; j < dataGridView1.ColumnCount - 1; j++)
            {
                sumDx += Math.Pow(Convert.ToDouble(dataGridView1.Rows[0].Cells[j].Value),2)
                * Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value);
            }
            sumDx = sumDx - Math.Pow(Convert.ToDouble(mxLabel.Text), 2);
            dxLabel.Text = sumDx.ToString("N3");

        }
        //расчет дисперсии У
        void CalcDy() {
            double sumDy = 0;
            for (int j = 2; j < dataGridView1.RowCount - 1; j++)
            {
                sumDy += Math.Pow(Convert.ToDouble(dataGridView1.Rows[j].Cells[0].Value),2)
                * Convert.ToDouble(dataGridView1.Rows[j].Cells[dataGridView1.ColumnCount - 1].Value);
            }
            sumDy= sumDy - Math.Pow(Convert.ToDouble(myLabel.Text), 2);
            dyLabel.Text = sumDy.ToString("N3");
        }

        double  Mxy() {

            double mJoint = 0;
            for (int i =2; i < dataGridView1.RowCount - 1; i++)
            {
               
                for (int j = 2; j < dataGridView1.ColumnCount - 1; j++)
                {
                    double currY = Convert.ToInt16(dataGridView1.Rows[i].Cells[0].Value);
                    double currX = Convert.ToInt16(dataGridView1.Rows[0].Cells[j].Value);
                    double currP = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    mJoint += currY * currP * currX;
                }
            }

            return mJoint;
        }

        double CalcK() {
            double k = Convert.ToDouble(yxmLabel.Text) - Convert.ToDouble(mxLabel.Text) * Convert.ToDouble(myLabel.Text);
            return k;
           
        }

        double CalcR()
        {
            double r = CalcK() / Math.Sqrt(Convert.ToDouble(dxLabel.Text)) / Math.Sqrt(Convert.ToDouble(dyLabel.Text));
            return r;
        }
        //метод подготовки прорисовки графиков
        void PrepaireCharts() {
            //очистка графиков
            xchart.Series.Clear();
            ychart.Series.Clear();
            xychart.Series.Clear();
            //подписи графиков
            xchart.Series.Add("Все X:");
            ychart.Series.Add("Все Y:");
            xychart.Series.Add("Все X/Y:");
            //составление легенды для каждого графика
            for (int i = 2; i < dataGridView1.ColumnCount - 1; i++) {
                xchart.Series.Add((dataGridView1.Rows[0].Cells[i].Value.ToString()));
            }
            for (int i = 2; i < dataGridView1.RowCount - 1; i++)
            {
                ychart.Series.Add((dataGridView1.Rows[i].Cells[0].Value.ToString()));
            }
            for (int i = 2; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 2; j < dataGridView1.RowCount - 1; j++)
                {
                    xychart.Series.Add(dataGridView1.Rows[0].Cells[i].Value.ToString()+ "-" + dataGridView1.Rows[j].Cells[0].Value.ToString());
                    //заполнение пользовательского класса парами данных
                    XyData d = new XyData(Convert.ToInt16(dataGridView1.Rows[0].Cells[i].Value), Convert.ToInt16(dataGridView1.Rows[j].Cells[0].Value));
                   _countxy.Add(d);
                }

                }
            

            }

        //метод прорисоки графиков
            void FillCharts()
        {

            int c = 1;
            foreach (var x in _countx)
            {
                xchart.Series[c++].Points.Add(x);
            }
            c = 1;
            foreach (var x in _county)
            {
                ychart.Series[c++].Points.Add(x);
            }

            c = 1;
            foreach (var x in _countxy)
            {
                xychart.Series[c++].Points.Add(x.Count);
            }


        }

        //расчет вероятностей и числовых характеристик
        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
          
            //заполнение таблицы вероятностями
            FillProbability();
            //суммы по столбцам
            DistributionRowX();
            //суммы по строкам
            DistributionColY();

            //проверка что сумма =1
            for (int i = 2; i < dataGridView1.ColumnCount-1; i++)
            {

                sum += (double)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[i].Value;
            }
            if (Math.Abs(sum - 1.0d) > 0.00001)
            {
                MessageBox.Show("Сумма вероятностей не равна 1");

                return;
            }

            //вычисление матожидания и дисперсии
            CalcMx();
            CalcMy();
            CalcDx();
            CalcDy();
           yxmLabel.Text= Mxy().ToString();
            rlabel.Text= CalcR().ToString();//коэффициент корреляции

            //расчет диапазонов X суммированим каждой вероятности (0-1)
            _xsegments.Add(0);
            int pos = 0;
            for (int i = 2; i < dataGridView1.ColumnCount - 1; i++) {

                _xsegments.Add(_xsegments[pos]+Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[i].Value));
                pos++;
            }
            //расчет диапазонов Yсуммированим каждой вероятности (0-1)
            _ysegments.Add(0);
           pos = 0;
            for (int i = 2; i < dataGridView1.RowCount - 1; i++)
            {

                _ysegments.Add(_ysegments[pos] + Convert.ToDouble(dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value));
                pos++;
            }

            PrepaireCharts();

           

        }

        void Clearfreq() {

          _countx.Clear();
           _county.Clear();
            _countxy.Clear();
            //создаем списки на указанное количество элементов и заполняем нулями
            for (int i = 0; i < Convert.ToInt16(textBox1.Text); i++)
            {
                _county.Add(0);
            }
            for (int i = 0; i < Convert.ToInt16(textBox2.Text); i++)
            {
                _countx.Add(0);
            }
            PrepaireCharts();
        }

        //генерация данных по заданному виду распределения
        private void button3_Click(object sender, EventArgs e)
        {    //очистка графиков
            Clearfreq();
            richTextBox1.Clear();
         
        

            //количество генерируемых данных
            int count = Convert.ToInt16(kolichTextBox.Text);
            //вычисление позиции в таблице
            int xindex=0;
            int yindex = 0;
            //данные в таблице
            int xvalue;
            int yvalue;
            Random rnd = new Random();
            for (int i = 0; i < count; i++) {
                double xrand = rnd.NextDouble();
                //проверка, что х относится к конкретному сегменту
                for (int j=0;j<_xsegments.Count; j++) {
                    if (xrand < _xsegments[j])
                    {
                        xindex = j;
                        _countx[xindex-1]++;
                        break;
                    }
                }
                //выбираем X в RichTextBox
                xvalue = (int)dataGridView1.Rows[0].Cells[1 + xindex].Value;
               richTextBox1.AppendText(" X: "+ xvalue.ToString());

                   double yrand = rnd.NextDouble();
                    for (int j = 0; j < _ysegments.Count; j++)
                    {//проверка что у относится к конкретномму сегменту
                        if (yrand < _ysegments[j])
                        {
                            yindex = j;
                        _county[yindex - 1]++;
                        break;
                        }
                    }
                //выбираем Y в RichTextBox
                yvalue = (int)dataGridView1.Rows[1 + yindex].Cells[0].Value;
                richTextBox1.AppendText(" Y: " + yvalue.ToString());
                    foreach (var v in _countxy) {
                    //проверка попадания комбинации XУ в конкретный диапазон
                    if (v.X == xvalue && v.Y == yvalue)
                        v.Count++;
                }
                
                //выбираем P вероятность в RichTextBox
                richTextBox1.AppendText(" P: " + dataGridView1.Rows[1 + yindex].Cells[1 + xindex].Value.ToString() + "\n");


            }
            //заполнение графиков данными
            FillCharts();

        }
    }
}
