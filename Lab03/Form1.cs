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
        List<double> xsegments=new List<double>();//диапазоны  для x 
        List<double> ysegments=new List<double>();//диапазоны для у
        List<int> countx;//количество конкретных значений по Х
        List<int> county;//количество конкретных значений по У
        List<XYData> countxy;//количество конкретных значений по комбинации  Х/У

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            county = new List<int>(Convert.ToInt16(textBox2.Text));
            countx = new List<int>(Convert.ToInt16(textBox1.Text));
            countxy= new List<XYData>();

            clearfreq();
         

            //указываем сколько строк в таблице с учетом значений, вероятностей и сумм вероятностей
            dataGridView1.RowCount = Convert.ToInt16(textBox1.Text)+3;
            dataGridView1.ColumnCount = Convert.ToInt16(textBox2.Text)+3;

            //расскраска ячеек
            for (int i = 0; i < dataGridView1.ColumnCount-1 ; i++)
            {
                dataGridView1.Rows[1].Cells[i].Style.BackColor = System.Drawing.Color.Green;
                dataGridView1.Rows[1].Cells[i].Style.ForeColor = System.Drawing.Color.White;
            }

            for (int i = 2; i < dataGridView1.RowCount-1; i++)
            {
                dataGridView1.Rows[i].Cells[1].Style.BackColor = System.Drawing.Color.IndianRed;
                dataGridView1.Rows[i].Cells[1].Style.ForeColor = System.Drawing.Color.White;
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
        public void fillProbability() {
         
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
        private void distributionRowX() {

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
        private void distributionColY()
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
        void calcMX() {
            double sumMX = 0;
            for (int j = 2; j < dataGridView1.ColumnCount - 1; j++)
            {
                sumMX += Convert.ToDouble(dataGridView1.Rows[0].Cells[j].Value)
                * Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value);
            }
            mxLabel.Text = sumMX.ToString();

        }

        //расчет матожидания У
                void calcMY() {

            double sumMY = 0;
            for (int j = 2; j < dataGridView1.RowCount - 1; j++)
            {
                sumMY += Convert.ToDouble(dataGridView1.Rows[j].Cells[0].Value)
                * Convert.ToDouble(dataGridView1.Rows[j].Cells[dataGridView1.ColumnCount - 1].Value);
            }
            myLabel.Text = sumMY.ToString();

        }
        //расчет дисперсии Х
        void calcDX() {
            double sumDX = 0;
            for (int j = 2; j < dataGridView1.ColumnCount - 1; j++)
            {
                sumDX += Math.Pow(Convert.ToDouble(dataGridView1.Rows[0].Cells[j].Value),2)
                * Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[j].Value);
            }
            sumDX = sumDX - Math.Pow(Convert.ToDouble(mxLabel.Text), 2);
            dxLabel.Text = sumDX.ToString("N3");

        }
        //расчет дисперсии У
        void calcDY() {
            double sumDY = 0;
            for (int j = 2; j < dataGridView1.RowCount - 1; j++)
            {
                sumDY += Math.Pow(Convert.ToDouble(dataGridView1.Rows[j].Cells[0].Value),2)
                * Convert.ToDouble(dataGridView1.Rows[j].Cells[dataGridView1.ColumnCount - 1].Value);
            }
            sumDY= sumDY - Math.Pow(Convert.ToDouble(myLabel.Text), 2);
            dyLabel.Text = sumDY.ToString("N3");
        }

        double  MXY() {

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
        void prepaireCharts() {
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
                    XYData d = new XYData(Convert.ToInt16(dataGridView1.Rows[0].Cells[i].Value), Convert.ToInt16(dataGridView1.Rows[j].Cells[0].Value));
                   countxy.Add(d);
                }

                }
            

            }

        //метод прорисоки графиков
            void fillCharts()
        {

            int c = 1;
            foreach (var x in countx)
            {
                xchart.Series[c++].Points.Add(x);
            }
            c = 1;
            foreach (var x in county)
            {
                ychart.Series[c++].Points.Add(x);
            }

            c = 1;
            foreach (var x in countxy)
            {
                xychart.Series[c++].Points.Add(x.count);
            }


        }

        //расчет вероятностей и числовых характеристик
        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
          
            //заполнение таблицы вероятностями
            fillProbability();
            //суммы по столбцам
            distributionRowX();
            //суммы по строкам
            distributionColY();

            //проверка что сумма =1
            for (int i = 2; i < dataGridView1.ColumnCount-1; i++)
            {

                sum += (double)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[i].Value;
            }
            if (sum != 1)
            {
                MessageBox.Show("Сумма вероятностей не равна 1");

                return;
            }

            //вычисление матожидания и дисперсии
            calcMX();
            calcMY();
            calcDX();
            calcDY();
           yxmLabel.Text= MXY().ToString();
            rlabel.Text= CalcR().ToString();//коэффициент корреляции

            //расчет диапазонов X суммированим каждой вероятности (0-1)
            xsegments.Add(0);
            int pos = 0;
            for (int i = 2; i < dataGridView1.ColumnCount - 1; i++) {

                xsegments.Add(xsegments[pos]+Convert.ToDouble(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[i].Value));
                pos++;
            }
            //расчет диапазонов Yсуммированим каждой вероятности (0-1)
            ysegments.Add(0);
           pos = 0;
            for (int i = 2; i < dataGridView1.RowCount - 1; i++)
            {

                ysegments.Add(ysegments[pos] + Convert.ToDouble(dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value));
                pos++;
            }

            prepaireCharts();

           

        }

        void clearfreq() {

          countx.Clear();
           county.Clear();
            countxy.Clear();
            //создаем списки на указанное количество элементов и заполняем нулями
            for (int i = 0; i < Convert.ToInt16(textBox1.Text); i++)
            {
                county.Add(0);
            }
            for (int i = 0; i < Convert.ToInt16(textBox2.Text); i++)
            {
                countx.Add(0);
            }
            prepaireCharts();
        }

        //генерация данных по заданному виду распределения
        private void button3_Click(object sender, EventArgs e)
        {    //очистка графиков
            clearfreq();
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
                for (int j=0;j<xsegments.Count; j++) {
                    if (xrand < xsegments[j])
                    {
                        xindex = j;
                        countx[xindex-1]++;
                        break;
                    }
                }
                //выбираем X в RichTextBox
                xvalue = (int)dataGridView1.Rows[0].Cells[1 + xindex].Value;
               richTextBox1.AppendText(" X: "+ xvalue.ToString());

                   double yrand = rnd.NextDouble();
                    for (int j = 0; j < ysegments.Count; j++)
                    {//проверка что у относится к конкретномму сегменту
                        if (yrand < ysegments[j])
                        {
                            yindex = j;
                        county[yindex - 1]++;
                        break;
                        }
                    }
                //выбираем Y в RichTextBox
                yvalue = (int)dataGridView1.Rows[1 + yindex].Cells[0].Value;
                richTextBox1.AppendText(" Y: " + yvalue.ToString());
                    foreach (var v in countxy) {
                    //проверка попадания комбинации XУ в конкретный диапазон
                    if (v.x == xvalue && v.y == yvalue)
                        v.count++;
                }
                
                //выбираем P вероятность в RichTextBox
                richTextBox1.AppendText(" P: " + dataGridView1.Rows[1 + yindex].Cells[1 + xindex].Value.ToString() + "\n");


            }
            //заполнение графиков данными
            fillCharts();

        }
    }
}
