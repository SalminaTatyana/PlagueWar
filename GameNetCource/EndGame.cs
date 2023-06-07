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


        }
        public EndGame(string name)
        {
            InitializeComponent();
            try
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        label1.Text = "Победил " + name;
                    }));
                }
                else
                {
                    label1.Text = "Победил " + name;
                }
            }
            catch (Exception ex)
            {

            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
