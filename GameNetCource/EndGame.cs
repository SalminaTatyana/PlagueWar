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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
            EndGame.ActiveForm.Width = 500;
            EndGame.ActiveForm.Height = 250;
            
        }
        public EndGame(string name)
        {
            InitializeComponent();
            label1.Text = "Победил " + name;
            EndGame.ActiveForm.Width = 500;
            EndGame.ActiveForm.Height = 250;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
