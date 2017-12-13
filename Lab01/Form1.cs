using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        int number_of_elements;
        List<double> squaremed_list = new List<double>();//набор хранения  данных
         List<double> multy_con_list = new List<double>();
        List<FreqClass> freqlist;
        List<FreqClass> freqlist2;

        public List<double> Squaremed_list
        {
            get
            {
                return squaremed_list;
            }

            set
            {
                squaremed_list = value;
            }
        }

        public Form1()
        {
            InitializeComponent();

            freqlist = new List<FreqClass>();
            freqlist.Add(new FreqClass("0-0.1"));
            freqlist.Add(new FreqClass("0.1-0.2"));
            freqlist.Add(new FreqClass("0.2-0.3"));
            freqlist.Add(new FreqClass("0.3-0.4"));
            freqlist.Add(new FreqClass("0.4-0.5"));
            freqlist.Add(new FreqClass("0.5-0.6"));
            freqlist.Add(new FreqClass("0.6-0.7"));
            freqlist.Add(new FreqClass("0.7-0.8"));
            freqlist.Add(new FreqClass("0.8-0.9"));
            freqlist.Add(new FreqClass("0.9-1.0"));

           freqlist2 = new List<FreqClass>(freqlist);

            chartMSK.DataSource = freqlist;
            chart2.DataSource = freqlist2;
        }

      

        void calcFreq(List<double> li, List<FreqClass> flist) {
            foreach (var v in flist) {
                v.Freq = 0;
            }
               foreach (double d in li)
            {
                if (d < 0.1) flist[0].Freq++;
                if (d >= 0.1 && d < 0.2) flist[1].Freq++;
                if (d >= 0.2 && d < 0.3) flist[2].Freq++;
                if (d >= 0.3 && d < 0.4) flist[3].Freq++;
                if (d >= 0.4 && d < 0.5) flist[4].Freq++;
                if (d >= 0.5 && d < 0.6) flist[5].Freq++;
                if (d >= 0.6 && d < 0.7) flist[6].Freq++;
                if (d >= 0.7 && d < 0.8) flist[7].Freq++;
                if (d >= 0.8 && d < 0.9) flist[8].Freq++;
                if (d >= 0.9 && d < 1)   flist[9].Freq++;
            }

        }
        //расчет  коэффициента корреляции 
        double r_value(List<double> li)
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

           
            double r;
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
            r = chislitel / znamenatel;
                 return r;
        }
        double Mcorp(List<double> li)
        {
            
            double sumZ = 0;
            double Mcup = 0;
            foreach (var v in li)
            {
                sumZ += v;
            }
            Mcup = sumZ / li.Count;
            return Mcup;
        }
        double Dcorp(List<double> li)
        {
         
            double sumZ = 0;
            double Dcup;
            sumZ = 0;
            foreach (var v in li)
            {
                sumZ = sumZ + Math.Pow(v, 2);
            }
            Dcup = (sumZ / li.Count) - Math.Pow(Mcorp(li), 2);
            return Dcup;
        }
        // Метод середины квадрата
        private void buttonMSK_Click(object sender, EventArgs e)
        {
            Squaremed_list.Clear();
            listViewMSK.Items.Clear();
            int local_value =Convert.ToInt32( textBoxStart_value.Text);
            number_of_elements = Convert.ToInt32(textBoxNumber_of_elements.Text);
            int[] r_data = new int[8];


            if (local_value < 1000 || local_value > 9999)
            {
                MessageBox.Show("Вы ввели некорректное число");
                return;
            }
            for (int j = 1; j <= number_of_elements; j++)
            {
                local_value = (int)Math.Pow(local_value, 2);
                for (int i = 7; i >= 0; i--)
                {
                    int rezid = local_value % 10;
                    local_value = local_value / 10;
                    r_data[i] = rezid;
                }
                local_value = r_data[2] * 1000 + r_data[3] * 100 + r_data[4] * 10 + r_data[5];
                Squaremed_list.Add(local_value);
                listViewMSK.Items.Add(local_value.ToString());
            }
            for (int i = 0; i < Squaremed_list.Count; i++)
                Squaremed_list[i] = Squaremed_list[i] / 10000;
            calcFreq(Squaremed_list, freqlist);
            chartMSK.DataBind();
            labelD.Text= Dcorp(Squaremed_list).ToString();
            labelM.Text = Mcorp(Squaremed_list).ToString();
            labelR.Text = r_value(Squaremed_list).ToString();
        }

        //метод Мультипликативный конгруэнтный и проверка
        private void button1_Click(object sender, EventArgs e)
        {
            multy_con_list.Clear();
            listViewMKM.Items.Clear();
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

            var AiList = new List<double>();
            AiList.Add(1);

            multy_con_list = new List<double>();
            var firstNumber = (double)1 / modul_m;
            multy_con_list.Add(firstNumber);
            listViewMKM.Items.Add(firstNumber.ToString());

            for (int j = 1; j < number_of_elements; j++)  
            {
                Ai = (k_value * AiList[j - 1]) % modul_m;
                
                z = Ai / modul_m;
                
                AiList.Add(Ai);
                multy_con_list.Add(z);                
                listViewMKM.Items.Add(z.ToString());
            }
            calcFreq(multy_con_list, freqlist2);
            chart2.DataBind();
            labelD.Text = Dcorp(multy_con_list).ToString();
            labelM.Text = Mcorp(multy_con_list).ToString();
            labelR.Text = r_value(multy_con_list).ToString();

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

        private void listViewMSK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox(listViewMSK);
            }

        }

              private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
         

            if (e.TabPageIndex == 1)
            {
                if (multy_con_list.Count > 0)
                {
                    labelD.Text = Dcorp(multy_con_list).ToString();
                    labelM.Text = Mcorp(multy_con_list).ToString();
                    labelR.Text = r_value(multy_con_list).ToString();
                }
                else {
                    labelD.Text = "0";
                    labelM.Text = "0";
                    labelR.Text = "0";
                }

            }
            else
            {
                if (Squaremed_list.Count > 0)
                {
                    labelD.Text = Dcorp(Squaremed_list).ToString();
                    labelM.Text = Mcorp(Squaremed_list).ToString();
                    labelR.Text = r_value(Squaremed_list).ToString();
                }
                else {
                    labelD.Text = "0";
                    labelM.Text = "0";
                    labelR.Text = "0";
                }
            }

        }
    }
}
