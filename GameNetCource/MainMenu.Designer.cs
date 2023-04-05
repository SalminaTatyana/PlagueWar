
namespace GameNetCource
{
    partial class MainMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.button1.Location = new System.Drawing.Point(27, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Одиночная игра";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(200)))), ((int)(((byte)(173)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            this.button2.Location = new System.Drawing.Point(27, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(349, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Мультиплеер";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(58)))), ((int)(((byte)(221)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(27, 455);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выйти в Windows";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameNetCource.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(1462, 738);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}