﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNetCource
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
            maskedTextBox1.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            try
            {
                IPAddress ipParce;
                if (!IPAddress.TryParse(maskedTextBox1.Text.Replace(",","."), out ipParce))
                {
                    label3.Visible = true;
                } 
                if (textBox1.Text.Length < 0)
                {
                    label5.Text = "Имя не должно быть пустым";
                    label5.Visible = true;
                }
                if (textBox1.Text.Length > 20)
                {
                    label5.Text = "В имени должно быть менее 20 символов";
                    label5.Visible = true;
                }
               
                if (Int32.Parse(maskedTextBox2.Text) > 65535 && Int32.Parse(maskedTextBox2.Text) > 1023)
                {
                    label4.Visible = true;
                }
                if (IPAddress.TryParse(maskedTextBox1.Text.Replace(",", "."), out ipParce) && Int32.Parse(maskedTextBox2.Text) < 65535 && Int32.Parse(maskedTextBox2.Text) > 1023 && !String.IsNullOrEmpty(textBox1.Text)&& textBox1.Text.Length < 20)
                {
                    GameNet form = new GameNet(maskedTextBox1.Text.Replace(",", "."), Int32.Parse(maskedTextBox2.Text), textBox1.Text);
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                if (String.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    label3.Visible = true;
                }
                if (String.IsNullOrEmpty(maskedTextBox2.Text))
                {
                    label4.Visible = true;
                }
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                     label5.Visible = true;
                }

                
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label7.Visible = false;

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ][a-zA-Z ]{0,19}") && textBox1.Text.Length > 0)
            {
                label7.Text = "Имя может содержать только буквы латинского алфавита";

                label7.Visible = true;  
            }
            if (textBox1.Text.Length > 20)
            {
                label7.Text = "В имени должно быть менее 20 символов ";
                label7.Visible = true;
            }
        }
    }
}