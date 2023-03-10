using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNetCource
{
    public partial class Form1 : Form
    {
        Player playerOne = new Player("img/cross.png", 0, 3, new List<Button>(), 100);
        Player playerTwo = new Player("img/circle.png", 0, 3, new List<Button>(), 100);
        public Form1()
        {
            InitializeComponent();
            try
            {
                button10.BackgroundImage = Image.FromFile(playerOne.Img);
                button10.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch 
            {
                button10.BackColor = Color.FromArgb(189, 0, 255);
            }
            playerOne.Step+=1;
            Button Button10 = new Button("button10");
            playerOne.ActiveBtn.Add(Button10);
            try
            {
                button91.BackgroundImage = Image.FromFile(playerTwo.Img);
                button91.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch 
            {
                button91.BackColor = Color.FromArgb(255, 230, 0);
            }
            playerTwo.Step += 1;
        }

    }
}
