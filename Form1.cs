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
    public partial class Form1 : Form
    {
        string playerName;;
        string dragontype; 



        public Form1()
        { 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            playerName = textplayerName.Text;
            dragonName = txtDragonName.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            rtblog.Text = "Player Name: " + playerName +
                            "\nDragon Name: " + dragonName;
        }
    }
}
