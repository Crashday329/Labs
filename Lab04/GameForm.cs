using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class GameForm : Form
    {
        //перечисление вариантов результата игры
        public enum ResultVariants {Nothing,
            ChangedAndWon,
            KeepAndWon,
        ChangedAndLost,
           KeepAndLost }
        //фазы игры
        private enum GamePhase
        {
            Started,
           
            OneDoorOpened,
            
            Result
        }
        //текущая фаза игры
        private GamePhase CurrentGamePhase { get; set; }
        //результат игры
        public ResultVariants GameResult { get; set; } = ResultVariants.Nothing;
        //генератор псевдослучайных чисел
        private readonly Random rnd = new Random();
        //дверки
        private List<Door> Doors { get; set; }
        public GameForm()
        {
            
            InitializeComponent();
            SeedGame();
            CurrentGamePhase = GamePhase.Started;
        }
        //начальная генерация условий игры
        private void SeedGame()
        {
            Doors = new List<Door>() {pictureBox1, pictureBox2, pictureBox3 };
            for (int i = 0; i < 3; i++)
            {
                Doors[i].Position = i + 1;
                Doors[i].SizeMode = PictureBoxSizeMode.Zoom;
            }
            //наличие машинки обозначаем через 1
            Doors[rnd.Next(0, 3)].IsCarHere = true;
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Door clickedDoor = (Door)sender;
            if(clickedDoor.isOpened)return;
            bool changedMind = !clickedDoor.isChecked;
            MarkDoorAsClicked(clickedDoor);
            if (CurrentGamePhase == GamePhase.Started)
            {
                var doorsToOpen = Doors.Except(new[] {clickedDoor}).Where(d => !d.IsCarHere).ToList();
                Door doorToOpen = doorsToOpen.ElementAt(rnd.Next(0,doorsToOpen.Count));
                doorToOpen.isOpened = true;
                doorToOpen.Image = global::lab04.Properties.Resources.koza;
                label2.Text = "Отлично, вы сделали свой выбор!"+Environment.NewLine
                    + "Мы открыли для вас одну дверь. Не хотите поменять свой выбор?"+Environment.NewLine
                    +"Щелкните на дверь для окончательного выбора!";
                CurrentGamePhase = GamePhase.OneDoorOpened;
            }
            else if (CurrentGamePhase == GamePhase.OneDoorOpened)
            {
                Door doorToOpen = clickedDoor;
                
                
                doorToOpen.isOpened = true;
                if (doorToOpen.IsCarHere)
                {
                    doorToOpen.Image = global::lab04.Properties.Resources.bmw;
                    label2.Text = "Вы победили!";
                    GameResult = changedMind ? ResultVariants.ChangedAndWon : ResultVariants.KeepAndWon;
                }
                else
                {
                    doorToOpen.Image = global::lab04.Properties.Resources.koza;
                    label2.Text = "Вы проиграли! Вам Коза!";
                    GameResult = changedMind ? ResultVariants.ChangedAndLost : ResultVariants.KeepAndLost;
                }
               
                CurrentGamePhase = GamePhase.Result;
            }
        }

        private void MarkDoorAsClicked(Door clickedDoor)
        {
            Doors.ForEach(d=>d.isChecked=false);
            clickedDoor.isChecked = true;
            clickedDoor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }
    }
    //используем расширение контрола picturebox Для хранения информации о дверях
    public class Door:PictureBox
    {
        
        public int Position { get; set; }
        public bool isOpened { get; set; }
        public bool isChecked { get; set; }

        public bool IsCarHere { get; set; }
    }
}

