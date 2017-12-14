using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab04
{
    public partial class Form1 : Form
    {
        Result _res;
        public Form1()
        {
            InitializeComponent();
            Initgr();
        }
        void Initgr() {
             chart1.Series.Clear();
            
            chart1.Name = "Распределение случаев:";
            chart1.Series.Add("изменил выбор и победил");
            chart1.Series.Add("изменил выбор и потерял");
            chart1.Series.Add("не менял выбор и победил");
            chart1.Series.Add("не менял выбор и потерял");
            chart1.ChartAreas[0].AxisY.Maximum = Convert.ToInt16(textBox1.Text)/2;
            _res = new Result();
        }
        void Game()
            {
            Initgr();

            Random rnd = new Random();
            int iterations = Convert.ToInt16(textBox1.Text);
            for (int it = 0; it < iterations; it++)
            {  //три двери
                int[] doors = { 0, 0, 0 };
                //генерируем номер(индекс) двери, за которой прячется машинка
                
                int carIn = rnd.Next(0, 3);
                //наличие машинки обозначаем через 1
                doors[carIn] = 1;

                //генерация пользовательского выбора
                int myChoice = rnd.Next(0, 3);

                // менять или не менять?
                bool changeChoice = rnd.Next(0, 2) == 1;
                int otherOpen = 0;
                int otherClosed = 0;
                bool opened = false;

                //перебираем двери
                for (int i = 0; i < 3; i++)
                {//если номер текущей двери не равен  номеру выбранной, и за этой дверью нет авто, и дверь не открыта
                    if (i != myChoice && doors[i] == 0 && !opened)
                    {
                        //запоминаем номер  проверяемой двери (если не открыта и там нет авто)
                        otherOpen = i;
                        opened = true;//статус - открыта и показываем Козу
                    }
                    else if (i != myChoice)//если только номер текущей двери не равен  номеру выбранной
                    {
                        //запоминаем как номер второй закрытой двери (наша дверь по прежнему закрыта)
                        otherClosed = i;
                    }
                }

                //индекс двери или второй закрытой или нашей
                int selected = changeChoice ? otherClosed : myChoice;

                //нам попал вариант двери с машинкой
                if (doors[selected] != 0)
                {
                    if (changeChoice)//раз мы изменили выбор, то правильно сделали
                        _res.ChangedAndWon++;
                    else
                        _res.KeepAndWon++;//правильно сделали что не изменили выбор
                }
                else// нам не попал вариант с машинкой
                {
                    if (changeChoice)//изменили и проиграли
                        _res.ChangedAndLost++;
                    else
                        _res.KeepAndLost++;// не изменили выбор и поэтому проиграли
                }
            }
            DrawResultsInCharts();
            }

        private void DrawResultsInCharts()
        {
            chart1.Series.ToList().ForEach(s=>s.Points.Clear());
            chart1.Series[0].Points.Add(_res.ChangedAndWon);
            chart1.Series[1].Points.Add(_res.ChangedAndLost);
            chart1.Series[2].Points.Add(_res.KeepAndWon);
            chart1.Series[3].Points.Add(_res.KeepAndLost);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
           Game();
           

            Console.WriteLine();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var gameForm = new GameForm())
            {
                gameForm.ShowDialog();
                switch (gameForm.GameResult)
                {
                    case GameForm.ResultVariants.KeepAndLost:
                        _res.KeepAndLost++;
                        break;
                    case GameForm.ResultVariants.KeepAndWon:
                        _res.KeepAndWon++;
                        break;
                    case GameForm.ResultVariants.ChangedAndLost:
                        _res.ChangedAndLost++;
                        break;
                    case GameForm.ResultVariants.ChangedAndWon:
                        _res.ChangedAndWon++;
                        break;
                }
                DrawResultsInCharts();
            }                


        }
    }
    }

