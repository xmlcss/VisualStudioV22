using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cha4FingerGuessGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //把sender显示强制类型转换为button
            Button btn = (Button)sender;
            if (btn != null)
            {
                Player player1 = new Player();
                int userFist = player1.PlayerShowFinger(btn.Text);
                label2.Text ="玩家出的是: " + player1.FingerType;

                ComputPlayer cp = new ComputPlayer();
                int cmFist = cp.ComputerShowFinger();
                label3.Text ="计算机出的是: " + cp.ComFingerType;

                label4.Text = Judge.JudgeLossWin(userFist, cmFist);
            }
        }
    }
}
