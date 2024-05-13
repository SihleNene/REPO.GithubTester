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
    public partial class NewFrom1 : Form
    {
        public NewFrom1()
        {
            InitializeComponent();
        }

        private void NewFrom1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public partial class Form1 : Form
        {
            public static Form1 instance;
 
            public string[] p1Data = new string[3];
            public string[] p2Data = new string[3];
           
            public int[] p1Values = new int[4];
            public int[] p2Values = new int[4];

            //Fire Dragon 
            const string FIRE_DRAG_NAME = "Fire";
            const int FIRE_DRAG_HP = 20;
            const int FIRE_DRAG_ATK = 5;
            const int FIRE_DRAG_SPATK = 12;
            const int FIRE_DRAG_BLOCK = 4;

            //Ice Dragon
            const string ICE_DRAG_NAME = "Ice";
            const int ICE_DRAG_HP = 30;
            const int ICE_DRAG_ATK = 4;
            const int ICE_DRAG_SPATK = 9;
            const int ICE_DRAG_BLOCK = 5;

            //Wind Dragon
            const string WIND_DRAG_NAME = "Wind";
            const int WIND_DRAG_HP = 40;
            const int WIND_DRAG_ATK = 3;
            const int WIND_DRAG_SPATK = 7;
            const int WIND_DRAG_BLOCK = 5;

            //Earth Dragon
            const string EARTH_DRAG_NAME = "Earth";
            const int EARTH_DRAG_HP = 50;
            const int EARTH_DRAG_ATK = 2;
            const int EARTH_DRAG_SPATK = 5;
            const int EARTH_DRAG_BLOCK = 6;

            private void btnSave1_Click(object sender, EventArgs e)
            {
                SaveValues1();
            }

                public Form1()
            {
                InitializeComponent();
                instance = this;
            }

            void SaveValues1()
            {
                p1Data[0] = txtPlayerName1.Text;
                p1Data[1] = txtDragonName1.Text;
                if (radFireDragon1.Checked == true)
                {
                    p1Data[2] = FIRE_DRAG_NAME;
                    p1Values[0] = FIRE_DRAG_HP;
                    p1Values[1] = FIRE_DRAG_ATK;
                    p1Values[2] = FIRE_DRAG_SPATK;
                    p1Values[3] = FIRE_DRAG_BLOCK;
                }
                else if (radIceDragon1.Checked == true)
                {
                    p1Data[2] = ICE_DRAG_NAME;
                    p1Values[0] = ICE_DRAG_HP;
                    p1Values[1] = ICE_DRAG_ATK;
                    p1Values[2] = ICE_DRAG_SPATK;
                    p1Values[3] = ICE_DRAG_BLOCK;
                }
                else if (radWindDragon1.Checked == true)
                {
                    p1Data[2] = WIND_DRAG_NAME;
                    p1Values[0] = WIND_DRAG_HP;
                    p1Values[1] = WIND_DRAG_ATK;
                    p1Values[2] = WIND_DRAG_SPATK;
                    p1Values[3] = WIND_DRAG_BLOCK;
                }
                else if (radEarthDragon1.Checked == true)
                {
                    p1Data[2] = EARTH_DRAG_NAME;
                    p1Values[0] = EARTH_DRAG_HP;
                    p1Values[1] = EARTH_DRAG_ATK;
                    p1Values[2] = EARTH_DRAG_SPATK;
                    p1Values[3] = EARTH_DRAG_BLOCK;
                }

            }

            void SaveValues2()
            {
                p2Data[0] = txtPlayerName2.Text;
                p2Data[1] = txtDragonName2.Text;
                if (radFireDragon2.Checked == true)
                {
                    p2Data[2] = FIRE_DRAG_NAME;
                    p2Values[0] = FIRE_DRAG_HP;
                    p2Values[1] = FIRE_DRAG_ATK;
                    p2Values[2] = FIRE_DRAG_SPATK;
                    p2Values[3] = FIRE_DRAG_BLOCK;
                }
                if (radIceDragon2.Checked == true)
                {
                    p2Data[2] = ICE_DRAG_NAME;
                    p2Values[0] = ICE_DRAG_HP;
                    p2Values[1] = ICE_DRAG_ATK;
                    p2Values[2] = ICE_DRAG_SPATK;
                    p2Values[3] = ICE_DRAG_BLOCK;
                }
                if (radWindDragon2.Checked == true)
                {
                    p2Data[2] = WIND_DRAG_NAME;
                    p2Values[0] = WIND_DRAG_HP;
                    p2Values[1] = WIND_DRAG_ATK;
                    p2Values[2] = WIND_DRAG_SPATK;
                    p2Values[3] = WIND_DRAG_BLOCK;
                }
                if (radFireDragon2.Checked == true)
                {
                    p2Data[2] = EARTH_DRAG_NAME;
                    p2Values[0] = EARTH_DRAG_HP;
                    p2Values[1] = EARTH_DRAG_ATK;
                    p2Values[2] = EARTH_DRAG_SPATK;
                    p2Values[3] = EARTH_DRAG_BLOCK;
                }
            }

           

           

            private void btnStartGame_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }


        }

        void btnPlayerSave1_Click(object sender, EventArgs e)
        {
            if (txtPlayerName1.Text != "" && txtDragonName1.Text != "")
            {
                if (radFireDragon1.Checked == true || radIceDragon1.Checked == true || radWindDragon1.Checked == true || radEarthDragon1.Checked == true)
                {
                    btnPlayerSave1.Enabled = false;
                    txtPlayerName1.Enabled = false;
                    txtDragonName1.Enabled = false;
                    radEarthDragon1.Enabled = false;
                    radWindDragon1.Enabled = false;
                    radFireDragon1.Enabled = false;
                    radIceDragon1.Enabled = false;
                    SaveValues1();
                    if (btnPlayerSave1.Enabled == false && btnPlayerSave1.Enabled == false)
                        btnStartGame.Enabled = true;
                }
            }
        }

        private void btnPlayerSave2_Click(object sender, EventArgs e)
            {
                if (txtPlayerName2.Text != "" && txtDragonName2.Text != "")
                {
                    if (radFireDragon2.Checked == true || radIceDragon2.Checked == true || radWindDragon2.Checked == true || radFireDragon2.Checked == true)
                    {
                        btnPlayerSave2.Enabled = false;  
                        txtPlayerName2.Enabled = false; 
                        txtDragonName2.Enabled = false; 
                        radEarthDragon2.Enabled = false; 
                        radWindDragon2.Enabled = false; 
                        radFireDragon2.Enabled = false;
                        radIceDragon2.Enabled = false; 

                        SaveValues2();
                        if (btnPlayerSave2.Enabled == false && btnPlayerSave2.Enabled == false)
                            btnStartGame.Enabled = true;
                    }
                }
            }



        private void radIceDragon2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
