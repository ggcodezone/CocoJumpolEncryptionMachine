using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CocoEncryption
{
    public partial class MainMenu : Form
    {
        //initialize audio
        SoundPlayer cocotheme = new SoundPlayer(soundLocation: @"D:\COURSEWORK\OOP\CocoEncryption\CocoEncryption\Resources\cocotheme.wav");
        public MainMenu()
        {
            InitializeComponent();

            //music play
            cocotheme.Play();
        }

        private void buttonMethod1_Click(object sender, EventArgs e) //pull up new window
        {
            Form Method1 = new Method1();
            Method1.ShowDialog();
        }

        private void buttonMethod2_Click(object sender, EventArgs e) //pull up new window
        {
            Form Method2 = new Method2();
            Method2.ShowDialog();
        }

        private void musicStop_Click(object sender, EventArgs e)
        {
            cocotheme.Stop();
        }
    }
}
