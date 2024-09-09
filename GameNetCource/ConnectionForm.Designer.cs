namespace GameNetCource
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            label6 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(120, 58, 221);
            button1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.FromArgb(194, 243, 255);
            button1.Location = new System.Drawing.Point(290, 439);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(305, 68);
            button1.TabIndex = 2;
            button1.Text = "Подключиться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(290, 165);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 39);
            label1.TabIndex = 3;
            label1.Text = "Ip";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(290, 303);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 39);
            label2.TabIndex = 4;
            label2.Text = "Порт";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(1, 37, 73);
            maskedTextBox1.Location = new System.Drawing.Point(290, 216);
            maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new System.Drawing.Size(305, 45);
            maskedTextBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(290, 271);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(199, 20);
            label3.TabIndex = 6;
            label3.Text = "Неправильное значение IP";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(290, 401);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(228, 20);
            label4.TabIndex = 7;
            label4.Text = "Неправильное значение порта";
            label4.Visible = false;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            maskedTextBox2.ForeColor = System.Drawing.Color.FromArgb(1, 37, 73);
            maskedTextBox2.Location = new System.Drawing.Point(290, 347);
            maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            maskedTextBox2.Mask = "00000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new System.Drawing.Size(305, 45);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(290, 31);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(73, 39);
            label6.TabIndex = 9;
            label6.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.Color.FromArgb(1, 37, 73);
            textBox1.Location = new System.Drawing.Point(290, 75);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(305, 45);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.Red;
            label5.Location = new System.Drawing.Point(290, 145);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(202, 20);
            label5.TabIndex = 11;
            label5.Text = "Имя не может быть пустым";
            label5.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = System.Drawing.Color.Red;
            label7.Location = new System.Drawing.Point(290, 129);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(414, 20);
            label7.TabIndex = 12;
            label7.Text = "Имя может содержать только буквы латинского алфавита";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(350, 291);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(212, 39);
            label8.TabIndex = 14;
            label8.Text = "Подключение";
            label8.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            pictureBox1.Image = Properties.Resources._498f7727ecf2a588d6c3eebac92a7c4b;
            pictureBox1.Location = new System.Drawing.Point(190, 31);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(578, 532);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Red;
            label9.Location = new System.Drawing.Point(169, 557);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(665, 32);
            label9.TabIndex = 15;
            label9.Text = "Не удается выполнить подключение, попробуйте еще раз";
            label9.Visible = false;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(1, 37, 73);
            ClientSize = new System.Drawing.Size(926, 629);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ConnectionForm";
            Text = "ConnectionForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
    }
}