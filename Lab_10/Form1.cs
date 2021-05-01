using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{

    public partial class Form1 : Form
    {
        Game game = new Game();
        public int grany;
        public bool cheat;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grany = Convert.ToInt32(textBox1.Text);
            cheat = checkBox1.Checked;
            game.Start(grany, cheat);
            label1.Text = "Вам выпало: " + game.player.ToString();
            label2.Text = "Компьютеру выпало: " + game.iu.ToString();
            label3.Text = game.Who_win();
        }
    }
}
