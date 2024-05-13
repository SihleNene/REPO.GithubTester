using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dragon_Game_gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        public partial class Form2 : Form
        {
            public static Form2 Instance;
            int playerturn; 
            int damage; 
            int roundCounter = 0; //turns passed
            bool blockFlag1 = false; //Player1 block bool
            bool blockFlag2 = false; //Player2 block bool
            bool rest1 = false; //dragon1 s atk bool
            bool rest2 = false; //dragon2 s atk bool
            public Form2()
            {
                InitializeComponent();
                Instance = this;
                TakeInitiative();
            }

            void Rounds() 
            {
                roundCounter++;
                if (roundCounter == 2)
                {
                    roundCounter = 0;
                    TakeInitiative();
                }
                else if (playerturn == 1)
                    Player2Customise();
                else if (playerturn == 2)
                    Player1Customise();
            }
            int RandomRoll() //Rolls dice out of 6
            {
                Random Diceroll = new Random();
                int roll = Diceroll.Next(1, 7);
                return roll;
            }

            void TakeInitiative() 
            {
                int p1Roll = 0;
                int p2Roll = 0;
                while (p1Roll == p2Roll)
                {
                    p1Roll = RandomRoll();
                    p2Roll = RandomRoll();
                }
                if (p1Roll > p2Roll) 
                    Player1Customise();
                else if (p2Roll > p1Roll) 
                    Player2Customise();
            }

            void Player1Customise() 
            {
                playerturn = 1;
                txtBattleLog.Text += $"\n{Form1.instance.p1Data[0]}'s Turn:";
                gbxPlayerTurn.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon's Turn"; 
                Form2.Instance.Text = $"{Form1.instance.p1Data[0]}'s Turn"; 
                lblOpponentDragon.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon"; 
                gbxOpponent.Text = $"Opponent: {Form1.instance.p2Data[0]}"; 

                if (rest1 == true)
                {
                    btnRest.Enabled = true;
                    btnRest.Visible = true;
                    DisableButtons();
                }
            }

            void Player2Customise() 
            {
                playerturn = 2;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[0]}'s Turn:";
                gbxPlayerTurn.Text = $"{Form1.instance.p2Data[1]}, the {Form1.instance.p2Data[2]} Dragon's Turn";
                Form2.Instance.Text = $"{Form1.instance.p2Data[0]}'s Turn"; 
                lblOpponentDragon.Text = $"{Form1.instance.p1Data[1]}, the {Form1.instance.p1Data[2]} Dragon"; 
                gbxOpponent.Text = $"Opponent: {Form1.instance.p1Data[0]}"; 

                if (rest2 == true)
                {
                    btnRest.Enabled = true;
                    btnRest.Visible = true;
                    DisableButtons();
                }
            }

            private void btnAttack_Click(object sender, EventArgs e)
            {
                if (playerturn == 1)
                    Player1Attack();
                else if (playerturn == 2)
                    Player2Attack();
                DeclareWinner();
                Rounds();
            }

            private void btnSpecialAttack_Click(object sender, EventArgs e)
            {
                if (playerturn == 1)
                    Player1Special();
                else if (playerturn == 2)
                    Player2Special();
                DeclareWinner();
                Rounds();
            }

            private void btnBlock_Click(object sender, EventArgs e)
            {
                if (playerturn == 1)
                    Player1Block();
                else if (playerturn == 2)
                    Player2Block();
                DeclareWinner();
                Rounds();
            }

            private void btnRest_Click(object sender, EventArgs e)
            {
                if (playerturn == 1)
                    Player1Rest();
                else if (playerturn == 2)
                    Player2Rest();
                DeclareWinner();
                Rounds();
            }


            void DisableButtons()
            {
                btnAttack.Enabled = false;
                btnAttack.Visible = false;
                btnSpecialAttack.Enabled = false;
                btnSpecialAttack.Visible = false;
                btnBlock.Enabled = false;
                btnBlock.Visible = false;
            }
            void EnableButtons()
            {
                btnAttack.Enabled = true;
                btnAttack.Visible = true;
                btnSpecialAttack.Enabled = true;
                btnSpecialAttack.Visible = true;
                btnBlock.Enabled = true;
                btnBlock.Visible = true;
            }


            void Player1Block()
            {
                blockFlag1 = true;
                blockFlag2 = false;
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} chooses to block";
                rtbBattleLog.Text += $"\n*\n";
            }
            void Player2Block()
            {
                blockFlag2 = true;
                blockFlag1 = false;
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} chooses to block";
                rtbBattleLog.Text += $"\n*\n";
            }

            void Player1Attack()
            {
                if (blockFlag2 == false) 
                {
                    damage = Form1.instance.p1Values[1];
                    Form1.instance.p2Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage";
                    rtbBattleLog.Text += $"\n*";
                }
                else if (blockFlag2 == true) 
                {
                    if (Form1.instance.p2Values[3] > Form1.instance.p1Values[1]) 
                    {
                        damage = 0;
                        rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} blocks {Form1.instance.p1Data[1]}'s whole attacks";
                        rtbBattleLog.Text += $"\n*";
                    }
                    else 
                    {
                        damage = Form1.instance.p1Values[1] - Form1.instance.p2Values[3];
                        Form1.instance.p2Values[0] -= damage;
                        rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} attacks {Form1.instance.p2Data[1]} for {damage} damage";
                        rtbBattleLog.Text += $"\n*";
                    }
                }
                blockFlag2 = false;
            }
            void Player2Attack()
            {
                if (blockFlag1 == false) 
                {
                    damage = Form1.instance.p2Values[1];
                    Form1.instance.p1Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage";
                    rtbBattleLog.Text += $"\n*";
                }
                else if (blockFlag1 == true) 
                {
                    if (Form1.instance.p1Values[3] > Form1.instance.p2Values[1]) 
                    {
                        damage = 0;
                        rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} blocks {Form1.instance.p2Data[1]}'s whole attacks";
                        rtbBattleLog.Text += $"\n*";
                    }
                    else 
                    {
                        damage = Form1.instance.p2Values[1] - Form1.instance.p1Values[3];
                        Form1.instance.p1Values[0] -= damage;
                        rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} attacks {Form1.instance.p1Data[1]} for {damage} damage";
                        rtbBattleLog.Text += $"\n*\n";
                    }
                }
                blockFlag1 = false;
            }

            void Player1Special()
            {
                if (blockFlag2 == false) 
                {
                    damage = Form1.instance.p1Values[2];
                    Form1.instance.p2Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} special attacks {Form1.instance.p2Data[1]} for {damage} damage";
                    rtbBattleLog.Text += $"\n*\n";
                }
                else if (blockFlag2 == true) 
                {
                    if (Form1.instance.p2Values[3] > Form1.instance.p1Values[2]) 
                    {
                        damage = 0;
                        rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} blocks {Form1.instance.p1Data[1]}'s whole attack";
                        rtbBattleLog.Text += $"\n*\n";
                    }
                    else 
                    {
                        damage = Form1.instance.p1Values[2] - Form1.instance.p2Values[3];
                        Form1.instance.p2Values[0] -= damage;
                        rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} special attacks {Form1.instance.p2Data[1]} for {damage} damage";
                        rtbBattleLog.Text += $"\n*\n";
                    }
                }
                blockFlag2 = false;
                rest1 = true;
            }
            void Player2Special()
            {
                if (blockFlag1 == false) 
                {
                    damage = Form1.instance.p2Values[2];
                    Form1.instance.p1Values[0] -= damage;
                    rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} special attacks {Form1.instance.p1Data[1]} for {damage} damage";
                    rtbBattleLog.Text += $"\n*";
                }
                else if (blockFlag1 == true) 
                {
                    if (Form1.instance.p1Values[3] > Form1.instance.p2Values[2]) 
                    {
                        damage = 0;
                        rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} blocks {Form1.instance.p2Data[1]}'s whole attack";
                        rtbBattleLog.Text += $"\n*";
                    }
                    else 
                    {
                        damage = Form1.instance.p2Values[2] - Form1.instance.p1Values[3];
                        Form1.instance.p1Values[0] -= damage;
                        rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} special attacks {Form1.instance.p1Data[1]} for {damage} damage";
                        rtbBattleLog.Text += $"\n*";
                    }
                }
                blockFlag1 = false;
                rest2 = true;
            }
            void Player1Rest() 
            {
                rtbBattleLog.Text += $"\n{Form1.instance.p1Data[1]} is too tired to fight";
                rtbBattleLog.Text += $"\n*";
                rest1 = false;
                btnRest.Enabled = false;
                btnRest.Visible = false;
                EnableButtons();
            }
            void Player2Rest() 
            {
                rtbBattleLog.Text += $"\n{Form1.instance.p2Data[1]} is too tired to fight";
                rtbBattleLog.Text += $"\n*";
                rest2 = false;
                btnRest.Enabled = false;
                btnRest.Visible = false;
                EnableButtons();
            }
            void DeclareWinner()
            {
                if (Form1.instance.p1Values[0] <= 0)
                {
                    DisableButtons();
                    rtbBattleLog.Text += $"{Form1.instance.p1Data[1]} Wins";
                }
                else if (Form1.instance.p2Values[0] <= 0)
                {
                    DisableButtons();
                    rtbBattleLog.Text += $"{Form1.instance.p2Data[1]} Wins";
                }
            }
           
        }



    }
}
