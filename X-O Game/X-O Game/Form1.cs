using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<readyPlaces> buttons = new List<readyPlaces>();
        public static string Player { get; set; }
        public static string Enemy { get; set; }
        public static int ReadyPlaces = 9;
        public static bool Finished = false;
        public static bool Single;
        public static bool Player1_Turn, Player2_Turn;
        public static string Player1, Player2;
        public static int Game_Timer = 0;
        //public static int readyPlaces { get; set; }

        public class readyPlaces
        {
            public Button Place { get; set; }
            public bool Ready { get; set; }
            public int Place_ID { get; set; }
        }
        public void drawShape_Bot(Button Place, string Player, string Enemy, int Place_ID)
        {
            Finished = false;
            Random random = new Random();
            int placeNumber = 0;
            Place.Text = Player;
            buttons[Place_ID].Place.Text = Player;
            buttons[Place_ID].Ready = false;
            Place.Enabled = false;
            ReadyPlaces -= 1;
            Finished = showWinner(Player);
            if (Finished.Equals(false))
            {
                while (ReadyPlaces >= 0)
                {
                    placeNumber = random.Next(0, 9);
                    if (buttons[placeNumber].Place.Text == string.Empty && buttons[placeNumber].Ready == true)
                    {
                        buttons[placeNumber].Place.Text = Enemy;
                        buttons[placeNumber].Place.Enabled = false;
                        ReadyPlaces -= 1;
                        showWinner(Enemy);
                        break;
                    }
                }
            }
            
        }

        public void drawShape_Partner(Button Place, int Place_ID)
        {
            int Counter = 0;
            if (Player1_Turn)
            {
                Place.Text = Player1;
                buttons[Place_ID].Place.Text = Player1;
                buttons[Place_ID].Ready = false;
                buttons[Place_ID].Place.Enabled = false;
                Player1_Turn = false;
                Player2_Turn = true;
                Place.Enabled = false;
                showWinner(Player1);
            }
            else if (Player2_Turn)
            {
                Place.Text = Player2;
                buttons[Place_ID].Place.Text = Player2;
                buttons[Place_ID].Ready = false;
                buttons[Place_ID].Place.Enabled = false;
                Player2_Turn = false;
                Player1_Turn = true;
                Place.Enabled = false;
                showWinner(Player2);
            }
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].Ready == false)
                {
                    Counter += 1;
                }
            }
            if (Counter.Equals(9))
            {
                MessageBox.Show("Draw!", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public bool showWinner(string Player)
        {
            if (Place1.Text == Place2.Text && Place1.Text == Place3.Text && Place1.Text != string.Empty 
                || Place4.Text.Equals(Place5.Text) && Place4.Text.Equals(Place6.Text) && !Place4.Text.Equals(string.Empty)
                || Place1.Text.Equals(Place4.Text) && Place1.Text.Equals(Place7.Text) && !Place1.Text.Equals(string.Empty)
                || Place3.Text.Equals(Place5.Text) && Place3.Text.Equals(Place7.Text) && !Place3.Text.Equals(string.Empty)
                || Place7.Text.Equals(Place8.Text) && Place7.Text.Equals(Place9.Text) && !Place7.Text.Equals(string.Empty)
                || Place3.Text.Equals(Place6.Text) && Place3.Text.Equals(Place9.Text) && !Place3.Text.Equals(string.Empty)
                || Place2.Text.Equals(Place5.Text) && Place2.Text.Equals(Place8.Text) && !Place2.Text.Equals(string.Empty)
                || Place1.Text.Equals(Place5.Text) && Place1.Text.Equals(Place9.Text) && !Place1.Text.Equals(string.Empty)
                )
            {
                timer1.Stop();
                timer1.Enabled = false;
                Timer_Label.Text = "0";
                MessageBox.Show($"Hollay!\nWinner is {Player}\nTime: {Game_Timer.ToString()} seconds", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restart_Game();
                return true; //We have winner
            }
            else
            {
                return false; //We haven't winner
            }
            
        }


        public void Restart_Game()
        {
            Place1.Text = string.Empty;
            Place1.Enabled = false;
            Place2.Text = string.Empty; Place2.Enabled = false;
            Place3.Text = string.Empty; Place3.Enabled = false;
            Place4.Text = string.Empty; Place4.Enabled = false;
            Place5.Text = string.Empty; Place5.Enabled = false;
            Place6.Text = string.Empty; Place6.Enabled = false;
            Place7.Text = string.Empty; Place7.Enabled = false;
            Place8.Text = string.Empty; Place8.Enabled = false;
            Place9.Text = string.Empty; Place9.Enabled = false;
            for (int i = 0; i < 9; i++)
            {
                buttons[i].Place.Text = string.Empty;
            }
            Play_Button.Enabled = true;
            comboBox1.Enabled = true;
            Partner_RadioButton.Enabled = true;
            Single_RadioButton.Enabled = true;
            Single_RadioButton.Checked = true;
            comboBox1.SelectedIndex = -1;
            PlayerOne_Label.Text = "Empty";
            PlayerTwo_Label.Text = "Empty";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //readyPlaces = 9;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Play_Button.Enabled = false;
            comboBox1.Enabled = false;
            buttons.Add(new readyPlaces() { Place = Place1, Ready = true, Place_ID = 0 });
            buttons.Add(new readyPlaces() { Place = Place2, Ready = true, Place_ID = 1 });
            buttons.Add(new readyPlaces() { Place = Place3, Ready = true, Place_ID = 2 });
            buttons.Add(new readyPlaces() { Place = Place4, Ready = true, Place_ID = 3 });
            buttons.Add(new readyPlaces() { Place = Place5, Ready = true, Place_ID = 5 });
            buttons.Add(new readyPlaces() { Place = Place6, Ready = true, Place_ID = 5 });
            buttons.Add(new readyPlaces() { Place = Place7, Ready = true, Place_ID = 6 });
            buttons.Add(new readyPlaces() { Place = Place8, Ready = true, Place_ID = 7 });
            buttons.Add(new readyPlaces() { Place = Place9, Ready = true, Place_ID = 8 });
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Game_Timer = 0;
            if (Single.Equals(true))
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Select your character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0) { Player = "X"; Enemy = "O"; }
                    else { Player = "O"; Enemy = "X"; }
                    PlayerOne_Label.Text = Player;
                    PlayerTwo_Label.Text = "Bot";
                    for (int i = 0; i < 9; i++)
                    {
                        buttons[i].Place.Enabled = true;
                    }
                    comboBox1.Enabled = false;
                    Play_Button.Enabled = false;
                    Partner_RadioButton.Enabled = false;
                    Single_RadioButton.Enabled = false;
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
            else
            {
                if (comboBox1.SelectedIndex < 0)
                {
                    MessageBox.Show("Select your character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboBox1.SelectedIndex == 0) { Player1 = "X"; Player2 = "O"; }
                    else { Player1 = "O"; Player2 = "X"; }
                    Player1_Turn = true;
                    Player2_Turn = false;
                    PlayerOne_Label.Text = Player1;
                    PlayerTwo_Label.Text = Player2;
                    comboBox1.Enabled = false;
                    Play_Button.Enabled = false;
                    Partner_RadioButton.Enabled = false;
                    Single_RadioButton.Enabled = false;
                    for (int i = 0; i < 9; i++)
                    {
                        buttons[i].Place.Enabled = true;
                    }
                    timer1.Enabled = true;
                    timer1.Start();
                }
            }
        }

        private void Place5_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place5, Player, Enemy, 4);
            }
            else
            {
                drawShape_Partner(Place5, 4);
            }
        }

        private void Place1_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place1, Player, Enemy, 0);
            }
            else
            {
                drawShape_Partner(Place1, 0);
            }
        }

        private void Place2_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place2, Player, Enemy, 1);
            }
            else
            {
                drawShape_Partner(Place2, 1);
            }
        }

        private void Place3_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place3, Player, Enemy, 2);
            }
            else
            {
                drawShape_Partner(Place3, 2);
            }
        }

        private void Place4_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place4, Player, Enemy, 3);
            }
            else
            {
                drawShape_Partner(Place4, 3);
            }
        }

        private void Place6_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place6, Player, Enemy, 5);
            }
            else
            {
                drawShape_Partner(Place6, 5);
            }
        }

        private void Place7_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place7, Player, Enemy, 6);
            }
            else
            {
                drawShape_Partner(Place7, 6);
            }
        }

        private void Place8_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place8, Player, Enemy, 7);
            }
            else
            {
                drawShape_Partner(Place8, 7);
            }
        }

        private void Place9_Click(object sender, EventArgs e)
        {
            if (Single.Equals(true))
            {
                drawShape_Bot(Place9, Player, Enemy, 8);
            }
            else
            {
                drawShape_Partner(Place9, 8);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game_Timer += 1;
            Timer_Label.Text = Game_Timer.ToString() + " sec";
        }

        private void Single_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Which one you are?";
            Single = true;
            Play_Button.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void Partner_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Which one is player1:";
            Single = false;
            Play_Button.Enabled = true;
            comboBox1.Enabled = true;
        }
    }
}
