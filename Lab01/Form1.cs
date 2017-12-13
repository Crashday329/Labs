using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        private int _numberOfElements;
        private List<double> _multyConList = new List<double>();
        private readonly List<FreqClass> _freqlist = new List<FreqClass>();
        private List<FreqClass> _freqlist2;

        private List<double> SquaremedList { get;  } = new List<double>();

        public Form1()
        {
            InitializeComponent();
            GenKRanges();
        }
        //метод генерации диапазонов для оценивания вероятности
        private void GenKRanges()
        {
            _freqlist.Clear();
            var rangeLength = 1 / numericUpDownK_value.Value;
            for (decimal i = 0; i < 1; i = i + rangeLength)
            {
                _freqlist.Add(new FreqClass(i.ToString("##.###") + "-" + (i + rangeLength).ToString("##.###")) {LeftRange = (double)i, RightRange = (double)(i + rangeLength) });
            }


            //_freqlist = new List<FreqClass>
            //{
            //    new FreqClass("0-0.1"),
            //    new FreqClass("0.1-0.2"),
            //    new FreqClass("0.2-0.3"),
            //    new FreqClass("0.3-0.4"),
            //    new FreqClass("0.4-0.5"),
            //    new FreqClass("0.5-0.6"),
            //    new FreqClass("0.6-0.7"),
            //    new FreqClass("0.7-0.8"),
            //    new FreqClass("0.8-0.9"),
            //    new FreqClass("0.9-1.0")
            //};

            _freqlist2 = new List<FreqClass>(_freqlist);

            chartMSK.DataSource = _freqlist;
            chart2.DataSource = _freqlist2;
        }


        private void CalcFreq(List<double> li, List<FreqClass> flist) {

            foreach (var v in flist) {
                v.Freq = 0;
            }
               foreach (double d in li)
               {
                   flist.Find(f => d >= f.LeftRange && d < f.RightRange).Freq++;


                   //if (d < 0.1) flist[0].Freq++;
                   //if (d >= 0.1 && d < 0.2) flist[1].Freq++;
                   //if (d >= 0.2 && d < 0.3) flist[2].Freq++;
                   //if (d >= 0.3 && d < 0.4) flist[3].Freq++;
                   //if (d >= 0.4 && d < 0.5) flist[4].Freq++;
                   //if (d >= 0.5 && d < 0.6) flist[5].Freq++;
                   //if (d >= 0.6 && d < 0.7) flist[6].Freq++;
                   //if (d >= 0.7 && d < 0.8) flist[7].Freq++;
                   //if (d >= 0.8 && d < 0.9) flist[8].Freq++;
                   //if (d >= 0.9 && d < 1)   flist[9].Freq++;
               }

        }
        //расчет  коэффициента корреляции 
        double R_value(List<double> li)
        {
            List<double> xlist = new List<double>(li);
         
            double xmed=0;
            for(int i=1;i< xlist.Count;i++)
                xmed = xmed +xlist[i];

            xmed = xmed / (double)(xlist.Count-1);
            List<double> ylist = new List<double>(li);
            double ymed = 0;
            for (int i = 0; i < xlist.Count-1; i++)
                ymed = ymed+ xlist[i];
            ymed = ymed / (xlist.Count-1);


            double chislitel = 0;
            double podznamenatel1 = 0;
            double podznamenatel2 = 0;
            double znamenatel = 0;
            for (int i=0;i<xlist.Count-1;i++) {
                chislitel = chislitel + ((xlist[i+1] - xmed) * (ylist[i] - ymed));
                podznamenatel1 = podznamenatel1 + (Math.Pow((xlist[i+1] - xmed),2));
                podznamenatel2 = podznamenatel2 + (Math.Pow((ylist[i] - ymed), 2));
            }
            znamenatel = Math.Sqrt(podznamenatel1* podznamenatel2);
            var r = chislitel / znamenatel;
                 return r;
        }
        double Mcorp(List<double> li)
        {
            double mcup = 0;
            double sumZ = li.Sum();
            mcup = sumZ / li.Count;
            return mcup;
        }
        double Dcorp(List<double> li)
        {
         
            double sumZ = 0;
            sumZ = li.Aggregate<double, double>(0, (current, v) => current + Math.Pow(v, 2));
            var dcup = (sumZ / li.Count) - Math.Pow(Mcorp(li), 2);
            return dcup;
        }
        // Метод середины квадрата
        private void ButtonMSK_Click(object sender, EventArgs e)
        {
            SquaremedList.Clear();
            listViewMSK.Items.Clear();
            int localValue =Convert.ToInt32( numericStart_value.Value);
            _numberOfElements = Convert.ToInt32(numericUpDownGenCounter.Value);
           


            if (localValue < 1000 || localValue > 9999)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;
            }
            for (int j = 1; j <= _numberOfElements; j++)
            {
               
                    localValue = (int)Math.Pow(localValue, 2);
                
               
                string stringLocalValue = localValue.ToString().PadLeft(8, '0');
                string stringNewValue = stringLocalValue.Substring(2, 4);
                localValue = Int32.Parse(stringNewValue);
                //for (int i = 7; i >= 0; i--)
                //{
                //    int rezid = localValue % 10;
                //    localValue = localValue / 10;
                //    rData[i] = rezid;
                //}
                //localValue = rData[2] * 1000 + rData[3] * 100 + rData[4] * 10 + rData[5];
                SquaremedList.Add(localValue);
                listViewMSK.Items.Add(localValue.ToString());
            }
            for (int i = 0; i < SquaremedList.Count; i++)
                SquaremedList[i] = SquaremedList[i] / 10000;
            CalcFreq(SquaremedList, _freqlist);
            chartMSK.DataBind();
            labelD.Text= Dcorp(SquaremedList).ToString();
            labelM.Text = Mcorp(SquaremedList).ToString();
            labelR.Text = R_value(SquaremedList).ToString();
        }

        //метод Мультипликативный конгруэнтный и проверка
        private void Button1_Click(object sender, EventArgs e)
        {
            _multyConList.Clear();
            listViewMKM.Items.Clear();
            int localValue = Convert.ToInt32(numericStart_value.Value);
            _numberOfElements = Convert.ToInt32(numericUpDownGenCounter.Value);
            int modulM = Convert.ToInt32(textBoxMValue.Text);
            int kValue = Convert.ToInt32(textBoxKValue.Text);


            if (localValue < 1000 || localValue > 9999)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;
            }

            var aiList = new List<double>
            {
                1
            };

            _multyConList = new List<double>();
            var firstNumber = (double)1 / modulM;
            _multyConList.Add(firstNumber);
            listViewMKM.Items.Add(firstNumber.ToString());

            for (int j = 1; j < _numberOfElements; j++)  
            {
                var ai = (kValue * aiList[j - 1]) % modulM;
                
                var z = ai / modulM;
                
                aiList.Add(ai);
                _multyConList.Add(z);                
                listViewMKM.Items.Add(z.ToString());
            }
            CalcFreq(_multyConList, _freqlist2);
            chart2.DataBind();
            labelD.Text = Dcorp(_multyConList).ToString();
            labelM.Text = Mcorp(_multyConList).ToString();
            labelR.Text = R_value(_multyConList).ToString();

        }

        private void ListViewMKM_KeyDown(object sender, KeyEventArgs e)
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

        private void ListViewMSK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(listViewMSK);
            }

        }

              private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
         

            if (e.TabPageIndex == 1)
            {
                if (_multyConList.Count > 0)
                {
                    labelD.Text = Dcorp(_multyConList).ToString();
                    labelM.Text = Mcorp(_multyConList).ToString();
                    labelR.Text = R_value(_multyConList).ToString();
                }
                else {
                    labelD.Text = "0";
                    labelM.Text = "0";
                    labelR.Text = "0";
                }

            }
            else
            {
                if (SquaremedList.Count > 0)
                {
                    labelD.Text = Dcorp(SquaremedList).ToString();
                    labelM.Text = Mcorp(SquaremedList).ToString();
                    labelR.Text = R_value(SquaremedList).ToString();
                }
                else {
                    labelD.Text = "0";
                    labelM.Text = "0";
                    labelR.Text = "0";
                }
            }

        }
        //перегенрация диапазонов при изменении их количества
        private void numericUpDownK_value_ValueChanged(object sender, EventArgs e)
        {
            GenKRanges();
        }
    }
}
