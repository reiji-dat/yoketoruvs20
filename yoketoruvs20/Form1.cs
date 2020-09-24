using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class gameoverLabel : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + PlayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        int itemCount;
        bool[] getItem = new bool[ChrMax];

        const int TimeMax = 300;
        int time;

        int highscore = 0;

        static Random rand = new Random();

        enum State
        {
            None = -1,  //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear       //クリア
        }

        State curerentState = State.None;
        State nextState = State.Title;

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public gameoverLabel()
        {
            InitializeComponent();

            for (int i=0; i < ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i == PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if (i < ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
                chrs[i].Font = tempLabel.Font;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState != State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C) < 0)
                {
                    nextState = State.Clear;
                }
            }

            if(curerentState == State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Top = mp.Y - chrs[PlayerIndex].Height / 2;


            itemLabel.Text = "★：" + itemCount;

            if(itemCount <= 0)
            {
                nextState = State.Clear;
            }

            time--;
            timeLabel.Text = "TIME " + time;
            if (time <= 0) nextState = State.Gameover;

            //ここに移動処理関数
            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                if(chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                if(     chrs[i].Left <= mp.X 
                    &&  chrs[i].Top <= mp.Y 
                    &&  chrs[i].Right >= mp.X 
                    &&  chrs[i].Bottom >= mp.Y)
                {
                    if(i < ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else if(!getItem[i])
                    {
                        getItem[i] = true;
                        chrs[i].Visible = false;
                        itemCount--;
                    }
                }
            }
        }

        void initProc()
        {
            curerentState = nextState;
            nextState = State.None;
            switch(curerentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    stertButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    goLabel.Visible = false;
                    titleButton.Visible = false;
                    clearLabel.Visible = false;
                    for (int i = 0; i < ChrMax; i++) chrs[i].Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    stertButton.Visible = false;
                    copyrightLabel.Visible = false;
                    hiLabel.Visible = false;

                    itemCount = ItemMax;
                    itemLabel.Text = "★：" + itemCount;

                    for (int i = 0; i < ChrMax; i++) getItem[i] = false;

                    time = TimeMax;

                    for (int i = 0; i < ChrMax; i++) chrs[i].Visible = true;
                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }
                    break;

                case State.Gameover:
                    goLabel.Visible = true;
                    titleButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titleButton.Visible = true;
                    hiLabel.Visible = true;
                    if (time > highscore) highscore = time;
                    hiLabel.Text = "HighScore" + highscore;
                    break;
            }
        }

        private void stertButton_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void titleButton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
